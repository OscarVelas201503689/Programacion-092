Module Module1

    Public indice As Byte = 0

    Public Edad(7) As Integer
    Public Genero(7) As String
    Public Registro(7) As String
    Public Daños(7) As Integer
    Public Taller(7) As String
    Public Deducible(7) As Integer


    Public Sub formatear_datos()

        Form1.Text_Edad.Clear()
        Form1.Combo_Genero.SelectedIndex = -1
        Form1.Combo_Registro.SelectedIndex = -1
        Form1.Text_Daños.Clear()
        Form1.Combo_Taller.SelectedIndex = -1

    End Sub


End Module
