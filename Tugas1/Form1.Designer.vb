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
        Me.labelfakultas = New System.Windows.Forms.Label()
        Me.labelJurusan = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cbfakultas = New System.Windows.Forms.ComboBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.Process = New System.Windows.Forms.Button()
        Me.kelamin = New System.Windows.Forms.Label()
        Me.rdlaki = New System.Windows.Forms.RadioButton()
        Me.rdperempuan = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttugas = New System.Windows.Forms.TextBox()
        Me.txtuts = New System.Windows.Forms.TextBox()
        Me.txtuas = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        'labelfakultas
        '
        Me.labelfakultas.AutoSize = True
        Me.labelfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelfakultas.Location = New System.Drawing.Point(12, 190)
        Me.labelfakultas.Name = "labelfakultas"
        Me.labelfakultas.Size = New System.Drawing.Size(86, 25)
        Me.labelfakultas.TabIndex = 2
        Me.labelfakultas.Text = "Fakultas"
        '
        'labelJurusan
        '
        Me.labelJurusan.AutoSize = True
        Me.labelJurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJurusan.Location = New System.Drawing.Point(12, 230)
        Me.labelJurusan.Name = "labelJurusan"
        Me.labelJurusan.Size = New System.Drawing.Size(83, 25)
        Me.labelJurusan.TabIndex = 3
        Me.labelJurusan.Text = "Jurusan"
        '
        'txtnip
        '
        Me.txtnip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnip.Location = New System.Drawing.Point(155, 42)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(285, 30)
        Me.txtnip.TabIndex = 4
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(155, 96)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(386, 30)
        Me.txtnama.TabIndex = 5
        '
        'cbfakultas
        '
        Me.cbfakultas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbfakultas.FormattingEnabled = True
        Me.cbfakultas.Location = New System.Drawing.Point(155, 182)
        Me.cbfakultas.Name = "cbfakultas"
        Me.cbfakultas.Size = New System.Drawing.Size(266, 33)
        Me.cbfakultas.TabIndex = 6
        '
        'cbjurusan
        '
        Me.cbjurusan.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbjurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Location = New System.Drawing.Point(155, 230)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(323, 33)
        Me.cbjurusan.TabIndex = 7
        '
        'Process
        '
        Me.Process.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Process.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Process.Location = New System.Drawing.Point(12, 3)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtuas)
        Me.Panel1.Controls.Add(Me.txtuts)
        Me.Panel1.Controls.Add(Me.txttugas)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 341)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(467, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "UAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(646, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "-GRADE-"
        '
        'txttugas
        '
        Me.txttugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttugas.Location = New System.Drawing.Point(216, 276)
        Me.txttugas.Name = "txttugas"
        Me.txttugas.Size = New System.Drawing.Size(84, 30)
        Me.txttugas.TabIndex = 5
        '
        'txtuts
        '
        Me.txtuts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuts.Location = New System.Drawing.Point(365, 278)
        Me.txtuts.Name = "txtuts"
        Me.txtuts.Size = New System.Drawing.Size(85, 30)
        Me.txtuts.TabIndex = 6
        '
        'txtuas
        '
        Me.txtuas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuas.Location = New System.Drawing.Point(527, 278)
        Me.txtuas.Name = "txtuas"
        Me.txtuas.Size = New System.Drawing.Size(93, 30)
        Me.txtuas.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Process)
        Me.Panel2.Location = New System.Drawing.Point(5, 370)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(762, 45)
        Me.Panel2.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 504)
        Me.Controls.Add(Me.rdperempuan)
        Me.Controls.Add(Me.rdlaki)
        Me.Controls.Add(Me.kelamin)
        Me.Controls.Add(Me.cbjurusan)
        Me.Controls.Add(Me.cbfakultas)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.labelJurusan)
        Me.Controls.Add(Me.labelfakultas)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.NIP)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NIP As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents labelfakultas As System.Windows.Forms.Label
    Friend WithEvents labelJurusan As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cbfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Process As System.Windows.Forms.Button
    Friend WithEvents kelamin As System.Windows.Forms.Label
    Friend WithEvents rdlaki As System.Windows.Forms.RadioButton
    Friend WithEvents rdperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtuas As System.Windows.Forms.TextBox
    Friend WithEvents txtuts As System.Windows.Forms.TextBox
    Friend WithEvents txttugas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
