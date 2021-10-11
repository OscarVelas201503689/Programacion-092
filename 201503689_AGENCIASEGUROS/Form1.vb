Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(Text_Edad.Text) = False Or IsNumeric(Text_Daños.Text) = False Then
            MsgBox("El valor debe ser un número, corrija el valor ingresado para continuar", vbExclamation, Title:="Error de ingreso")
            Text_Edad.Focus()
            Exit Sub
        End If

        If (Text_Edad.Text = "") Or (Combo_Genero.Text = "") Or (Combo_Registro.Text = "") Or (Text_Daños.Text = "") Or (Combo_Taller.Text = "") Then
            MsgBox("Por favor revise que todos los campos estén completos", vbExclamation, Title:="Advertencia")

            Text_Edad.Focus()
            Exit Sub
        End If

        If (indice < 7) Then
            Edad(indice) = Val(Text_Edad.Text)
            Genero(indice) = Combo_Genero.SelectedItem
            Registro(indice) = Combo_Registro.Text
            Daños(indice) = Val(Text_Daños.Text)
            Taller(indice) = Combo_Taller.SelectedItem.ToString()
            Deducible(indice) = Val(Text_Daños.Text) * 0.06

        End If
        formatear_datos()
        indice = indice + 1

        If (indice >= 7) Then

            MsgBox("Limite de registros alcanzado", vbExclamation, Title:="Sistema dice")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim x As Byte

        List_Edad.Items.Clear()
        List_Genero.Items.Clear()
        List_Registro.Items.Clear()
        List_Daños.Items.Clear()
        List_Taller.Items.Clear()
        List_Deducible.Items.Clear()

        For x = 0 To 7
            If Edad(x) <> Nothing Then
                List_Edad.Items.Add(Edad(x))
                List_Genero.Items.Add(Genero(x))
                List_Registro.Items.Add(Registro(x))
                List_Daños.Items.Add(Daños(x))
                List_Taller.Items.Add(Taller(x))
                List_Deducible.Items.Add(Deducible(x))
            Else
                Exit For
            End If
        Next x

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim L As Byte


        For L = 0 To 7

            Edad(L) = Nothing
            Genero(L) = Nothing
            Registro(L) = Nothing
            Daños(L) = Nothing
            Taller(L) = Nothing
            Deducible(L) = Nothing

        Next L

        List_Edad.Items.Clear()
        List_Genero.Items.Clear()
        List_Registro.Items.Clear()
        List_Daños.Items.Clear()
        List_Taller.Items.Clear()
        List_Deducible.Items.Clear()
        Text_TotalDaños.Clear()

        indice = 0

        MsgBox("Vectores limpios, puede realizar de nuevo los 7 ingresos", vbOKOnly, Title:="Limpiar Vectores")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim total_daños As Integer = 0
        Dim Z As Integer

        For Z = 0 To List_Daños.Items.Count - 1
            total_daños = total_daños + Val(List_Daños.Items.Item(Z))

        Next Z

        Text_TotalDaños.Text = Str(total_daños)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim K As Byte
        Dim R1 As Byte = 0
        Dim R2 As Byte = 0
        Dim R3 As Byte = 0
        Dim R4 As Byte = 0
        Dim R5 As Byte = 0


        For K = 0 To 7

            If (Edad(K) > 0) And (Edad(K) < 25) Then
                R1 = R1 + 1
            End If

            If (Genero(K) = "F") Then
                R2 = R2 + 1
            End If

            Select Case Edad(K)
                Case 18 To 25 And Genero(K) = "M" : R3 = R3 + 1
            End Select

            If (Registro(K) = "0 - Extranjero") Then
                R4 = R4 + 1
            Else
                R4 = R4 + 0
            End If

            R5 = List_Edad.Items.Count()

        Next K

        Text_M25.Text = Math.Round((Str(R1) / indice) * 100, 2) & " %"
        Text_GF.Text = Math.Round((Str(R2) / indice) * 100, 2) & " %"
        Text_GM1825.Text = Math.Round((Str(R3) / indice) * 100, 2) & " %"
        Text_Rext.Text = Math.Round((Str(R4) / indice) * 100, 2) & " %"
        Text_TotalCond.Text = Str(R5)


    End Sub

    Private Sub Btn_Deducibles_Click(sender As Object, e As EventArgs) Handles Btn_Deducibles.Click
        Dim total_deducibles As Integer = 0
        Dim Z As Integer

        For Z = 0 To List_Deducible.Items.Count - 1
            total_deducibles = total_deducibles + Val(List_Deducible.Items.Item(Z))

        Next Z

        Text_totalDed.Text = Str(total_deducibles)
    End Sub

    Private Sub Btn_LimpiarE_Click(sender As Object, e As EventArgs) Handles Btn_LimpiarE.Click
        formatear_datos()
    End Sub

    Private Sub Btn_LimpiarEs_Click(sender As Object, e As EventArgs) Handles Btn_LimpiarEs.Click
        Text_M25.Text = ""
        Text_GF.Text = ""
        Text_GM1825.Text = ""
        Text_Rext.Text = ""
        Text_TotalCond.Text = ""
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
