Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Equipo.Items.Add("SKY")
        ComboBox_Equipo.Items.Add("MOVISTAR")
        ComboBox_Equipo.Items.Add("PRO CYCLING")
        ComboBox_Equipo.Items.Add("PRO TEAM")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(TextBox_Kms.Text) = False Or IsNumeric(TextBox_Tiempo.Text) = False Then
            MsgBox("Por favor verifique los datos ingresados", vbExclamation, Title:="Error de ingreso")
            TextBox_Kms.Focus()
            Exit Sub
        End If

        If TextBox_Etapa.Text = "" Or ComboBox_Equipo.Text = "" Then

            MsgBox("Por favor verifique los datos ingresados", vbExclamation, Title:="Error de ingreso")
            TextBox_Etapa.Focus()
            Exit Sub

        End If

        If RadioButton_Ext.Checked = False And RadioButton_Gua.Checked = False Then
            MsgBox("Por favor verifique los datos ingresados", vbExclamation, Title:="Error de ingreso")
            Exit Sub
        End If

        If (indice <= 11) Then

            If (Not (comprobar_repetido())) Then
                MsgBox("Etapa repetida, no se puede ingresar el dato")
                TextBox_Etapa.Focus()

            Else

                Vector_Etapa(indice) = TextBox_Etapa.Text
                Vector_Equipo(indice) = ComboBox_Equipo.Text

                If RadioButton_Ext.Checked = True Then
                    Vector_Nacionalidad(indice) = RadioButton_Ext.Text

                ElseIf RadioButton_Gua.Checked = True Then
                    Vector_Nacionalidad(indice) = RadioButton_Gua.Text
                End If

                Vector_Km(indice) = Val(TextBox_Kms.Text)
                Vector_Tiempo(indice) = Val(TextBox_Tiempo.Text)

                Select Case Val(TextBox_Tiempo.Text)
                    Case 0 To 119 : penal_benef = 0
                    Case 120 To 139 : penal_benef = penalizacion_120
                    Case 140 To 159 : penal_benef = penalizacion_140
                    Case > 160 : penal_benef = penalizacion_160
                End Select

                Vector_Penalizacion(indice) = penal_benef

                Select Case ComboBox_Equipo.SelectedIndex
                    Case 1
                        If Val(TextBox_Tiempo.Text) < 85 Then
                            Vector_Penalizacion(indice) = beneficio_movistarmenor85 + penal_benef
                        End If
                End Select

                Select Case ComboBox_Equipo.SelectedIndex
                    Case 3 : Vector_Penalizacion(indice) = beneficio_proteam + penal_benef
                End Select

                Vector_Total(indice) = Val(Vector_Tiempo(indice)) + Val(Vector_Penalizacion(indice))


                MsgBox("Registro realizado con éxito", Title:="Sistema dice")

                indice = indice + 1

            End If
        End If

        If (indice = 12) Then
            MsgBox("Limite de registros alcanzado", vbExclamation, Title:="Sistema dice")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrar_matriz()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        inicializar_datos()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim EXISTE As Boolean = True

        While (i <= 11) And (EXISTE)
            If (Vector_Etapa(i) <> Nothing) Then
                If Vector_Etapa(i) = TextBox_ConsultaEtapa.Text Then
                    EXISTE = False
                Else
                    i = i + 1
                End If
            Else
                Exit While
            End If
        End While

        If (EXISTE) Then
            MsgBox("Registro no encontrado")
            TextBox_ConsultaEtapa.Focus()
        Else
            MsgBox("Registro encontrado éxitosamente")
            TextBox_Etapa.Text = Vector_Etapa(i)
            ComboBox_Equipo.Text = Vector_Equipo(i)

            If Vector_Nacionalidad(i) = "GUATEMALTECO" Then

                RadioButton_Gua.Checked = True

            ElseIf Vector_Nacionalidad(i) = "EXTRANJERO" Then

                RadioButton_Ext.Checked = True

            End If

            TextBox_Kms.Text = Vector_Km(i)
            TextBox_Tiempo.Text = Vector_Tiempo(i)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add((Vector_Etapa(i)), (Vector_Equipo(i)), (Vector_Nacionalidad(i)), (Vector_Km(i)), (Vector_Tiempo(i)), (Vector_Penalizacion(i)), (Vector_Total(i)))

            indice = i
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If (Not (comprobar_repetido())) Then
            MsgBox("Etapa repetida, no se puede ingresar el dato")
            TextBox_Etapa.Focus()

        Else

            Vector_Etapa(indice) = TextBox_Etapa.Text
            Vector_Equipo(indice) = ComboBox_Equipo.Text

            If RadioButton_Ext.Checked = True Then
                Vector_Nacionalidad(indice) = RadioButton_Ext.Text

            ElseIf RadioButton_Gua.Checked = True Then
                Vector_Nacionalidad(indice) = RadioButton_Gua.Text
            End If

            Vector_Km(indice) = Val(TextBox_Kms.Text)
            Vector_Tiempo(indice) = Val(TextBox_Tiempo.Text)

            Select Case Val(TextBox_Tiempo.Text)
                Case 0 To 119 : penal_benef = 0
                Case 120 To 139 : penal_benef = penalizacion_120
                Case 140 To 159 : penal_benef = penalizacion_140
                Case > 160 : penal_benef = penalizacion_160
            End Select

            Vector_Penalizacion(indice) = penal_benef

            Select Case ComboBox_Equipo.SelectedIndex
                Case 1
                    If Val(TextBox_Tiempo.Text) < 85 Then
                        Vector_Penalizacion(indice) = beneficio_movistarmenor85 + penal_benef
                    End If
            End Select

            Select Case ComboBox_Equipo.SelectedIndex
                Case 3 : Vector_Penalizacion(indice) = beneficio_proteam + penal_benef
            End Select

            Vector_Total(indice) = Val(Vector_Tiempo(indice)) + Val(Vector_Penalizacion(indice))

            MsgBox("Registro actualizado con éxito", vbExclamation, Title:="Sistema dice")

            indice = 12

        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Vector_Etapa(indice) = Nothing
        Vector_Equipo(indice) = Nothing
        Vector_Km(indice) = Nothing
        Vector_Tiempo(indice) = Nothing
        Vector_Penalizacion(indice) = Nothing
        Vector_Nacionalidad(indice) = Nothing
        Vector_Total(indice) = Nothing

        For i = indice To 11

            Vector_Etapa(i) = Vector_Etapa(i + 1)
            Vector_Equipo(i) = Vector_Equipo(i + 1)
            Vector_Tiempo(i) = Vector_Tiempo(i + 1)
            Vector_Penalizacion(i) = Vector_Penalizacion(i + 1)
            Vector_Nacionalidad(i) = Vector_Nacionalidad(i + 1)
            Vector_Total(i) = Vector_Total(i + 1)

        Next i

        MsgBox("Registro eliminado con éxito", vbExclamation, Title:="Sistema dice")

        Vector_Etapa(i) = Nothing
        Vector_Equipo(i) = Nothing
        Vector_Km(i) = Nothing
        Vector_Tiempo(i) = Nothing
        Vector_Penalizacion(i) = Nothing
        Vector_Nacionalidad(i) = Nothing
        Vector_Total(i) = Nothing

        indice = i
        inicializar_datos()
        mostrar_matriz()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim r1 As Double = 0
        Dim r2 As Double = 0
        Dim r3 As Double = 0
        Dim r4 As Double = 0
        Dim r5 As Double = 0
        Dim r6 As Double = 0
        Dim r7 As Double = 0
        Dim r8 As Double = 0
        Dim r9 As Double = 0
        Dim r As Byte = 0

        For r = 0 To 12
            If Vector_Etapa(r) <> Nothing Then

                If (Vector_Nacionalidad(r) = "GUATEMALTECO") And Vector_Km(r) > 45 Then
                    r1 = r1 + 1
                End If

                If (Vector_Equipo(r) = "SKY") Then
                    r2 = r2 + Val(Vector_Km(r))
                End If

                If (Vector_Equipo(r) = "MOVISTAR") Then
                    r3 = r3 + Val(Vector_Km(r))
                End If

                If (Vector_Equipo(r) = "PRO CYCLING") Then
                    r4 = r4 + Val(Vector_Km(r))
                End If

                If (Vector_Equipo(r) = "PRO TEAM") Then
                    r5 = r5 + Val(Vector_Km(r))
                End If

                If (Vector_Equipo(r) = "SKY") Then
                    r6 = r6 + Val(Vector_Total(r))
                End If

                If (Vector_Equipo(r) = "MOVISTAR") Then
                    r7 = r7 + Val(Vector_Total(r))
                End If

                If (Vector_Equipo(r) = "PRO CYCLING") Then
                    r8 = r8 + Val(Vector_Total(r))
                End If

                If (Vector_Equipo(r) = "PRO TEAM") Then
                    r9 = r9 + Val(Vector_Total(r))
                End If


            Else
                    Exit For
            End If
        Next r

        TextBox_r1.Text = Str(r1)
        TextBox_r2.Text = Str(r2)
        TextBox_r3.Text = Str(r3)
        TextBox_r4.Text = Str(r4)
        TextBox_r5.Text = Str(r5)
        TextBox_r6.Text = Str(r6)
        TextBox_r7.Text = Str(r7)
        TextBox_r8.Text = Str(r8)
        TextBox_r9.Text = Str(r9)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox_r1.Text = ""
        TextBox_r2.Text = ""
        TextBox_r3.Text = ""
        TextBox_r4.Text = ""
        TextBox_r5.Text = ""
        TextBox_r6.Text = ""
        TextBox_r7.Text = ""
        TextBox_r8.Text = ""
        TextBox_r9.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DataGridView1.Sort(ETAPA, System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        limpiar_vectores()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
