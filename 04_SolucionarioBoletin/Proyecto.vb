Option Strict On
Imports System.IO

Public Class Proyecto
    Dim registros As List(Of String) = New List(Of String)()
    Dim rutaDirectory As String = Directory.GetCurrentDirectory()
    Dim rutaFichero As String = rutaDirectory + "\registros.txt"
    Dim posicionador As Integer = 0
    Private Sub btnGuardarUsuario_Click(sender As Object, e As EventArgs) Handles btnGuardarUsuario.Click
        Dim nombre, apellidos, email, dni As String
        Dim edad As Integer
        Dim correctoNombre, correctoEdad, correctoDni, correctoApellidos, correctoEmail As Boolean
        'Validar cajas de texto
        If txtNombre.Text = "" Then
            txtNombre.Focus()
            txtNombre.BackColor = Color.Coral
            correctoNombre = False
        Else
            nombre = txtNombre.Text
            correctoNombre = True
            txtNombre.BackColor = Color.White
        End If

        If txtApellidos.Text = "" Then

            txtApellidos.Focus()
            txtApellidos.BackColor = Color.Coral
            correctoApellidos = False
        Else

            apellidos = txtApellidos.Text
            correctoApellidos = True
            txtApellidos.BackColor = Color.White
        End If

        If txtEdad.Text = "" Then
            txtEdad.Focus()
            txtEdad.BackColor = Color.Coral
            correctoEdad = False
        Else
            'Validar que es mayor de edad
            edad = Convert.ToInt32(txtEdad.Text)
            correctoEdad = True
            txtEdad.BackColor = Color.White
        End If
        If txtEmail.Text = "" Then
            correctoEmail = False
            txtEmail.Focus()
            txtEmail.BackColor = Color.Coral
        Else
            email = txtEmail.Text
            'Validar email

            correctoEmail = True
            txtEmail.BackColor = Color.White
        End If
        If txtDni.Text = "" Then
            correctoDni = False
            txtDni.Focus()
            txtDni.BackColor = Color.Coral
        Else
            dni = txtDni.Text
            'Validar DNI
            If dni.Length <> 9 Then
            Else

            End If


            'Búsqueda en la matriz

            correctoDni = True
            txtDni.BackColor = Color.White

        End If

        'Si las cajas de texto están bien
        'cubiertas , guardamos los datos en el fichero
        If correctoApellidos = True And correctoNombre = True And correctoEmail = True And correctoDni = True And correctoEdad = True Then
            Dim respuesta As DialogResult = MessageBox.Show("Quiere guardar estos datos ", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If respuesta = DialogResult.Yes Then
                Dim registro As String = nombre + "*" + apellidos + "*" +
                edad.ToString() + "*" + email.ToString() + "*" + dni
                Dim escritor As StreamWriter = New StreamWriter(rutaFichero, True)
                escritor.WriteLine(registro)
                'Añadir también a la lista local de registros
                registros.Add(registro)
                escritor.Close()
            End If
        End If

    End Sub

    Private Sub Proyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Volcar registros a la lista
        Dim lector As StreamReader = New StreamReader(rutaFichero)
        Dim i As Integer = 0
        While Not lector.EndOfStream
            Dim reg As String = lector.ReadLine()
            registros.Add(reg)
        End While
        lector.Close()
        'Mostrar en el visualizador el primer registro

        If registros.Count > 0 Then
            'Spliteamos el primer registro
            Dim trozos() As String = registros(0).Split("*"c)
            txtVerNombre.Text = trozos(0)
            txtVerApellidos.Text = trozos(1)
            txtVerEdad.Text = trozos(2)
            txtVerEmail.Text = trozos(3)
            txtVerDNI.Text = trozos(4)
        End If


    End Sub

    Private Sub btnVerPrimero_Click(sender As Object, e As EventArgs) Handles btnVerPrimero.Click
        posicionador = 0
        If registros.Count > 0 Then
            'Spliteamos el primer registro
            Dim trozos() As String = registros(posicionador).Split("*"c)
            txtVerNombre.Text = trozos(0)
            txtVerApellidos.Text = trozos(1)
            txtVerEdad.Text = trozos(2)
            txtVerEmail.Text = trozos(3)
            txtVerDNI.Text = trozos(4)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicionador = registros.Count - 1
        If registros.Count > 0 Then
            'Spliteamos el primer registro
            Dim trozos() As String = registros(posicionador).Split("*"c)
            txtVerNombre.Text = trozos(0)
            txtVerApellidos.Text = trozos(1)
            txtVerEdad.Text = trozos(2)
            txtVerEmail.Text = trozos(3)
            txtVerDNI.Text = trozos(4)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        posicionador -= 1

        If posicionador > 0 Then
            'Spliteamos el primer registro
            Dim trozos() As String = registros(posicionador).Split("*"c)
            txtVerNombre.Text = trozos(0)
            txtVerApellidos.Text = trozos(1)
            txtVerEdad.Text = trozos(2)
            txtVerEmail.Text = trozos(3)
            txtVerDNI.Text = trozos(4)
        Else
            posicionador = 0
            Dim trozos() As String = registros(posicionador).Split("*"c)
            txtVerNombre.Text = trozos(0)
            txtVerApellidos.Text = trozos(1)
            txtVerEdad.Text = trozos(2)
            txtVerEmail.Text = trozos(3)
            txtVerDNI.Text = trozos(4)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        posicionador += 1

        If posicionador < registros.Count Then
            'Spliteamos el primer registro
            Dim trozos() As String = registros(posicionador).Split("*"c)
            txtVerNombre.Text = trozos(0)
            txtVerApellidos.Text = trozos(1)
            txtVerEdad.Text = trozos(2)
            txtVerEmail.Text = trozos(3)
            txtVerDNI.Text = trozos(4)
        Else
            posicionador = registros.Count - 1
            Dim trozos() As String = registros(posicionador).Split("*"c)
            txtVerNombre.Text = trozos(0)
            txtVerApellidos.Text = trozos(1)
            txtVerEdad.Text = trozos(2)
            txtVerEmail.Text = trozos(3)
            txtVerDNI.Text = trozos(4)
        End If
    End Sub
End Class