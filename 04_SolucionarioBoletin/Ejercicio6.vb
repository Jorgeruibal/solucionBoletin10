Option Strict On
Public Class Ejercicio6
    Dim gradosCentigrados, gradosFahrenheit As Double
    Private Sub txtCentigrados_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCentigrados.KeyDown, txtFahrenheit.KeyDown

        'Verificar que se ha pulsado la tecla enter
        If e.KeyCode = Keys.Enter Then
            'Detectar en que caja de texto está el usuario
            If sender Is txtCentigrados Then
                gradosCentigrados = Convert.ToDouble(txtCentigrados.Text)

                gradosFahrenheit = gradosCentigrados * (9 / 5) + 32

                txtFahrenheit.Text = gradosFahrenheit.ToString()
            Else
                gradosFahrenheit = Convert.ToDouble(txtFahrenheit.Text)

                gradosCentigrados = (gradosFahrenheit - 32) * (5 / 9)

                txtCentigrados.Text = gradosCentigrados.ToString()
            End If
        End If

    End Sub
End Class