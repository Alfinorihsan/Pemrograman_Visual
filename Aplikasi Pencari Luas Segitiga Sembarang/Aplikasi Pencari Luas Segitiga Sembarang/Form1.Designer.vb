<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAlas = New System.Windows.Forms.TextBox()
        Me.TextBoxTinggi = New System.Windows.Forms.TextBox()
        Me.TextBoxLuas = New System.Windows.Forms.TextBox()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonHitung = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(656, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Pencari Luas Segitiga Sembarang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alas      :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Pencari_Luas_Segitiga_Sembarang.My.Resources.Resources.penggunaan_trigonometri_dalam_mencari_luas_segitiga
        Me.PictureBox1.Location = New System.Drawing.Point(478, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tinggi  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Silahkan isi data berikut:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(393, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Luas Segitiga Sembarang tersebut adalah  :"
        '
        'TextBoxAlas
        '
        Me.TextBoxAlas.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBoxAlas.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlas.Location = New System.Drawing.Point(142, 165)
        Me.TextBoxAlas.Name = "TextBoxAlas"
        Me.TextBoxAlas.Size = New System.Drawing.Size(296, 35)
        Me.TextBoxAlas.TabIndex = 6
        '
        'TextBoxTinggi
        '
        Me.TextBoxTinggi.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBoxTinggi.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTinggi.Location = New System.Drawing.Point(142, 239)
        Me.TextBoxTinggi.Name = "TextBoxTinggi"
        Me.TextBoxTinggi.Size = New System.Drawing.Size(296, 35)
        Me.TextBoxTinggi.TabIndex = 7
        '
        'TextBoxLuas
        '
        Me.TextBoxLuas.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBoxLuas.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLuas.Location = New System.Drawing.Point(444, 372)
        Me.TextBoxLuas.Name = "TextBoxLuas"
        Me.TextBoxLuas.ReadOnly = True
        Me.TextBoxLuas.Size = New System.Drawing.Size(255, 35)
        Me.TextBoxLuas.TabIndex = 8
        '
        'ButtonReset
        '
        Me.ButtonReset.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.Location = New System.Drawing.Point(142, 307)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(131, 47)
        Me.ButtonReset.TabIndex = 9
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonHitung
        '
        Me.ButtonHitung.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHitung.Location = New System.Drawing.Point(297, 307)
        Me.ButtonHitung.Name = "ButtonHitung"
        Me.ButtonHitung.Size = New System.Drawing.Size(141, 47)
        Me.ButtonHitung.TabIndex = 10
        Me.ButtonHitung.Text = "Hitung"
        Me.ButtonHitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(765, 428)
        Me.Controls.Add(Me.ButtonHitung)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.TextBoxLuas)
        Me.Controls.Add(Me.TextBoxTinggi)
        Me.Controls.Add(Me.TextBoxAlas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Pencari Luas Segitiga Sembarang (Alfi_018)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAlas As TextBox
    Friend WithEvents TextBoxTinggi As TextBox
    Friend WithEvents TextBoxLuas As TextBox
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonHitung As Button
End Class
