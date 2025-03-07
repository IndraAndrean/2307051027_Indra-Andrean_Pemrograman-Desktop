Public Class Form2

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtambah.CheckedChanged

    End Sub

    Private Sub txtnilai1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnilai1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtnilai2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnilai2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Hitung.Click
        Dim nilai1 As Integer = CInt(txtnilai1.Text)
        Dim nilai2 As Integer = CInt(txtnilai2.Text)
        Dim hasil As Double


        If (rbkali.Checked) Then
            hasil = nilai1 * nilai2
        ElseIf (rbbagi.Checked) Then
            hasil = nilai1 / nilai2
        ElseIf (rbtambah.Checked) Then
            hasil = nilai1 + nilai2
        ElseIf (rbkurang.Checked) Then
            hasil = nilai1 - nilai2
        End If
        txthasil.Text = hasil
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        txtnilai1.Text = ""
        txtnilai2.Text = ""
        rbbagi.Checked = False
        rbkali.Checked = False
        rbkurang.Checked = False
        rbtambah.Checked = False
        txthasil.Text = ""
        txtnilai1.Focus()
    End Sub
End Class