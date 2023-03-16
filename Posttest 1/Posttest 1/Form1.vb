Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Mendefinisikan variabel dan menghitung konversi'
        Dim input As Decimal = TextBox1.Text
        Dim output As Decimal
        Dim fromUnit As String = ComboBox1.SelectedItem
        Dim toUnit As String = ComboBox2.SelectedItem

        Select Case fromUnit
            Case "Kilometer"
                Select Case toUnit
                    Case "Kilometer"
                        output = input
                    Case "Hektometer"
                        output = input * 10
                    Case "Dekameter"
                        output = input * 100
                    Case "Meter"
                        output = input * 1000
                    Case "Desimeter"
                        output = input * 10000
                    Case "Centimeter"
                        output = input * 100000
                    Case "Milimeter"
                        output = input * 1000000
                End Select

            Case "Hektometer"
                Select Case toUnit
                    Case "Kilometer"
                        output = input / 10
                    Case "Hektometer"
                        output = input
                    Case "Dekameter"
                        output = input * 10
                    Case "Meter"
                        output = input * 100
                    Case "Desimeter"
                        output = input * 1000
                    Case "Centimeter"
                        output = input * 10000
                    Case "Milimeter"
                        output = input * 100000
                End Select

            Case "Dekameter"
                Select Case toUnit
                    Case "Kilometer"
                        output = input / 100
                    Case "Hektometer"
                        output = input / 10
                    Case "Dekameter"
                        output = input
                    Case "Meter"
                        output = input * 10
                    Case "Desimeter"
                        output = input * 100
                    Case "Centimeter"
                        output = input * 1000
                    Case "Milimeter"
                        output = input * 10000
                End Select

            Case "Meter"
                Select Case toUnit
                    Case "Kilometer"
                        output = input / 1000
                    Case "Hektometer"
                        output = input / 100
                    Case "Dekameter"
                        output = input / 10
                    Case "Meter"
                        output = input
                    Case "Desimeter"
                        output = input * 10
                    Case "Centimeter"
                        output = input * 100
                    Case "Milimeter"
                        output = input * 1000
                End Select

            Case "Desimeter"
                Select Case toUnit
                    Case "Kilometer"
                        output = input / 10000
                    Case "Hektometer"
                        output = input / 1000
                    Case "Dekameter"
                        output = input / 100
                    Case "Meter"
                        output = input / 10
                    Case "Desimeter"
                        output = input
                    Case "Centimeter"
                        output = input * 10
                    Case "Milimeter"
                        output = input * 100
                End Select

            Case "Centimeter"
                Select Case toUnit
                    Case "Kilometer"
                        output = input / 100000
                    Case "Hektometer"
                        output = input / 10000
                    Case "Dekameter"
                        output = input / 1000
                    Case "Meter"
                        output = input / 100
                    Case "Desimeter"
                        output = input / 10
                    Case "Centimeter"
                        output = input
                    Case "Milimeter"
                        output = input * 10
                End Select

            Case "Milimeter"
                Select Case toUnit
                    Case "Kilometer"
                        output = input / 1000000
                    Case "Hektometer"
                        output = input / 100000
                    Case "Dekameter"
                        output = input / 10000
                    Case "Meter"
                        output = input / 1000
                    Case "Desimeter"
                        output = input / 100
                    Case "Centimeter"
                        output = input / 10
                    Case "Milimeter"
                        output = input
                End Select
        End Select

        'Menampilkan hasil konversi 
        TextBox3.Text = output.ToString()

        'Menampilkan satuan dari input 
        TextBox2.Text = fromUnit

        'Menampilkan satuan dari output 
        TextBox4.Text = toUnit
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Merestart program dengan mengembalikan nilai input dan output ke 0'
        TextBox1.Text = 0
        TextBox3.Text = 0
        TextBox2.Clear()
        TextBox4.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub
End Class