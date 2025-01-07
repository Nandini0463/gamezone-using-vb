<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Package
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.lbl_diamond = New System.Windows.Forms.Label()
        Me.lbl_600 = New System.Windows.Forms.Label()
        Me.lbl_gold = New System.Windows.Forms.Label()
        Me.lbl_400 = New System.Windows.Forms.Label()
        Me.lbl_silver = New System.Windows.Forms.Label()
        Me.lbl_200 = New System.Windows.Forms.Label()
        Me.cmbx_package = New System.Windows.Forms.ComboBox()
        Me.lbl_choosepack = New System.Windows.Forms.Label()
        Me.lbl_next = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"-4 Lane Bowling Alley", "-Cricket", "-Air Hockey", "-Shooting Range", "-Virtual Golf", "-Bumper Car", "-Mirror Maze"})
        Me.ListBox1.Location = New System.Drawing.Point(41, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"-4 Lane Bowling Alley", "-Shooting Range", "-Virtual Golf", "-Bumper Car", "-Mirror Maze"})
        Me.ListBox2.Location = New System.Drawing.Point(341, 177)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 82)
        Me.ListBox2.TabIndex = 0
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Items.AddRange(New Object() {"-Cricket", "-Air Hockey", "-Bumper Car"})
        Me.ListBox3.Location = New System.Drawing.Point(630, 119)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(105, 56)
        Me.ListBox3.TabIndex = 0
        '
        'lbl_diamond
        '
        Me.lbl_diamond.AutoSize = True
        Me.lbl_diamond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diamond.Location = New System.Drawing.Point(38, 29)
        Me.lbl_diamond.Name = "lbl_diamond"
        Me.lbl_diamond.Size = New System.Drawing.Size(136, 16)
        Me.lbl_diamond.TabIndex = 2
        Me.lbl_diamond.Text = "Diamond Package"
        '
        'lbl_600
        '
        Me.lbl_600.AutoSize = True
        Me.lbl_600.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_600.Location = New System.Drawing.Point(78, 55)
        Me.lbl_600.Name = "lbl_600"
        Me.lbl_600.Size = New System.Drawing.Size(47, 13)
        Me.lbl_600.TabIndex = 3
        Me.lbl_600.Text = "Rs 600"
        '
        'lbl_gold
        '
        Me.lbl_gold.AutoSize = True
        Me.lbl_gold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gold.Location = New System.Drawing.Point(354, 119)
        Me.lbl_gold.Name = "lbl_gold"
        Me.lbl_gold.Size = New System.Drawing.Size(107, 16)
        Me.lbl_gold.TabIndex = 4
        Me.lbl_gold.Text = "Gold Package"
        '
        'lbl_400
        '
        Me.lbl_400.AutoSize = True
        Me.lbl_400.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_400.Location = New System.Drawing.Point(367, 144)
        Me.lbl_400.Name = "lbl_400"
        Me.lbl_400.Size = New System.Drawing.Size(52, 15)
        Me.lbl_400.TabIndex = 5
        Me.lbl_400.Text = "Rs 400"
        '
        'lbl_silver
        '
        Me.lbl_silver.AutoSize = True
        Me.lbl_silver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_silver.Location = New System.Drawing.Point(630, 29)
        Me.lbl_silver.Name = "lbl_silver"
        Me.lbl_silver.Size = New System.Drawing.Size(114, 16)
        Me.lbl_silver.TabIndex = 6
        Me.lbl_silver.Text = "Silver Package"
        '
        'lbl_200
        '
        Me.lbl_200.AutoSize = True
        Me.lbl_200.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_200.Location = New System.Drawing.Point(655, 55)
        Me.lbl_200.Name = "lbl_200"
        Me.lbl_200.Size = New System.Drawing.Size(55, 16)
        Me.lbl_200.TabIndex = 7
        Me.lbl_200.Text = "Rs 200"
        '
        'cmbx_package
        '
        Me.cmbx_package.FormattingEnabled = True
        Me.cmbx_package.Items.AddRange(New Object() {"Diamond Package", "Gold Package", "Silver Package"})
        Me.cmbx_package.Location = New System.Drawing.Point(370, 342)
        Me.cmbx_package.Name = "cmbx_package"
        Me.cmbx_package.Size = New System.Drawing.Size(121, 21)
        Me.cmbx_package.TabIndex = 8
        '
        'lbl_choosepack
        '
        Me.lbl_choosepack.AutoSize = True
        Me.lbl_choosepack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_choosepack.Location = New System.Drawing.Point(176, 340)
        Me.lbl_choosepack.Name = "lbl_choosepack"
        Me.lbl_choosepack.Size = New System.Drawing.Size(184, 20)
        Me.lbl_choosepack.TabIndex = 9
        Me.lbl_choosepack.Text = "Choose Any Package:"
        '
        'lbl_next
        '
        Me.lbl_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_next.Location = New System.Drawing.Point(386, 402)
        Me.lbl_next.Name = "lbl_next"
        Me.lbl_next.Size = New System.Drawing.Size(75, 33)
        Me.lbl_next.TabIndex = 10
        Me.lbl_next.Text = "NEXT"
        Me.lbl_next.UseVisualStyleBackColor = True
        '
        'btn_previous
        '
        Me.btn_previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.Location = New System.Drawing.Point(211, 402)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(90, 33)
        Me.btn_previous.TabIndex = 11
        Me.btn_previous.Text = "Previous"
        Me.btn_previous.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.Location = New System.Drawing.Point(564, 387)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(75, 33)
        Me.btn_end.TabIndex = 12
        Me.btn_end.Text = "End"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'Package
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(827, 462)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_previous)
        Me.Controls.Add(Me.lbl_next)
        Me.Controls.Add(Me.lbl_choosepack)
        Me.Controls.Add(Me.cmbx_package)
        Me.Controls.Add(Me.lbl_200)
        Me.Controls.Add(Me.lbl_silver)
        Me.Controls.Add(Me.lbl_400)
        Me.Controls.Add(Me.lbl_gold)
        Me.Controls.Add(Me.lbl_600)
        Me.Controls.Add(Me.lbl_diamond)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Package"
        Me.Text = "Package"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents lbl_diamond As System.Windows.Forms.Label
    Friend WithEvents lbl_600 As System.Windows.Forms.Label
    Friend WithEvents lbl_gold As System.Windows.Forms.Label
    Friend WithEvents lbl_400 As System.Windows.Forms.Label
    Friend WithEvents lbl_silver As System.Windows.Forms.Label
    Friend WithEvents lbl_200 As System.Windows.Forms.Label
    Friend WithEvents cmbx_package As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_choosepack As System.Windows.Forms.Label
    Friend WithEvents lbl_next As System.Windows.Forms.Button
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_end As System.Windows.Forms.Button
End Class
