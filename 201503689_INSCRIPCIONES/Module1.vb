﻿Module Module1


    Public INSCRIPCIONES(7, 10) As String

    Public INDICE1 As Byte = 0

    Public INSCRIPCION_BASICO As Double = 350.0
    Public INSCRIPCION_DIVER As Double = 450.0
    Public MENSUAL_BASICO As Double = 250.0
    Public MENSUAL_DIVER As Double = 350.0

    Public PAGOPARCIAL As Double = 0

    Public Sub LIMPIAR_ENTRADAS()

        Form1.TextNombre.Text = ""
        Form1.TextCarnet.Text = ""
        Form1.RadioBasico.Checked = False
        Form1.RadioDiver.Checked = False
        Form1.ComboDiver.SelectedIndex = -1
        Form1.ComboFPago.SelectedIndex = -1

        Form1.TextNombre.Focus()

    End Sub




End Module
