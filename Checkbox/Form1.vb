Public Class Form1
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim Rock, Pop, Clasica, Reggaeton, Otros As Boolean
        If Me.Rock.Checked = True Then
            Rock = True
        Else
            Rock = False
        End If
        If Me.Pop.Checked = True Then
            Pop = True
        Else
            Pop = False
        End If
        If Me.Clasica.Checked = True Then
            Clasica = True
        Else
            Clasica = False
        End If
        If Me.Reggaeton.Checked = True Then
            Reggaeton = True
        Else
            Reggaeton = False
        End If
        If Me.Otros.Checked = True Then
            Otros = True
        Else
            Otros = False
        End If

        MsgBox("Genero seleccionados:")
        If Rock = True Then
            MsgBox("Rock")
        End If

        If Pop = True Then
            MsgBox("Pop")
        End If

        If Clasica = True Then
            MsgBox("Clasica")
        End If

        If Reggaeton = True Then
            MsgBox("Reggaeton")
        End If

        If Otros = True Then
            MsgBox("otros")
        End If



    End Sub
End Class
