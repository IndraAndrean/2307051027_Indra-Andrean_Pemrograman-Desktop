Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles NIP.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Nama.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Fakultas.Click

    End Sub

    Private Sub Process_Click(sender As Object, e As EventArgs) Handles Process.Click
        Dim nip As Long
        If Not Long.TryParse(TextBox1.Text, nip) Then
            MessageBox.Show("NIP harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim nama As String = TextBox2.Text
        Dim fakultas As String = ComboBox1.Text
        Dim jurusan As String = ComboBox2.Text

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
