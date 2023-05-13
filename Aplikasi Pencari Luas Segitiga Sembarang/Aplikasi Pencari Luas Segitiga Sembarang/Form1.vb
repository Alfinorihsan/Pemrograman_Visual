Public Class Form1
    Private Sub HitungButton_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        Dim isValidInput As Boolean = True
        Dim alas As Double = 0
        Dim tinggi As Double = 0
        If Not Double.TryParse(TextBoxAlas.Text, alas) Then
            isValidInput = False
            MessageBox.Show("HARAP PERIKSA INPUTAN ANDA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxAlas.Focus()
        ElseIf Not Double.TryParse(TextBoxTinggi.Text, tinggi) Then
            isValidInput = False
            MessageBox.Show("HARAP PERIKSA INPUTAN ANDA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxTinggi.Focus()
        End If

        If isValidInput Then
            Dim luas As Double = (alas * tinggi) / 2
            TextBoxLuas.Text = luas.ToString()
        Else
            TextBoxLuas.Text = ""
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxAlas.Text = ""
        TextBoxTinggi.Text = ""
        TextBoxLuas.Text = ""
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class

