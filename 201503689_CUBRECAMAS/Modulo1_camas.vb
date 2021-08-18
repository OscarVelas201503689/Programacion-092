Module Modulo1_camas

    Public Const mano_obra_imperial As Double = 65.5
    Public Const mano_obra_matrimonial As Double = 85.99
    Public Const mano_obra_queen As Double = 99.99
    Public Const mano_obra_king As Double = 105.99

    Public Const lino As Double = 15.0
    Public Const algodon As Double = 23.99
    Public Const seda As Double = 30.99
    Public Const hilo_crudo As Double = 39.99


    Public Const yardas_imperial As Integer = 3
    Public Const yardas_matrimonial As Integer = 5
    Public Const yardas_queen As Integer = 6
    Public Const yardas_king As Integer = 7

    Public sel_cubre As Double

    Public seleccion As Boolean = False

    Public total_lino, total_algodon, total_seda, total_hiloc, total_yardas As Double

    Public precio_venta As Double




    Public Sub limpiar()

        Form1.Txt_lino.Clear()
        Form1.Txt_algodon.Clear()
        Form1.Txt_seda.Clear()
        Form1.Txt_Hiloc.Clear()

        Form1.Txt_Total.Clear()
        Form1.Txt_venta.Clear()

        Form1.Txt_TLino.Clear()
        Form1.Txt_TAlg.Clear()
        Form1.Txt_TSeda.Clear()
        Form1.Txt_THiloc.Clear()

        If Form1.Check_Lino.CheckState = CheckState.Checked Then Form1.Check_Lino.CheckState = CheckState.Unchecked

        If Form1.Check_Alg.CheckState = CheckState.Checked Then Form1.Check_Alg.CheckState = CheckState.Unchecked

        If Form1.Check_Seda.CheckState = CheckState.Checked Then Form1.Check_Seda.CheckState = CheckState.Unchecked

        If Form1.Check_Hiloc.CheckState = CheckState.Checked Then Form1.Check_Hiloc.CheckState = CheckState.Unchecked


    End Sub


    Public Sub salir()

        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub

End Module
