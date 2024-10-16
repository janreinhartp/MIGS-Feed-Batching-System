Module CRUD

    Public Sub AddFormula(ByRef formula As formula)
        connect()
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = String.Format("INSERT INTO tblformula (formula_id,formula_name,
                                        formula_silo1,
                                        formula_silo2,
                                        formula_silo3,
                                        formula_silo4,
                                        formula_silo5,
                                        formula_silo6,
                                        formula_silo7,
                                        formula_silo8,
                                        formula_molasses,
                                        formula_coco_oil) 
                                        VALUES ( '" & formula.Id & "',
                                        '" & formula.FormulaName & "',
                                        '" & formula.Silo1 & "',
                                        '" & formula.Silo2 & "',
                                        '" & formula.Silo3 & "',
                                        '" & formula.Silo4 & "',
                                        '" & formula.Silo5 & "',
                                        '" & formula.Silo6 & "',
                                        '" & formula.Silo7 & "',
                                        '" & formula.Silo8 & "',
                                        '" & formula.Molasses & "',
                                        '" & formula.CocoOil & "')")

        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Function checkFormulaName(ByRef name As String) As Boolean
        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblformula WHERE formula_name='" & name & "'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Close()
            conn.Close()
            Return True
        Else
            Return False
            dr.Close()
            conn.Close()
        End If
    End Function


    Public Sub UpdateFormula(ByRef formula As formula)
        connect()

        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = String.Format("UPDATE tblformula SET formula_name='" & formula.FormulaName & "',
                                        formula_silo1='" & formula.Silo1 & "',
                                        formula_silo2='" & formula.Silo2 & "',
                                        formula_silo3='" & formula.Silo3 & "',
                                        formula_silo4='" & formula.Silo4 & "',
                                        formula_silo5='" & formula.Silo5 & "',
                                        formula_silo6='" & formula.Silo6 & "',
                                        formula_silo7='" & formula.Silo7 & "',
                                        formula_silo8='" & formula.Silo8 & "',
                                        formula_molasses='" & formula.Molasses & "',
                                        formula_coco_oil='" & formula.CocoOil & "'
                                        WHERE formula_id='" & formula.Id & "'")

        Dim affectedRows As Integer = cmd.ExecuteNonQuery

        If affectedRows > 0 Then
            'SuccessNotify("Modify", "Successfully modified Formula" & vbNewLine & "Formula Name: " + formula.FormulaName)
        Else
            'ErrorNotify("Modify", "Failed to modify Formula." & vbNewLine & "Formula Name: " + formula.FormulaName)
        End If

        conn.Close()
    End Sub
    Public Sub DeleteFormula(ByRef formula As formula)
        If MsgBox("Are you sure do you want to delete " + formula.FormulaName + "?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            connect()
            conn.Open()

            cmd = conn.CreateCommand

            cmd.CommandText = String.Format("DELETE FROM tblformula WHERE formula_id= '" & formula.Id & "' ")

            Dim affectedRows As Integer = cmd.ExecuteNonQuery

            If affectedRows > 0 Then
                MsgBox("Successfully deleted!")
            Else
                MsgBox("Failed to delete!")
            End If

            conn.Close()
        End If
    End Sub
    Public Sub GetFormulaById(ByRef id As Integer)

    End Sub

    Function GetFormulas() As List(Of formula)
        Dim formulas As New List(Of formula)

        connect()
        conn.Open()
        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblformula"

        dr = cmd.ExecuteReader()


        While dr.Read()
            formulas.Add(New formula(dr("formula_id"), dr("formula_name"), dr("formula_silo1"), dr("formula_silo2"), dr("formula_silo3"), dr("formula_silo4"), dr("formula_silo5"), dr("formula_silo6"), dr("formula_silo7"), dr("formula_silo8"), dr("formula_molasses"), dr("formula_coco_oil")))
        End While

        dr.Close()
        conn.Close()

        Return formulas
    End Function

End Module
