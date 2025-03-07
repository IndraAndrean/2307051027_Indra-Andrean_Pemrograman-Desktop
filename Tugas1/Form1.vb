Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles NIP.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Nama.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Fakultas.Click

    End Sub

    Private Sub Process_Click(sender As Object, e As EventArgs) Handles Process.Click
        Dim nip As Long
        If Not Long.TryParse(TextBox1.Text.Trim(), nip) Then
            Exit Sub
        End If
        Dim nama As String = TextBox2.Text.Trim()
        Dim fakultas As String = ComboBox1.Text.Trim()
        Dim jurusan As String = ComboBox2.Text.Trim()

        Dim jenisKelamin As String = ""
        If rdlaki.Checked Then
            jenisKelamin = "Laki-Laki"
        ElseIf rdperempuan.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
