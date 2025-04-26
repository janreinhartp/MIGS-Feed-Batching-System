Imports System.Threading
Imports System.Threading.Tasks
Imports System.UI.Widget

Module Batching
    Public DryMatsBatch As Task
    Public LiquidMatsBatch As Task

    Public statusDry As Integer
    Public statusWet As Integer

    Public currentFormula As formula

    Public dryCancellationTokenSource As CancellationTokenSource
    Public liquidCancellationTokenSource As CancellationTokenSource

    Public Async Function DryMatsBatchingAsync(token As CancellationToken) As Task
        While Not token.IsCancellationRequested
            Select Case statusDry
                Case 1
                    Form1.commandPLC(0) = 1

                    Do
                        If Form1.binCurrentLoadDry >= Form1.currentTargetWeightDry - My.Settings.AdjustmentSilo1 AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop

                    Form1.commandPLC(0) = 0
                    Await Task.Delay(1000) ' Simulate delay for next step
                    Form1.currentTargetWeightDry += CDbl(Form1.currentFormulaBatching.Silo2)

                    Form1.lblCurrentSilo.Text = "Silo2"
                    Form1.lblCurrentTargetWeightDry.Text = Form1.currentTargetWeightDry
                    statusDry = 2

                Case 2
                    Form1.commandPLC(1) = 1
                    Do
                        If Form1.binCurrentLoadDry >= Form1.currentTargetWeightDry - My.Settings.AdjustmentSilo2 AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(1) = 0
                    Await Task.Delay(1000) ' Simulate delay for next step
                    Form1.currentTargetWeightDry += CDbl(Form1.currentFormulaBatching.Silo3)
                    Form1.lblCurrentSilo.Text = "Silo3"
                    Form1.lblCurrentTargetWeightDry.Text = Form1.currentTargetWeightDry
                    statusDry = 3

                Case 3
                    Form1.commandPLC(2) = 1
                    Do
                        If Form1.binCurrentLoadDry >= Form1.currentTargetWeightDry - My.Settings.AdjustmentSilo3 AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(2) = 0
                    Await Task.Delay(1000) ' Simulate delay for next step
                    Form1.currentTargetWeightDry += CDbl(Form1.currentFormulaBatching.Silo4)
                    Form1.lblCurrentSilo.Text = "Silo4"
                    Form1.lblCurrentTargetWeightDry.Text = Form1.currentTargetWeightDry
                    statusDry = 4
                Case 4
                    Form1.commandPLC(3) = 1
                    Do
                        If Form1.binCurrentLoadDry >= Form1.currentTargetWeightDry - My.Settings.AdjustmentSilo4 AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(3) = 0
                    Await Task.Delay(1000) ' Simulate delay for next step
                    Form1.currentTargetWeightDry += CDbl(Form1.currentFormulaBatching.Silo5)
                    Form1.lblCurrentSilo.Text = "Silo5"
                    Form1.lblCurrentTargetWeightDry.Text = Form1.currentTargetWeightDry
                    statusDry = 5

                Case 5
                    Form1.commandPLC(4) = 1
                    Do
                        If Form1.binCurrentLoadDry >= Form1.currentTargetWeightDry - My.Settings.AdjustmentSilo5 AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(4) = 0
                    Await Task.Delay(1000) ' Simulate delay for next step
                    Form1.currentTargetWeightDry += CDbl(Form1.currentFormulaBatching.Silo6)
                    Form1.lblCurrentSilo.Text = "Silo6"
                    Form1.lblCurrentTargetWeightDry.Text = Form1.currentTargetWeightDry
                    statusDry = 6

                Case 6
                    Form1.commandPLC(5) = 1
                    Do
                        If Form1.binCurrentLoadDry >= Form1.currentTargetWeightDry - My.Settings.AdjustmentSilo6 AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(5) = 0
                    Await Task.Delay(1000) ' Simulate delay for next step
                    Form1.currentTargetWeightDry += CDbl(Form1.currentFormulaBatching.Silo7)
                    Form1.lblCurrentSilo.Text = "Silo7"
                    Form1.lblCurrentTargetWeightDry.Text = Form1.currentTargetWeightDry
                    statusDry = 7

                Case 7
                    Form1.commandPLC(6) = 1
                    Do
                        If Form1.binCurrentLoadDry >= Form1.currentTargetWeightDry - My.Settings.AdjustmentSilo7 AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(6) = 0
                    Await Task.Delay(1000) ' Simulate delay for next step
                    Form1.currentTargetWeightDry += CDbl(Form1.currentFormulaBatching.Silo8)
                    Form1.lblCurrentSilo.Text = "Silo8"
                    Form1.lblCurrentTargetWeightDry.Text = Form1.currentTargetWeightDry
                    statusDry = 8
                Case 8
                    Form1.commandPLC(7) = 1
                    Do
                        If Form1.binCurrentLoadDry >= Form1.currentTargetWeightDry - My.Settings.AdjustmentSilo8 AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(7) = 0
                    Await Task.Delay(1000)
                    statusDry = 0
                    'Form1.CallToast("Auto Batching", "Dry batching finished!")
                    Exit While

                Case Else
                    'Form1.CallToast("Auto Batching", "Dry batching finished!")
                    Exit While
            End Select
        End While
    End Function

    Public Async Function LiquidMatsBatchingAsync(token As CancellationToken) As Task
        While Not token.IsCancellationRequested
            Select Case statusWet
                Case 1
                    Form1.commandPLC(9) = 1
                    Do
                        If Form1.binCurrentLoadWet >= Form1.currentTargetWeightWet - My.Settings.AdjustmentCocoOil AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(9) = 0
                    Await Task.Delay(1000)
                    Form1.currentTargetWeightWet += CDbl(Form1.currentFormulaBatching.CocoOil)
                    Form1.lblCurrentPump.Text = "Molasses"
                    Form1.lblCurrentTargetWeightLiquid.Text = Form1.currentTargetWeightWet
                    statusWet = 2

                Case 2
                    Form1.commandPLC(8) = 1
                    Do
                        If Form1.binCurrentLoadWet >= Form1.currentTargetWeightWet - My.Settings.AdjustmentMolasses AndAlso Not token.IsCancellationRequested Then
                            Exit Do
                        Else
                            Await Task.Delay(100) ' Check every 100ms
                        End If
                    Loop
                    Form1.commandPLC(8) = 0
                    Await Task.Delay(1000)
                    statusWet = 0
                    'Form1.CallToast("Auto Batching", "Liquid batching finished!")
                    Exit While

                Case Else
                    'Form1.CallToast("Auto Batching", "Liquid batching finished!")
                    Exit While
            End Select
        End While
    End Function
End Module
