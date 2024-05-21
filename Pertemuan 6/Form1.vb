Public Class Form1
    Private Sub BtnLeft_Click(sender As Object, e As EventArgs) Handles BtnLeft.Click
        txthasil.Text = Strings.Left(txtkalimat.Text, 4)
    End Sub

    Private Sub BtnMid_Click(sender As Object, e As EventArgs) Handles BtnMid.Click
        txthasil.Text = Strings.Mid(txtkalimat.Text, 3, 5)
    End Sub

    Private Sub BtnRight_Click(sender As Object, e As EventArgs) Handles BtnRight.Click
        txthasil.Text = Strings.Right(txtkalimat.Text, 4)
    End Sub

    Private Sub BtnUpper_Click(sender As Object, e As EventArgs) Handles BtnUpper.Click
        txthasil.Text = Strings.UCase(txtkalimat.Text)
    End Sub

    Private Sub BtnProper_Click(sender As Object, e As EventArgs) Handles BtnProper.Click
        txthasil.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtkalimat.Text)
    End Sub

    Private Sub BtnLower_Click(sender As Object, e As EventArgs) Handles BtnLower.Click
        txthasil.Text = Strings.LCase(txtkalimat.Text)
    End Sub

    Private Sub BtnTrim_Click(sender As Object, e As EventArgs) Handles BtnTrim.Click
        txthasil.Text = Trim(txtkalimat.Text)
    End Sub

    Private Sub BtnLen_Click(sender As Object, e As EventArgs) Handles BtnLen.Click
        txthasil.Text = Len(txtkalimat.Text)
    End Sub

    Private Sub BtnLTrim_Click(sender As Object, e As EventArgs) Handles BtnLTrim.Click
        txthasil.Text = LTrim(txtkalimat.Text)
    End Sub
End Class
