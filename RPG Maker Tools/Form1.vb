Public Class ToolkitForm
    Private Sub VXAceLaunch_Click(sender As Object, e As EventArgs) Handles VXAceLaunch.Click
        Try
            Process.Start("steam://rungameid/220700")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Process.Start("steam://rungameid/292230")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        JPEGSelect.Enabled = True
        PNGSelect.Enabled = True
        BMPSelect.Enabled = True
        OGVSelect.Enabled = False
        MP3Select.Enabled = False
        WMASelect.Enabled = False
        OGGSelect.Enabled = False
        AACSelect.Enabled = False
        My.Settings.ConvertMode = "Picture"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        JPEGSelect.Enabled = False
        PNGSelect.Enabled = False
        BMPSelect.Enabled = False
        OGVSelect.Enabled = True
        MP3Select.Enabled = False
        WMASelect.Enabled = False
        OGGSelect.Enabled = False
        AACSelect.Enabled = False
        My.Settings.ConvertMode = "Video"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        JPEGSelect.Enabled = False
        PNGSelect.Enabled = False
        BMPSelect.Enabled = False
        OGVSelect.Enabled = False
        MP3Select.Enabled = True
        WMASelect.Enabled = True
        OGGSelect.Enabled = True
        AACSelect.Enabled = True
        My.Settings.ConvertMode = "Audio"
    End Sub

    Private Sub ToolkitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (My.Settings.ConvertMode = "Picture") Then RadioButton1.Checked = True
        If (My.Settings.ConvertMode = "Video") Then RadioButton2.Checked = True
        If (My.Settings.ConvertMode = "Audio") Then RadioButton3.Checked = True
    End Sub
End Class
