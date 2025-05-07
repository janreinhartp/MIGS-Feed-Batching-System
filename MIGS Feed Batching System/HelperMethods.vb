Module HelperMethods

    Public Function ConvertSecondsToTime(ByVal seconds As Integer) As String
        Dim ts As TimeSpan = TimeSpan.FromSeconds(seconds)
        Dim formattedTime As String = ts.ToString("hh\:mm\:ss")
        Return formattedTime
    End Function

    Public Function ConvertMinutesToTime(ByVal minute As Integer) As String
        Dim ts As TimeSpan = TimeSpan.FromMinutes(minute)
        Dim formattedTime As String = ts.ToString("hh\:mm\:ss")
        Return formattedTime
    End Function

    Public Sub LoadComPort()
        ' Form1.srlPLC.PortName = My.Settings.PlcPort


        'Form1.srlDryScale.PortName = My.Settings.BatchScalePort

        'Form1.srlLiquidScale.PortName = My.Settings.LiquidScalePort

        'Main.SerialPLC.PortName = "COM120"
        'Main.comScaleDry.PortName = "COM120"
        'Main.comScaleWet.PortName = "COM120"
    End Sub

    Public Sub ClearFormulaBatching()
        Form1.currentFormulaBatching = New formula(0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        Form1.lblFormulaNameBatching.Text = "Select Formula"
        Form1.lblSilo1WeightBatching.Text = Form1.currentFormulaBatching.Silo1.ToString + " KG"
        Form1.lblSilo2WeightBatching.Text = Form1.currentFormulaBatching.Silo2.ToString + " KG"
        Form1.lblSilo3WeightBatching.Text = Form1.currentFormulaBatching.Silo3.ToString + " KG"
        Form1.lblSilo4WeightBatching.Text = Form1.currentFormulaBatching.Silo4.ToString + " KG"
        Form1.lblSilo5WeightBatching.Text = Form1.currentFormulaBatching.Silo5.ToString + " KG"
        Form1.lblSilo6WeightBatching.Text = Form1.currentFormulaBatching.Silo6.ToString + " KG"
        Form1.lblSilo7WeightBatching.Text = Form1.currentFormulaBatching.Silo6.ToString + " KG"
        Form1.lblSilo8WeightBatching.Text = Form1.currentFormulaBatching.Silo6.ToString + " KG"
        Form1.lblMolassesWeightBatching.Text = Form1.currentFormulaBatching.Molasses.ToString + " KG"
        Form1.lblCocoOilWeightBatching.Text = Form1.currentFormulaBatching.CocoOil.ToString + " KG"
        Form1.lblBatchingStatus.Text = "Waiting For Batching"
        Form1.lblCurrentSilo.Text = "N/A"
        Form1.lblCurrentTargetWeightDry.Text = "0 KG"
        Form1.lblCurrentPump.Text = "N/A"
        Form1.lblCurrentTargetWeightLiquid.Text = "0 KG"

    End Sub

    Public Sub ClearFormula()
        Form1.txtbFormulaName.Text = ""
        Form1.txtbSilo1Weight.Text = ""
        Form1.txtbSilo2Weight.Text = ""
        Form1.txtbSilo3Weight.Text = ""
        Form1.txtbSilo4Weight.Text = ""
        Form1.txtbSilo5Weight.Text = ""
        Form1.txtbSilo6Weight.Text = ""
        Form1.txtbSilo7Weight.Text = ""
        Form1.txtbSilo8Weight.Text = ""
        Form1.txtbMolassesWeight.Text = ""
        Form1.txtbCocoOilWeight.Text = ""
        Form1.lblFormulaId.Text = 0
    End Sub
    Public Sub convertTxtBtoZero()
        If Form1.txtbSilo1Weight.Text = "" Then
            Form1.txtbSilo1Weight.Text = 0
        End If
        If Form1.txtbSilo2Weight.Text = "" Then
            Form1.txtbSilo2Weight.Text = 0
        End If
        If Form1.txtbSilo3Weight.Text = "" Then
            Form1.txtbSilo3Weight.Text = 0
        End If
        If Form1.txtbSilo4Weight.Text = "" Then
            Form1.txtbSilo4Weight.Text = 0
        End If
        If Form1.txtbSilo5Weight.Text = "" Then
            Form1.txtbSilo5Weight.Text = 0
        End If
        If Form1.txtbSilo6Weight.Text = "" Then
            Form1.txtbSilo6Weight.Text = 0
        End If

        If Form1.txtbSilo7Weight.Text = "" Then
            Form1.txtbSilo7Weight.Text = 0
        End If
        If Form1.txtbSilo8Weight.Text = "" Then
            Form1.txtbSilo8Weight.Text = 0
        End If

        If Form1.txtbMolassesWeight.Text = "" Then
            Form1.txtbMolassesWeight.Text = 0
        End If

        If Form1.txtbCocoOilWeight.Text = "" Then
            Form1.txtbCocoOilWeight.Text = 0
        End If
    End Sub

    Public Sub AddFormulaTextBoxtoFormula()
        Form1.currentFormula = New formula(0,
                                           Form1.txtbFormulaName.Text,
                                           CDbl(Form1.txtbSilo1Weight.Text),
                                           CDbl(Form1.txtbSilo2Weight.Text),
                                           CDbl(Form1.txtbSilo3Weight.Text),
                                           CDbl(Form1.txtbSilo4Weight.Text),
                                           CDbl(Form1.txtbSilo5Weight.Text),
                                           CDbl(Form1.txtbSilo6Weight.Text),
                                           CDbl(Form1.txtbSilo7Weight.Text),
                                           CDbl(Form1.txtbSilo8Weight.Text),
                                           CDbl(Form1.txtbMolassesWeight.Text),
                                           CDbl(Form1.txtbCocoOilWeight.Text))
    End Sub

    Public Sub EditFormulaTextBoxtoFormula()
        Form1.currentFormula = New formula(CInt(Form1.lblFormulaId.Text),
                                           Form1.txtbFormulaName.Text,
                                           CDbl(Form1.txtbSilo1Weight.Text),
                                           CDbl(Form1.txtbSilo2Weight.Text),
                                           CDbl(Form1.txtbSilo3Weight.Text),
                                           CDbl(Form1.txtbSilo4Weight.Text),
                                           CDbl(Form1.txtbSilo5Weight.Text),
                                           CDbl(Form1.txtbSilo6Weight.Text),
                                           CDbl(Form1.txtbSilo7Weight.Text),
                                           CDbl(Form1.txtbSilo8Weight.Text),
                                           CDbl(Form1.txtbMolassesWeight.Text),
                                           CDbl(Form1.txtbCocoOilWeight.Text))
    End Sub


    Public Sub RefreshFormulaList()
        Form1.formulaList = GetFormulas()
        Form1.cmbFormula.Items.Clear()
        Form1.cmbFormulaBatching.Items.Clear()

        For Each item As formula In Form1.formulaList
            Form1.cmbFormulaBatching.Items.Add(item.FormulaName)
            Form1.cmbFormula.Items.Add(item.FormulaName)
        Next
    End Sub


    Public Sub UpdateUI()
        If Form1.commandPLC(0) = True Then
            Form1.pbSilo1.Image = My.Resources.RUN
        Else
            Form1.pbSilo1.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(1) = True Then
            Form1.pbSilo2.Image = My.Resources.RUN
        Else
            Form1.pbSilo2.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(2) = True Then
            Form1.pbSilo3.Image = My.Resources.RUN
        Else
            Form1.pbSilo3.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(3) = True Then
            Form1.pbSilo4.Image = My.Resources.RUN
        Else
            Form1.pbSilo4.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(4) = True Then
            Form1.pbSilo5.Image = My.Resources.RUN
        Else
            Form1.pbSilo5.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(5) = True Then
            Form1.pbSilo6.Image = My.Resources.RUN
        Else
            Form1.pbSilo6.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(6) = True Then
            Form1.pbSilo7.Image = My.Resources.RUN
        Else
            Form1.pbSilo7.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(7) = True Then
            Form1.pbSilo8.Image = My.Resources.RUN
        Else
            Form1.pbSilo8.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(8) = True Then
            Form1.pbMolasses.Image = My.Resources.RUN
        Else
            Form1.pbMolasses.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(9) = True Then
            Form1.pbCocoOil.Image = My.Resources.RUN
        Else
            Form1.pbCocoOil.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(10) = True Then
            Form1.pbSprayPump.Image = My.Resources.RUN
        Else
            Form1.pbSprayPump.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(11) = True Then
            Form1.pbBatchGate.Image = My.Resources.RUN
        Else
            Form1.pbBatchGate.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(12) = True Then
            Form1.pbLiquidGate.Image = My.Resources.RUN
        Else
            Form1.pbLiquidGate.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(13) = True Then
            Form1.pbTopGate.Image = My.Resources.RUN
        Else
            Form1.pbTopGate.Image = My.Resources.STOP_1
        End If

        If Form1.commandPLC(14) = True Then
            Form1.pbBottomGate.Image = My.Resources.RUN
        Else
            Form1.pbBottomGate.Image = My.Resources.STOP_1
        End If
    End Sub

    Public Sub stopBatching()
        Form1.commandPLC(0) = 0
        Form1.commandPLC(1) = 0
        Form1.commandPLC(2) = 0
        Form1.commandPLC(3) = 0
        Form1.commandPLC(4) = 0
        Form1.commandPLC(5) = 0
        Form1.commandPLC(6) = 0
        Form1.commandPLC(7) = 0

        Form1.commandPLC(8) = 0
        Form1.commandPLC(9) = 0
    End Sub

    Public Sub stopAll()
        Form1.commandPLC(0) = 0
        Form1.commandPLC(1) = 0
        Form1.commandPLC(2) = 0
        Form1.commandPLC(3) = 0
        Form1.commandPLC(4) = 0
        Form1.commandPLC(5) = 0
        Form1.commandPLC(6) = 0
        Form1.commandPLC(7) = 0
        Form1.commandPLC(8) = 0
        Form1.commandPLC(9) = 0
        Form1.commandPLC(10) = 0
        Form1.commandPLC(11) = 0
        Form1.commandPLC(12) = 0
        Form1.commandPLC(13) = 0
        Form1.commandPLC(14) = 0
        Form1.commandPLC(15) = 0
        Form1.commandPLC(16) = 0
        Form1.commandPLC(17) = 0
        Form1.commandPLC(18) = 0
        Form1.commandPLC(19) = 0
    End Sub

End Module
