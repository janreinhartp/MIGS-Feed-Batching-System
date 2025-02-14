Imports System.IO.Ports

Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableComPorts()
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        txtbComPortPLC.Text = My.Settings.ComPortPLC
        txtbComPortDryScale.Text = My.Settings.ComPortDryScale
        txtbComPortLiquidScale.Text = My.Settings.ComportLiquidScale
        txtbIngredientSilo1.Text = My.Settings.Silo1Material
        txtbIngredientSilo2.Text = My.Settings.Silo2Material
        txtbIngredientSilo3.Text = My.Settings.Silo3Material
        txtbIngredientSilo4.Text = My.Settings.Silo4Material
        txtbIngredientSilo5.Text = My.Settings.Silo5Material
        txtbIngredientSilo6.Text = My.Settings.Silo6Material
        txtbIngredientSilo7.Text = My.Settings.Silo7Material
        txtbIngredientSilo8.Text = My.Settings.Silo8Material

        txtbWeighAdjustmentSilo1.Text = My.Settings.AdjustmentSilo1
        txtbWeighAdjustmentSilo2.Text = My.Settings.AdjustmentSilo2
        txtbWeighAdjustmentSilo3.Text = My.Settings.AdjustmentSilo3
        txtbWeighAdjustmentSilo4.Text = My.Settings.AdjustmentSilo4
        txtbWeighAdjustmentSilo5.Text = My.Settings.AdjustmentSilo5
        txtbWeighAdjustmentSilo6.Text = My.Settings.AdjustmentSilo6
        txtbWeighAdjustmentSilo7.Text = My.Settings.AdjustmentSilo7
        txtbWeighAdjustmentSilo8.Text = My.Settings.AdjustmentSilo8

        txtbWeighAdjustmentCocoOil.Text = My.Settings.AdjustmentCocoOil
        txtbWeighAdjustmentMolasses.Text = My.Settings.AdjustmentMolasses

    End Sub

    Private Sub LoadAvailableComPorts()
        ListBox1.Items.Clear()
        Dim ports As String() = SerialPort.GetPortNames()
        ListBox1.Items.AddRange(ports)
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.ComPortPLC = txtbComPortPLC.Text
        My.Settings.ComPortDryScale = txtbComPortDryScale.Text
        My.Settings.ComportLiquidScale = txtbComPortLiquidScale.Text
        My.Settings.Silo1Material = txtbIngredientSilo1.Text
        My.Settings.Silo2Material = txtbIngredientSilo2.Text
        My.Settings.Silo3Material = txtbIngredientSilo3.Text
        My.Settings.Silo4Material = txtbIngredientSilo4.Text
        My.Settings.Silo5Material = txtbIngredientSilo5.Text
        My.Settings.Silo6Material = txtbIngredientSilo6.Text
        My.Settings.Silo7Material = txtbIngredientSilo7.Text
        My.Settings.Silo8Material = txtbIngredientSilo8.Text

        My.Settings.AdjustmentSilo1 = txtbWeighAdjustmentSilo1.Text
        My.Settings.AdjustmentSilo2 = txtbWeighAdjustmentSilo2.Text
        My.Settings.AdjustmentSilo3 = txtbWeighAdjustmentSilo3.Text
        My.Settings.AdjustmentSilo4 = txtbWeighAdjustmentSilo4.Text
        My.Settings.AdjustmentSilo5 = txtbWeighAdjustmentSilo5.Text
        My.Settings.AdjustmentSilo6 = txtbWeighAdjustmentSilo6.Text
        My.Settings.AdjustmentSilo7 = txtbWeighAdjustmentSilo7.Text
        My.Settings.AdjustmentSilo8 = txtbWeighAdjustmentSilo8.Text

        My.Settings.AdjustmentCocoOil = txtbWeighAdjustmentCocoOil.Text
        My.Settings.AdjustmentMolasses = txtbWeighAdjustmentMolasses.Text

        My.Settings.Save()

        Application.Restart()
    End Sub
End Class