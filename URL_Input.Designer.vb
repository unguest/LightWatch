<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class URL_Input
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.URL_Text = New System.Windows.Forms.TextBox()
        Me.URL_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'URL_Text
        '
        Me.URL_Text.Location = New System.Drawing.Point(12, 12)
        Me.URL_Text.Name = "URL_Text"
        Me.URL_Text.Size = New System.Drawing.Size(422, 20)
        Me.URL_Text.TabIndex = 0
        '
        'URL_Button
        '
        Me.URL_Button.Location = New System.Drawing.Point(12, 38)
        Me.URL_Button.Name = "URL_Button"
        Me.URL_Button.Size = New System.Drawing.Size(202, 47)
        Me.URL_Button.TabIndex = 1
        Me.URL_Button.Text = "Send the media to the player"
        Me.URL_Button.UseVisualStyleBackColor = True
        '
        'URL_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 87)
        Me.Controls.Add(Me.URL_Button)
        Me.Controls.Add(Me.URL_Text)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "URL_Input"
        Me.ShowIcon = False
        Me.Text = "Enter the URL of the media"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents URL_Text As System.Windows.Forms.TextBox
    Public WithEvents URL_Button As System.Windows.Forms.Button
End Class
