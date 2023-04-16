Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Kategori
    Sub Reset()
        txtId.Clear()
        txtKategori.Clear()
        txtCari.Clear()
        txtId.Focus()
    End Sub
    Sub Isi()
        txtKategori.Clear()
        txtKategori.Focus()
    End Sub
    Sub TampilData()
        DA = New MySqlDataAdapter("Select * From tbKategori", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbKategori")
        DataGridView1.DataSource = DS.Tables("tbKategori")
        DataGridView1.Refresh()
    End Sub

    Private Sub Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilData()
        Call Reset()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtId.Text = "" Or txtKategori.Text = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu, Admin-San")
            txtId.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From tbKategori where idKategori='" & txtId.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()

            If Not RD.HasRows Then
                Dim Simpan As String = "insert into tbKategori (idKategori, Kategori) values ('" & txtId.Text & "','" & txtKategori.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil di simpan, Admin-San!", MsgBoxStyle.Information, "HOREE")
            End If
            Call TampilData()
            Call Reset()
            txtId.Focus()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin untuk keluar, Admin-San?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call Reset()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtId.Text = "" Then
            MsgBox("Tolong isi ID terlebih dahulu, Admin-San")
            txtId.Focus()
        Else
            Dim Ubah As String = "Update tbKategori set idKategori = '" & txtId.Text & "', Kategori = '" & txtKategori.Text & "' where IdKategori = '" & txtId.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasi diubah Admin-San", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilData()
            Call Reset()
            txtId.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtId.Text = "" Then
            MsgBox("ID belum diisi, Admin-San")
            txtId.Focus()
        Else
            If MessageBox.Show("Apakah anda yakin untuk menghapus data " & txtId.Text & ", Admin-San?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbKategori Where idKategori = '" & txtId.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Reset()
                Call TampilData()
            Else
                Call Reset()
            End If
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbKategori where idKategori like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From tbKategori where idKategori like '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Data ditemukan Admin-San !")
                DataGridView1.DataSource = DS.Tables("Data ditemukan Admin-San !")
                DataGridView1.ReadOnly = True

            Else
                RD.Close()
                MsgBox("Data tidak ditemukan, Admin-San")
            End If
        End If
    End Sub

End Class