<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTK))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTK = New System.Windows.Forms.DataGridView()
        Me.bsTK = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnKH_SP = New System.Windows.Forms.Button()
        Me.cboLoai = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnQuy = New System.Windows.Forms.Button()
        Me.cboQuy = New System.Windows.Forms.ComboBox()
        Me.txtTKQuy = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        CType(Me.dgvTK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Thống kê "
        '
        'dgvTK
        '
        Me.dgvTK.AllowUserToAddRows = False
        Me.dgvTK.AllowUserToDeleteRows = False
        Me.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTK.Location = New System.Drawing.Point(12, 96)
        Me.dgvTK.Name = "dgvTK"
        Me.dgvTK.ReadOnly = True
        Me.dgvTK.Size = New System.Drawing.Size(560, 256)
        Me.dgvTK.TabIndex = 13
        '
        'btnKH_SP
        '
        Me.btnKH_SP.Location = New System.Drawing.Point(128, 37)
        Me.btnKH_SP.Name = "btnKH_SP"
        Me.btnKH_SP.Size = New System.Drawing.Size(110, 23)
        Me.btnKH_SP.TabIndex = 16
        Me.btnKH_SP.Text = "Doanh thu theo: "
        Me.btnKH_SP.UseVisualStyleBackColor = True
        '
        'cboLoai
        '
        Me.cboLoai.FormattingEnabled = True
        Me.cboLoai.Items.AddRange(New Object() {"Sản phẩm", "Khách hàng"})
        Me.cboLoai.Location = New System.Drawing.Point(244, 38)
        Me.cboLoai.Name = "cboLoai"
        Me.cboLoai.Size = New System.Drawing.Size(120, 21)
        Me.cboLoai.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(497, 67)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnQuy
        '
        Me.btnQuy.Location = New System.Drawing.Point(128, 66)
        Me.btnQuy.Name = "btnQuy"
        Me.btnQuy.Size = New System.Drawing.Size(109, 23)
        Me.btnQuy.TabIndex = 19
        Me.btnQuy.Text = "Doanh thu quý:"
        Me.btnQuy.UseVisualStyleBackColor = True
        '
        'cboQuy
        '
        Me.cboQuy.FormattingEnabled = True
        Me.cboQuy.Items.AddRange(New Object() {"Quý I", "Quý II", "Quý III", "Quý IV"})
        Me.cboQuy.Location = New System.Drawing.Point(245, 68)
        Me.cboQuy.Name = "cboQuy"
        Me.cboQuy.Size = New System.Drawing.Size(120, 21)
        Me.cboQuy.TabIndex = 20
        '
        'txtTKQuy
        '
        Me.txtTKQuy.Location = New System.Drawing.Point(406, 69)
        Me.txtTKQuy.Name = "txtTKQuy"
        Me.txtTKQuy.Size = New System.Drawing.Size(50, 20)
        Me.txtTKQuy.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Năm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Năm"
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(405, 38)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(51, 20)
        Me.txtTK.TabIndex = 23
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(497, 37)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 24
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'frmTK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 364)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.txtTK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTKQuy)
        Me.Controls.Add(Me.cboQuy)
        Me.Controls.Add(Me.btnQuy)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cboLoai)
        Me.Controls.Add(Me.btnKH_SP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông Kê"
        CType(Me.dgvTK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvTK As System.Windows.Forms.DataGridView
    Friend WithEvents bsTK As System.Windows.Forms.BindingSource
    Friend WithEvents btnKH_SP As System.Windows.Forms.Button
    Friend WithEvents cboLoai As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnQuy As System.Windows.Forms.Button
    Friend WithEvents cboQuy As System.Windows.Forms.ComboBox
    Friend WithEvents txtTKQuy As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTK As System.Windows.Forms.TextBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
End Class
