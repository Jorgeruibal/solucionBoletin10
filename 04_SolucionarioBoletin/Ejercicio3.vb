Option Strict On
Public Class Ejercicio3

    Dim area As Double = 0
    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click, btnRectangulo.Click, btnTriangulo.Click

        'Obtener el botón que ha sido pulsado

        Dim boton As Button = CType(sender, Button)

        If sender Is btnCuadrado Then
            Dim ladoCuadrado As Double = Convert.ToDouble(txtLadoCuadrado.Text)
            area = ladoCuadrado * ladoCuadrado
            lblResultado.Text = "El área del cuadrado es " + area.ToString()


        ElseIf sender Is btnRectangulo Then
            Dim ladoMayor As Double = Convert.ToDouble(txtLadoMayor.Text)
            Dim ladoMenor As Double = Convert.ToDouble(txtLadoMenor.Text)
            area = ladoMayor * ladoMenor

            lblResultado.Text = "El área del rectángulo es " + area.ToString()
        Else

        End If

    End Sub
End Class