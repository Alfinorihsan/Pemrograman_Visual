Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call koneksi()
        CMD = New MySqlCommand("Select * From tbAkun where NamaUser='" & txtUser.Text & "' and PasswordUser='" & txtPass.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            Me.Visible = False
            Fmenu.Show()
            Fmenu.ToolStripStatusLabel1.Text = RD.GetString(0)
            Fmenu.ToolStripStatusLabel2.Text = RD.GetString(1)
            Fmenu.ToolStripStatusLabel3.Text = RD.GetString(2)
            RD.Close()
            If Fmenu.ToolStripStatusLabel3.Text <> "ADMIN" Then
                Fmenu.UserToolStripMenuItem.Enabled = False
            Else
                Fmenu.UserToolStripMenuItem.Enabled = True
            End If
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa Kembali Username dan Password, User-San", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUser.Focus()
            txtUser.Text = ""
            txtPass.Text = ""
        End If
    End Sub
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then txtPass.Focus()
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then btnLogin.Focus()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        End
    End Sub
End Class