Module Module1

    Public V_DPI(6) As Double
    Public V_Nombre(6) As String
    Public V_Valor(6) As Double
    Public V_Meses(6) As Integer
    Public V_Tasa(6) As Double
    Public V_Total(6) As Double

    Public t As Byte
    Public indice As Integer = 0

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True
        t = 0
        comprobar_repetido = True
        While (t <= 6) And (encontrado)

            If (V_DPI(t) <> Nothing) Then

                If (V_DPI(t) = (Form1.TextBox1.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    t = t + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function

    Public Sub mostrar_matriz()
        Dim x As Byte

        Form1.DataGridView1.Rows.Clear()

        x = 0

        While (x < 7)

            If (V_DPI(x) <> Nothing) Then

                Form1.DataGridView1.Rows.Add((V_DPI(x)), (V_Nombre(x)), (V_Valor(x)), (V_Meses(x)), (V_Tasa(x)), (V_Total(x)))
                x = x + 1
            Else
                Exit While
            End If
        End While
    End Sub

    Public Sub limpiar_entradas()

        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""

    End Sub
    Public Sub limpiar_vectores()

        Dim j As Byte

        Form1.DataGridView1.Rows.Clear()
        indice = 0


        j = 0
        While (j <= 5)

            V_DPI(j) = Nothing
            V_Nombre(j) = Nothing
            V_Valor(j) = Nothing
            V_Meses(j) = Nothing
            V_Tasa(j) = Nothing
            V_Total(j) = Nothing

            j = j + 1

        End While

        MsgBox("Vectores se han limpiado con éxito")

    End Sub


End Module
