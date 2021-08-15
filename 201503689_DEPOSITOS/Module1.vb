Module Module1

    Public IntAcu As Double
    Public t_selecc As Boolean = False
    Public monto_deposito As Double
    Public interes As Double
    Public interes_calculado As Double
    Public deposito_act As Double
    Public saldo_total As Double




    Public Sub Limpiar()


        Form1.Txt_Monto1.Clear()
        Form1.Txt_Monto2.Clear()
        Form1.Txt_Monto3.Clear()
        Form1.Txt_SaldoAnt.Clear()

        If Form1.Check_Propio.CheckState = CheckState.Checked Then Form1.Check_Propio.CheckState = CheckState.Unchecked
        If Form1.Check_Otrob.CheckState = CheckState.Checked Then Form1.Check_Otrob.CheckState = CheckState.Unchecked
        If Form1.Check_Efectivo.CheckState = CheckState.Checked Then Form1.Check_Efectivo.CheckState = CheckState.Unchecked

        FormResultados.TxtInteres.Clear()
        FormResultados.Txt_DepositoT.Clear()
        FormResultados.Txt_InteresCalc.Clear()
        FormResultados.Txt_SaldoTtl.Clear()


    End Sub
End Module
