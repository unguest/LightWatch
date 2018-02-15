Public Class Player

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog.Filter = "Videos|*.avi;*.mp4;*.wmv;*.mov|Images|*.png;*.jpeg;*.jpg;*.png;*.gif;*.bmp|Sound|*.mp3;*.wav;*.wma;*.ogg"
        OpenFileDialog.ShowDialog()
        URL_Label.Text = OpenFileDialog.FileName
        MediaPlayer.URL = OpenFileDialog.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        URL_Input.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        About.Show()
    End Sub
End Class
