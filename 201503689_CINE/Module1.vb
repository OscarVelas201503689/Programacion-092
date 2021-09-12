Module Module1

    Public a As Integer
    Public b As Integer
    Public c As Integer

    Public num_entradas As Integer
    Public desc1_ As Double
    Public desc2_ As Double
    Public subtotal_1 As Double
    Public subtotal_2 As Double
    Public subtotal_ = 0
    Public total_ As Double

    Public indice As Byte = 0

    Public Funcion(9) As Double
    Public Cine(9) As String
    Public NumEntradas(9) As Double
    Public SubTotal(9) As Double
    Public Desc1(9) As Double
    Public Desc2(9) As Double
    Public Total(9) As Double


    Sub Limpiar_entradas()

        Form1.Combo_Funcion.SelectedIndex = "-1"
        Form1.Combo_Cine.SelectedIndex = "-1"
        Form1.Txt_entradas.Clear()

    End Sub

    Sub mostrar_resultado()

        Form1.List_Funcion.Items.Add(Funcion(indice))
        Form1.List_Cine.Items.Add(Cine(indice))
        Form1.List_Entradas.Items.Add(NumEntradas(indice))
        Form1.List_SubTotal.Items.Add(SubTotal(indice))
        Form1.List_Desc1.Items.Add(Desc1(indice))
        Form1.List_Desc2.Items.Add(Desc2(indice))
        Form1.List_Total.Items.Add(Total(indice))

    End Sub

    Sub Limpiar_vectores()

        Form1.List_Funcion.Items.Clear()
        Form1.List_Cine.Items.Clear()
        Form1.List_Entradas.Items.Clear()
        Form1.List_SubTotal.Items.Clear()
        Form1.List_Desc1.Items.Clear()
        Form1.List_Desc2.Items.Clear()
        Form1.List_Total.Items.Clear()

        indice = 0


        MsgBox("Se limpiaron los vectores, puede realizar 9 ingresos de nuevo", vbExclamation)
    End Sub

    Sub Limpiar_Listas()

        Form1.List_Funcion.Items.Clear()
        Form1.List_Cine.Items.Clear()
        Form1.List_Entradas.Items.Clear()
        Form1.List_SubTotal.Items.Clear()
        Form1.List_Desc1.Items.Clear()
        Form1.List_Desc2.Items.Clear()
        Form1.List_Total.Items.Clear()


        MsgBox("Se limpiaron las listas, si ya había ingresado datos anteriormente, no fueron borrados", vbExclamation)

    End Sub



End Module
