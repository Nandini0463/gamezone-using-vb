<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Games
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
        Me.lbl_gme = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_gname = New System.Windows.Forms.Label()
        Me.lbl_gprice = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_pre = New System.Windows.Forms.Button()
        Me.txt_gid = New System.Windows.Forms.TextBox()
        Me.txt_gname = New System.Windows.Forms.TextBox()
        Me.txt_gprive = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_gme
        '
        Me.lbl_gme.AutoSize = True
        Me.lbl_gme.Font = New System.Drawing.Font("Segoe Print", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gme.Location = New System.Drawing.Point(215, 9)
        Me.lbl_gme.Name = "lbl_gme"
        Me.lbl_gme.Size = New System.Drawing.Size(123, 47)
        Me.lbl_gme.TabIndex = 0
        Me.lbl_gme.Text = "GAMES"
        Me.lbl_gme.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(244, 626)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(108, 31)
        Me.btn_next.TabIndex = 22
        Me.btn_next.Text = "NEXT"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Game_Zone_Management.My.Resources.Resources.golf
        Me.PictureBox3.Location = New System.Drawing.Point(375, 444)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(232, 147)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Game_Zone_Management.My.Resources.Resources.bowling2
        Me.PictureBox2.Location = New System.Drawing.Point(375, 230)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(232, 165)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Game_Zone_Management.My.Resources.Resources.air_hockey
        Me.PictureBox1.Location = New System.Drawing.Point(375, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 165)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(57, 379)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(72, 16)
        Me.lbl_id.TabIndex = 23
        Me.lbl_id.Text = "Game ID:"
        '
        'lbl_gname
        '
        Me.lbl_gname.AutoSize = True
        Me.lbl_gname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gname.Location = New System.Drawing.Point(52, 444)
        Me.lbl_gname.Name = "lbl_gname"
        Me.lbl_gname.Size = New System.Drawing.Size(98, 16)
        Me.lbl_gname.TabIndex = 24
        Me.lbl_gname.Text = "Game Name:"
        '
        'lbl_gprice
        '
        Me.lbl_gprice.AutoSize = True
        Me.lbl_gprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gprice.Location = New System.Drawing.Point(57, 518)
        Me.lbl_gprice.Name = "lbl_gprice"
        Me.lbl_gprice.Size = New System.Drawing.Size(93, 16)
        Me.lbl_gprice.TabIndex = 25
        Me.lbl_gprice.Text = "Game Price:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(290, 267)
        Me.DataGridView1.TabIndex = 26
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(12, 626)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(108, 31)
        Me.btn_insert.TabIndex = 27
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(126, 626)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(108, 31)
        Me.btn_update.TabIndex = 28
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(375, 626)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(108, 31)
        Me.btn_del.TabIndex = 29
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_pre
        '
        Me.btn_pre.Location = New System.Drawing.Point(499, 626)
        Me.btn_pre.Name = "btn_pre"
        Me.btn_pre.Size = New System.Drawing.Size(108, 31)
        Me.btn_pre.TabIndex = 30
        Me.btn_pre.Text = "PREVIOUS"
        Me.btn_pre.UseVisualStyleBackColor = True
        '
        'txt_gid
        '
        Me.txt_gid.Location = New System.Drawing.Point(167, 374)
        Me.txt_gid.Name = "txt_gid"
        Me.txt_gid.Size = New System.Drawing.Size(100, 20)
        Me.txt_gid.TabIndex = 32
        '
        'txt_gname
        '
        Me.txt_gname.Location = New System.Drawing.Point(167, 443)
        Me.txt_gname.Name = "txt_gname"
        Me.txt_gname.Size = New System.Drawing.Size(100, 20)
        Me.txt_gname.TabIndex = 33
        '
        'txt_gprive
        '
        Me.txt_gprive.Location = New System.Drawing.Point(177, 518)
        Me.txt_gprive.Name = "txt_gprive"
        Me.txt_gprive.Size = New System.Drawing.Size(100, 20)
        Me.txt_gprive.TabIndex = 34
        '
        'Games
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(667, 669)
        Me.Controls.Add(Me.txt_gprive)
        Me.Controls.Add(Me.txt_gname)
        Me.Controls.Add(Me.txt_gid)
        Me.Controls.Add(Me.btn_pre)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_gprice)
        Me.Controls.Add(Me.lbl_gname)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_gme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Games"
        Me.Text = "g"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_gme As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_gname As System.Windows.Forms.Label
    Friend WithEvents lbl_gprice As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_pre As System.Windows.Forms.Button
    Friend WithEvents txt_gid As System.Windows.Forms.TextBox
    Friend WithEvents txt_gname As System.Windows.Forms.TextBox
    Friend WithEvents txt_gprive As System.Windows.Forms.TextBox
End Class
