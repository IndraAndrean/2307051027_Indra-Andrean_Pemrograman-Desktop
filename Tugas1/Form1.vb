Public Class Form1

    ' Mengisi daftar fakultas saat form pertama kali dimuat
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbfakultas.Items.Add("FMIPA")
        cbfakultas.Items.Add("FKIP")
        cbfakultas.Items.Add("FEB")
    End Sub

    ' Memilih jurusan berdasarkan fakultas yang dipilih
    Private Sub cbfakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfakultas.SelectedIndexChanged
        Dim fakultas As String = cbfakultas.SelectedItem
        cbjurusan.Items.Clear()
        Select Case (fakultas)
            Case "FMIPA"
                cbjurusan.Items.Add("Sistem Informasi")
                cbjurusan.Items.Add("Manajemen Informatika")
                cbjurusan.Items.Add("Ilmu Komputer")
            Case "FKIP"
                cbjurusan.Items.Add("Pendidikan Teknologi Informasi")
                cbjurusan.Items.Add("Pendidikan Jasmani")
            Case "FEB"
                cbjurusan.Items.Add("Manajemen")
                cbjurusan.Items.Add("Perbankan")
                cbjurusan.Items.Add("Akuntansi")
        End Select
    End Sub

    ' Memilih mata kuliah berdasarkan jurusan yang dipilih
    Private Sub cbjurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjurusan.SelectedIndexChanged
        cbmatakuliah.Items.Clear()
        Select Case cbjurusan.Text
            Case "Sistem Informasi"
                cbmatakuliah.Items.Add("Basis Data")
                cbmatakuliah.Items.Add("Pemrograman Web")
                cbmatakuliah.Items.Add("Jaringan Komputer")
            Case "Manajemen Informatika"
                cbmatakuliah.Items.Add("Algoritma")
                cbmatakuliah.Items.Add("Struktur Data")
                cbmatakuliah.Items.Add("Keamanan Informasi")
            Case "Ilmu Komputer"
                cbmatakuliah.Items.Add("Pemrograman Java")
                cbmatakuliah.Items.Add("Machine Learning")
                cbmatakuliah.Items.Add("Artificial Intelligence")
            Case "Pendidikan Teknologi Informasi"
                cbmatakuliah.Items.Add("Didaktik Komputasi")
                cbmatakuliah.Items.Add("Multimedia Pembelajaran")
            Case "Pendidikan Jasmani"
                cbmatakuliah.Items.Add("Teori Kepelatihan")
                cbmatakuliah.Items.Add("Gizi Olahraga")
            Case "Manajemen"
                cbmatakuliah.Items.Add("Ekonomi Mikro")
                cbmatakuliah.Items.Add("Ekonomi Makro")
            Case "Perbankan"
                cbmatakuliah.Items.Add("Manajemen Risiko")
                cbmatakuliah.Items.Add("Analisis Laporan Keuangan")
            Case "Akuntansi"
                cbmatakuliah.Items.Add("Akuntansi Keuangan")
                cbmatakuliah.Items.Add("Audit")
        End Select
    End Sub

    ' Membatasi input NIP hanya berupa angka
    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnip.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    ' Menghitung nilai akhir dan menentukan grade
    Private Sub UpdateGrade()
        Dim tugas, uts, uas As Double
        If Double.TryParse(txttugas.Text, tugas) AndAlso Double.TryParse(txtuts.Text, uts) AndAlso Double.TryParse(txtuas.Text, uas) Then
            Dim total As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)
            Dim grade As String

            Select Case total
                Case Is >= 78
                    grade = "A"
                Case Is >= 65
                    grade = "B"
                Case Is >= 50
                    grade = "C"
                Case Is >= 40
                    grade = "D"
                Case Else
                    grade = "E"
            End Select

            lblgrade.Text = " " & grade
        Else
            lblgrade.Text = " ... "
        End If
    End Sub

    ' Memperbarui grade saat nilai tugas diubah
    Private Sub txttugas_TextChanged(sender As Object, e As EventArgs) Handles txttugas.TextChanged
        UpdateGrade()
    End Sub

    ' Memperbarui grade saat nilai UTS diubah
    Private Sub txtuts_TextChanged(sender As Object, e As EventArgs) Handles txtuts.TextChanged
        UpdateGrade()
    End Sub

    ' Memperbarui grade saat nilai UAS diubah
    Private Sub txtuas_TextChanged(sender As Object, e As EventArgs) Handles txtuas.TextChanged
        UpdateGrade()
    End Sub

    ' Mengosongkan semua field input dan mengatur ulang formulir
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtnip.Clear()
        txtnama.Clear()
        cbfakultas.SelectedIndex = -1
        cbjurusan.SelectedIndex = -1
        cbmatakuliah.SelectedIndex = -1
        txttugas.Clear()
        txtuts.Clear()
        txtuas.Clear()
        lblgrade.Text = " -GRADE- "
        txtnip.Enabled = True
        txtnip.Focus()
    End Sub

    ' Menyimpan data ke dalam DataGridView atau memperbarui data jika sudah ada
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or cbjurusan.Text = "" Or cbmatakuliah.Text = "" Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rowIndex As Integer = -1
        For Each row As DataGridViewRow In dgvdata.Rows
            If row.Cells("dgnip").Value IsNot Nothing AndAlso row.Cells("dgnip").Value.ToString() = txtnip.Text Then
                rowIndex = row.Index
                Exit For
            End If
        Next

        If rowIndex = -1 Then
            dgvdata.Rows.Add(txtnip.Text, txtnama.Text, If(rbL.Checked, "Laki-Laki", "Perempuan"), cbjurusan.Text, cbmatakuliah.Text, lblgrade.Text)
        Else
            dgvdata.Rows(rowIndex).SetValues(txtnip.Text, txtnama.Text, If(rbL.Checked, "Laki-Laki", "Perempuan"), cbjurusan.Text, cbmatakuliah.Text, lblgrade.Text)
        End If

        btnnew.PerformClick()
    End Sub

    ' Menghapus data yang dipilih dari DataGridView
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvdata.SelectedRows.Count > 0 Then
            Dim confirm As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                dgvdata.Rows.RemoveAt(dgvdata.SelectedRows(0).Index)
                btnnew.PerformClick()
            End If
        Else
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Menutup aplikasi saat tombol close ditekan
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

End Class
