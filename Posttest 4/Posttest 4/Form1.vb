Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class form1
    Sub Reset()
        txtId.Clear()
        txtNama.Clear()
        cmbUkuran.Focus()
        cmbUkuran.Text = ""
        txtHarga.Clear()
        txtCari.Clear()
        txtId.Focus()
    End Sub
    Sub Isi()
        txtNama.Clear()
        txtNama.Focus()
        cmbUkuran.Focus()
        txtHarga.Clear()
        txtHarga.Focus()
    End Sub
    Sub TampilData()
        DA = New MySqlDataAdapter("Select * From tbkostum", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbkostum")
        DataGridView1.DataSource = DS.Tables("tbkostum")
        DataGridView1.Refresh()
    End Sub

    Private Sub Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilData()
        Call Reset()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtId.Text = "" Or txtNama.Text = "" Or cmbUkuran.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu, Admin-San")
            txtId.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From tbkostum where id='" & txtId.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()

            If Not RD.HasRows Then
                Dim Simpan As String = "insert into tbkostum (ID, Nama, Ukuran, Harga) values ('" & txtId.Text & "','" & txtNama.Text & "','" & cmbUkuran.Text & "','" & txtHarga.Text & "')"
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
            End
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
            Dim Ubah As String = "Update tbkostum set id = '" & txtId.Text & "', Nama = '" & txtNama.Text & "', Ukuran = '" & cmbUkuran.Text & "', Harga = '" & txtHarga.Text & "' where Id = '" & txtId.Text & "'"
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
                CMD = New MySqlCommand("Delete From tbkostum Where id = '" & txtId.Text & "'", CONN)
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
            CMD = New MySqlCommand("Select * From tbkostum where id like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From tbkostum where id like '%" & txtCari.Text & "%'", CONN)
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