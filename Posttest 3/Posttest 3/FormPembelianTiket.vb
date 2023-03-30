Public Class FormPembelianTiket
    Dim harga As Integer
    Dim kursi As String

    Private Sub cmbJudulFilm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJudulFilm.SelectedIndexChanged
        If cmbJudulFilm.SelectedIndex = 0 Then
            txtStudio.Text = "Regular"
        ElseIf cmbJudulFilm.SelectedIndex = 1 Then
            txtStudio.Text = "Velvet Class"
        ElseIf cmbJudulFilm.SelectedIndex = 2 Then
            txtStudio.Text = "3D"
        ElseIf cmbJudulFilm.SelectedIndex = 3 Then
            txtStudio.Text = "Dolby Atmos"
        End If
    End Sub

    Private Sub cmbHari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHari.SelectedIndexChanged
        If cmbHari.SelectedIndex <= 3 Then
            harga = 35000
        ElseIf cmbHari.SelectedIndex = 4 Then
            harga = 45000
        Else
            harga = 55000
        End If
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Dim kursiDipilih As Boolean = False
        Dim jumlahPesanan As Integer = 0 'variabel baru untuk menyimpan jumlah pesanan
        Dim jumlahKursi As Integer = 0 'variabel baru untuk menyimpan jumlah kursi yang dipilih

        For Each cb In gbKursi.Controls
            If TypeOf cb Is CheckBox Then
                If cb.Checked Then
                    kursi &= cb.Text & ", "
                    jumlahKursi += 1 'menambahkan 1 ke variabel jumlahKursi setiap kali kursi dipilih
                End If
            End If
        Next

        If cmbJudulFilm.SelectedIndex <> -1 And cmbHari.SelectedIndex <> -1 And (radJamTayang1.Checked Or radJamTayang2.Checked Or radJamTayang3.Checked) And txtJumlah.Text <> "" And Val(txtJumlah.Text) > 0 And jumlahKursi = Val(txtJumlah.Text) Then
            jumlahPesanan = Val(txtJumlah.Text) 'mengisi nilai variabel jumlahPesanan dengan nilai yang dimasukkan oleh pengguna
            Dim frmDetail As New FormDetailTiket
            frmDetail.lblJudulFilm.Text = cmbJudulFilm.SelectedItem.ToString

            frmDetail.lblStudio.Text = txtStudio.Text
            frmDetail.lblHari.Text = cmbHari.SelectedItem.ToString
            If radJamTayang1.Checked Then
                frmDetail.lblJam.Text = radJamTayang1.Text
            ElseIf radJamTayang2.Checked Then
                frmDetail.lblJam.Text = radJamTayang2.Text
            Else
                frmDetail.lblJam.Text = radJamTayang3.Text
            End If
            frmDetail.lblJumlah.Text = jumlahPesanan.ToString() 'menampilkan jumlahPesanan di FormDetailTiket
            frmDetail.lblKursi.Text = kursi.TrimEnd(", ")
            frmDetail.lblTotal.Text = (harga * jumlahPesanan).ToString("#,###")
            frmDetail.Show()
            kursi = "" 'Menetapkan nilai variabel "kursi" menjadi string kosong
        ElseIf jumlahKursi <> Val(txtJumlah.Text) Then
            MessageBox.Show("Jumlah kursi yang dipilih tidak sama dengan jumlah pesanan yang dimasukkan!")
        Else
            MessageBox.Show("Lengkapi data terlebih dahulu")
        End If
    End Sub





    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Mereset seluruh komponen input menjadi kosong atau nilai default'
        cmbJudulFilm.SelectedIndex = -1
        txtStudio.Text = ""
        cmbHari.SelectedIndex = -1
        radJamTayang1.Checked = False
        radJamTayang2.Checked = False
        radJamTayang3.Checked = False
        txtJumlah.Text = ""

        For Each cb In gbKursi.Controls
            If TypeOf cb Is CheckBox Then
                cb.Checked = False
            End If
        Next
        kursi = "" 'Menetapkan nilai variabel "kursi" menjadi string kosong
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Menampilkan pesan konfirmasi sebelum menutup program'
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menutup program?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'Jika pengguna memilih tombol "Yes", maka program akan ditutup'
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class