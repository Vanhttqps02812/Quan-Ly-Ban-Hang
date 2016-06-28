<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHD))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.txtTimLoai = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTimTen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtThang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNgay = New System.Windows.Forms.TextBox()
        Me.lblNgay = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSP = New System.Windows.Forms.ComboBox()
        Me.cboKH = New System.Windows.Forms.ComboBox()
        Me.dtpHD = New System.Windows.Forms.DateTimePicker()
        Me.txtThanhtien = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvHD = New System.Windows.Forms.DataGridView()
        Me.bsHD = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTim)
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Controls.Add(Me.txtTimLoai)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTimTen)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtNam)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtThang)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNgay)
        Me.GroupBox2.Controls.Add(Me.lblNgay)
        Me.GroupBox2.Location = New System.Drawing.Point(379, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 136)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tìm kiếm"
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(114, 107)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(75, 23)
        Me.btnTim.TabIndex = 11
        Me.btnTim.Text = "Tìm kiếm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(33, 107)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 10
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'txtTimLoai
        '
        Me.txtTimLoai.Location = New System.Drawing.Point(56, 77)
        Me.txtTimLoai.Name = "txtTimLoai"
        Me.txtTimLoai.Size = New System.Drawing.Size(161, 20)
        Me.txtTimLoai.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Loại SP"
        '
        'txtTimTen
        '
        Me.txtTimTen.Location = New System.Drawing.Point(56, 52)
        Me.txtTimTen.Name = "txtTimTen"
        Me.txtTimTen.Size = New System.Drawing.Size(161, 20)
        Me.txtTimTen.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Tên KH"
        '
        'txtNam
        '
        Me.txtNam.Location = New System.Drawing.Point(175, 21)
        Me.txtNam.MaxLength = 4
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(42, 20)
        Me.txtNam.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Năm"
        '
        'txtThang
        '
        Me.txtThang.Location = New System.Drawing.Point(114, 21)
        Me.txtThang.MaxLength = 2
        Me.txtThang.Name = "txtThang"
        Me.txtThang.Size = New System.Drawing.Size(20, 20)
        Me.txtThang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tháng"
        '
        'txtNgay
        '
        Me.txtNgay.Location = New System.Drawing.Point(44, 21)
        Me.txtNgay.MaxLength = 2
        Me.txtNgay.Name = "txtNgay"
        Me.txtNgay.Size = New System.Drawing.Size(20, 20)
        Me.txtNgay.TabIndex = 1
        '
        'lblNgay
        '
        Me.lblNgay.AutoSize = True
        Me.lblNgay.Location = New System.Drawing.Point(6, 25)
        Me.lblNgay.Name = "lblNgay"
        Me.lblNgay.Size = New System.Drawing.Size(32, 13)
        Me.lblNgay.TabIndex = 0
        Me.lblNgay.Text = "Ngày"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(297, 154)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Location = New System.Drawing.Point(12, 154)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 30)
        Me.btnThem.TabIndex = 7
        Me.btnThem.TabStop = False
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(527, 154)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 30)
        Me.btnClose.TabIndex = 9
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.Location = New System.Drawing.Point(107, 154)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 30)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.TabStop = False
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSua.Location = New System.Drawing.Point(202, 154)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 30)
        Me.btnSua.TabIndex = 8
        Me.btnSua.TabStop = False
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSP)
        Me.GroupBox1.Controls.Add(Me.cboKH)
        Me.GroupBox1.Controls.Add(Me.dtpHD)
        Me.GroupBox1.Controls.Add(Me.txtThanhtien)
        Me.GroupBox1.Controls.Add(Me.txtSoLuong)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMaHD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 136)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'cboSP
        '
        Me.cboSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboSP.FormattingEnabled = True
        Me.cboSP.Location = New System.Drawing.Point(77, 77)
        Me.cboSP.Name = "cboSP"
        Me.cboSP.Size = New System.Drawing.Size(275, 21)
        Me.cboSP.TabIndex = 13
        '
        'cboKH
        '
        Me.cboKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboKH.FormattingEnabled = True
        Me.cboKH.Location = New System.Drawing.Point(77, 52)
        Me.cboKH.Name = "cboKH"
        Me.cboKH.Size = New System.Drawing.Size(275, 21)
        Me.cboKH.Sorted = True
        Me.cboKH.TabIndex = 12
        '
        'dtpHD
        '
        Me.dtpHD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHD.Location = New System.Drawing.Point(240, 21)
        Me.dtpHD.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpHD.Name = "dtpHD"
        Me.dtpHD.Size = New System.Drawing.Size(115, 20)
        Me.dtpHD.TabIndex = 1
        '
        'txtThanhtien
        '
        Me.txtThanhtien.Location = New System.Drawing.Point(240, 108)
        Me.txtThanhtien.Name = "txtThanhtien"
        Me.txtThanhtien.ReadOnly = True
        Me.txtThanhtien.Size = New System.Drawing.Size(115, 20)
        Me.txtThanhtien.TabIndex = 7
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(76, 108)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(84, 20)
        Me.txtSoLuong.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Ngày lập HD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Thành tiên"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Số lượng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tên SP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tên KH"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(76, 21)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(84, 20)
        Me.txtMaHD.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã HD"
        '
        'dgvHD
        '
        Me.dgvHD.AllowUserToAddRows = False
        Me.dgvHD.AllowUserToDeleteRows = False
        Me.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHD.Location = New System.Drawing.Point(11, 190)
        Me.dgvHD.Name = "dgvHD"
        Me.dgvHD.ReadOnly = True
        Me.dgvHD.Size = New System.Drawing.Size(591, 209)
        Me.dgvHD.TabIndex = 38
        '
        'frmHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 411)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvHD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa Đơn"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSP As System.Windows.Forms.ComboBox
    Friend WithEvents cboKH As System.Windows.Forms.ComboBox
    Friend WithEvents dtpHD As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtThanhtien As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvHD As System.Windows.Forms.DataGridView
    Friend WithEvents bsHD As System.Windows.Forms.BindingSource
    Friend WithEvents txtNgay As System.Windows.Forms.TextBox
    Friend WithEvents lblNgay As System.Windows.Forms.Label
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents txtTimLoai As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTimTen As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNam As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtThang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
