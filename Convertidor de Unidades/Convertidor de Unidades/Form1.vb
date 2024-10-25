Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Function ConvertirMasa(ByVal valor As Double, ByVal unidadEntrada As String, ByVal unidadSalida As String) As Double
        Dim resultado As Double = valor
        If unidadEntrada = "Kilogramos" Then
            If unidadSalida = "Gramos" Then
                resultado = valor * 1000
            ElseIf unidadSalida = "Miligramos" Then
                resultado = valor * 1000000
            End If
        ElseIf unidadEntrada = "Gramos" Then
            If unidadSalida = "Kilogramos" Then
                resultado = valor / 1000
            ElseIf unidadSalida = "Miligramos" Then
                resultado = valor * 1000
            End If
        ElseIf unidadEntrada = "Miligramos" Then
            If unidadSalida = "Kilogramos" Then
                resultado = valor / 1000000
            ElseIf unidadSalida = "Gramos" Then
                resultado = valor / 1000
            End If
        End If
        Return resultado
    End Function


    Private Function ConvertirDistancia(ByVal valor As Double, ByVal unidadEntrada As String, ByVal unidadSalida As String) As Double
        Dim resultado As Double = valor
        If unidadEntrada = "Kilómetros" Then
            If unidadSalida = "Metros" Then
                resultado = valor * 1000
            ElseIf unidadSalida = "Centímetros" Then
                resultado = valor * 100000
            ElseIf unidadSalida = "Milímetros" Then
                resultado = valor * 1000000
            End If
        ElseIf unidadEntrada = "Metros" Then
            If unidadSalida = "Kilómetros" Then
                resultado = valor / 1000
            ElseIf unidadSalida = "Centímetros" Then
                resultado = valor * 100
            ElseIf unidadSalida = "Milímetros" Then
                resultado = valor * 1000
            End If
        ElseIf unidadEntrada = "Centímetros" Then
            If unidadSalida = "Kilómetros" Then
                resultado = valor / 100000
            ElseIf unidadSalida = "Metros" Then
                resultado = valor / 100
            ElseIf unidadSalida = "Milímetros" Then
                resultado = valor * 10
            End If
        ElseIf unidadEntrada = "Milímetros" Then
            If unidadSalida = "Kilómetros" Then
                resultado = valor / 1000000
            ElseIf unidadSalida = "Metros" Then
                resultado = valor / 1000
            ElseIf unidadSalida = "Centímetros" Then
                resultado = valor / 10
            End If
        End If
        Return resultado
    End Function


    Private Function UnidadesCompatibles(ByVal unidadEntrada As String, ByVal unidadSalida As String) As Boolean
        If (unidadEntrada = "Kilogramos" Or unidadEntrada = "Gramos" Or unidadEntrada = "Miligramos") And
       (unidadSalida = "Kilogramos" Or unidadSalida = "Gramos" Or unidadSalida = "Miligramos") Then
            Return True
        ElseIf (unidadEntrada = "Kilómetros" Or unidadEntrada = "Metros" Or unidadEntrada = "Centímetros" Or unidadEntrada = "Milímetros") And
           (unidadSalida = "Kilómetros" Or unidadSalida = "Metros" Or unidadSalida = "Centímetros" Or unidadSalida = "Milímetros") Then
            Return True
        End If
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim inputValue As Double
        Dim outputValue As Double

        If Not Double.TryParse(TextBox1.Text, inputValue) Then
            MessageBox.Show("Por favor, ingrese un valor numérico válido.")
            Exit Sub
        End If

        Dim unidadEntrada As String = input.SelectedItem.ToString()
        Dim unidadSalida As String = converter.SelectedItem.ToString()

        If UnidadesCompatibles(unidadEntrada, unidadSalida) Then
            If (unidadEntrada = "Kilogramos" Or unidadEntrada = "Gramos" Or unidadEntrada = "Miligramos") Then
                outputValue = ConvertirMasa(inputValue, unidadEntrada, unidadSalida)
            ElseIf (unidadEntrada = "Kilómetros" Or unidadEntrada = "Metros" Or unidadEntrada = "Centímetros" Or unidadEntrada = "Milímetros") Then
                outputValue = ConvertirDistancia(inputValue, unidadEntrada, unidadSalida)
            End If
        Else
            MessageBox.Show("EH!!! Quieres transformar unidades no validas! Eso no! Que lo qué?! Pon dos unidades que tengan sentido")
            Exit Sub
        End If

        output.Text = outputValue.ToString()
    End Sub

End Class
