Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class form1
    Sub Reset()
        txtId.Clear()
        txtNama.Clear()
        cmbUkuran.Focus()
        cmbUkuran.Text = ""
        txtHarga.Clear()
        txtId.Focus()
    End Sub
    Sub Isi()
        txtNama.Clear()
        txtNama.Focus()
        cmbUkuran.Focus()
        txtHarga.Clear()
        txtHarga.Focus()
    End Sub
    Sub TampilJenis()
        DA = New MySqlDataAdapter("Select * From tbkostum", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbkostum")
        DataGridView1.DataSource = DS.Tables("tbkostum")
        DataGridView1.Refresh()
    End Sub

    Private Sub DataJenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilJenis()
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
            Call TampilJenis()
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

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtId.Text = "" Then
            MsgBox("ID belum diisi, Admin-San")
            txtId.Focus()
        Else
            If MessageBox.Show("Apakah anda yakin untuk menghapus data " & txtId.Text & ", Admin-San?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbkostum Where id = '" & txtId.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Reset()
                Call TampilJenis()
            Else
                Call Reset()
            End If
        End If

    End Sub
End Class


