<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.lbl_gzm = New System.Windows.Forms.Label()
        Me.lbl_reg = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_mno = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_bdate = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_mno = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbx_gender = New System.Windows.Forms.ComboBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_gzm
        '
        Me.lbl_gzm.AutoSize = True
        Me.lbl_gzm.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gzm.ForeColor = System.Drawing.Color.Red
        Me.lbl_gzm.Location = New System.Drawing.Point(226, 9)
        Me.lbl_gzm.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_gzm.Name = "lbl_gzm"
        Me.lbl_gzm.Size = New System.Drawing.Size(502, 64)
        Me.lbl_gzm.TabIndex = 0
        Me.lbl_gzm.Text = "Game Zone Management"
        '
        'lbl_reg
        '
        Me.lbl_reg.AutoSize = True
        Me.lbl_reg.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reg.ForeColor = System.Drawing.Color.Green
        Me.lbl_reg.Location = New System.Drawing.Point(377, 93)
        Me.lbl_reg.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_reg.Name = "lbl_reg"
        Me.lbl_reg.Size = New System.Drawing.Size(164, 42)
        Me.lbl_reg.TabIndex = 1
        Me.lbl_reg.Text = "Registration"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_name.Location = New System.Drawing.Point(199, 177)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 16)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "Name:"
        '
        'lbl_mno
        '
        Me.lbl_mno.AutoSize = True
        Me.lbl_mno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_mno.Location = New System.Drawing.Point(197, 213)
        Me.lbl_mno.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_mno.Name = "lbl_mno"
        Me.lbl_mno.Size = New System.Drawing.Size(117, 16)
        Me.lbl_mno.TabIndex = 3
        Me.lbl_mno.Text = "Mobile Number:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_email.Location = New System.Drawing.Point(199, 259)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(51, 16)
        Me.lbl_email.TabIndex = 4
        Me.lbl_email.Text = "Email:"
        '
        'lbl_bdate
        '
        Me.lbl_bdate.AutoSize = True
        Me.lbl_bdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_bdate.Location = New System.Drawing.Point(197, 349)
        Me.lbl_bdate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_bdate.Name = "lbl_bdate"
        Me.lbl_bdate.Size = New System.Drawing.Size(74, 16)
        Me.lbl_bdate.TabIndex = 5
        Me.lbl_bdate.Text = "Birthdate:"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_gender.Location = New System.Drawing.Point(197, 301)
        Me.lbl_gender.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(63, 16)
        Me.lbl_gender.TabIndex = 6
        Me.lbl_gender.Text = "Gender:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(446, 167)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(164, 26)
        Me.txt_name.TabIndex = 7
        '
        'txt_mno
        '
        Me.txt_mno.Location = New System.Drawing.Point(446, 203)
        Me.txt_mno.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_mno.Name = "txt_mno"
        Me.txt_mno.Size = New System.Drawing.Size(164, 26)
        Me.txt_mno.TabIndex = 8
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(446, 249)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(164, 26)
        Me.txt_email.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(443, 339)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(331, 26)
        Me.DateTimePicker1.TabIndex = 12
        '
        'cmbx_gender
        '
        Me.cmbx_gender.FormattingEnabled = True
        Me.cmbx_gender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbx_gender.Location = New System.Drawing.Point(446, 289)
        Me.cmbx_gender.Name = "cmbx_gender"
        Me.cmbx_gender.Size = New System.Drawing.Size(164, 28)
        Me.cmbx_gender.TabIndex = 14
        '
        'btn_update
        '
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_update.Location = New System.Drawing.Point(384, 414)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(94, 34)
        Me.btn_update.TabIndex = 16
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_del.Location = New System.Drawing.Point(254, 414)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(94, 34)
        Me.btn_del.TabIndex = 17
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(139, 470)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(658, 150)
        Me.DataGridView1.TabIndex = 18
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_submit.Location = New System.Drawing.Point(100, 414)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(113, 34)
        Me.btn_submit.TabIndex = 13
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_reset.Location = New System.Drawing.Point(506, 414)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(89, 34)
        Me.btn_reset.TabIndex = 19
        Me.btn_reset.Text = "Clear"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(629, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 34)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_previous
        '
        Me.btn_previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_previous.Location = New System.Drawing.Point(742, 415)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(86, 34)
        Me.btn_previous.TabIndex = 21
        Me.btn_previous.Text = "Previous"
        Me.btn_previous.UseVisualStyleBackColor = True
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1031, 647)
        Me.Controls.Add(Me.btn_previous)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.cmbx_gender)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_mno)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.lbl_bdate)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_mno)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_reg)
        Me.Controls.Add(Me.lbl_gzm)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Brown
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Registration"
        Me.Text = "Registration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_gzm As System.Windows.Forms.Label
    Friend WithEvents lbl_reg As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_mno As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_bdate As System.Windows.Forms.Label
    Friend WithEvents lbl_gender As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_mno As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbx_gender As System.Windows.Forms.ComboBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_previous As System.Windows.Forms.Button

End Class
