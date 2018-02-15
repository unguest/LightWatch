Public Class URL_Input

    Private Sub URL_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles URL_Button.Click
        Player.MediaPlayer.URL = URL_Text.Text
        Player.URL_Label.Text = URL_Text.Text
        Me.Hide()
        Player.Show()
    End Sub
End Class