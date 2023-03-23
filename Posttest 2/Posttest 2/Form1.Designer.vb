<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtGajiPokok = New System.Windows.Forms.TextBox()
        Me.cmbBulan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHariKerja = New System.Windows.Forms.TextBox()
        Me.txtSakit = New System.Windows.Forms.TextBox()
        Me.txtTanpaKet = New System.Windows.Forms.TextBox()
        Me.txtIzin = New System.Windows.Forms.TextBox()
        Me.txtTunjangan = New System.Windows.Forms.TextBox()
        Me.txtGajiBersih = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvwData = New System.Windows.Forms.ListView()
        Me.GajiPokok = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bulan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HariKerja = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sakit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TanpaKet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Izin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tunjangan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GajiBersih = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kalkulasi Gaji"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(143, 243)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 49)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.Location = New System.Drawing.Point(143, 89)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.Size = New System.Drawing.Size(261, 26)
        Me.txtGajiPokok.TabIndex = 5
        '
        'cmbBulan
        '
        Me.cmbBulan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbBulan.FormattingEnabled = True
        Me.cmbBulan.IntegralHeight = False
        Me.cmbBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "November", "Desember"})
        Me.cmbBulan.Location = New System.Drawing.Point(143, 124)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(261, 28)
        Me.cmbBulan.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Gaji Pokok"
        '
        'txtHariKerja
        '
        Me.txtHariKerja.Enabled = False
        Me.txtHariKerja.Location = New System.Drawing.Point(143, 163)
        Me.txtHariKerja.Name = "txtHariKerja"
        Me.txtHariKerja.ReadOnly = True
        Me.txtHariKerja.Size = New System.Drawing.Size(261, 26)
        Me.txtHariKerja.TabIndex = 16
        '
        'txtSakit
        '
        Me.txtSakit.Location = New System.Drawing.Point(143, 199)
        Me.txtSakit.Name = "txtSakit"
        Me.txtSakit.Size = New System.Drawing.Size(261, 26)
        Me.txtSakit.TabIndex = 18
        '
        'txtTanpaKet
        '
        Me.txtTanpaKet.Location = New System.Drawing.Point(586, 89)
        Me.txtTanpaKet.Name = "txtTanpaKet"
        Me.txtTanpaKet.Size = New System.Drawing.Size(261, 26)
        Me.txtTanpaKet.TabIndex = 19
        '
        'txtIzin
        '
        Me.txtIzin.Location = New System.Drawing.Point(586, 126)
        Me.txtIzin.Name = "txtIzin"
        Me.txtIzin.Size = New System.Drawing.Size(261, 26)
        Me.txtIzin.TabIndex = 20
        '
        'txtTunjangan
        '
        Me.txtTunjangan.Enabled = False
        Me.txtTunjangan.Location = New System.Drawing.Point(586, 163)
        Me.txtTunjangan.Name = "txtTunjangan"
        Me.txtTunjangan.ReadOnly = True
        Me.txtTunjangan.Size = New System.Drawing.Size(261, 26)
        Me.txtTunjangan.TabIndex = 21
        '
        'txtGajiBersih
        '
        Me.txtGajiBersih.Enabled = False
        Me.txtGajiBersih.Location = New System.Drawing.Point(586, 200)
        Me.txtGajiBersih.Name = "txtGajiBersih"
        Me.txtGajiBersih.ReadOnly = True
        Me.txtGajiBersih.Size = New System.Drawing.Size(261, 26)
        Me.txtGajiBersih.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Bulan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Hari Kerja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Sakit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(489, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 23)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tanpa Ket."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(489, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 23)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Izin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(489, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 23)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Gaji Bersih"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(489, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Tunjangan"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(405, 243)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 49)
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(311, 548)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(298, 31)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvwData
        '
        Me.lvwData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GajiPokok, Me.Bulan, Me.HariKerja, Me.Sakit, Me.TanpaKet, Me.Izin, Me.Tunjangan, Me.GajiBersih})
        Me.lvwData.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwData.GridLines = True
        Me.lvwData.HideSelection = False
        Me.lvwData.Location = New System.Drawing.Point(47, 298)
        Me.lvwData.Name = "lvwData"
        Me.lvwData.Size = New System.Drawing.Size(800, 244)
        Me.lvwData.TabIndex = 32
        Me.lvwData.UseCompatibleStateImageBehavior = False
        Me.lvwData.View = System.Windows.Forms.View.Details
        '
        'GajiPokok
        '
        Me.GajiPokok.Text = "Gaji Pokok"
        Me.GajiPokok.Width = 132
        '
        'Bulan
        '
        Me.Bulan.Text = "Bulan"
        Me.Bulan.Width = 115
        '
        'HariKerja
        '
        Me.HariKerja.Text = "Hari Kerja"
        Me.HariKerja.Width = 91
        '
        'Sakit
        '
        Me.Sakit.Text = "Sakit"
        Me.Sakit.Width = 57
        '
        'TanpaKet
        '
        Me.TanpaKet.Text = "Tanpa Ket."
        Me.TanpaKet.Width = 90
        '
        'Izin
        '
        Me.Izin.Text = "Izin"
        Me.Izin.Width = 54
        '
        'Tunjangan
        '
        Me.Tunjangan.Text = "Tunjangan"
        Me.Tunjangan.Width = 120
        '
        'GajiBersih
        '
        Me.GajiBersih.Text = "Gaji Bersih"
        Me.GajiBersih.Width = 196
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(721, 243)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(126, 49)
        Me.btnHitung.TabIndex = 33
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 609)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.lvwData)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGajiBersih)
        Me.Controls.Add(Me.txtTunjangan)
        Me.Controls.Add(Me.txtIzin)
        Me.Controls.Add(Me.txtTanpaKet)
        Me.Controls.Add(Me.txtSakit)
        Me.Controls.Add(Me.txtHariKerja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbBulan)
        Me.Controls.Add(Me.txtGajiPokok)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kalkulasi Gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtGajiPokok As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHariKerja As TextBox
    Friend WithEvents txtSakit As TextBox
    Friend WithEvents txtTanpaKet As TextBox
    Friend WithEvents txtIzin As TextBox
    Friend WithEvents txtTunjangan As TextBox
    Friend WithEvents txtGajiBersih As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lvwData As ListView
    Friend WithEvents GajiPokok As ColumnHeader
    Friend WithEvents Bulan As ColumnHeader
    Friend WithEvents HariKerja As ColumnHeader
    Friend WithEvents Sakit As ColumnHeader
    Friend WithEvents TanpaKet As ColumnHeader
    Friend WithEvents Izin As ColumnHeader
    Friend WithEvents Tunjangan As ColumnHeader
    Friend WithEvents GajiBersih As ColumnHeader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents cmbBulan As ComboBox
End Class
