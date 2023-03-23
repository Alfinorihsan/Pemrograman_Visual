Public Class Form1
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Hapus seluruh data yang terisi
        txtGajiPokok.Text = ""
        txtSakit.Text = ""
        txtTanpaKet.Text = ""
        txtIzin.Text = ""
        cmbBulan.SelectedIndex = -1
        txtHariKerja.Text = ""
        txtTunjangan.Text = ""
        txtGajiBersih.Text = ""
        lvwData.Items.Clear()

        ' Focus pada textbox Gaji Pokok
        txtGajiPokok.Focus()
    End Sub

    Private Sub cmbBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBulan.SelectedIndexChanged
        ' Hitung jumlah hari kerja sesuai bulan yang dipilih
        Select Case cmbBulan.SelectedIndex
            Case 0 ' Januari
                txtHariKerja.Text = "27"
            Case 1 ' Februari
                txtHariKerja.Text = "24"
            Case 2 ' Maret
                txtHariKerja.Text = "27"
            Case 3 ' April
                txtHariKerja.Text = "26"
            Case 4 ' Mei
                txtHariKerja.Text = "27"
            Case 5 ' Juni
                txtHariKerja.Text = "26"
            Case 6 ' Juli
                txtHariKerja.Text = "27"
            Case 7 ' Agustus
                txtHariKerja.Text = "27"
            Case 8 ' September
                txtHariKerja.Text = "26"
            Case 9 ' Oktober
                txtHariKerja.Text = "27"
            Case 10 ' November
                txtHariKerja.Text = "26"
            Case 11 ' Desember
                txtHariKerja.Text = "27"
        End Select
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' Validasi data kosong
        If txtGajiPokok.Text = "" Or cmbBulan.SelectedIndex = -1 Or txtSakit.Text = "" Or txtTanpaKet.Text = "" Then
            MessageBox.Show("Mohon lengkapi semua data terlebih dahulu.")
            Return
        End If

        ' Hitung tunjangan
        Dim hariKerja As Integer = CInt(txtHariKerja.Text)
        Dim jumlahSakit As Integer = CInt(txtSakit.Text)
        Dim jumlahTanpaKet As Integer = CInt(txtTanpaKet.Text)
        Dim jumlahIzin As Integer = CInt(txtIzin.Text)
        Dim tunjangan As Integer = hariKerja * 50000

        If jumlahSakit = 0 And jumlahTanpaKet = 0 And jumlahIzin = 0 Then
            txtTunjangan.Text = tunjangan.ToString
        Else
            tunjangan -= (jumlahSakit * 20000 + jumlahTanpaKet * 5000 + jumlahIzin * 30000)
            txtTunjangan.Text = tunjangan.ToString
        End If

        ' Hitung gaji bersih
        Dim gajiPokok As Integer = CInt(txtGajiPokok.Text)
        Dim totalTunjangan As Integer = CInt(tunjangan)
        Dim gajiBersih As Integer = gajiPokok + totalTunjangan
        txtGajiBersih.Text = gajiBersih.ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' Tambahkan data ke ListView
        Dim items(7) As String

        items(0) = txtGajiPokok.Text
        items(1) = cmbBulan.SelectedItem.ToString
        items(2) = txtHariKerja.Text
        items(3) = txtSakit.Text
        items(4) = txtTanpaKet.Text
        items(5) = txtIzin.Text
        items(6) = txtTunjangan.Text
        items(7) = txtGajiBersih.Text


        Dim listViewItem As New ListViewItem(items)
        lvwData.Items.Add(listViewItem)
    End Sub
End Class