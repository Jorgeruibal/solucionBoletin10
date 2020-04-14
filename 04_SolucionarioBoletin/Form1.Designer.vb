<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BoletínIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoletínIIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoletínIToolStripMenuItem, Me.BoletínIIToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BoletínIToolStripMenuItem
        '
        Me.BoletínIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio1ToolStripMenuItem, Me.Ejercicio2ToolStripMenuItem, Me.Ejercicio3ToolStripMenuItem, Me.Ejercicio4ToolStripMenuItem, Me.Ejercicio6ToolStripMenuItem, Me.ProyectoToolStripMenuItem})
        Me.BoletínIToolStripMenuItem.Name = "BoletínIToolStripMenuItem"
        Me.BoletínIToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.BoletínIToolStripMenuItem.Text = "Boletín I"
        '
        'Ejercicio1ToolStripMenuItem
        '
        Me.Ejercicio1ToolStripMenuItem.Name = "Ejercicio1ToolStripMenuItem"
        Me.Ejercicio1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio1ToolStripMenuItem.Text = "Ejercicio 1"
        '
        'Ejercicio2ToolStripMenuItem
        '
        Me.Ejercicio2ToolStripMenuItem.Name = "Ejercicio2ToolStripMenuItem"
        Me.Ejercicio2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio2ToolStripMenuItem.Text = "Ejercicio 2"
        '
        'Ejercicio3ToolStripMenuItem
        '
        Me.Ejercicio3ToolStripMenuItem.Name = "Ejercicio3ToolStripMenuItem"
        Me.Ejercicio3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio3ToolStripMenuItem.Text = "Ejercicio 3"
        '
        'Ejercicio4ToolStripMenuItem
        '
        Me.Ejercicio4ToolStripMenuItem.Name = "Ejercicio4ToolStripMenuItem"
        Me.Ejercicio4ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio4ToolStripMenuItem.Text = "Ejercicio 4"
        '
        'Ejercicio6ToolStripMenuItem
        '
        Me.Ejercicio6ToolStripMenuItem.Name = "Ejercicio6ToolStripMenuItem"
        Me.Ejercicio6ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio6ToolStripMenuItem.Text = "Ejercicio 6"
        '
        'BoletínIIToolStripMenuItem
        '
        Me.BoletínIIToolStripMenuItem.Name = "BoletínIIToolStripMenuItem"
        Me.BoletínIIToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.BoletínIIToolStripMenuItem.Text = "Boletín II"
        '
        'ProyectoToolStripMenuItem
        '
        Me.ProyectoToolStripMenuItem.Name = "ProyectoToolStripMenuItem"
        Me.ProyectoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProyectoToolStripMenuItem.Text = "Proyecto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Ejercicios Boletín Aplicaciones Gráficas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BoletínIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoletínIIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProyectoToolStripMenuItem As ToolStripMenuItem
End Class
