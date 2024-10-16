Imports System.Text.RegularExpressions

Module Validation
    Sub Main()
        Dim f As New Form1
        f.ShowDialog()
    End Sub

    Public Sub AssignValidation(ByRef CTRL As Bunifu.Framework.UI.BunifuMetroTextbox, ByVal Validation_Type As Integer)
        Dim txt As Bunifu.Framework.UI.BunifuMetroTextbox = CTRL
        Select Case Validation_Type
            Case 1
                AddHandler txt.KeyPress, AddressOf number_Leave
            Case 2
                AddHandler txt.KeyPress, AddressOf OCHAR_Leave
            Case 3
                AddHandler txt.Leave, AddressOf NotNull_Leave
            Case 4
                AddHandler txt.Leave, AddressOf Email_Leave
            Case 5
                AddHandler txt.KeyPress, AddressOf Phonenumber_Leave
        End Select
    End Sub
    Public Sub number_Leave(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim numbers As Bunifu.Framework.UI.BunifuMetroTextbox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub
    Public Sub Phonenumber_Leave(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim numbers As Bunifu.Framework.UI.BunifuMetroTextbox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub
    Public Sub OCHAR_Leave(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr("1234567890!@#$%^&*()_+=-", e.KeyChar) > 0 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub
    Public Sub NotNull_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim No As Bunifu.Framework.UI.BunifuMetroTextbox = sender
        If No.Text.Trim = "" Then
            MsgBox("This field Must be filled!")
            No.Focus()
        End If
    End Sub
    Public Sub Email_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Email As Bunifu.Framework.UI.BunifuMetroTextbox = sender
        If Email.Text <> "" Then
            Dim rex As Match = Regex.Match(Trim(Email.Text), "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                MessageBox.Show("Please Enter a valid Email Address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Email.BackColor = Color.Red
                Email.Focus()
                Exit Sub
            Else
                Email.BackColor = Color.White
            End If
        End If
    End Sub
End Module
