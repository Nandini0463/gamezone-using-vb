<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.lbl_uid = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.txt_uid = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_uid
        '
        Me.lbl_uid.AutoSize = True
        Me.lbl_uid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uid.Location = New System.Drawing.Point(171, 91)
        Me.lbl_uid.Name = "lbl_uid"
        Me.lbl_uid.Size = New System.Drawing.Size(83, 16)
        Me.lbl_uid.TabIndex = 0
        Me.lbl_uid.Text = "Username:"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(174, 133)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(80, 16)
        Me.lbl_pass.TabIndex = 1
        Me.lbl_pass.Text = "Password:"
        '
        'txt_uid
        '
        Me.txt_uid.Location = New System.Drawing.Point(275, 87)
        Me.txt_uid.Name = "txt_uid"
        Me.txt_uid.Size = New System.Drawing.Size(100, 20)
        Me.txt_uid.TabIndex = 2
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(275, 133)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass.TabIndex = 3
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(99, 237)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_submit.TabIndex = 4
        Me.btn_submit.Text = "Login"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(208, 237)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(389, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-28, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(430, 405)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_uid)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_uid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_uid As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents txt_uid As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
