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
        Me.NIP = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Fakultas = New System.Windows.Forms.Label()
        Me.Jurusan = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Process = New System.Windows.Forms.Button()
        Me.kelamin = New System.Windows.Forms.Label()
        Me.rdlaki = New System.Windows.Forms.RadioButton()
        Me.rdperempuan = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'NIP
        '
        Me.NIP.AutoSize = True
        Me.NIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIP.Location = New System.Drawing.Point(12, 47)
        Me.NIP.Name = "NIP"
        Me.NIP.Size = New System.Drawing.Size(44, 25)
        Me.NIP.TabIndex = 0
        Me.NIP.Text = "NIP"
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(12, 96)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(64, 25)
        Me.Nama.TabIndex = 1
        Me.Nama.Text = "Nama"
        '
        'Fakultas
        '
        Me.Fakultas.AutoSize = True
        Me.Fakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fakultas.Location = New System.Drawing.Point(12, 190)
        Me.Fakultas.Name = "Fakultas"
        Me.Fakultas.Size = New System.Drawing.Size(86, 25)
        Me.Fakultas.TabIndex = 2
        Me.Fakultas.Text = "Fakultas"
        '
        'Jurusan
        '
        Me.Jurusan.AutoSize = True
        Me.Jurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jurusan.Location = New System.Drawing.Point(12, 230)
        Me.Jurusan.Name = "Jurusan"
        Me.Jurusan.Size = New System.Drawing.Size(83, 25)
        Me.Jurusan.TabIndex = 3
        Me.Jurusan.Text = "Jurusan"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(155, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 30)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(155, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(386, 30)
        Me.TextBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.ComboBox1.Location = New System.Drawing.Point(155, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 33)
        Me.ComboBox1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.ComboBox2.Location = New System.Drawing.Point(155, 230)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(323, 33)
        Me.ComboBox2.TabIndex = 7
        '
        'Process
        '
        Me.Process.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Process.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Process.Location = New System.Drawing.Point(155, 287)
        Me.Process.Name = "Process"
        Me.Process.Size = New System.Drawing.Size(92, 38)
        Me.Process.TabIndex = 8
        Me.Process.Text = "Process"
        Me.Process.UseVisualStyleBackColor = False
        '
        'kelamin
        '
        Me.kelamin.AutoSize = True
        Me.kelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelamin.Location = New System.Drawing.Point(12, 146)
        Me.kelamin.Name = "kelamin"
        Me.kelamin.Size = New System.Drawing.Size(135, 25)
        Me.kelamin.TabIndex = 9
        Me.kelamin.Text = "Jenis Kelamin"
        '
        'rdlaki
        '
        Me.rdlaki.AutoSize = True
        Me.rdlaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdlaki.Location = New System.Drawing.Point(155, 144)
        Me.rdlaki.Name = "rdlaki"
        Me.rdlaki.Size = New System.Drawing.Size(105, 29)
        Me.rdlaki.TabIndex = 10
        Me.rdlaki.TabStop = True
        Me.rdlaki.Text = "Laki-laki"
        Me.rdlaki.UseVisualStyleBackColor = True
        '
        'rdperempuan
        '
        Me.rdperempuan.AutoSize = True
        Me.rdperempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdperempuan.Location = New System.Drawing.Point(278, 144)
        Me.rdperempuan.Name = "rdperempuan"
        Me.rdperempuan.Size = New System.Drawing.Size(134, 29)
        Me.rdperempuan.TabIndex = 11
        Me.rdperempuan.TabStop = True
        Me.rdperempuan.Text = "Perempuan"
        Me.rdperempuan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 361)
        Me.Controls.Add(Me.rdperempuan)
        Me.Controls.Add(Me.rdlaki)
        Me.Controls.Add(Me.kelamin)
        Me.Controls.Add(Me.Process)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Jurusan)
        Me.Controls.Add(Me.Fakultas)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.NIP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NIP As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents Fakultas As System.Windows.Forms.Label
    Friend WithEvents Jurusan As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Process As System.Windows.Forms.Button
    Friend WithEvents kelamin As System.Windows.Forms.Label
    Friend WithEvents rdlaki As System.Windows.Forms.RadioButton
    Friend WithEvents rdperempuan As System.Windows.Forms.RadioButton

End Class
