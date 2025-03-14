Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxjurusan.Items.Add("Sistem Informasi")
        cbxjurusan.Items.Add("Ilmu Komputer")
        cbxjurusan.Items.Add("Manajemen Informatika")
    End Sub

    Private Sub cbxjurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxjurusan.SelectedIndexChanged
        Dim jurusan As String = cbxjurusan.SelectedItem
        cbxmataKuliah.Items.Clear()
        Select Case (jurusan)
            Case "Sistem Informasi"
                cbxmataKuliah.Items.Add("Logika Informatika")
                cbxmataKuliah.Items.Add("Matematika Diskrit")
                cbxmataKuliah.Items.Add("Aljabar Linier")

            Case "Ilmu Komputer"
                cbxmataKuliah.Items.Add("Kecerdasan Buatan")
                cbxmataKuliah.Items.Add("IOT")
                cbxmataKuliah.Items.Add("Robotika")
            Case "Manajemen Informatika"
                cbxmataKuliah.Items.Add("Pemrograman Dekstop")
                cbxmataKuliah.Items.Add("OOP")
                cbxmataKuliah.Items.Add("Pemrograman Web")
        End Select
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub txtfornext_Click(sender As Object, e As EventArgs) Handles txtfornext.Click
        For i = 1 To 10
            ListBox1.Items.Add(i)
        Next i
    End Sub

    Private Sub btndowhile_Click(sender As Object, e As EventArgs) Handles btndowhile.Click
        Dim i As Integer = 1

        Do While (i < 10)
            ListBox1.Items.Add(i)
            i = i + 1
        Loop
    End Sub

    Private Sub btnwhile_Click(sender As Object, e As EventArgs) Handles btnwhile.Click
        Dim i As Integer = 1

        Do
            ListBox1.Items.Add(i)
            i = i + 1
        Loop Until (i > 10)
    End Sub
End Class