<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSP
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSP))
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTimTen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTimLoai = New System.Windows.Forms.TextBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txtMota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboLoai = New System.Windows.Forms.ComboBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDVT = New System.Windows.Forms.TextBox()
        Me.bsSP = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSP
        '
        Me.dgvSP.AllowUserToAddRows = False
        Me.dgvSP.AllowUserToDeleteRows = False
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(11, 227)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.ReadOnly = True
        Me.dgvSP.Size = New System.Drawing.Size(563, 252)
        Me.dgvSP.TabIndex = 47
        Me.dgvSP.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTimTen)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTimLoai)
        Me.GroupBox2.Controls.Add(Me.btnTim)
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(196, 168)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tìm kiếm"
        '
        'txtTimTen
        '
        Me.txtTimTen.Location = New System.Drawing.Point(6, 86)
        Me.txtTimTen.Name = "txtTimTen"
        Me.txtTimTen.Size = New System.Drawing.Size(180, 20)
        Me.txtTimTen.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Tên SP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Loại SP"
        '
        'txtTimLoai
        '
        Me.txtTimLoai.Location = New System.Drawing.Point(6, 37)
        Me.txtTimLoai.Name = "txtTimLoai"
        Me.txtTimLoai.Size = New System.Drawing.Size(180, 20)
        Me.txtTimLoai.TabIndex = 4
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(102, 137)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(75, 23)
        Me.btnTim.TabIndex = 1
        Me.btnTim.Text = "Tìm kiếm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(21, 137)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 0
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.BackgroundImage = Global.QLBanHang.My.Resources.Resources.Clear
        Me.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClean.Location = New System.Drawing.Point(195, 186)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(35, 35)
        Me.btnClean.TabIndex = 10
        Me.btnClean.TabStop = False
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = Global.QLBanHang.My.Resources.Resources.Add
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Location = New System.Drawing.Point(11, 186)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(35, 35)
        Me.btnThem.TabIndex = 7
        Me.btnThem.TabStop = False
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.QLBanHang.My.Resources.Resources._Exit
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(539, 186)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 9
        Me.btnClose.TabStop = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = Global.QLBanHang.My.Resources.Resources.Bin
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.Location = New System.Drawing.Point(72, 186)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(35, 35)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.TabStop = False
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = Global.QLBanHang.My.Resources.Resources.edit
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSua.Location = New System.Drawing.Point(133, 186)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(35, 35)
        Me.btnSua.TabIndex = 8
        Me.btnSua.TabStop = False
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'txtMota
        '
        Me.txtMota.Location = New System.Drawing.Point(76, 137)
        Me.txtMota.Name = "txtMota"
        Me.txtMota.Size = New System.Drawing.Size(279, 20)
        Me.txtMota.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Mô tả :"
        '
        'cboLoai
        '
        Me.cboLoai.FormattingEnabled = True
        Me.cboLoai.Location = New System.Drawing.Point(245, 29)
        Me.cboLoai.Name = "cboLoai"
        Me.cboLoai.Size = New System.Drawing.Size(110, 21)
        Me.cboLoai.TabIndex = 44
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(76, 65)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(279, 20)
        Me.txtTen.TabIndex = 43
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(76, 29)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(107, 20)
        Me.txtMa.TabIndex = 37
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(246, 101)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(109, 20)
        Me.txtGia.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Loại SP :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Đơn vị tính :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Tên SP :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Mã SP :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDVT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboLoai)
        Me.GroupBox1.Controls.Add(Me.txtGia)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.txtMota)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 168)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Đơn giá :"
        '
        'txtDVT
        '
        Me.txtDVT.Location = New System.Drawing.Point(76, 101)
        Me.txtDVT.Name = "txtDVT"
        Me.txtDVT.Size = New System.Drawing.Size(107, 20)
        Me.txtDVT.TabIndex = 3
        '
        'frmSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 491)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sản Phẩm"
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSP As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents txtMota As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboLoai As System.Windows.Forms.ComboBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDVT As System.Windows.Forms.TextBox
    Friend WithEvents bsSP As System.Windows.Forms.BindingSource
    Friend WithEvents txtTimTen As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTimLoai As System.Windows.Forms.TextBox
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnHuy As System.Windows.Forms.Button
End Class
