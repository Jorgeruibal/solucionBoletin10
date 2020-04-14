Imports System.IO
Public Class Ejercicio1

    Dim nombre As String
    Dim correo As String

    Dim rutaDebug As String = Directory.GetCurrentDirectory()
    Dim rutaFichero1 As String = rutaDebug + "\datos.txt"

    Private Sub btnGuardarDatos_Click(sender As Object, e As EventArgs) Handles btnGuardarDatos.Click
        'recogemos datos de las cajas de texto

        nombre = txtNombre.Text
        correo = txtCorreo.Text

        If nombre = "" Then
            txtNombre.Focus()
            txtNombre.BackColor = Color.Coral
            MessageBox.Show("Debe introducir un nombre")

        ElseIf correo = "" Then
            txtCorreo.Focus()
            txtNombre.BackColor = Color.CadetBlue
            txtCorreo.BackColor = Color.Coral
            MessageBox.Show("Debe introducir un correo")
        Else
            txtNombre.BackColor = Color.CadetBlue
            txtCorreo.BackColor = Color.CadetBlue
            'Preguntamos si desea guardarlos en el fichero
            Dim respuesta As DialogResult = MessageBox.Show("¿Desea guardar los datos : " + nombre + " " + correo + ", en el fichero de registro?",
                    "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                Dim escritor As StreamWriter = New StreamWriter(rutaFichero1, True)
                escritor.WriteLine(nombre + "_" + correo)
                escritor.Close()
            End If
        End If


    End Sub
End Class