Imports MySql.Data.MySqlClient

Public Class Form1

    Sub Reset()
        txtId.Clear()
        txtNama.Clear()
        cmbUkuran.Focus()
        cmbUkuran.Text = ""
        txtKategori.Clear()
        cbIdKategori.Text = ""
        txtHarga.Clear()
        txtCari.Clear()
        txtId.Focus()
    End Sub

    Sub Isi()
        txtId.Clear()
        txtNama.Clear()
        cmbUkuran.Text = ""
        cbIdKategori.Text = ""
        txtHarga.Clear()
        cbIdKategori.Focus()
    End Sub

    Sub TampilKostum()
        DA = New MySqlDataAdapter("Select * From tbKostum", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Kostum")
        DataGridView1.DataSource = DS.Tables("Kostum")
        DataGridView1.Refresh()
    End Sub

    Sub TampilKategori()
        CMD = New MySqlCommand("Select IdKategori From tbKategori", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            cbIdKategori.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Sub AturGrid()
        'Untuk mengatur luas Columns pada DataGridView'
        DataGridView1.Columns(0).Width = 30
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 50
        DataGridView1.Columns(3).Width = 90
        DataGridView1.Columns(4).Width = 100

        'Untuk menampilkan Judul Header pada DataGridView'
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Ukuran"
        DataGridView1.Columns(3).HeaderText = "Id Kategori"
        DataGridView1.Columns(4).HeaderText = "Harga"
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtId.Text = "" Or cbIdKategori.Text = "" Or txtNama.Text = "" Or
            cmbUkuran.Text = "" Or txtHarga.Text = "" Then

            MsgBox("Mohon lengkapi data terlebih dahulu, Admin-San")
            txtId.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From tbKostum where IdKategori = '" & txtId.Text & "'", CONN)
            RD = CMD.ExecuteReader

            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tbKostum(Id,Nama,Ukuran,IdKategori,Harga)values
                                        ('" & txtId.Text & "','" & txtNama.Text & "',
                                        '" & cmbUkuran.Text & "','" & cbIdKategori.Text & "','" & txtHarga.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil di simpan, Admin-San!", MsgBoxStyle.Information, "HOREE")
            Else
                MsgBox("Data tidak berhasil di simpan, Admin-San", MsgBoxStyle.Exclamation)
            End If
            RD.Close()
            Call TampilKostum()
            Call Reset()
            txtId.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call Reset()
        Call TampilKostum()
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbKostum where Id like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From tbKostum where Id like '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Data Ditemukan, Admin-San")
                DataGridView1.DataSource = DS.Tables("Data Ditemukan, Admin-San")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan, Admin-San")
            End If
        End If
    End Sub

    Private Sub DataBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilKategori()
        Call TampilKostum()
        Call Reset()
        Call AturGrid()
    End Sub

    Private Sub cbIdKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIdKategori.SelectedIndexChanged
        CMD = New MySqlCommand("Select * From tbKategori where idKategori='" & cbIdKategori.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows = True Then
            txtKategori.Text = RD.Item(1)
        Else
            MsgBox("Kategori Tidak Terdaftar, Admin-San")
        End If
        RD.Close()
    End Sub

End Class