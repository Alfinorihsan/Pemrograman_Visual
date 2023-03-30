<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailTiket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label6 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHari = New System.Windows.Forms.Label()
        Me.lblStudio = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.lblKursi = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.lblJudulFilm = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label6.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(32, 30)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(434, 25)
        Label6.TabIndex = 1
        Label6.Text = "                                                        DETAIL TIKET             " &
    "                                          "
        AddHandler Label6.Click, AddressOf Me.Label6_Click
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHari)
        Me.GroupBox1.Controls.Add(Me.lblStudio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblJam)
        Me.GroupBox1.Controls.Add(Me.lblKursi)
        Me.GroupBox1.Controls.Add(Me.lblJumlah)
        Me.GroupBox1.Controls.Add(Me.lblJudulFilm)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'lblHari
        '
        Me.lblHari.AutoSize = True
        Me.lblHari.Location = New System.Drawing.Point(90, 126)
        Me.lblHari.Name = "lblHari"
        Me.lblHari.Size = New System.Drawing.Size(34, 21)
        Me.lblHari.TabIndex = 10
        Me.lblHari.Text = "Hari"
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudio.Location = New System.Drawing.Point(6, 85)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(59, 25)
        Me.lblStudio.TabIndex = 9
        Me.lblStudio.Text = "Studio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 21)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Hari : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 21)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Jumlah : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Kursi : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Jam : "
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Location = New System.Drawing.Point(341, 126)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(33, 21)
        Me.lblJam.TabIndex = 4
        Me.lblJam.Text = "Jam"
        '
        'lblKursi
        '
        Me.lblKursi.AutoSize = True
        Me.lblKursi.Location = New System.Drawing.Point(90, 200)
        Me.lblKursi.Name = "lblKursi"
        Me.lblKursi.Size = New System.Drawing.Size(39, 21)
        Me.lblKursi.TabIndex = 3
        Me.lblKursi.Text = "Kursi"
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(90, 162)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(51, 21)
        Me.lblJumlah.TabIndex = 1
        Me.lblJumlah.Text = "Jumlah"
        '
        'lblJudulFilm
        '
        Me.lblJudulFilm.AutoSize = True
        Me.lblJudulFilm.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulFilm.Location = New System.Drawing.Point(6, 38)
        Me.lblJudulFilm.Name = "lblJudulFilm"
        Me.lblJudulFilm.Size = New System.Drawing.Size(69, 30)
        Me.lblJudulFilm.TabIndex = 0
        Me.lblJudulFilm.Text = "JUDUL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total : "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(121, 407)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 25)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total"
        '
        'FormDetailTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(491, 450)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FormDetailTiket"
        Me.Text = "Detail Tiket"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblHari As Label
    Friend WithEvents lblStudio As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblKursi As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblJudulFilm As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
End Class
