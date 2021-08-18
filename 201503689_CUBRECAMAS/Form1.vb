Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        total_yardas = Val(Txt_lino.Text) + Val(Txt_algodon.Text) + Val(Txt_seda.Text) + Val(Txt_Hiloc.Text)

        If (Radio_Imperial.Checked) Or (Radio_mat.Checked) Or (Radio_queen.Checked) Or (Radio_king.Checked) Then

            If (Radio_Imperial.Checked) Then

                If (IsNumeric(total_yardas) And (total_yardas) <= 3) Then

                    sel_cubre = mano_obra_imperial

                Else

                    MsgBox("Error, el total de yardas para el cubrecamas imperial no puede ser mayor a 3", Title:="Sistema de CubreCamas O.V. dice")
                    Exit Sub

                End If
            End If

            If (Radio_mat.Checked) Then

                If (IsNumeric(total_yardas) And (total_yardas) <= 5) Then

                    sel_cubre = mano_obra_matrimonial
                Else

                    MsgBox("Error, el total de yardas para el cubrecamas matrimonial no puede ser mayor a 5", Title:="Sistema de CubreCamas O.V. dice")
                    Exit Sub
                End If
            End If

            If (Radio_queen.Checked) Then

                If (IsNumeric(total_yardas) And (total_yardas) <= 6) Then

                    sel_cubre = mano_obra_queen

                Else

                    MsgBox("Error, el total de yardas para el cubrecamas queen no puede ser mayor a 6", Title:="Sistema de CubreCamas O.V. dice")
                    Exit Sub
                End If
            End If

            If (Radio_king.Checked) Then

                If (IsNumeric(total_yardas) And (total_yardas) <= 7) Then
                    sel_cubre = mano_obra_king

                Else

                    MsgBox("Error, el total de yardas para el cubrecamas king no puede ser mayor a 7", Title:="Sistema de CubreCamas O.V. dice")
                    Exit Sub
                End If
            End If

        End If


        If (Check_Lino.Checked) Then


            total_lino = (Val(Txt_lino.Text) * lino)
            Txt_TLino.Text = Math.Round(total_lino, 2)

        End If

        If (Check_Alg.Checked) Then

            total_algodon = (Val(Txt_algodon.Text) * algodon)
            Txt_TAlg.Text = Math.Round(total_algodon, 2)

        End If

        If (Check_Seda.Checked) Then

            total_seda = (Val(Txt_seda.Text) * seda)
            Txt_TSeda.Text = Math.Round(total_seda, 2)

        End If

        If (Check_Hiloc.Checked) Then

            total_hiloc = (Val(Txt_Hiloc.Text) * hilo_crudo)
            Txt_THiloc.Text = Math.Round(total_hiloc, 2)

        End If


        Txt_Total.Text = Math.Round((sel_cubre + total_lino + total_algodon + total_seda + total_hiloc), 2)

        precio_venta = (Val(Txt_Total.Text) * 0.65) + Val(Txt_Total.Text)
        Txt_venta.Text = Math.Round(precio_venta, 2)

    End Sub

    Private Sub Check_Lino_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Lino.CheckedChanged

        If Radio_Imperial.Checked = True Then
            seleccion = True
        ElseIf Radio_mat.Checked = True Then
            seleccion = True
        ElseIf Radio_queen.Checked = True Then
            seleccion = True
        ElseIf Radio_king.Checked = True Then
            seleccion = True
        End If

        If seleccion = True Then

            If Check_Lino.Checked = True Then
                Txt_lino.Enabled = True
            ElseIf Check_Lino.Checked = False Then
                Txt_lino.Enabled = False
            End If
        End If



    End Sub

    Private Sub Check_Alg_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Alg.CheckedChanged
        If Radio_Imperial.Checked = True Then
            seleccion = True
        ElseIf Radio_mat.Checked = True Then
            seleccion = True
        ElseIf Radio_queen.Checked = True Then
            seleccion = True
        ElseIf Radio_king.Checked = True Then
            seleccion = True
        End If

        If seleccion = True Then

            If Check_Alg.Checked = True Then
                Txt_algodon.Enabled = True
            ElseIf Check_Alg.Checked = False Then
                Txt_algodon.Enabled = False
            End If
        End If

    End Sub

    Private Sub Check_Seda_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Seda.CheckedChanged
        If Radio_Imperial.Checked = True Then
            seleccion = True
        ElseIf Radio_mat.Checked = True Then
            seleccion = True
        ElseIf Radio_queen.Checked = True Then
            seleccion = True
        ElseIf Radio_king.Checked = True Then
            seleccion = True
        End If

        If seleccion = True Then

            If Check_Seda.Checked = True Then
                Txt_seda.Enabled = True
            ElseIf Check_Seda.Checked = False Then
                Txt_seda.Enabled = False
            End If
        End If

    End Sub

    Private Sub Check_Hiloc_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Hiloc.CheckedChanged
        If Radio_Imperial.Checked = True Then
            seleccion = True
        ElseIf Radio_mat.Checked = True Then
            seleccion = True
        ElseIf Radio_queen.Checked = True Then
            seleccion = True
        ElseIf Radio_king.Checked = True Then
            seleccion = True
        End If

        If seleccion = True Then

            If Check_Hiloc.Checked = True Then
                Txt_Hiloc.Enabled = True
            ElseIf Check_Hiloc.Checked = False Then
                Txt_Hiloc.Enabled = False
            End If
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click

        Call limpiar()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Call salir()


    End Sub
End Class
