<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtnilai1 = New System.Windows.Forms.TextBox()
        Me.rbkali = New System.Windows.Forms.RadioButton()
        Me.rbbagi = New System.Windows.Forms.RadioButton()
        Me.rbtambah = New System.Windows.Forms.RadioButton()
        Me.rbkurang = New System.Windows.Forms.RadioButton()
        Me.txtnilai2 = New System.Windows.Forms.TextBox()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.Hitung = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Reset)
        Me.Panel1.Controls.Add(Me.Hitung)
        Me.Panel1.Controls.Add(Me.txthasil)
        Me.Panel1.Controls.Add(Me.txtnilai2)
        Me.Panel1.Controls.Add(Me.rbkurang)
        Me.Panel1.Controls.Add(Me.rbtambah)
        Me.Panel1.Controls.Add(Me.rbbagi)
        Me.Panel1.Controls.Add(Me.rbkali)
        Me.Panel1.Controls.Add(Me.txtnilai1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 322)
        Me.Panel1.TabIndex = 0
        '
        'txtnilai1
        '
        Me.txtnilai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnilai1.Location = New System.Drawing.Point(0, 0)
        Me.txtnilai1.Name = "txtnilai1"
        Me.txtnilai1.Size = New System.Drawing.Size(379, 30)
        Me.txtnilai1.TabIndex = 0
        '
        'rbkali
        '
        Me.rbkali.AutoSize = True
        Me.rbkali.Location = New System.Drawing.Point(48, 49)
        Me.rbkali.Name = "rbkali"
        Me.rbkali.Size = New System.Drawing.Size(38, 21)
        Me.rbkali.TabIndex = 1
        Me.rbkali.TabStop = True
        Me.rbkali.Text = "X"
        Me.rbkali.UseVisualStyleBackColor = True
        '
        'rbbagi
        '
        Me.rbbagi.AutoSize = True
        Me.rbbagi.Location = New System.Drawing.Point(134, 49)
        Me.rbbagi.Name = "rbbagi"
        Me.rbbagi.Size = New System.Drawing.Size(33, 21)
        Me.rbbagi.TabIndex = 2
        Me.rbbagi.TabStop = True
        Me.rbbagi.Text = "/"
        Me.rbbagi.UseVisualStyleBackColor = True
        '
        'rbtambah
        '
        Me.rbtambah.AutoSize = True
        Me.rbtambah.Location = New System.Drawing.Point(222, 49)
        Me.rbtambah.Name = "rbtambah"
        Me.rbtambah.Size = New System.Drawing.Size(37, 21)
        Me.rbtambah.TabIndex = 3
        Me.rbtambah.TabStop = True
        Me.rbtambah.Text = "+"
        Me.rbtambah.UseVisualStyleBackColor = True
        '
        'rbkurang
        '
        Me.rbkurang.AutoSize = True
        Me.rbkurang.Location = New System.Drawing.Point(311, 49)
        Me.rbkurang.Name = "rbkurang"
        Me.rbkurang.Size = New System.Drawing.Size(34, 21)
        Me.rbkurang.TabIndex = 4
        Me.rbkurang.TabStop = True
        Me.rbkurang.Text = "-"
        Me.rbkurang.UseVisualStyleBackColor = True
        '
        'txtnilai2
        '
        Me.txtnilai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnilai2.Location = New System.Drawing.Point(0, 76)
        Me.txtnilai2.Name = "txtnilai2"
        Me.txtnilai2.Size = New System.Drawing.Size(379, 30)
        Me.txtnilai2.TabIndex = 5
        '
        'txthasil
        '
        Me.txthasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthasil.Location = New System.Drawing.Point(0, 159)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(379, 30)
        Me.txthasil.TabIndex = 6
        '
        'Hitung
        '
        Me.Hitung.Location = New System.Drawing.Point(148, 119)
        Me.Hitung.Name = "Hitung"
        Me.Hitung.Size = New System.Drawing.Size(85, 34)
        Me.Hitung.TabIndex = 7
        Me.Hitung.Text = "Hitung"
        Me.Hitung.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(148, 206)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(85, 32)
        Me.Reset.TabIndex = 8
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 285)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbkurang As System.Windows.Forms.RadioButton
    Friend WithEvents rbtambah As System.Windows.Forms.RadioButton
    Friend WithEvents rbbagi As System.Windows.Forms.RadioButton
    Friend WithEvents rbkali As System.Windows.Forms.RadioButton
    Friend WithEvents txtnilai1 As System.Windows.Forms.TextBox
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents Hitung As System.Windows.Forms.Button
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents txtnilai2 As System.Windows.Forms.TextBox
End Class
