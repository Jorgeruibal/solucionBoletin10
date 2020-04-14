Option Strict On
Public Class Ejercicio2

    Dim dia, mes, anho As Integer

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDia.Text = ""
        txtMes.Text = ""
        txtAnho.Text = ""

        lblResultado.Text = ""
        txtDia.Focus()
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim correcto As Boolean = True
        If txtDia.Text = "" Then
            correcto = False
            MessageBox.Show("Debe de introducir un día entre 1 y 31")
        ElseIf txtMes.Text = "" Then
            correcto = False
            MessageBox.Show("Debe de introducir un mes")
        ElseIf txtAnho.Text = "" Then

            correcto = False
            MessageBox.Show("Introduzca el año")
        Else
            dia = Convert.ToInt32(txtDia.Text)
            mes = Convert.ToInt32(txtMes.Text)
            anho = Convert.ToInt32(txtAnho.Text)
            Dim nombreMes As String = ""

            Select Case mes
                Case 1
                    nombreMes = "Enero"
                Case 2
                    nombreMes = "Febrero"

                Case 3
                    nombreMes = "Marzo"
            End Select



            Dim resultado As String = dia.ToString() + " de " + nombreMes + " de " + anho.ToString()

            Me.lblResultado.Text = resultado
            lblResultado.Visible = True
        End If


    End Sub


End Class