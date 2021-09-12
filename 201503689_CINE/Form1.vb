Public Class Form1
    Private Sub Btn_Calcular_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click

        If (Txt_entradas.Text = "") Then

            MsgBox("Ingrese el número de las entradas que comprará por favor", vbQuestion)

            Exit Sub

            Txt_entradas.Focus()

        End If

        If (Combo_Funcion.Text = "") Then

            MsgBox("Seleccione la función por favor", vbQuestion)


            Exit Sub

            Txt_entradas.Focus()

        End If

        If (Combo_Cine.Text = "") Then

            MsgBox("Seleccione el cine por favor", vbQuestion)

            Exit Sub

            Txt_entradas.Focus()

        End If


        If (indice < 9) Then

            Funcion(indice) = Combo_Funcion.Text
            Cine(indice) = Combo_Cine.Text
            NumEntradas(indice) = Txt_entradas.Text



            If Combo_Cine.Text = "A" And Combo_Funcion.Text = "1" Then
                a = 30
                subtotal_ = Val(Txt_entradas.Text) * a

            ElseIf Combo_Cine.Text = "A" And Combo_Funcion.Text = "2" Then
                a = 35
                subtotal_ = Val(Txt_entradas.Text) * a

            ElseIf Combo_Cine.Text = "A" And Combo_Funcion.Text = "3" Then
                a = 40
                subtotal_ = Val(Txt_entradas.Text) * a
            ElseIf Combo_Cine.Text = "A" And Combo_Funcion.Text = "4" Then
                a = 40
                subtotal_ = Val(Txt_entradas.Text) * a
            End If

            If Combo_Cine.Text = "B" And Combo_Funcion.Text = "1" Then

                b = 24
                subtotal_ = Val(Txt_entradas.Text) * b
            ElseIf Combo_Cine.Text = "B" And Combo_Funcion.Text = "2" Then

                b = 34
                subtotal_ = Val(Txt_entradas.Text) * b
            ElseIf Combo_Cine.Text = "B" And Combo_Funcion.Text = "3" Then

                b = 44
                subtotal_ = Val(Txt_entradas.Text) * b
            ElseIf Combo_Cine.Text = "B" And Combo_Funcion.Text = "4" Then

                b = 44
                subtotal_ = Val(Txt_entradas.Text) * b
            End If

            If Combo_Cine.Text = "C" And Combo_Funcion.Text = "1" Then

                c = 35
                subtotal_ = Val(Txt_entradas.Text) * c
            ElseIf Combo_Cine.Text = "C" And Combo_Funcion.Text = "2" Then

                c = 40
                subtotal_ = Val(Txt_entradas.Text) * c
            ElseIf Combo_Cine.Text = "C" And Combo_Funcion.Text = "3" Then

                c = 50
                subtotal_ = Val(Txt_entradas.Text) * c
            ElseIf Combo_Cine.Text = "C" And Combo_Funcion.Text = "4" Then

                c = 50
                subtotal_ = Val(Txt_entradas.Text) * c
            End If

            SubTotal(indice) = subtotal_

            Desc1(indice) = calcular_desc1(Funcion(indice), Cine(indice))
            Desc2(indice) = calcular_desc2(subtotal_2)

            total_ = subtotal_ - calcular_desc1(Funcion(indice), Cine(indice)) - calcular_desc2(subtotal_2)

            Total(indice) = total_

            mostrar_resultado()

            indice = indice + 1


        End If

        If (indice >= 9) Then

            MsgBox("Limite de 9 ingresos alcanzado", vbExclamation, Title:="Sistema dice:")

        End If


    End Sub

    Function calcular_desc1(Funcion_ As Double, Cine_ As String) As Double

        If (Combo_Funcion.Text = "3" Or Combo_Funcion.Text = "4") And (Combo_Cine.Text = "C" Or Combo_Cine.Text = "B") Then

            calcular_desc1 = subtotal_ * 0.055

        ElseIf (Combo_Funcion.Text = "1") And (Combo_Cine.Text = "C" Or Combo_Cine.Text = "B") Then

            calcular_desc1 = subtotal_ * 0.03

        ElseIf (Combo_Funcion.Text = "2") And (Combo_Cine.Text = "A") Then

            calcular_desc1 = subtotal_ * 0.015

        End If

        Return calcular_desc1

    End Function

    Function calcular_desc2(subtotal_2 As Double) As Double

        If (subtotal_ >= 100 And subtotal_ <= 300) Then

            calcular_desc2 = subtotal_ * 0.02

        ElseIf (subtotal_ >= 301 And subtotal_ <= 500) Then

            calcular_desc2 = subtotal_ * 0.04

        ElseIf (subtotal_ >= 501 And subtotal_ <= 1000) Then

            calcular_desc2 = subtotal_ * 0.06

        End If

        Return calcular_desc2

    End Function

    Private Sub Btn_LimpiarL_Click(sender As Object, e As EventArgs) Handles Btn_LimpiarL.Click

        Limpiar_Listas()

    End Sub

    Private Sub Btn_LimpiarE_Click(sender As Object, e As EventArgs) Handles Btn_LimpiarE.Click


        Limpiar_entradas()

    End Sub

    Private Sub Btn_LimpiarV_Click(sender As Object, e As EventArgs) Handles Btn_LimpiarV.Click

        Limpiar_vectores()

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub


End Class
