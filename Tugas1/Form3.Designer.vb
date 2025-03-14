<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.cbxjurusan = New System.Windows.Forms.ComboBox()
        Me.cbxmataKuliah = New System.Windows.Forms.ComboBox()
        Me.jurusan = New System.Windows.Forms.Label()
        Me.matakuliah = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.txtfornext = New System.Windows.Forms.Button()
        Me.btndowhile = New System.Windows.Forms.Button()
        Me.btnwhile = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'cbxjurusan
        '
        Me.cbxjurusan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxjurusan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxjurusan.FormattingEnabled = True
        Me.cbxjurusan.Location = New System.Drawing.Point(120, 44)
        Me.cbxjurusan.Name = "cbxjurusan"
        Me.cbxjurusan.Size = New System.Drawing.Size(264, 24)
        Me.cbxjurusan.TabIndex = 0
        '
        'cbxmataKuliah
        '
        Me.cbxmataKuliah.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxmataKuliah.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxmataKuliah.FormattingEnabled = True
        Me.cbxmataKuliah.Location = New System.Drawing.Point(120, 85)
        Me.cbxmataKuliah.Name = "cbxmataKuliah"
        Me.cbxmataKuliah.Size = New System.Drawing.Size(264, 24)
        Me.cbxmataKuliah.TabIndex = 2
        '
        'jurusan
        '
        Me.jurusan.AutoSize = True
        Me.jurusan.Location = New System.Drawing.Point(12, 51)
        Me.jurusan.Name = "jurusan"
        Me.jurusan.Size = New System.Drawing.Size(59, 17)
        Me.jurusan.TabIndex = 3
        Me.jurusan.Text = "Jurusan"
        '
        'matakuliah
        '
        Me.matakuliah.AutoSize = True
        Me.matakuliah.Location = New System.Drawing.Point(12, 92)
        Me.matakuliah.Name = "matakuliah"
        Me.matakuliah.Size = New System.Drawing.Size(82, 17)
        Me.matakuliah.TabIndex = 4
        Me.matakuliah.Text = "Mata Kuliah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Case"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(33, 168)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(147, 180)
        Me.ListBox1.TabIndex = 6
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(220, 168)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(89, 28)
        Me.btnreset.TabIndex = 7
        Me.btnreset.Text = "reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'txtfornext
        '
        Me.txtfornext.Location = New System.Drawing.Point(220, 214)
        Me.txtfornext.Name = "txtfornext"
        Me.txtfornext.Size = New System.Drawing.Size(89, 28)
        Me.txtfornext.TabIndex = 8
        Me.txtfornext.Text = "For Next"
        Me.txtfornext.UseVisualStyleBackColor = True
        '
        'btndowhile
        '
        Me.btndowhile.Location = New System.Drawing.Point(220, 263)
        Me.btndowhile.Name = "btndowhile"
        Me.btndowhile.Size = New System.Drawing.Size(89, 28)
        Me.btndowhile.TabIndex = 9
        Me.btndowhile.Text = "Do While"
        Me.btndowhile.UseVisualStyleBackColor = True
        '
        'btnwhile
        '
        Me.btnwhile.Location = New System.Drawing.Point(220, 309)
        Me.btnwhile.Name = "btnwhile"
        Me.btnwhile.Size = New System.Drawing.Size(89, 28)
        Me.btnwhile.TabIndex = 10
        Me.btnwhile.Text = "While"
        Me.btnwhile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(33, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 220)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 373)
        Me.Controls.Add(Me.btnwhile)
        Me.Controls.Add(Me.btndowhile)
        Me.Controls.Add(Me.txtfornext)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.matakuliah)
        Me.Controls.Add(Me.jurusan)
        Me.Controls.Add(Me.cbxmataKuliah)
        Me.Controls.Add(Me.cbxjurusan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cbxmataKuliah As System.Windows.Forms.ComboBox
    Friend WithEvents jurusan As System.Windows.Forms.Label
    Friend WithEvents matakuliah As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents txtfornext As System.Windows.Forms.Button
    Friend WithEvents btndowhile As System.Windows.Forms.Button
    Friend WithEvents btnwhile As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
