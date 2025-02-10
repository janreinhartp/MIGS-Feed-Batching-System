
Imports System.IO.Ports
Imports System.Net.Mail
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Google.Protobuf.WellKnownTypes
Imports Modbus.Device
Imports Org.BouncyCastle.Tls

Imports System.UI.Widget

Delegate Sub SetTextCallback(ByVal [text] As String)
Public Class Form1
    Public currentFormula As formula
    Public currentFormulaBatching As formula
    Public formulaList As List(Of formula)

    Private timeSpray As Stopwatch
    Private targetTimeSpray As TimeSpan

    Private timeMixer As Stopwatch
    Private targetTimeMixer As TimeSpan

    Public weight As String
    Public weightLiquid As String

    'Batching Variables and Declaration
    Public Shared binCurrentLoadDry As Double
    Public Shared currentTargetWeightDry As Double

    Public Shared binCurrentLoadWet As Double
    Public Shared currentTargetWeightWet As Double

    Public batchDryFlag As Boolean
    Public batchLiquidFlag As Boolean

    'Declaration for PLC Connection
    Dim Master_Station As ModbusSerialMaster
    Dim IF_Connected As Boolean = False

    Dim SLAVE_ADDRESS As Byte = 1

    Public Shared silo1,
        silo2,
        silo3,
        silo4,
        silo5,
        silo6,
        silo7,
        silo8,
        molasses,
        cocooil,
        spraypump,
        batchgate,
        liquidgate,
        topgate,
        bottomgate,
        alarm As UShort

    Public BatchGateStatus, TopGateStatus, BottomGateStatus, MixingStatus, SprayStatus As Boolean


    Public Shared commandPLC(19) As Boolean
    Public Shared recentCommandPLC(19) As Boolean
    Public Shared inputPLC(19) As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssignValidation(Me.txtbSilo1Weight, 1)
        AssignValidation(Me.txtbSilo2Weight, 1)
        AssignValidation(Me.txtbSilo3Weight, 1)
        AssignValidation(Me.txtbSilo4Weight, 1)
        AssignValidation(Me.txtbSilo5Weight, 1)
        AssignValidation(Me.txtbSilo6Weight, 1)
        AssignValidation(Me.txtbSilo7Weight, 1)
        AssignValidation(Me.txtbSilo8Weight, 1)
        AssignValidation(Me.txtbMolassesWeight, 1)
        AssignValidation(Me.txtbCocoOilWeight, 1)
        ClearFormulaBatching()
        RefreshFormulaList()
        loadSettings()

        timeSpray = New Stopwatch()
        timeMixer = New Stopwatch()
        InitializeAddress()
        connectPLC()
        ' loadScales()
        tmrUiUpdate.Start()
    End Sub

    Public Sub InitializeAddress()
        silo1 = 0
        silo2 = 1
        silo3 = 2
        silo4 = 3
        silo5 = 4
        silo6 = 5
        silo7 = 6
        silo8 = 7
        molasses = 8
        cocooil = 9
        spraypump = 10
        batchgate = 11
        liquidgate = 12
        topgate = 13
        bottomgate = 14
        alarm = 15

        For i As Integer = 0 To 19
            commandPLC(i) = False
            Console.Write("Command " + i.ToString + " : ")
            Console.WriteLine(commandPLC(i).ToString)
        Next

        For i As Integer = 0 To 19
            recentCommandPLC(i) = False
            Console.Write("Recent " + i.ToString + " : ")
            Console.WriteLine(recentCommandPLC(i).ToString)
        Next
    End Sub

    Public Sub loadSettings()
        lblSilo1RawMatsBatching.Text = My.Settings.Silo1Material
        lblSilo2RawMatsBatching.Text = My.Settings.Silo2Material
        lblSilo3RawMatsBatching.Text = My.Settings.Silo3Material
        lblSilo4RawMatsBatching.Text = My.Settings.Silo4Material
        lblSilo5RawMatsBatching.Text = My.Settings.Silo5Material
        lblSilo6RawMatsBatching.Text = My.Settings.Silo6Material
        lblSilo7RawMatsBatching.Text = My.Settings.Silo7Material
        lblSilo8RawMatsBatching.Text = My.Settings.Silo8Material
        lblFormulaMatSilo1.Text = My.Settings.Silo1Material
        lblFormulaMatSilo2.Text = My.Settings.Silo2Material
        lblFormulaMatSilo3.Text = My.Settings.Silo3Material
        lblFormulaMatSilo4.Text = My.Settings.Silo4Material
        lblFormulaMatSilo5.Text = My.Settings.Silo5Material
        lblFormulaMatSilo6.Text = My.Settings.Silo6Material
        lblFormulaMatSilo7.Text = My.Settings.Silo7Material
        lblFormulaMatSilo8.Text = My.Settings.Silo8Material
    End Sub

    Public Sub writeCoils()
        For i As Integer = 0 To 19
            If commandPLC(i) <> recentCommandPLC(i) Then
                Try
                    Master_Station.WriteSingleCoil(SLAVE_ADDRESS, i, commandPLC(i))
                    recentCommandPLC(i) = commandPLC(i)
                Catch ex As Exception
                    'ReportError(ex.Message)
                End Try
            End If
        Next
    End Sub

    Private Sub ReportError(ByVal s As String)
        MessageBox.Show(s)
    End Sub

    Public Sub loadScales()
        srlDryScale.PortName = "COM4"
        srlDryScale.BaudRate = "9600"

        srlLiquidScale.PortName = "COM3"
        srlLiquidScale.BaudRate = "9600"

        Try
            srlDryScale.Open()
            ' MsgBox("Connected")
        Catch ex As Exception
            MsgBox("Please Contact the Administrator" + " " + ex.Message)
            'btnStartBatching.Enabled = False
        End Try
        Try
            srlLiquidScale.Open()
            '  MsgBox("Connected")
        Catch ex As Exception
            MsgBox("Please Contact the Administrator" + " " + ex.Message)
            'btnStartBatching.Enabled = False
        End Try

    End Sub


    Private Sub conBatchScale_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles srlDryScale.DataReceived
        receivedText(srlDryScale.ReadExisting())
    End Sub

    Private Sub tmrPLC_Tick(sender As Object, e As EventArgs) Handles tmrPLC.Tick
        writeCoils()

        Try
            Dim holding_register As Boolean() = Master_Station.ReadCoils(SLAVE_ADDRESS, 0, 20) ' Read holding FC03

            For i As Integer = 0 To 19
                'Console.Write("Read Coil " + i.ToString + " : ")
                'Console.WriteLine(holding_register(i))
                recentCommandPLC(i) = Convert.ToBoolean(holding_register(i))
            Next

            Dim input_register As Boolean() = Master_Station.ReadCoils(SLAVE_ADDRESS, 20, 20) ' Read holding FC03

            For i As Integer = 0 To 19
                'Console.Write("input read " + i.ToString + " : ")
                'Console.WriteLine(input_register(i))
                inputPLC(i) = Convert.ToBoolean(input_register(i))
            Next
        Catch ex As Exception
            ' ReportError(ex.Message)
        End Try
    End Sub

    Private Sub drpdownFormulaBatching_onItemSelected(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnRefreshFormulaBatching_Click(sender As Object, e As EventArgs) Handles btnRefreshFormulaBatching.Click
        RefreshFormulaList()
    End Sub



    Private Sub cmbFormulaBatching_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormulaBatching.SelectedIndexChanged
        Console.WriteLine(cmbFormulaBatching.SelectedIndex)
        currentFormulaBatching = New formula(formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Id,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).FormulaName,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Silo1,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Silo2,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Silo3,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Silo4,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Silo5,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Silo6,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Silo7,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Silo8,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).Molasses,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormulaBatching.Text).CocoOil)

        lblFormulaNameBatching.Text = currentFormulaBatching.FormulaName
        lblSilo1WeightBatching.Text = currentFormulaBatching.Silo1
        lblSilo2WeightBatching.Text = currentFormulaBatching.Silo2
        lblSilo3WeightBatching.Text = currentFormulaBatching.Silo3
        lblSilo4WeightBatching.Text = currentFormulaBatching.Silo4
        lblSilo5WeightBatching.Text = currentFormulaBatching.Silo5
        lblSilo6WeightBatching.Text = currentFormulaBatching.Silo6
        lblSilo7WeightBatching.Text = currentFormulaBatching.Silo7
        lblSilo8WeightBatching.Text = currentFormulaBatching.Silo8
        lblMolassesWeightBatching.Text = currentFormulaBatching.Molasses
        lblCocoOilWeightBatching.Text = currentFormulaBatching.CocoOil
    End Sub
    Public Sub CallToast(ByVal caption As String, ByVal description As String)
        Dim toast = New ToastBuilder(Me).SetCaption(caption).SetDescription(description).SetDuration(5000).SetMuting(False).Build()
        toast.Show()
    End Sub




    Private Async Sub btnStartStopBatching_Click(sender As Object, e As EventArgs) Handles btnStartStopBatching.Click
        If dryCancellationTokenSource Is Nothing AndAlso liquidCancellationTokenSource Is Nothing Then
            dryCancellationTokenSource = New CancellationTokenSource()
            liquidCancellationTokenSource = New CancellationTokenSource()

            statusDry = 1
            statusWet = 1
            currentTargetWeightDry = currentFormulaBatching.Silo1
            currentTargetWeightWet = currentFormulaBatching.Molasses

            lblCurrentSilo.Text = "Silo 1"
            lblCurrentTargetWeightDry.Text = currentTargetWeightDry

            lblCurrentPump.Text = "Coco Oil"
            lblCurrentTargetWeightLiquid.Text = currentTargetWeightWet

            btnDischarge.Enabled = False

            ' Start both tasks asynchronously
            Await Task.WhenAll(
            DryMatsBatchingAsync(dryCancellationTokenSource.Token),
            LiquidMatsBatchingAsync(liquidCancellationTokenSource.Token))

            btnDischarge.Enabled = True
            CallToast("Auto Batching", "Batching completed. Discharge is now available.")
        Else
            If dryCancellationTokenSource IsNot Nothing Then
                dryCancellationTokenSource.Cancel()
                dryCancellationTokenSource = Nothing
            End If

            If liquidCancellationTokenSource IsNot Nothing Then
                liquidCancellationTokenSource.Cancel()
                liquidCancellationTokenSource = Nothing
            End If

            stopBatching()
            btnDischarge.Enabled = True
            MsgBox("Batching stopped.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox1.Text, currentValue) Then
            currentValue -= 1
            TextBox1.Text = currentValue.ToString()
            binCurrentLoadDry = CDbl(currentValue)
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox1.Text, currentValue) Then
            currentValue += 1
            TextBox1.Text = currentValue.ToString()
            binCurrentLoadDry = CDbl(currentValue)
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox2.Text, currentValue) Then
            currentValue += 1
            TextBox2.Text = currentValue.ToString()
            binCurrentLoadWet = CDbl(currentValue)
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox2.Text, currentValue) Then
            currentValue -= 1
            TextBox2.Text = currentValue.ToString()
            binCurrentLoadWet = CDbl(currentValue)
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tmrUiUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUiUpdate.Tick
        UpdateUI()
    End Sub

    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        If BatchGateStatus = False Then
            BatchGateStatus = True
            commandPLC(8) = True
            commandPLC(12) = True

            btnDischarge.color = Color.Firebrick
            btnStartStopBatching.Enabled = False
            btnTopGate.Enabled = False
        Else
            BatchGateStatus = False
            commandPLC(8) = False
            commandPLC(12) = False

            btnDischarge.color = Color.SeaGreen
            btnStartStopBatching.Enabled = True
            btnTopGate.Enabled = True
        End If
    End Sub

    Private Sub btnTopGate_Click(sender As Object, e As EventArgs) Handles btnTopGate.Click
        If TopGateStatus = False Then
            TopGateStatus = True
            commandPLC(13) = True
            btnBottomGate.Enabled = False
            btnDischarge.Enabled = False
        Else
            TopGateStatus = False
            commandPLC(13) = False
            btnBottomGate.Enabled = True
            btnDischarge.Enabled = True
        End If
    End Sub

    Private Sub btnBottomGate_Click(sender As Object, e As EventArgs) Handles btnBottomGate.Click
        If BottomGateStatus = False Then
            BottomGateStatus = True
            commandPLC(14) = True
            btnTopGate.Enabled = False
            'btnDischarge.Enabled = False
        Else
            BottomGateStatus = False
            commandPLC(14) = False
            btnTopGate.Enabled = True
            'btnDischarge.Enabled = True
        End If
    End Sub

    Private Sub cmbFormula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormula.SelectedIndexChanged
        Console.WriteLine(cmbFormula.SelectedValue)
        currentFormula = New formula(formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Id,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).FormulaName,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Silo1,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Silo2,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Silo3,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Silo4,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Silo5,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Silo6,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Silo7,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Silo8,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).Molasses,
                                    formulaList.Find(Function(name) name.FormulaName = cmbFormula.Text).CocoOil)

        Console.WriteLine(currentFormula.FormulaName)
        lblFormulaId.Text = currentFormula.Id
        txtbFormulaName.Text = currentFormula.FormulaName
        txtbSilo1Weight.Text = currentFormula.Silo1
        txtbSilo2Weight.Text = currentFormula.Silo2
        txtbSilo3Weight.Text = currentFormula.Silo3
        txtbSilo4Weight.Text = currentFormula.Silo4
        txtbSilo5Weight.Text = currentFormula.Silo5
        txtbSilo6Weight.Text = currentFormula.Silo6
        txtbSilo7Weight.Text = currentFormula.Silo7
        txtbSilo8Weight.Text = currentFormula.Silo8
        txtbMolassesWeight.Text = currentFormula.Molasses
        txtbCocoOilWeight.Text = currentFormula.CocoOil
    End Sub

    Sub connectPLC()
        Try
            If (IF_Connected = False) Then
                IF_Connected = True
                srlPLC = New SerialPort("COM4", 9600, Parity.None, 8, 1)
                srlPLC.Open() 'Open 
                Master_Station = ModbusSerialMaster.CreateRtu(srlPLC)
                Master_Station.Transport.ReadTimeout = 500
                Master_Station.Transport.WriteTimeout = 500
                Master_Station.Transport.Retries = 0
                tmrPLC.Start()
                'ถ้า เชื่อมต่อไม่ได้
            ElseIf (IF_Connected = True) Then
                IF_Connected = False
                tmrPLC.Stop()
                srlPLC.Close() 'Close COM port
            End If
        Catch ex As Exception
            'ReportError(ex.Message)
        End Try

    End Sub

    Private Sub receivedText(ByVal [text] As String)
        If Me.lblCurrentWeightDryBatching.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf receivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Dim revString As String = [text]
            Dim clean As String
            clean = revString.Replace("=", "")
            weight = clean
            Try
                binCurrentLoadDry = CDbl(clean)
            Catch ex As Exception

            End Try


            Try
                Me.lblCurrentWeightDryBatching.Text = CStr(binCurrentLoadDry) + " KG" 'append text
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub conLiquidScale_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles srlLiquidScale.DataReceived
        receivedTextliquid(srlLiquidScale.ReadExisting())
    End Sub
    Private Sub receivedTextliquid(ByVal [text] As String)
        If Me.lblCurrentWeightLiquidBatching.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf receivedTextliquid)
            Me.Invoke(x, New Object() {(text)})
        Else
            Dim revString As String = [text]
            Dim clean As String
            clean = revString.Replace("=", "")
            weightLiquid = clean
            Try
                binCurrentLoadWet = CDbl(clean)
            Catch ex As Exception

            End Try

            Try
                Me.lblCurrentWeightLiquidBatching.Text = CStr(binCurrentLoadWet) + " KG" 'append text
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnAddFormula_Click(sender As Object, e As EventArgs) Handles btnAddFormula.Click
        If txtbFormulaName.Text = "" Or txtbFormulaName.Text = "Enter Formula Name" Then
            MsgBox("Please Enter Formula Name!")
        Else
            If checkFormulaName(txtbFormulaName.Text) = False Then
                Try
                    AddFormulaTextBoxtoFormula()
                    AddFormula(currentFormula)

                    ClearFormula()
                    convertTxtBtoZero()
                    RefreshFormulaList()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Formula Already Existed!")
            End If
        End If
    End Sub

    Private Sub btnRefreshFormula_Click(sender As Object, e As EventArgs) Handles btnRefreshFormula.Click
        RefreshFormulaList()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFormula()
        convertTxtBtoZero()
    End Sub

    Private Sub btnDeleteFormula_Click(sender As Object, e As EventArgs) Handles btnDeleteFormula.Click
        Try
            DeleteFormula(currentFormula)
            ClearFormula()
            convertTxtBtoZero()
            RefreshFormulaList()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnEditFormula_Click(sender As Object, e As EventArgs) Handles btnEditFormula.Click
        Try
            EditFormulaTextBoxtoFormula()
            UpdateFormula(currentFormula)
            ClearFormula()
            convertTxtBtoZero()
            RefreshFormulaList()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Sub read()
        Try
            If (IF_Connected = False) Then
                IF_Connected = True
                srlPLC.PortName = My.Settings.ComPortPLC
                srlPLC = New SerialPort(My.Settings.ComPortPLC, 9600, Parity.None, 8, StopBits.One)
                srlPLC.Open()
                Master_Station = ModbusSerialMaster.CreateRtu(srlPLC)
                Master_Station.Transport.ReadTimeout = 300
            ElseIf (IF_Connected = True) Then
                pbPLC.Image = My.Resources.CONNECTED
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub tmrSpray_Tick(sender As Object, e As EventArgs) Handles tmrSpray.Tick
        Dim elapsedTime As TimeSpan = timeSpray.Elapsed
        Dim remainingTime As TimeSpan = targetTimeSpray - elapsedTime

        If remainingTime.TotalSeconds <= 0 Then
            timeSpray.Stop()
            tmrSpray.Stop()
            lblTimerSprayRemain.Text = "00:00:00"
            btnSprayPump.color = Color.SeaGreen
            btnDischarge.Enabled = True
            commandPLC(9) = 0
        Else
            lblTimerSprayRemain.Text = remainingTime.ToString("hh\:mm\:ss")
            commandPLC(9) = 1
        End If
    End Sub

    Private Sub btnSprayPump_Click(sender As Object, e As EventArgs) Handles btnSprayPump.Click
        If tmrSpray.Enabled = False Then
            If TimeSpan.TryParse(ConvertSecondsToTime(txtbTimerSpray.Text), targetTimeSpray) Then
                timeSpray.Reset()
                timeSpray.Start()
                tmrSpray.Start()
                btnDischarge.Enabled = False
            Else
                MessageBox.Show("Invalid time format. Please enter time in the format 'hh:mm:ss'.")
            End If
            btnSprayPump.color = Color.Firebrick
        Else
            timeSpray.Stop()
            tmrSpray.Stop()
            lblTimerSprayRemain.Text = "00:00:00"
            btnSprayPump.color = Color.SeaGreen
            btnDischarge.Enabled = True
            commandPLC(9) = 0
        End If

    End Sub

    Private Sub tmrMixer_Tick(sender As Object, e As EventArgs) Handles tmrMixer.Tick
        Dim elapsedTime As TimeSpan = timeMixer.Elapsed
        Dim remainingTime As TimeSpan = targetTimeMixer - elapsedTime

        If remainingTime.TotalSeconds <= 0 Then
            timeMixer.Stop()
            tmrMixer.Stop()
            lblTimeMixerRemain.Text = "00:00:00"
            btnMixerTimer.color = Color.SeaGreen
            btnTopGate.Enabled = True
            btnBottomGate.Enabled = True
            btnSprayPump.Enabled = False
        Else
            lblTimeMixerRemain.Text = remainingTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub btnMixerTimer_Click(sender As Object, e As EventArgs) Handles btnMixerTimer.Click
        If tmrMixer.Enabled = False Then
            If TimeSpan.TryParse(ConvertMinutesToTime(txtBTimeMixer.Text), targetTimeMixer) Then
                timeMixer.Reset()
                timeMixer.Start()
                tmrMixer.Start()
                btnTopGate.Enabled = False
                btnBottomGate.Enabled = False
                btnSprayPump.Enabled = True
            Else
                MessageBox.Show("Invalid time format. Please enter time in the format 'hh:mm:ss'.")
            End If
            btnMixerTimer.color = Color.Firebrick
        Else
            timeMixer.Stop()
            tmrMixer.Stop()
            lblTimeMixerRemain.Text = "00:00:00"
            btnMixerTimer.color = Color.SeaGreen
            btnTopGate.Enabled = True
            btnBottomGate.Enabled = True

            timeSpray.Stop()
            tmrSpray.Stop()
            lblTimerSprayRemain.Text = "00:00:00"
            btnSprayPump.color = Color.SeaGreen
            btnDischarge.Enabled = True
            commandPLC(9) = 0

            btnSprayPump.Enabled = False
        End If

    End Sub
End Class
