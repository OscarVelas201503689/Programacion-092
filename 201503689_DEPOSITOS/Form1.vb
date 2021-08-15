Public Class Form1
    Private Sub Btn_Calcular_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click

        deposito_act = Val(Txt_Monto1.Text) + Val(Txt_Monto2.Text) + Val(Txt_Monto3.Text)

        MsgBox("El depósito que usted realizará es de: Q" + Str(deposito_act), Title:="Sistema de Depósitos Oscar Velas")


        monto_deposito = Val(Txt_Monto1.Text) + Val(Txt_Monto2.Text) + Val(Txt_Monto3.Text) + Val(Txt_SaldoAnt.Text)
        FormResultados.Txt_DepositoT.Text = monto_deposito

        If Radio_Ahorros.Checked = True Then

            Select Case monto_deposito

                Case 1.01 To 1000.99
                    interes = 1.5 / 100
                Case 1001 To 5000.99
                    interes = 2.5 / 100
                Case 5001 To 15000.99
                    interes = 7.5 / 100
                Case Is >= 15001
                    interes = 10 / 100
            End Select

            Me.Hide()
            FormResultados.Show()

            FormResultados.TxtInteres.Text = Str(interes * 100) + "%"

            interes_calculado = (monto_deposito + interes_calculado) * interes
            FormResultados.Txt_InteresCalc.Text = interes_calculado


            saldo_total = monto_deposito + interes_calculado
            FormResultados.Txt_SaldoTtl.Text = saldo_total

        End If

        If Radio_Premier.Checked = True Then

            Select Case Val(Txt_SaldoAnt.Text)

                Case 1.01 To 10000.99
                    interes = 2.5 / 100
                Case 10001 To 15000.99
                    interes = 3 / 100
                Case Is >= 15001
                    interes = 4.5 / 100
            End Select

            MsgBox("Para la Tarifa Monetario Premier recuerde que el cálculo de los intereses es realizado en base a su Saldo Anterior", vbExclamation, Title:="ALERTA")
            MsgBox("El Saldo Anterior en su cuenta es: Q" + Str(Txt_SaldoAnt.Text), Title:="ALERTA")

            Me.Hide()
            FormResultados.Show()

            FormResultados.TxtInteres.Text = Str(interes * 100) + "%"

            interes_calculado = Val(Txt_SaldoAnt.Text) * interes
            FormResultados.Txt_InteresCalc.Text = interes_calculado

            saldo_total = monto_deposito + interes_calculado
            FormResultados.Txt_SaldoTtl.Text = saldo_total

        End If

        If Radio_Monetario.Checked = True Then

            Me.Hide()
            FormResultados.Show()

            saldo_total = monto_deposito
            FormResultados.Txt_SaldoTtl.Text = saldo_total

        End If
    End Sub

    Private Sub Check_Propio_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Propio.CheckedChanged

        If Radio_Monetario.Checked = True Then
            t_selecc = True

        ElseIf Radio_Premier.Checked = True Then
            t_selecc = True

        ElseIf Radio_Ahorros.Checked = True Then
            t_selecc = True

        End If

        If t_selecc = True Then

            If Check_Propio.Checked = True Then

                Txt_Monto1.Enabled = True

            ElseIf Check_Propio.Checked = False Then

                Txt_Monto1.Enabled = False

            End If

        End If


    End Sub

    Private Sub Check_Otrob_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Otrob.CheckedChanged
        If Radio_Monetario.Checked = True Then
            t_selecc = True

        ElseIf Radio_Premier.Checked = True Then
            t_selecc = True

        ElseIf Radio_Ahorros.Checked = True Then
            t_selecc = True

        End If

        If t_selecc = True Then

            If Check_Otrob.Checked = True Then
                Txt_Monto2.Enabled = True

            ElseIf Check_Otrob.Checked = False Then
                Txt_Monto2.Enabled = False

                End If
            End If
    End Sub

    Private Sub Check_Efectivo_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Efectivo.CheckedChanged

        If Radio_Monetario.Checked = True Then
            t_selecc = True

        ElseIf Radio_Premier.Checked = True Then
            t_selecc = True

        ElseIf Radio_Ahorros.Checked = True Then
            t_selecc = True

        End If

        If t_selecc = True Then

            If Check_Efectivo.Checked = True Then

                Txt_Monto3.Enabled = True

            ElseIf Check_Efectivo.Checked = False Then

                Txt_Monto3.Enabled = False

            End If

        End If

    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click

        Limpiar()

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub
End Class
