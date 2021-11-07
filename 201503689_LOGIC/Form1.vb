Public Class Form1
    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then

            MsgBox("Por favor verifique los ingresos")
            Exit Sub

        End If

        If (indice < 7) Then
            If (Not (comprobar_repetido())) Then
                MsgBox("DPI repetido, no se puede ingresar el dato")
                TextBox1.Focus()

            Else
                V_DPI(indice) = TextBox1.Text
                V_Nombre(indice) = TextBox2.Text
                V_Valor(indice) = TextBox3.Text
                V_Meses(indice) = TextBox4.Text

                If Val(TextBox4.Text) <= 12 Then
                    V_Tasa(indice) = 0.03
                ElseIf Val(TextBox4.Text) > 12 And Val(TextBox4.Text) <= 24 Then
                    V_Tasa(indice) = 0.045
                ElseIf Val(TextBox4.Text) > 24 And Val(TextBox4.Text) <= 36 Then
                    V_Tasa(indice) = 0.055
                ElseIf Val(TextBox4.Text) >= 36 Then
                    V_Tasa(indice) = 0.062
                ElseIf Val(TextBox4.Text) = 12 And Val(TextBox3.Text) > 8000 Then
                    V_Tasa(indice) = 0.02
                End If
                V_Total(indice) = Math.Round(Val(TextBox3.Text) + V_Tasa(indice) * Val(TextBox3.Text), 2)

                indice = indice + 1
                MsgBox("Registrado con éxito")
                limpiar_vectores()
            End If

        Else
            MsgBox("Vectores llenos")
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar_matriz()
    End Sub

    Private Sub OrdenarAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendenteToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Double
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As Integer
        Dim temp5 As Double
        Dim temp6 As Double

        For i = 0 To 5
            For j = i + 1 To 6

                If (V_DPI(j) <> Nothing) Then
                    If (V_DPI(i) > V_DPI(j)) Then

                        temp1 = V_DPI(i)
                        V_DPI(i) = V_DPI(j)
                        V_DPI(j) = temp1

                        temp2 = V_Nombre(i)
                        V_Nombre(i) = V_Nombre(j)
                        V_Nombre(j) = temp2

                        temp3 = V_Valor(i)
                        V_Valor(i) = V_Valor(j)
                        V_Valor(j) = temp3

                        temp4 = V_Meses(i)
                        V_Meses(i) = V_Meses(j)
                        V_Meses(j) = temp4

                        temp5 = V_Tasa(i)
                        V_Tasa(i) = V_Tasa(j)
                        V_Tasa(j) = temp5

                        temp6 = V_Total(i)
                        V_Total(i) = V_Total(j)
                        V_Total(j) = temp6

                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub

    Private Sub OrdenarDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDescendenteToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Double
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As Integer
        Dim temp5 As Double
        Dim temp6 As Double

        For i = 0 To 5
            For j = i + 1 To 6

                If (V_DPI(j) <> Nothing) Then
                    If (V_DPI(i) < V_DPI(j)) Then

                        temp1 = V_DPI(i)
                        V_DPI(i) = V_DPI(j)
                        V_DPI(j) = temp1

                        temp2 = V_Nombre(i)
                        V_Nombre(i) = V_Nombre(j)
                        V_Nombre(j) = temp2

                        temp3 = V_Valor(i)
                        V_Valor(i) = V_Valor(j)
                        V_Valor(j) = temp3

                        temp4 = V_Meses(i)
                        V_Meses(i) = V_Meses(j)
                        V_Meses(j) = temp4

                        temp5 = V_Tasa(i)
                        V_Tasa(i) = V_Tasa(j)
                        V_Tasa(j) = temp5

                        temp6 = V_Total(i)
                        V_Total(i) = V_Total(j)
                        V_Total(j) = temp6

                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
