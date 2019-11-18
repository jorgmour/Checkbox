<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Rock = New System.Windows.Forms.CheckBox()
        Me.Pop = New System.Windows.Forms.CheckBox()
        Me.Clasica = New System.Windows.Forms.CheckBox()
        Me.Reggaeton = New System.Windows.Forms.CheckBox()
        Me.Otros = New System.Windows.Forms.CheckBox()
        Me.lblpregunta = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Rock
        '
        Me.Rock.AutoSize = True
        Me.Rock.Location = New System.Drawing.Point(81, 92)
        Me.Rock.Name = "Rock"
        Me.Rock.Size = New System.Drawing.Size(52, 17)
        Me.Rock.TabIndex = 0
        Me.Rock.Text = "Rock"
        Me.Rock.UseVisualStyleBackColor = True
        '
        'Pop
        '
        Me.Pop.AutoSize = True
        Me.Pop.Location = New System.Drawing.Point(81, 135)
        Me.Pop.Name = "Pop"
        Me.Pop.Size = New System.Drawing.Size(45, 17)
        Me.Pop.TabIndex = 1
        Me.Pop.Text = "Pop"
        Me.Pop.UseVisualStyleBackColor = True
        '
        'Clasica
        '
        Me.Clasica.AutoSize = True
        Me.Clasica.Location = New System.Drawing.Point(81, 179)
        Me.Clasica.Name = "Clasica"
        Me.Clasica.Size = New System.Drawing.Size(60, 17)
        Me.Clasica.TabIndex = 2
        Me.Clasica.Text = "Clasica"
        Me.Clasica.UseVisualStyleBackColor = True
        '
        'Reggaeton
        '
        Me.Reggaeton.AutoSize = True
        Me.Reggaeton.Location = New System.Drawing.Point(81, 217)
        Me.Reggaeton.Name = "Reggaeton"
        Me.Reggaeton.Size = New System.Drawing.Size(79, 17)
        Me.Reggaeton.TabIndex = 3
        Me.Reggaeton.Text = "Reggaeton"
        Me.Reggaeton.UseVisualStyleBackColor = True
        '
        'Otros
        '
        Me.Otros.AutoSize = True
        Me.Otros.Location = New System.Drawing.Point(81, 255)
        Me.Otros.Name = "Otros"
        Me.Otros.Size = New System.Drawing.Size(51, 17)
        Me.Otros.TabIndex = 4
        Me.Otros.Text = "Otros"
        Me.Otros.UseVisualStyleBackColor = True
        '
        'lblpregunta
        '
        Me.lblpregunta.AutoSize = True
        Me.lblpregunta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblpregunta.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpregunta.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblpregunta.Location = New System.Drawing.Point(76, 39)
        Me.lblpregunta.Name = "lblpregunta"
        Me.lblpregunta.Size = New System.Drawing.Size(264, 26)
        Me.lblpregunta.TabIndex = 5
        Me.lblpregunta.Text = "Que genero de musica te gusta ?"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(273, 92)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(122, 29)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = " Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblpregunta)
        Me.Controls.Add(Me.Otros)
        Me.Controls.Add(Me.Reggaeton)
        Me.Controls.Add(Me.Clasica)
        Me.Controls.Add(Me.Pop)
        Me.Controls.Add(Me.Rock)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rock As Windows.Forms.CheckBox
    Friend WithEvents Pop As Windows.Forms.CheckBox
    Friend WithEvents Clasica As Windows.Forms.CheckBox
    Friend WithEvents Reggaeton As Windows.Forms.CheckBox
    Friend WithEvents Otros As Windows.Forms.CheckBox
    Friend WithEvents lblpregunta As Label
    Friend WithEvents btnEnviar As Button
End Class
