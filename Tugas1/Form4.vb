Public Class Form4

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        'membersikan semua textField di layar
        txtnip.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""

        'membersikan selection pada datragrid
        DataGridView1.ClearSelection()
        'membuat kursor kembali keposisi txtNip
        txtnip.Focus()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If (DataGridView1.SelectedRows().Count > 0) Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells(0).Value = txtnip.Text
            selectedRow.Cells(1).Value = txtnama.Text
            selectedRow.Cells(2).Value = txtalamat.Text

            DataGridView1.Refresh()
        Else
            'menambah data pada masing-masing
            'txtfield kedalam datagridview
            DataGridView1.Rows.Add(txtnip.Text, txtnama.Text, txtalamat.Text)
            btnnew.PerformClick()
        End If
        
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DataGridView1.Rows(e.RowIndex).Selected = True
        txtnip.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        txtnama.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        txtalamat.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
    End Sub

    Private Sub btndalete_Click(sender As Object, e As EventArgs) Handles btndalete.Click
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim res As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data dengan NIP " +
            selectedRow.Cells(0).Value + " ?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If (res = Windows.Forms.DialogResult.Yes) Then
            DataGridView1.Rows.Remove(selectedRow)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class