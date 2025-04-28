<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrPLC = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDryScale = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLiquidScale = New System.Windows.Forms.Timer(Me.components)
        Me.srlPLC = New System.IO.Ports.SerialPort(Me.components)
        Me.srlDryScale = New System.IO.Ports.SerialPort(Me.components)
        Me.srlLiquidScale = New System.IO.Ports.SerialPort(Me.components)
        Me.pnlBatching = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFormulaBatching = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTimerSprayRemain = New System.Windows.Forms.Label()
        Me.lblTimeMixerRemain = New System.Windows.Forms.Label()
        Me.txtbTimerSpray = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtBTimeMixer = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnSprayPump = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnBottomGate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnMixerTimer = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnTopGate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDischarge = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnStartStopBatching = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnRefreshFormulaBatching = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlDiagram = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pbLiquidGate = New System.Windows.Forms.PictureBox()
        Me.pbCocoOil = New System.Windows.Forms.PictureBox()
        Me.pbMolasses = New System.Windows.Forms.PictureBox()
        Me.pbSprayPump = New System.Windows.Forms.PictureBox()
        Me.pbBottomGate = New System.Windows.Forms.PictureBox()
        Me.pbTopGate = New System.Windows.Forms.PictureBox()
        Me.pbBatchGate = New System.Windows.Forms.PictureBox()
        Me.pbSilo8 = New System.Windows.Forms.PictureBox()
        Me.pbSilo7 = New System.Windows.Forms.PictureBox()
        Me.pbSilo6 = New System.Windows.Forms.PictureBox()
        Me.pbSilo5 = New System.Windows.Forms.PictureBox()
        Me.pbSilo4 = New System.Windows.Forms.PictureBox()
        Me.pbSilo3 = New System.Windows.Forms.PictureBox()
        Me.pbSilo2 = New System.Windows.Forms.PictureBox()
        Me.pbSilo1 = New System.Windows.Forms.PictureBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.lblFormulaNameBatching = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.lblCurrentTargetWeightLiquid = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.lblCurrentPump = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.lblCurrentTargetWeightDry = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.lblCurrentSilo = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.lblBatchingStatus = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lblTargetWeightDryBatching = New System.Windows.Forms.Label()
        Me.lblCurrentWeightDryBatching = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.lblTargetWeightLiquidBatching = New System.Windows.Forms.Label()
        Me.lblCurrentWeightLiquidBatching = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblMolassesWeightBatching = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblCocoOilWeightBatching = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblSilo8WeightBatching = New System.Windows.Forms.Label()
        Me.lblSilo8RawMatsBatching = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblSilo7WeightBatching = New System.Windows.Forms.Label()
        Me.lblSilo7RawMatsBatching = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblSilo6WeightBatching = New System.Windows.Forms.Label()
        Me.lblSilo6RawMatsBatching = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblSilo5WeightBatching = New System.Windows.Forms.Label()
        Me.lblSilo5RawMatsBatching = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblSilo4WeightBatching = New System.Windows.Forms.Label()
        Me.lblSilo4RawMatsBatching = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblSilo3WeightBatching = New System.Windows.Forms.Label()
        Me.lblSilo3RawMatsBatching = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSilo2WeightBatching = New System.Windows.Forms.Label()
        Me.lblSilo2RawMatsBatching = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSilo1WeightBatching = New System.Windows.Forms.Label()
        Me.lblSilo1RawMatsBatching = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlFormula = New System.Windows.Forms.Panel()
        Me.lblFormulaMatSilo8 = New System.Windows.Forms.Label()
        Me.lblFormulaMatSilo7 = New System.Windows.Forms.Label()
        Me.lblFormulaMatSilo6 = New System.Windows.Forms.Label()
        Me.lblFormulaMatSilo5 = New System.Windows.Forms.Label()
        Me.lblFormulaMatSilo4 = New System.Windows.Forms.Label()
        Me.lblFormulaMatSilo3 = New System.Windows.Forms.Label()
        Me.lblFormulaMatSilo2 = New System.Windows.Forms.Label()
        Me.lblFormulaMatSilo1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFormula = New System.Windows.Forms.ComboBox()
        Me.lblFormulaId = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.btnClear = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDeleteFormula = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnEditFormula = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnAddFormula = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnRefreshFormula = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtbCocoOilWeight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtbMolassesWeight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtbSilo8Weight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtbSilo7Weight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtbSilo6Weight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtbSilo5Weight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtbSilo4Weight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtbSilo3Weight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtbSilo2Weight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtbSilo1Weight = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtbFormulaName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tmrUiUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSpray = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMixer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBatching.SuspendLayout()
        Me.pnlDiagram.SuspendLayout()
        CType(Me.pbLiquidGate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCocoOil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMolasses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSprayPump, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBottomGate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTopGate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBatchGate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFormula.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrPLC
        '
        '
        'srlDryScale
        '
        '
        'srlLiquidScale
        '
        '
        'pnlBatching
        '
        Me.pnlBatching.Controls.Add(Me.Label1)
        Me.pnlBatching.Controls.Add(Me.cmbFormulaBatching)
        Me.pnlBatching.Controls.Add(Me.Panel1)
        Me.pnlBatching.Controls.Add(Me.Label3)
        Me.pnlBatching.Controls.Add(Me.Label4)
        Me.pnlBatching.Controls.Add(Me.lblTimerSprayRemain)
        Me.pnlBatching.Controls.Add(Me.lblTimeMixerRemain)
        Me.pnlBatching.Controls.Add(Me.txtbTimerSpray)
        Me.pnlBatching.Controls.Add(Me.txtBTimeMixer)
        Me.pnlBatching.Controls.Add(Me.btnSprayPump)
        Me.pnlBatching.Controls.Add(Me.btnBottomGate)
        Me.pnlBatching.Controls.Add(Me.btnMixerTimer)
        Me.pnlBatching.Controls.Add(Me.btnTopGate)
        Me.pnlBatching.Controls.Add(Me.btnDischarge)
        Me.pnlBatching.Controls.Add(Me.btnStartStopBatching)
        Me.pnlBatching.Controls.Add(Me.btnRefreshFormulaBatching)
        Me.pnlBatching.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBatching.Location = New System.Drawing.Point(0, 0)
        Me.pnlBatching.Name = "pnlBatching"
        Me.pnlBatching.Size = New System.Drawing.Size(540, 1080)
        Me.pnlBatching.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 41)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Select Formula Batching:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbFormulaBatching
        '
        Me.cmbFormulaBatching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormulaBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormulaBatching.FormattingEnabled = True
        Me.cmbFormulaBatching.Location = New System.Drawing.Point(52, 86)
        Me.cmbFormulaBatching.MaxDropDownItems = 20
        Me.cmbFormulaBatching.Name = "cmbFormulaBatching"
        Me.cmbFormulaBatching.Size = New System.Drawing.Size(326, 33)
        Me.cmbFormulaBatching.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 1007)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 73)
        Me.Panel1.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Spray Timer:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 478)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Mixer Timer:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimerSprayRemain
        '
        Me.lblTimerSprayRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerSprayRemain.Location = New System.Drawing.Point(299, 509)
        Me.lblTimerSprayRemain.Name = "lblTimerSprayRemain"
        Me.lblTimerSprayRemain.Size = New System.Drawing.Size(150, 25)
        Me.lblTimerSprayRemain.TabIndex = 18
        Me.lblTimerSprayRemain.Text = "00:00:00"
        Me.lblTimerSprayRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeMixerRemain
        '
        Me.lblTimeMixerRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeMixerRemain.Location = New System.Drawing.Point(72, 510)
        Me.lblTimeMixerRemain.Name = "lblTimeMixerRemain"
        Me.lblTimeMixerRemain.Size = New System.Drawing.Size(150, 25)
        Me.lblTimeMixerRemain.TabIndex = 17
        Me.lblTimeMixerRemain.Text = "00:00:00"
        Me.lblTimeMixerRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbTimerSpray
        '
        Me.txtbTimerSpray.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtbTimerSpray.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbTimerSpray.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtbTimerSpray.BorderThickness = 3
        Me.txtbTimerSpray.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbTimerSpray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbTimerSpray.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbTimerSpray.isPassword = False
        Me.txtbTimerSpray.Location = New System.Drawing.Point(297, 537)
        Me.txtbTimerSpray.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbTimerSpray.Name = "txtbTimerSpray"
        Me.txtbTimerSpray.Size = New System.Drawing.Size(154, 60)
        Me.txtbTimerSpray.TabIndex = 16
        Me.txtbTimerSpray.Text = "30"
        Me.txtbTimerSpray.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtBTimeMixer
        '
        Me.txtBTimeMixer.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtBTimeMixer.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBTimeMixer.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtBTimeMixer.BorderThickness = 3
        Me.txtBTimeMixer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBTimeMixer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBTimeMixer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBTimeMixer.isPassword = False
        Me.txtBTimeMixer.Location = New System.Drawing.Point(70, 537)
        Me.txtBTimeMixer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtBTimeMixer.Name = "txtBTimeMixer"
        Me.txtBTimeMixer.Size = New System.Drawing.Size(154, 60)
        Me.txtBTimeMixer.TabIndex = 15
        Me.txtBTimeMixer.Text = "5"
        Me.txtBTimeMixer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSprayPump
        '
        Me.btnSprayPump.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSprayPump.color = System.Drawing.Color.SeaGreen
        Me.btnSprayPump.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnSprayPump.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSprayPump.Enabled = False
        Me.btnSprayPump.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnSprayPump.ForeColor = System.Drawing.Color.White
        Me.btnSprayPump.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.SPRAY
        Me.btnSprayPump.ImagePosition = 20
        Me.btnSprayPump.ImageZoom = 25
        Me.btnSprayPump.LabelPosition = 41
        Me.btnSprayPump.LabelText = "SPRAY"
        Me.btnSprayPump.Location = New System.Drawing.Point(279, 609)
        Me.btnSprayPump.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSprayPump.Name = "btnSprayPump"
        Me.btnSprayPump.Size = New System.Drawing.Size(190, 120)
        Me.btnSprayPump.TabIndex = 14
        '
        'btnBottomGate
        '
        Me.btnBottomGate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnBottomGate.color = System.Drawing.Color.SeaGreen
        Me.btnBottomGate.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnBottomGate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBottomGate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnBottomGate.ForeColor = System.Drawing.Color.White
        Me.btnBottomGate.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.BOTTOM
        Me.btnBottomGate.ImagePosition = 20
        Me.btnBottomGate.ImageZoom = 25
        Me.btnBottomGate.LabelPosition = 41
        Me.btnBottomGate.LabelText = "BOTTOM GATE"
        Me.btnBottomGate.Location = New System.Drawing.Point(279, 315)
        Me.btnBottomGate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBottomGate.Name = "btnBottomGate"
        Me.btnBottomGate.Size = New System.Drawing.Size(190, 120)
        Me.btnBottomGate.TabIndex = 13
        '
        'btnMixerTimer
        '
        Me.btnMixerTimer.BackColor = System.Drawing.Color.SeaGreen
        Me.btnMixerTimer.color = System.Drawing.Color.SeaGreen
        Me.btnMixerTimer.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnMixerTimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMixerTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnMixerTimer.ForeColor = System.Drawing.Color.White
        Me.btnMixerTimer.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.MIX
        Me.btnMixerTimer.ImagePosition = 20
        Me.btnMixerTimer.ImageZoom = 25
        Me.btnMixerTimer.LabelPosition = 41
        Me.btnMixerTimer.LabelText = "MIXER"
        Me.btnMixerTimer.Location = New System.Drawing.Point(52, 609)
        Me.btnMixerTimer.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMixerTimer.Name = "btnMixerTimer"
        Me.btnMixerTimer.Size = New System.Drawing.Size(190, 120)
        Me.btnMixerTimer.TabIndex = 11
        '
        'btnTopGate
        '
        Me.btnTopGate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnTopGate.color = System.Drawing.Color.SeaGreen
        Me.btnTopGate.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnTopGate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTopGate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnTopGate.ForeColor = System.Drawing.Color.White
        Me.btnTopGate.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.TOP
        Me.btnTopGate.ImagePosition = 20
        Me.btnTopGate.ImageZoom = 25
        Me.btnTopGate.LabelPosition = 41
        Me.btnTopGate.LabelText = "TOP GATE"
        Me.btnTopGate.Location = New System.Drawing.Point(52, 315)
        Me.btnTopGate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnTopGate.Name = "btnTopGate"
        Me.btnTopGate.Size = New System.Drawing.Size(190, 120)
        Me.btnTopGate.TabIndex = 9
        '
        'btnDischarge
        '
        Me.btnDischarge.BackColor = System.Drawing.Color.SeaGreen
        Me.btnDischarge.color = System.Drawing.Color.SeaGreen
        Me.btnDischarge.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnDischarge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnDischarge.ForeColor = System.Drawing.Color.White
        Me.btnDischarge.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.DISCHARGE
        Me.btnDischarge.ImagePosition = 20
        Me.btnDischarge.ImageZoom = 25
        Me.btnDischarge.LabelPosition = 41
        Me.btnDischarge.LabelText = "DISCHARGE"
        Me.btnDischarge.Location = New System.Drawing.Point(279, 166)
        Me.btnDischarge.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDischarge.Name = "btnDischarge"
        Me.btnDischarge.Size = New System.Drawing.Size(190, 120)
        Me.btnDischarge.TabIndex = 7
        '
        'btnStartStopBatching
        '
        Me.btnStartStopBatching.BackColor = System.Drawing.Color.SeaGreen
        Me.btnStartStopBatching.color = System.Drawing.Color.SeaGreen
        Me.btnStartStopBatching.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnStartStopBatching.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartStopBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnStartStopBatching.ForeColor = System.Drawing.Color.White
        Me.btnStartStopBatching.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.START
        Me.btnStartStopBatching.ImagePosition = 20
        Me.btnStartStopBatching.ImageZoom = 25
        Me.btnStartStopBatching.LabelPosition = 41
        Me.btnStartStopBatching.LabelText = "START"
        Me.btnStartStopBatching.Location = New System.Drawing.Point(52, 166)
        Me.btnStartStopBatching.Margin = New System.Windows.Forms.Padding(6)
        Me.btnStartStopBatching.Name = "btnStartStopBatching"
        Me.btnStartStopBatching.Size = New System.Drawing.Size(190, 120)
        Me.btnStartStopBatching.TabIndex = 5
        '
        'btnRefreshFormulaBatching
        '
        Me.btnRefreshFormulaBatching.BackColor = System.Drawing.Color.SeaGreen
        Me.btnRefreshFormulaBatching.color = System.Drawing.Color.SeaGreen
        Me.btnRefreshFormulaBatching.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnRefreshFormulaBatching.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshFormulaBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnRefreshFormulaBatching.ForeColor = System.Drawing.Color.White
        Me.btnRefreshFormulaBatching.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.REFRESH
        Me.btnRefreshFormulaBatching.ImagePosition = 10
        Me.btnRefreshFormulaBatching.ImageZoom = 15
        Me.btnRefreshFormulaBatching.LabelPosition = 41
        Me.btnRefreshFormulaBatching.LabelText = "REFRESH"
        Me.btnRefreshFormulaBatching.Location = New System.Drawing.Point(387, 42)
        Me.btnRefreshFormulaBatching.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRefreshFormulaBatching.Name = "btnRefreshFormulaBatching"
        Me.btnRefreshFormulaBatching.Size = New System.Drawing.Size(144, 80)
        Me.btnRefreshFormulaBatching.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Activecolor = System.Drawing.Color.Maroon
        Me.btnExit.BackColor = System.Drawing.Color.Firebrick
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.BorderRadius = 0
        Me.btnExit.ButtonText = "EXIT"
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DisabledColor = System.Drawing.Color.Gray
        Me.btnExit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExit.Iconimage = Global.MIGS_Feed_Batching_System.My.Resources.Resources._STOP
        Me.btnExit.Iconimage_right = Nothing
        Me.btnExit.Iconimage_right_Selected = Nothing
        Me.btnExit.Iconimage_Selected = Nothing
        Me.btnExit.IconMarginLeft = 0
        Me.btnExit.IconMarginRight = 0
        Me.btnExit.IconRightVisible = True
        Me.btnExit.IconRightZoom = 0R
        Me.btnExit.IconVisible = True
        Me.btnExit.IconZoom = 40.0R
        Me.btnExit.IsTab = False
        Me.btnExit.Location = New System.Drawing.Point(434, 1007)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Normalcolor = System.Drawing.Color.Firebrick
        Me.btnExit.OnHovercolor = System.Drawing.Color.DarkRed
        Me.btnExit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExit.selected = False
        Me.btnExit.Size = New System.Drawing.Size(91, 48)
        Me.btnExit.TabIndex = 51
        Me.btnExit.Text = "EXIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.Textcolor = System.Drawing.Color.White
        Me.btnExit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlDiagram
        '
        Me.pnlDiagram.BackColor = System.Drawing.Color.Transparent
        Me.pnlDiagram.Controls.Add(Me.Button3)
        Me.pnlDiagram.Controls.Add(Me.Button4)
        Me.pnlDiagram.Controls.Add(Me.Button2)
        Me.pnlDiagram.Controls.Add(Me.Button1)
        Me.pnlDiagram.Controls.Add(Me.TextBox2)
        Me.pnlDiagram.Controls.Add(Me.TextBox1)
        Me.pnlDiagram.Controls.Add(Me.pbLiquidGate)
        Me.pnlDiagram.Controls.Add(Me.pbCocoOil)
        Me.pnlDiagram.Controls.Add(Me.pbMolasses)
        Me.pnlDiagram.Controls.Add(Me.pbSprayPump)
        Me.pnlDiagram.Controls.Add(Me.pbBottomGate)
        Me.pnlDiagram.Controls.Add(Me.pbTopGate)
        Me.pnlDiagram.Controls.Add(Me.pbBatchGate)
        Me.pnlDiagram.Controls.Add(Me.pbSilo8)
        Me.pnlDiagram.Controls.Add(Me.pbSilo7)
        Me.pnlDiagram.Controls.Add(Me.pbSilo6)
        Me.pnlDiagram.Controls.Add(Me.pbSilo5)
        Me.pnlDiagram.Controls.Add(Me.pbSilo4)
        Me.pnlDiagram.Controls.Add(Me.pbSilo3)
        Me.pnlDiagram.Controls.Add(Me.pbSilo2)
        Me.pnlDiagram.Controls.Add(Me.pbSilo1)
        Me.pnlDiagram.Controls.Add(Me.Label65)
        Me.pnlDiagram.Controls.Add(Me.Label66)
        Me.pnlDiagram.Controls.Add(Me.lblFormulaNameBatching)
        Me.pnlDiagram.Controls.Add(Me.Label64)
        Me.pnlDiagram.Controls.Add(Me.lblCurrentTargetWeightLiquid)
        Me.pnlDiagram.Controls.Add(Me.Label60)
        Me.pnlDiagram.Controls.Add(Me.lblCurrentPump)
        Me.pnlDiagram.Controls.Add(Me.Label62)
        Me.pnlDiagram.Controls.Add(Me.lblCurrentTargetWeightDry)
        Me.pnlDiagram.Controls.Add(Me.Label58)
        Me.pnlDiagram.Controls.Add(Me.lblCurrentSilo)
        Me.pnlDiagram.Controls.Add(Me.Label56)
        Me.pnlDiagram.Controls.Add(Me.lblBatchingStatus)
        Me.pnlDiagram.Controls.Add(Me.Label48)
        Me.pnlDiagram.Controls.Add(Me.lblTargetWeightDryBatching)
        Me.pnlDiagram.Controls.Add(Me.lblCurrentWeightDryBatching)
        Me.pnlDiagram.Controls.Add(Me.Label52)
        Me.pnlDiagram.Controls.Add(Me.Label53)
        Me.pnlDiagram.Controls.Add(Me.lblTargetWeightLiquidBatching)
        Me.pnlDiagram.Controls.Add(Me.lblCurrentWeightLiquidBatching)
        Me.pnlDiagram.Controls.Add(Me.Label34)
        Me.pnlDiagram.Controls.Add(Me.Label33)
        Me.pnlDiagram.Controls.Add(Me.lblMolassesWeightBatching)
        Me.pnlDiagram.Controls.Add(Me.Label32)
        Me.pnlDiagram.Controls.Add(Me.lblCocoOilWeightBatching)
        Me.pnlDiagram.Controls.Add(Me.Label30)
        Me.pnlDiagram.Controls.Add(Me.lblSilo8WeightBatching)
        Me.pnlDiagram.Controls.Add(Me.lblSilo8RawMatsBatching)
        Me.pnlDiagram.Controls.Add(Me.Label28)
        Me.pnlDiagram.Controls.Add(Me.lblSilo7WeightBatching)
        Me.pnlDiagram.Controls.Add(Me.lblSilo7RawMatsBatching)
        Me.pnlDiagram.Controls.Add(Me.Label25)
        Me.pnlDiagram.Controls.Add(Me.lblSilo6WeightBatching)
        Me.pnlDiagram.Controls.Add(Me.lblSilo6RawMatsBatching)
        Me.pnlDiagram.Controls.Add(Me.Label22)
        Me.pnlDiagram.Controls.Add(Me.lblSilo5WeightBatching)
        Me.pnlDiagram.Controls.Add(Me.lblSilo5RawMatsBatching)
        Me.pnlDiagram.Controls.Add(Me.Label19)
        Me.pnlDiagram.Controls.Add(Me.lblSilo4WeightBatching)
        Me.pnlDiagram.Controls.Add(Me.lblSilo4RawMatsBatching)
        Me.pnlDiagram.Controls.Add(Me.Label16)
        Me.pnlDiagram.Controls.Add(Me.lblSilo3WeightBatching)
        Me.pnlDiagram.Controls.Add(Me.lblSilo3RawMatsBatching)
        Me.pnlDiagram.Controls.Add(Me.Label13)
        Me.pnlDiagram.Controls.Add(Me.lblSilo2WeightBatching)
        Me.pnlDiagram.Controls.Add(Me.lblSilo2RawMatsBatching)
        Me.pnlDiagram.Controls.Add(Me.Label10)
        Me.pnlDiagram.Controls.Add(Me.lblSilo1WeightBatching)
        Me.pnlDiagram.Controls.Add(Me.lblSilo1RawMatsBatching)
        Me.pnlDiagram.Controls.Add(Me.Label5)
        Me.pnlDiagram.Controls.Add(Me.PictureBox2)
        Me.pnlDiagram.Controls.Add(Me.PictureBox1)
        Me.pnlDiagram.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlDiagram.Location = New System.Drawing.Point(540, 0)
        Me.pnlDiagram.Name = "pnlDiagram"
        Me.pnlDiagram.Size = New System.Drawing.Size(840, 1080)
        Me.pnlDiagram.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(191, 482)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(191, 453)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 71
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 411)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(50, 468)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 68
        Me.TextBox2.Text = "0"
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 415)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 67
        Me.TextBox1.Text = "0"
        Me.TextBox1.Visible = False
        '
        'pbLiquidGate
        '
        Me.pbLiquidGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbLiquidGate.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbLiquidGate.Location = New System.Drawing.Point(516, 939)
        Me.pbLiquidGate.Name = "pbLiquidGate"
        Me.pbLiquidGate.Size = New System.Drawing.Size(40, 40)
        Me.pbLiquidGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLiquidGate.TabIndex = 66
        Me.pbLiquidGate.TabStop = False
        '
        'pbCocoOil
        '
        Me.pbCocoOil.BackColor = System.Drawing.Color.Transparent
        Me.pbCocoOil.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbCocoOil.Location = New System.Drawing.Point(711, 888)
        Me.pbCocoOil.Name = "pbCocoOil"
        Me.pbCocoOil.Size = New System.Drawing.Size(40, 40)
        Me.pbCocoOil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCocoOil.TabIndex = 65
        Me.pbCocoOil.TabStop = False
        '
        'pbMolasses
        '
        Me.pbMolasses.BackColor = System.Drawing.Color.Transparent
        Me.pbMolasses.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbMolasses.Location = New System.Drawing.Point(606, 888)
        Me.pbMolasses.Name = "pbMolasses"
        Me.pbMolasses.Size = New System.Drawing.Size(40, 40)
        Me.pbMolasses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMolasses.TabIndex = 64
        Me.pbMolasses.TabStop = False
        '
        'pbSprayPump
        '
        Me.pbSprayPump.BackColor = System.Drawing.Color.Transparent
        Me.pbSprayPump.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSprayPump.Location = New System.Drawing.Point(414, 959)
        Me.pbSprayPump.Name = "pbSprayPump"
        Me.pbSprayPump.Size = New System.Drawing.Size(40, 40)
        Me.pbSprayPump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSprayPump.TabIndex = 63
        Me.pbSprayPump.TabStop = False
        '
        'pbBottomGate
        '
        Me.pbBottomGate.BackColor = System.Drawing.Color.Transparent
        Me.pbBottomGate.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbBottomGate.Location = New System.Drawing.Point(303, 942)
        Me.pbBottomGate.Name = "pbBottomGate"
        Me.pbBottomGate.Size = New System.Drawing.Size(40, 40)
        Me.pbBottomGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBottomGate.TabIndex = 62
        Me.pbBottomGate.TabStop = False
        '
        'pbTopGate
        '
        Me.pbTopGate.BackColor = System.Drawing.Color.Transparent
        Me.pbTopGate.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbTopGate.Location = New System.Drawing.Point(303, 818)
        Me.pbTopGate.Name = "pbTopGate"
        Me.pbTopGate.Size = New System.Drawing.Size(40, 40)
        Me.pbTopGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTopGate.TabIndex = 61
        Me.pbTopGate.TabStop = False
        '
        'pbBatchGate
        '
        Me.pbBatchGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbBatchGate.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbBatchGate.Location = New System.Drawing.Point(532, 618)
        Me.pbBatchGate.Name = "pbBatchGate"
        Me.pbBatchGate.Size = New System.Drawing.Size(40, 40)
        Me.pbBatchGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBatchGate.TabIndex = 60
        Me.pbBatchGate.TabStop = False
        '
        'pbSilo8
        '
        Me.pbSilo8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbSilo8.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSilo8.Location = New System.Drawing.Point(711, 386)
        Me.pbSilo8.Name = "pbSilo8"
        Me.pbSilo8.Size = New System.Drawing.Size(40, 40)
        Me.pbSilo8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSilo8.TabIndex = 59
        Me.pbSilo8.TabStop = False
        '
        'pbSilo7
        '
        Me.pbSilo7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbSilo7.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSilo7.Location = New System.Drawing.Point(590, 386)
        Me.pbSilo7.Name = "pbSilo7"
        Me.pbSilo7.Size = New System.Drawing.Size(40, 40)
        Me.pbSilo7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSilo7.TabIndex = 58
        Me.pbSilo7.TabStop = False
        '
        'pbSilo6
        '
        Me.pbSilo6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbSilo6.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSilo6.Location = New System.Drawing.Point(468, 386)
        Me.pbSilo6.Name = "pbSilo6"
        Me.pbSilo6.Size = New System.Drawing.Size(40, 40)
        Me.pbSilo6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSilo6.TabIndex = 57
        Me.pbSilo6.TabStop = False
        '
        'pbSilo5
        '
        Me.pbSilo5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbSilo5.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSilo5.Location = New System.Drawing.Point(347, 386)
        Me.pbSilo5.Name = "pbSilo5"
        Me.pbSilo5.Size = New System.Drawing.Size(40, 40)
        Me.pbSilo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSilo5.TabIndex = 56
        Me.pbSilo5.TabStop = False
        '
        'pbSilo4
        '
        Me.pbSilo4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbSilo4.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSilo4.Location = New System.Drawing.Point(711, 144)
        Me.pbSilo4.Name = "pbSilo4"
        Me.pbSilo4.Size = New System.Drawing.Size(40, 40)
        Me.pbSilo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSilo4.TabIndex = 55
        Me.pbSilo4.TabStop = False
        '
        'pbSilo3
        '
        Me.pbSilo3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbSilo3.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSilo3.Location = New System.Drawing.Point(589, 144)
        Me.pbSilo3.Name = "pbSilo3"
        Me.pbSilo3.Size = New System.Drawing.Size(40, 40)
        Me.pbSilo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSilo3.TabIndex = 54
        Me.pbSilo3.TabStop = False
        '
        'pbSilo2
        '
        Me.pbSilo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbSilo2.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSilo2.Location = New System.Drawing.Point(468, 144)
        Me.pbSilo2.Name = "pbSilo2"
        Me.pbSilo2.Size = New System.Drawing.Size(40, 40)
        Me.pbSilo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSilo2.TabIndex = 53
        Me.pbSilo2.TabStop = False
        '
        'pbSilo1
        '
        Me.pbSilo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbSilo1.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.STOP_1
        Me.pbSilo1.Location = New System.Drawing.Point(346, 144)
        Me.pbSilo1.Name = "pbSilo1"
        Me.pbSilo1.Size = New System.Drawing.Size(40, 40)
        Me.pbSilo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSilo1.TabIndex = 52
        Me.pbSilo1.TabStop = False
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(369, 792)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(206, 35)
        Me.Label65.TabIndex = 51
        Me.Label65.Text = "TARGET WEIGHT:"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(368, 731)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(238, 61)
        Me.Label66.TabIndex = 50
        Me.Label66.Text = "CURRENT WEIGHT: "
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormulaNameBatching
        '
        Me.lblFormulaNameBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaNameBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaNameBatching.Location = New System.Drawing.Point(23, 65)
        Me.lblFormulaNameBatching.Name = "lblFormulaNameBatching"
        Me.lblFormulaNameBatching.Size = New System.Drawing.Size(250, 23)
        Me.lblFormulaNameBatching.TabIndex = 49
        Me.lblFormulaNameBatching.Text = "Silo 1"
        Me.lblFormulaNameBatching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(23, 42)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(250, 23)
        Me.Label64.TabIndex = 48
        Me.Label64.Text = "Selected Formula:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentTargetWeightLiquid
        '
        Me.lblCurrentTargetWeightLiquid.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTargetWeightLiquid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTargetWeightLiquid.Location = New System.Drawing.Point(23, 339)
        Me.lblCurrentTargetWeightLiquid.Name = "lblCurrentTargetWeightLiquid"
        Me.lblCurrentTargetWeightLiquid.Size = New System.Drawing.Size(250, 23)
        Me.lblCurrentTargetWeightLiquid.TabIndex = 47
        Me.lblCurrentTargetWeightLiquid.Text = "Silo 1"
        Me.lblCurrentTargetWeightLiquid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(23, 315)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(250, 23)
        Me.Label60.TabIndex = 46
        Me.Label60.Text = "Current Liquid Target Weight:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentPump
        '
        Me.lblCurrentPump.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPump.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPump.Location = New System.Drawing.Point(23, 291)
        Me.lblCurrentPump.Name = "lblCurrentPump"
        Me.lblCurrentPump.Size = New System.Drawing.Size(250, 23)
        Me.lblCurrentPump.TabIndex = 45
        Me.lblCurrentPump.Text = "Silo 1"
        Me.lblCurrentPump.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(23, 267)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(250, 23)
        Me.Label62.TabIndex = 44
        Me.Label62.Text = "Current Pump:"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentTargetWeightDry
        '
        Me.lblCurrentTargetWeightDry.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTargetWeightDry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTargetWeightDry.Location = New System.Drawing.Point(23, 243)
        Me.lblCurrentTargetWeightDry.Name = "lblCurrentTargetWeightDry"
        Me.lblCurrentTargetWeightDry.Size = New System.Drawing.Size(250, 23)
        Me.lblCurrentTargetWeightDry.TabIndex = 43
        Me.lblCurrentTargetWeightDry.Text = "Silo 1"
        Me.lblCurrentTargetWeightDry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(23, 219)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(250, 23)
        Me.Label58.TabIndex = 42
        Me.Label58.Text = "Current Dry Target Weight:"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo
        '
        Me.lblCurrentSilo.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentSilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSilo.Location = New System.Drawing.Point(23, 195)
        Me.lblCurrentSilo.Name = "lblCurrentSilo"
        Me.lblCurrentSilo.Size = New System.Drawing.Size(250, 23)
        Me.lblCurrentSilo.TabIndex = 41
        Me.lblCurrentSilo.Text = "Silo 1"
        Me.lblCurrentSilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(23, 171)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(250, 23)
        Me.Label56.TabIndex = 40
        Me.Label56.Text = "Current Silo:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBatchingStatus
        '
        Me.lblBatchingStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchingStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatchingStatus.Location = New System.Drawing.Point(23, 121)
        Me.lblBatchingStatus.Name = "lblBatchingStatus"
        Me.lblBatchingStatus.Size = New System.Drawing.Size(250, 23)
        Me.lblBatchingStatus.TabIndex = 39
        Me.lblBatchingStatus.Text = "Silo 1"
        Me.lblBatchingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(23, 98)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(250, 23)
        Me.Label48.TabIndex = 38
        Me.Label48.Text = "Batching Status:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTargetWeightDryBatching
        '
        Me.lblTargetWeightDryBatching.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTargetWeightDryBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetWeightDryBatching.Location = New System.Drawing.Point(590, 581)
        Me.lblTargetWeightDryBatching.Name = "lblTargetWeightDryBatching"
        Me.lblTargetWeightDryBatching.Size = New System.Drawing.Size(113, 35)
        Me.lblTargetWeightDryBatching.TabIndex = 33
        Me.lblTargetWeightDryBatching.Text = "2000 KG"
        Me.lblTargetWeightDryBatching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentWeightDryBatching
        '
        Me.lblCurrentWeightDryBatching.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrentWeightDryBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentWeightDryBatching.Location = New System.Drawing.Point(386, 533)
        Me.lblCurrentWeightDryBatching.Name = "lblCurrentWeightDryBatching"
        Me.lblCurrentWeightDryBatching.Size = New System.Drawing.Size(329, 44)
        Me.lblCurrentWeightDryBatching.TabIndex = 32
        Me.lblCurrentWeightDryBatching.Text = "2000 KG"
        Me.lblCurrentWeightDryBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(399, 582)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(207, 35)
        Me.Label52.TabIndex = 37
        Me.Label52.Text = "TARGET WEIGHT:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(386, 503)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(329, 30)
        Me.Label53.TabIndex = 36
        Me.Label53.Text = "CURRENT WEIGHT: "
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTargetWeightLiquidBatching
        '
        Me.lblTargetWeightLiquidBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblTargetWeightLiquidBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetWeightLiquidBatching.Location = New System.Drawing.Point(588, 792)
        Me.lblTargetWeightLiquidBatching.Name = "lblTargetWeightLiquidBatching"
        Me.lblTargetWeightLiquidBatching.Size = New System.Drawing.Size(178, 35)
        Me.lblTargetWeightLiquidBatching.TabIndex = 35
        Me.lblTargetWeightLiquidBatching.Text = "2000 KG"
        Me.lblTargetWeightLiquidBatching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentWeightLiquidBatching
        '
        Me.lblCurrentWeightLiquidBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentWeightLiquidBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentWeightLiquidBatching.Location = New System.Drawing.Point(606, 731)
        Me.lblCurrentWeightLiquidBatching.Name = "lblCurrentWeightLiquidBatching"
        Me.lblCurrentWeightLiquidBatching.Size = New System.Drawing.Size(178, 61)
        Me.lblCurrentWeightLiquidBatching.TabIndex = 34
        Me.lblCurrentWeightLiquidBatching.Text = "2000 KG"
        Me.lblCurrentWeightLiquidBatching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(267, 918)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(132, 23)
        Me.Label34.TabIndex = 31
        Me.Label34.Text = "BOTTOM GATE"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(267, 792)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(132, 23)
        Me.Label33.TabIndex = 30
        Me.Label33.Text = "TOP GATE"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMolassesWeightBatching
        '
        Me.lblMolassesWeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblMolassesWeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMolassesWeightBatching.Location = New System.Drawing.Point(592, 959)
        Me.lblMolassesWeightBatching.Name = "lblMolassesWeightBatching"
        Me.lblMolassesWeightBatching.Size = New System.Drawing.Size(74, 23)
        Me.lblMolassesWeightBatching.TabIndex = 29
        Me.lblMolassesWeightBatching.Text = "100 KG"
        Me.lblMolassesWeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(586, 931)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(92, 23)
        Me.Label32.TabIndex = 28
        Me.Label32.Text = "MOLASSES"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCocoOilWeightBatching
        '
        Me.lblCocoOilWeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblCocoOilWeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCocoOilWeightBatching.Location = New System.Drawing.Point(690, 959)
        Me.lblCocoOilWeightBatching.Name = "lblCocoOilWeightBatching"
        Me.lblCocoOilWeightBatching.Size = New System.Drawing.Size(74, 23)
        Me.lblCocoOilWeightBatching.TabIndex = 27
        Me.lblCocoOilWeightBatching.Text = "100 KG"
        Me.lblCocoOilWeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(690, 931)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 23)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "COCO OIL"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo8WeightBatching
        '
        Me.lblSilo8WeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo8WeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo8WeightBatching.Location = New System.Drawing.Point(676, 330)
        Me.lblSilo8WeightBatching.Name = "lblSilo8WeightBatching"
        Me.lblSilo8WeightBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo8WeightBatching.TabIndex = 25
        Me.lblSilo8WeightBatching.Text = "100 KG"
        Me.lblSilo8WeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo8RawMatsBatching
        '
        Me.lblSilo8RawMatsBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo8RawMatsBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo8RawMatsBatching.Location = New System.Drawing.Point(676, 302)
        Me.lblSilo8RawMatsBatching.Name = "lblSilo8RawMatsBatching"
        Me.lblSilo8RawMatsBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo8RawMatsBatching.TabIndex = 24
        Me.lblSilo8RawMatsBatching.Text = "Silo 1"
        Me.lblSilo8RawMatsBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(676, 274)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(109, 23)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Silo 8"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo7WeightBatching
        '
        Me.lblSilo7WeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo7WeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo7WeightBatching.Location = New System.Drawing.Point(555, 330)
        Me.lblSilo7WeightBatching.Name = "lblSilo7WeightBatching"
        Me.lblSilo7WeightBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo7WeightBatching.TabIndex = 22
        Me.lblSilo7WeightBatching.Text = "100 KG"
        Me.lblSilo7WeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo7RawMatsBatching
        '
        Me.lblSilo7RawMatsBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo7RawMatsBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo7RawMatsBatching.Location = New System.Drawing.Point(555, 302)
        Me.lblSilo7RawMatsBatching.Name = "lblSilo7RawMatsBatching"
        Me.lblSilo7RawMatsBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo7RawMatsBatching.TabIndex = 21
        Me.lblSilo7RawMatsBatching.Text = "Silo 1"
        Me.lblSilo7RawMatsBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(555, 274)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 23)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Silo 7"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo6WeightBatching
        '
        Me.lblSilo6WeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo6WeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo6WeightBatching.Location = New System.Drawing.Point(434, 330)
        Me.lblSilo6WeightBatching.Name = "lblSilo6WeightBatching"
        Me.lblSilo6WeightBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo6WeightBatching.TabIndex = 19
        Me.lblSilo6WeightBatching.Text = "100 KG"
        Me.lblSilo6WeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo6RawMatsBatching
        '
        Me.lblSilo6RawMatsBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo6RawMatsBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo6RawMatsBatching.Location = New System.Drawing.Point(434, 302)
        Me.lblSilo6RawMatsBatching.Name = "lblSilo6RawMatsBatching"
        Me.lblSilo6RawMatsBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo6RawMatsBatching.TabIndex = 18
        Me.lblSilo6RawMatsBatching.Text = "Silo 1"
        Me.lblSilo6RawMatsBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(434, 274)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 23)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Silo 6"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo5WeightBatching
        '
        Me.lblSilo5WeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo5WeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo5WeightBatching.Location = New System.Drawing.Point(313, 330)
        Me.lblSilo5WeightBatching.Name = "lblSilo5WeightBatching"
        Me.lblSilo5WeightBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo5WeightBatching.TabIndex = 16
        Me.lblSilo5WeightBatching.Text = "100 KG"
        Me.lblSilo5WeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo5RawMatsBatching
        '
        Me.lblSilo5RawMatsBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo5RawMatsBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo5RawMatsBatching.Location = New System.Drawing.Point(313, 302)
        Me.lblSilo5RawMatsBatching.Name = "lblSilo5RawMatsBatching"
        Me.lblSilo5RawMatsBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo5RawMatsBatching.TabIndex = 15
        Me.lblSilo5RawMatsBatching.Text = "Silo 1"
        Me.lblSilo5RawMatsBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(313, 274)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 23)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Silo 5"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo4WeightBatching
        '
        Me.lblSilo4WeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo4WeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo4WeightBatching.Location = New System.Drawing.Point(676, 90)
        Me.lblSilo4WeightBatching.Name = "lblSilo4WeightBatching"
        Me.lblSilo4WeightBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo4WeightBatching.TabIndex = 13
        Me.lblSilo4WeightBatching.Text = "100 KG"
        Me.lblSilo4WeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo4RawMatsBatching
        '
        Me.lblSilo4RawMatsBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo4RawMatsBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo4RawMatsBatching.Location = New System.Drawing.Point(676, 62)
        Me.lblSilo4RawMatsBatching.Name = "lblSilo4RawMatsBatching"
        Me.lblSilo4RawMatsBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo4RawMatsBatching.TabIndex = 12
        Me.lblSilo4RawMatsBatching.Text = "Silo 1"
        Me.lblSilo4RawMatsBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(676, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 23)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Silo 4"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo3WeightBatching
        '
        Me.lblSilo3WeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo3WeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo3WeightBatching.Location = New System.Drawing.Point(555, 90)
        Me.lblSilo3WeightBatching.Name = "lblSilo3WeightBatching"
        Me.lblSilo3WeightBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo3WeightBatching.TabIndex = 10
        Me.lblSilo3WeightBatching.Text = "100 KG"
        Me.lblSilo3WeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo3RawMatsBatching
        '
        Me.lblSilo3RawMatsBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo3RawMatsBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo3RawMatsBatching.Location = New System.Drawing.Point(555, 62)
        Me.lblSilo3RawMatsBatching.Name = "lblSilo3RawMatsBatching"
        Me.lblSilo3RawMatsBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo3RawMatsBatching.TabIndex = 9
        Me.lblSilo3RawMatsBatching.Text = "Silo 1"
        Me.lblSilo3RawMatsBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(555, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 23)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Silo 3"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo2WeightBatching
        '
        Me.lblSilo2WeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo2WeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo2WeightBatching.Location = New System.Drawing.Point(434, 90)
        Me.lblSilo2WeightBatching.Name = "lblSilo2WeightBatching"
        Me.lblSilo2WeightBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo2WeightBatching.TabIndex = 7
        Me.lblSilo2WeightBatching.Text = "100 KG"
        Me.lblSilo2WeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo2RawMatsBatching
        '
        Me.lblSilo2RawMatsBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo2RawMatsBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo2RawMatsBatching.Location = New System.Drawing.Point(434, 62)
        Me.lblSilo2RawMatsBatching.Name = "lblSilo2RawMatsBatching"
        Me.lblSilo2RawMatsBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo2RawMatsBatching.TabIndex = 6
        Me.lblSilo2RawMatsBatching.Text = "Silo 1"
        Me.lblSilo2RawMatsBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(434, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Silo 2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo1WeightBatching
        '
        Me.lblSilo1WeightBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo1WeightBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo1WeightBatching.Location = New System.Drawing.Point(313, 90)
        Me.lblSilo1WeightBatching.Name = "lblSilo1WeightBatching"
        Me.lblSilo1WeightBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo1WeightBatching.TabIndex = 4
        Me.lblSilo1WeightBatching.Text = "100 KG"
        Me.lblSilo1WeightBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSilo1RawMatsBatching
        '
        Me.lblSilo1RawMatsBatching.BackColor = System.Drawing.Color.Transparent
        Me.lblSilo1RawMatsBatching.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilo1RawMatsBatching.Location = New System.Drawing.Point(313, 62)
        Me.lblSilo1RawMatsBatching.Name = "lblSilo1RawMatsBatching"
        Me.lblSilo1RawMatsBatching.Size = New System.Drawing.Size(109, 23)
        Me.lblSilo1RawMatsBatching.TabIndex = 3
        Me.lblSilo1RawMatsBatching.Text = "Silo 1"
        Me.lblSilo1RawMatsBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Silo 1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.LIQUID_AND_MIXER
        Me.PictureBox2.Location = New System.Drawing.Point(37, 695)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(761, 350)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.SILOS
        Me.PictureBox1.Location = New System.Drawing.Point(303, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(492, 633)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlFormula
        '
        Me.pnlFormula.Controls.Add(Me.btnExit)
        Me.pnlFormula.Controls.Add(Me.lblFormulaMatSilo8)
        Me.pnlFormula.Controls.Add(Me.lblFormulaMatSilo7)
        Me.pnlFormula.Controls.Add(Me.lblFormulaMatSilo6)
        Me.pnlFormula.Controls.Add(Me.lblFormulaMatSilo5)
        Me.pnlFormula.Controls.Add(Me.lblFormulaMatSilo4)
        Me.pnlFormula.Controls.Add(Me.lblFormulaMatSilo3)
        Me.pnlFormula.Controls.Add(Me.lblFormulaMatSilo2)
        Me.pnlFormula.Controls.Add(Me.lblFormulaMatSilo1)
        Me.pnlFormula.Controls.Add(Me.Label2)
        Me.pnlFormula.Controls.Add(Me.cmbFormula)
        Me.pnlFormula.Controls.Add(Me.lblFormulaId)
        Me.pnlFormula.Controls.Add(Me.Label47)
        Me.pnlFormula.Controls.Add(Me.btnClear)
        Me.pnlFormula.Controls.Add(Me.btnDeleteFormula)
        Me.pnlFormula.Controls.Add(Me.btnEditFormula)
        Me.pnlFormula.Controls.Add(Me.btnAddFormula)
        Me.pnlFormula.Controls.Add(Me.btnRefreshFormula)
        Me.pnlFormula.Controls.Add(Me.Label45)
        Me.pnlFormula.Controls.Add(Me.txtbCocoOilWeight)
        Me.pnlFormula.Controls.Add(Me.Label46)
        Me.pnlFormula.Controls.Add(Me.txtbMolassesWeight)
        Me.pnlFormula.Controls.Add(Me.Label43)
        Me.pnlFormula.Controls.Add(Me.txtbSilo8Weight)
        Me.pnlFormula.Controls.Add(Me.Label44)
        Me.pnlFormula.Controls.Add(Me.txtbSilo7Weight)
        Me.pnlFormula.Controls.Add(Me.Label41)
        Me.pnlFormula.Controls.Add(Me.txtbSilo6Weight)
        Me.pnlFormula.Controls.Add(Me.Label42)
        Me.pnlFormula.Controls.Add(Me.txtbSilo5Weight)
        Me.pnlFormula.Controls.Add(Me.Label39)
        Me.pnlFormula.Controls.Add(Me.txtbSilo4Weight)
        Me.pnlFormula.Controls.Add(Me.Label40)
        Me.pnlFormula.Controls.Add(Me.txtbSilo3Weight)
        Me.pnlFormula.Controls.Add(Me.Label38)
        Me.pnlFormula.Controls.Add(Me.txtbSilo2Weight)
        Me.pnlFormula.Controls.Add(Me.Label37)
        Me.pnlFormula.Controls.Add(Me.txtbSilo1Weight)
        Me.pnlFormula.Controls.Add(Me.Label36)
        Me.pnlFormula.Controls.Add(Me.txtbFormulaName)
        Me.pnlFormula.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFormula.Location = New System.Drawing.Point(1380, 0)
        Me.pnlFormula.Name = "pnlFormula"
        Me.pnlFormula.Size = New System.Drawing.Size(540, 1080)
        Me.pnlFormula.TabIndex = 2
        '
        'lblFormulaMatSilo8
        '
        Me.lblFormulaMatSilo8.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaMatSilo8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaMatSilo8.Location = New System.Drawing.Point(268, 601)
        Me.lblFormulaMatSilo8.Name = "lblFormulaMatSilo8"
        Me.lblFormulaMatSilo8.Size = New System.Drawing.Size(158, 23)
        Me.lblFormulaMatSilo8.TabIndex = 62
        Me.lblFormulaMatSilo8.Text = "Silo 1 Weight:"
        Me.lblFormulaMatSilo8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormulaMatSilo7
        '
        Me.lblFormulaMatSilo7.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaMatSilo7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaMatSilo7.Location = New System.Drawing.Point(37, 601)
        Me.lblFormulaMatSilo7.Name = "lblFormulaMatSilo7"
        Me.lblFormulaMatSilo7.Size = New System.Drawing.Size(158, 23)
        Me.lblFormulaMatSilo7.TabIndex = 61
        Me.lblFormulaMatSilo7.Text = "Silo 1 Weight:"
        Me.lblFormulaMatSilo7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormulaMatSilo6
        '
        Me.lblFormulaMatSilo6.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaMatSilo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaMatSilo6.Location = New System.Drawing.Point(268, 492)
        Me.lblFormulaMatSilo6.Name = "lblFormulaMatSilo6"
        Me.lblFormulaMatSilo6.Size = New System.Drawing.Size(158, 23)
        Me.lblFormulaMatSilo6.TabIndex = 60
        Me.lblFormulaMatSilo6.Text = "Silo 1 Weight:"
        Me.lblFormulaMatSilo6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormulaMatSilo5
        '
        Me.lblFormulaMatSilo5.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaMatSilo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaMatSilo5.Location = New System.Drawing.Point(37, 492)
        Me.lblFormulaMatSilo5.Name = "lblFormulaMatSilo5"
        Me.lblFormulaMatSilo5.Size = New System.Drawing.Size(158, 23)
        Me.lblFormulaMatSilo5.TabIndex = 59
        Me.lblFormulaMatSilo5.Text = "Silo 1 Weight:"
        Me.lblFormulaMatSilo5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormulaMatSilo4
        '
        Me.lblFormulaMatSilo4.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaMatSilo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaMatSilo4.Location = New System.Drawing.Point(268, 383)
        Me.lblFormulaMatSilo4.Name = "lblFormulaMatSilo4"
        Me.lblFormulaMatSilo4.Size = New System.Drawing.Size(158, 23)
        Me.lblFormulaMatSilo4.TabIndex = 58
        Me.lblFormulaMatSilo4.Text = "Silo 1 Weight:"
        Me.lblFormulaMatSilo4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormulaMatSilo3
        '
        Me.lblFormulaMatSilo3.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaMatSilo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaMatSilo3.Location = New System.Drawing.Point(37, 383)
        Me.lblFormulaMatSilo3.Name = "lblFormulaMatSilo3"
        Me.lblFormulaMatSilo3.Size = New System.Drawing.Size(158, 23)
        Me.lblFormulaMatSilo3.TabIndex = 57
        Me.lblFormulaMatSilo3.Text = "Silo 1 Weight:"
        Me.lblFormulaMatSilo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormulaMatSilo2
        '
        Me.lblFormulaMatSilo2.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaMatSilo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaMatSilo2.Location = New System.Drawing.Point(268, 274)
        Me.lblFormulaMatSilo2.Name = "lblFormulaMatSilo2"
        Me.lblFormulaMatSilo2.Size = New System.Drawing.Size(158, 23)
        Me.lblFormulaMatSilo2.TabIndex = 56
        Me.lblFormulaMatSilo2.Text = "Silo 1 Weight:"
        Me.lblFormulaMatSilo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormulaMatSilo1
        '
        Me.lblFormulaMatSilo1.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaMatSilo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaMatSilo1.Location = New System.Drawing.Point(37, 274)
        Me.lblFormulaMatSilo1.Name = "lblFormulaMatSilo1"
        Me.lblFormulaMatSilo1.Size = New System.Drawing.Size(158, 23)
        Me.lblFormulaMatSilo1.TabIndex = 55
        Me.lblFormulaMatSilo1.Text = "Silo 1 Weight:"
        Me.lblFormulaMatSilo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 41)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Select Formula :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbFormula
        '
        Me.cmbFormula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormula.FormattingEnabled = True
        Me.cmbFormula.Location = New System.Drawing.Point(37, 101)
        Me.cmbFormula.MaxDropDownItems = 10
        Me.cmbFormula.Name = "cmbFormula"
        Me.cmbFormula.Size = New System.Drawing.Size(326, 33)
        Me.cmbFormula.TabIndex = 53
        '
        'lblFormulaId
        '
        Me.lblFormulaId.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaId.Location = New System.Drawing.Point(327, 189)
        Me.lblFormulaId.Name = "lblFormulaId"
        Me.lblFormulaId.Size = New System.Drawing.Size(77, 23)
        Me.lblFormulaId.TabIndex = 52
        Me.lblFormulaId.Text = "000"
        Me.lblFormulaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(284, 189)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(37, 23)
        Me.Label47.TabIndex = 51
        Me.Label47.Text = "ID:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SeaGreen
        Me.btnClear.color = System.Drawing.Color.SeaGreen
        Me.btnClear.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.CLEAR
        Me.btnClear.ImagePosition = 10
        Me.btnClear.ImageZoom = 15
        Me.btnClear.LabelPosition = 41
        Me.btnClear.LabelText = "CLEAR"
        Me.btnClear.Location = New System.Drawing.Point(184, 965)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(122, 80)
        Me.btnClear.TabIndex = 50
        '
        'btnDeleteFormula
        '
        Me.btnDeleteFormula.BackColor = System.Drawing.Color.Red
        Me.btnDeleteFormula.color = System.Drawing.Color.Red
        Me.btnDeleteFormula.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnDeleteFormula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnDeleteFormula.ForeColor = System.Drawing.Color.White
        Me.btnDeleteFormula.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.DELETE
        Me.btnDeleteFormula.ImagePosition = 20
        Me.btnDeleteFormula.ImageZoom = 25
        Me.btnDeleteFormula.LabelPosition = 41
        Me.btnDeleteFormula.LabelText = "DELETE"
        Me.btnDeleteFormula.Location = New System.Drawing.Point(318, 829)
        Me.btnDeleteFormula.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDeleteFormula.Name = "btnDeleteFormula"
        Me.btnDeleteFormula.Size = New System.Drawing.Size(122, 112)
        Me.btnDeleteFormula.TabIndex = 49
        '
        'btnEditFormula
        '
        Me.btnEditFormula.BackColor = System.Drawing.Color.SeaGreen
        Me.btnEditFormula.color = System.Drawing.Color.SeaGreen
        Me.btnEditFormula.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnEditFormula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnEditFormula.ForeColor = System.Drawing.Color.White
        Me.btnEditFormula.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.EDIT
        Me.btnEditFormula.ImagePosition = 20
        Me.btnEditFormula.ImageZoom = 25
        Me.btnEditFormula.LabelPosition = 41
        Me.btnEditFormula.LabelText = "EDIT"
        Me.btnEditFormula.Location = New System.Drawing.Point(184, 829)
        Me.btnEditFormula.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEditFormula.Name = "btnEditFormula"
        Me.btnEditFormula.Size = New System.Drawing.Size(122, 112)
        Me.btnEditFormula.TabIndex = 48
        '
        'btnAddFormula
        '
        Me.btnAddFormula.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAddFormula.color = System.Drawing.Color.SeaGreen
        Me.btnAddFormula.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnAddFormula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnAddFormula.ForeColor = System.Drawing.Color.White
        Me.btnAddFormula.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.SAVE
        Me.btnAddFormula.ImagePosition = 20
        Me.btnAddFormula.ImageZoom = 25
        Me.btnAddFormula.LabelPosition = 41
        Me.btnAddFormula.LabelText = "ADD"
        Me.btnAddFormula.Location = New System.Drawing.Point(41, 829)
        Me.btnAddFormula.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAddFormula.Name = "btnAddFormula"
        Me.btnAddFormula.Size = New System.Drawing.Size(122, 112)
        Me.btnAddFormula.TabIndex = 47
        '
        'btnRefreshFormula
        '
        Me.btnRefreshFormula.BackColor = System.Drawing.Color.SeaGreen
        Me.btnRefreshFormula.color = System.Drawing.Color.SeaGreen
        Me.btnRefreshFormula.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnRefreshFormula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnRefreshFormula.ForeColor = System.Drawing.Color.White
        Me.btnRefreshFormula.Image = Global.MIGS_Feed_Batching_System.My.Resources.Resources.REFRESH
        Me.btnRefreshFormula.ImagePosition = 10
        Me.btnRefreshFormula.ImageZoom = 15
        Me.btnRefreshFormula.LabelPosition = 41
        Me.btnRefreshFormula.LabelText = "REFRESH"
        Me.btnRefreshFormula.Location = New System.Drawing.Point(381, 42)
        Me.btnRefreshFormula.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRefreshFormula.Name = "btnRefreshFormula"
        Me.btnRefreshFormula.Size = New System.Drawing.Size(144, 80)
        Me.btnRefreshFormula.TabIndex = 46
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(268, 707)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(158, 23)
        Me.Label45.TabIndex = 44
        Me.Label45.Text = "Coco Oil:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbCocoOilWeight
        '
        Me.txtbCocoOilWeight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbCocoOilWeight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbCocoOilWeight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbCocoOilWeight.BorderThickness = 3
        Me.txtbCocoOilWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbCocoOilWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbCocoOilWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbCocoOilWeight.isPassword = False
        Me.txtbCocoOilWeight.Location = New System.Drawing.Point(268, 738)
        Me.txtbCocoOilWeight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbCocoOilWeight.Name = "txtbCocoOilWeight"
        Me.txtbCocoOilWeight.Size = New System.Drawing.Size(158, 60)
        Me.txtbCocoOilWeight.TabIndex = 43
        Me.txtbCocoOilWeight.Text = "0"
        Me.txtbCocoOilWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(37, 707)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(158, 23)
        Me.Label46.TabIndex = 42
        Me.Label46.Text = "Molasses Weight:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbMolassesWeight
        '
        Me.txtbMolassesWeight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbMolassesWeight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbMolassesWeight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbMolassesWeight.BorderThickness = 3
        Me.txtbMolassesWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbMolassesWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbMolassesWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbMolassesWeight.isPassword = False
        Me.txtbMolassesWeight.Location = New System.Drawing.Point(37, 738)
        Me.txtbMolassesWeight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbMolassesWeight.Name = "txtbMolassesWeight"
        Me.txtbMolassesWeight.Size = New System.Drawing.Size(158, 60)
        Me.txtbMolassesWeight.TabIndex = 41
        Me.txtbMolassesWeight.Text = "0"
        Me.txtbMolassesWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(268, 577)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(158, 23)
        Me.Label43.TabIndex = 40
        Me.Label43.Text = "Silo 8 Weight:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbSilo8Weight
        '
        Me.txtbSilo8Weight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbSilo8Weight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo8Weight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbSilo8Weight.BorderThickness = 3
        Me.txtbSilo8Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSilo8Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSilo8Weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo8Weight.isPassword = False
        Me.txtbSilo8Weight.Location = New System.Drawing.Point(268, 625)
        Me.txtbSilo8Weight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbSilo8Weight.Name = "txtbSilo8Weight"
        Me.txtbSilo8Weight.Size = New System.Drawing.Size(158, 60)
        Me.txtbSilo8Weight.TabIndex = 39
        Me.txtbSilo8Weight.Text = "0"
        Me.txtbSilo8Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(37, 577)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(158, 23)
        Me.Label44.TabIndex = 38
        Me.Label44.Text = "Silo 7 Weight:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbSilo7Weight
        '
        Me.txtbSilo7Weight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbSilo7Weight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo7Weight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbSilo7Weight.BorderThickness = 3
        Me.txtbSilo7Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSilo7Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSilo7Weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo7Weight.isPassword = False
        Me.txtbSilo7Weight.Location = New System.Drawing.Point(37, 625)
        Me.txtbSilo7Weight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbSilo7Weight.Name = "txtbSilo7Weight"
        Me.txtbSilo7Weight.Size = New System.Drawing.Size(158, 60)
        Me.txtbSilo7Weight.TabIndex = 37
        Me.txtbSilo7Weight.Text = "0"
        Me.txtbSilo7Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(268, 468)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(158, 23)
        Me.Label41.TabIndex = 36
        Me.Label41.Text = "Silo 6 Weight:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbSilo6Weight
        '
        Me.txtbSilo6Weight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbSilo6Weight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo6Weight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbSilo6Weight.BorderThickness = 3
        Me.txtbSilo6Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSilo6Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSilo6Weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo6Weight.isPassword = False
        Me.txtbSilo6Weight.Location = New System.Drawing.Point(268, 516)
        Me.txtbSilo6Weight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbSilo6Weight.Name = "txtbSilo6Weight"
        Me.txtbSilo6Weight.Size = New System.Drawing.Size(158, 60)
        Me.txtbSilo6Weight.TabIndex = 35
        Me.txtbSilo6Weight.Text = "0"
        Me.txtbSilo6Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(37, 468)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(158, 23)
        Me.Label42.TabIndex = 34
        Me.Label42.Text = "Silo 5 Weight:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbSilo5Weight
        '
        Me.txtbSilo5Weight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbSilo5Weight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo5Weight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbSilo5Weight.BorderThickness = 3
        Me.txtbSilo5Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSilo5Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSilo5Weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo5Weight.isPassword = False
        Me.txtbSilo5Weight.Location = New System.Drawing.Point(37, 516)
        Me.txtbSilo5Weight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbSilo5Weight.Name = "txtbSilo5Weight"
        Me.txtbSilo5Weight.Size = New System.Drawing.Size(158, 60)
        Me.txtbSilo5Weight.TabIndex = 33
        Me.txtbSilo5Weight.Text = "0"
        Me.txtbSilo5Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(268, 359)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(158, 23)
        Me.Label39.TabIndex = 32
        Me.Label39.Text = "Silo 4 Weight:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbSilo4Weight
        '
        Me.txtbSilo4Weight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbSilo4Weight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo4Weight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbSilo4Weight.BorderThickness = 3
        Me.txtbSilo4Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSilo4Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSilo4Weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo4Weight.isPassword = False
        Me.txtbSilo4Weight.Location = New System.Drawing.Point(268, 407)
        Me.txtbSilo4Weight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbSilo4Weight.Name = "txtbSilo4Weight"
        Me.txtbSilo4Weight.Size = New System.Drawing.Size(158, 60)
        Me.txtbSilo4Weight.TabIndex = 31
        Me.txtbSilo4Weight.Text = "0"
        Me.txtbSilo4Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(37, 359)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(158, 23)
        Me.Label40.TabIndex = 30
        Me.Label40.Text = "Silo 3 Weight:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbSilo3Weight
        '
        Me.txtbSilo3Weight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbSilo3Weight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo3Weight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbSilo3Weight.BorderThickness = 3
        Me.txtbSilo3Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSilo3Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSilo3Weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo3Weight.isPassword = False
        Me.txtbSilo3Weight.Location = New System.Drawing.Point(37, 407)
        Me.txtbSilo3Weight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbSilo3Weight.Name = "txtbSilo3Weight"
        Me.txtbSilo3Weight.Size = New System.Drawing.Size(158, 60)
        Me.txtbSilo3Weight.TabIndex = 29
        Me.txtbSilo3Weight.Text = "0"
        Me.txtbSilo3Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(268, 250)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(158, 23)
        Me.Label38.TabIndex = 28
        Me.Label38.Text = "Silo 2 Weight:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbSilo2Weight
        '
        Me.txtbSilo2Weight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbSilo2Weight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo2Weight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbSilo2Weight.BorderThickness = 3
        Me.txtbSilo2Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSilo2Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSilo2Weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo2Weight.isPassword = False
        Me.txtbSilo2Weight.Location = New System.Drawing.Point(268, 298)
        Me.txtbSilo2Weight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbSilo2Weight.Name = "txtbSilo2Weight"
        Me.txtbSilo2Weight.Size = New System.Drawing.Size(158, 60)
        Me.txtbSilo2Weight.TabIndex = 27
        Me.txtbSilo2Weight.Text = "0"
        Me.txtbSilo2Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(37, 250)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(158, 23)
        Me.Label37.TabIndex = 26
        Me.Label37.Text = "Silo 1 Weight:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbSilo1Weight
        '
        Me.txtbSilo1Weight.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbSilo1Weight.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo1Weight.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbSilo1Weight.BorderThickness = 3
        Me.txtbSilo1Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSilo1Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSilo1Weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbSilo1Weight.isPassword = False
        Me.txtbSilo1Weight.Location = New System.Drawing.Point(37, 298)
        Me.txtbSilo1Weight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbSilo1Weight.Name = "txtbSilo1Weight"
        Me.txtbSilo1Weight.Size = New System.Drawing.Size(158, 60)
        Me.txtbSilo1Weight.TabIndex = 25
        Me.txtbSilo1Weight.Text = "0"
        Me.txtbSilo1Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(37, 140)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(230, 23)
        Me.Label36.TabIndex = 24
        Me.Label36.Text = "Formula Name:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbFormulaName
        '
        Me.txtbFormulaName.BorderColorFocused = System.Drawing.Color.ForestGreen
        Me.txtbFormulaName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbFormulaName.BorderColorMouseHover = System.Drawing.Color.LimeGreen
        Me.txtbFormulaName.BorderThickness = 3
        Me.txtbFormulaName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbFormulaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormulaName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbFormulaName.isPassword = False
        Me.txtbFormulaName.Location = New System.Drawing.Point(37, 171)
        Me.txtbFormulaName.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtbFormulaName.Name = "txtbFormulaName"
        Me.txtbFormulaName.Size = New System.Drawing.Size(230, 60)
        Me.txtbFormulaName.TabIndex = 16
        Me.txtbFormulaName.Text = "Enter Formula Name"
        Me.txtbFormulaName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tmrUiUpdate
        '
        '
        'tmrSpray
        '
        '
        'tmrMixer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.pnlFormula)
        Me.Controls.Add(Me.pnlDiagram)
        Me.Controls.Add(Me.pnlBatching)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlBatching.ResumeLayout(False)
        Me.pnlDiagram.ResumeLayout(False)
        Me.pnlDiagram.PerformLayout()
        CType(Me.pbLiquidGate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCocoOil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMolasses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSprayPump, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBottomGate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTopGate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBatchGate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFormula.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrPLC As Timer
    Friend WithEvents tmrDryScale As Timer
    Friend WithEvents tmrLiquidScale As Timer
    Friend WithEvents srlPLC As IO.Ports.SerialPort
    Friend WithEvents srlDryScale As IO.Ports.SerialPort
    Friend WithEvents srlLiquidScale As IO.Ports.SerialPort
    Friend WithEvents pnlBatching As Panel
    Friend WithEvents pnlDiagram As Panel
    Friend WithEvents pnlFormula As Panel
    Friend WithEvents btnStartStopBatching As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnRefreshFormulaBatching As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSprayPump As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnBottomGate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnMixerTimer As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnTopGate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDischarge As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblTimerSprayRemain As Label
    Friend WithEvents lblTimeMixerRemain As Label
    Friend WithEvents txtbTimerSpray As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtBTimeMixer As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSilo8WeightBatching As Label
    Friend WithEvents lblSilo8RawMatsBatching As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblSilo7WeightBatching As Label
    Friend WithEvents lblSilo7RawMatsBatching As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblSilo6WeightBatching As Label
    Friend WithEvents lblSilo6RawMatsBatching As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblSilo5WeightBatching As Label
    Friend WithEvents lblSilo5RawMatsBatching As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblSilo4WeightBatching As Label
    Friend WithEvents lblSilo4RawMatsBatching As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblSilo3WeightBatching As Label
    Friend WithEvents lblSilo3RawMatsBatching As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblSilo2WeightBatching As Label
    Friend WithEvents lblSilo2RawMatsBatching As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSilo1WeightBatching As Label
    Friend WithEvents lblSilo1RawMatsBatching As Label
    Friend WithEvents lblCurrentWeightDryBatching As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lblMolassesWeightBatching As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lblCocoOilWeightBatching As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents txtbFormulaName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnAddFormula As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnRefreshFormula As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label45 As Label
    Friend WithEvents txtbCocoOilWeight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtbMolassesWeight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtbSilo8Weight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label44 As Label
    Friend WithEvents txtbSilo7Weight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label41 As Label
    Friend WithEvents txtbSilo6Weight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtbSilo5Weight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtbSilo4Weight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label40 As Label
    Friend WithEvents txtbSilo3Weight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtbSilo2Weight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtbSilo1Weight As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblFormulaId As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDeleteFormula As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnEditFormula As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents lblTargetWeightLiquidBatching As Label
    Friend WithEvents lblCurrentWeightLiquidBatching As Label
    Friend WithEvents lblTargetWeightDryBatching As Label
    Friend WithEvents lblCurrentTargetWeightLiquid As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents lblCurrentPump As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents lblCurrentTargetWeightDry As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents lblCurrentSilo As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents lblBatchingStatus As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents lblFormulaNameBatching As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents tmrUiUpdate As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tmrSpray As Timer
    Friend WithEvents tmrMixer As Timer
    Friend WithEvents cmbFormulaBatching As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbFormula As ComboBox
    Friend WithEvents pbSilo1 As PictureBox
    Friend WithEvents pbSilo8 As PictureBox
    Friend WithEvents pbSilo7 As PictureBox
    Friend WithEvents pbSilo6 As PictureBox
    Friend WithEvents pbSilo5 As PictureBox
    Friend WithEvents pbSilo4 As PictureBox
    Friend WithEvents pbSilo3 As PictureBox
    Friend WithEvents pbSilo2 As PictureBox
    Friend WithEvents pbLiquidGate As PictureBox
    Friend WithEvents pbCocoOil As PictureBox
    Friend WithEvents pbMolasses As PictureBox
    Friend WithEvents pbSprayPump As PictureBox
    Friend WithEvents pbBottomGate As PictureBox
    Friend WithEvents pbTopGate As PictureBox
    Friend WithEvents pbBatchGate As PictureBox
    Friend WithEvents lblFormulaMatSilo8 As Label
    Friend WithEvents lblFormulaMatSilo7 As Label
    Friend WithEvents lblFormulaMatSilo6 As Label
    Friend WithEvents lblFormulaMatSilo5 As Label
    Friend WithEvents lblFormulaMatSilo4 As Label
    Friend WithEvents lblFormulaMatSilo3 As Label
    Friend WithEvents lblFormulaMatSilo2 As Label
    Friend WithEvents lblFormulaMatSilo1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuFlatButton
End Class
