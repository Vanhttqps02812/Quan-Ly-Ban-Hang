<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKH))
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.txtSdt = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTimTen = New System.Windows.Forms.TextBox()
        Me.txtTimMa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.bsKH = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDC
        '
        Me.txtDC.Location = New System.Drawing.Point(68, 149)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(286, 20)
        Me.txtDC.TabIndex = 18
        '
        'txtSdt
        '
        Me.txtSdt.Location = New System.Drawing.Point(68, 120)
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(286, 20)
        Me.txtSdt.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(68, 91)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(286, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(68, 62)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(286, 20)
        Me.txtTen.TabIndex = 13
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(68, 33)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(80, 20)
        Me.txtMa.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Địa chỉ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SĐT :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tên KH :"
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(19, 36)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(43, 13)
        Me.lblMaKH.TabIndex = 12
        Me.lblMaKH.Text = "MaKH :"
        '
        'dgvKH
        '
        Me.dgvKH.AllowUserToAddRows = False
        Me.dgvKH.AllowUserToDeleteRows = False
        Me.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(10, 228)
        Me.dgvKH.MultiSelect = False
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.ReadOnly = True
        Me.dgvKH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKH.Size = New System.Drawing.Size(564, 254)
        Me.dgvKH.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 169)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin khách hàng"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTim)
        Me.GroupBox1.Controls.Add(Me.btnHuy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTimTen)
        Me.GroupBox1.Controls.Add(Me.txtTimMa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(377, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 169)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(104, 131)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(75, 23)
        Me.btnTim.TabIndex = 4
        Me.btnTim.Text = "Tìm kiếm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(23, 131)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 3
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tên KH"
        '
        'txtTimTen
        '
        Me.txtTimTen.Location = New System.Drawing.Point(9, 97)
        Me.txtTimTen.Name = "txtTimTen"
        Me.txtTimTen.Size = New System.Drawing.Size(182, 20)
        Me.txtTimTen.TabIndex = 1
        '
        'txtTimMa
        '
        Me.txtTimMa.Location = New System.Drawing.Point(9, 42)
        Me.txtTimMa.Name = "txtTimMa"
        Me.txtTimMa.Size = New System.Drawing.Size(182, 20)
        Me.txtTimMa.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mã KH"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.QLBanHang.My.Resources.Resources._Exit
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(539, 187)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 19
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.BackgroundImage = Global.QLBanHang.My.Resources.Resources.Clear
        Me.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClean.Location = New System.Drawing.Point(195, 187)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(35, 35)
        Me.btnClean.TabIndex = 10
        Me.btnClean.TabStop = False
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = Global.QLBanHang.My.Resources.Resources.edit
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSua.Location = New System.Drawing.Point(134, 187)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(35, 35)
        Me.btnSua.TabIndex = 8
        Me.btnSua.TabStop = False
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = Global.QLBanHang.My.Resources.Resources.Bin
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.Location = New System.Drawing.Point(73, 187)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(35, 35)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.TabStop = False
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = Global.QLBanHang.My.Resources.Resources.Add
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Location = New System.Drawing.Point(10, 187)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(35, 35)
        Me.btnThem.TabIndex = 7
        Me.btnThem.TabStop = False
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 494)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.txtSdt)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtMa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách Hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDC As System.Windows.Forms.TextBox
    Friend WithEvents txtSdt As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents dgvKH As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bsKH As System.Windows.Forms.BindingSource
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTimTen As System.Windows.Forms.TextBox
    Friend WithEvents txtTimMa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
