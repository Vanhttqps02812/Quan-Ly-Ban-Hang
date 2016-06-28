<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblKH = New System.Windows.Forms.Label()
        Me.lblGrInf = New System.Windows.Forms.Label()
        Me.lblGrHD = New System.Windows.Forms.Label()
        Me.lblGrSP = New System.Windows.Forms.Label()
        Me.lblGrKH = New System.Windows.Forms.Label()
        Me.btnInf = New System.Windows.Forms.Button()
        Me.btnTK = New System.Windows.Forms.Button()
        Me.btnHD = New System.Windows.Forms.Button()
        Me.btnSP = New System.Windows.Forms.Button()
        Me.btnKH = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(365, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 80)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "THỐNG KÊ DOANH THU"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 80)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "THÔNG TIN SẢN PHẨM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 80)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "THÔNG TIN HÓA ĐƠN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKH
        '
        Me.lblKH.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblKH.Location = New System.Drawing.Point(110, 60)
        Me.lblKH.Name = "lblKH"
        Me.lblKH.Size = New System.Drawing.Size(125, 80)
        Me.lblKH.TabIndex = 16
        Me.lblKH.Text = "THÔNG TIN KHÁCH HÀNG"
        Me.lblKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGrInf
        '
        Me.lblGrInf.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrInf.Location = New System.Drawing.Point(265, 170)
        Me.lblGrInf.Name = "lblGrInf"
        Me.lblGrInf.Size = New System.Drawing.Size(240, 110)
        Me.lblGrInf.TabIndex = 5
        '
        'lblGrHD
        '
        Me.lblGrHD.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrHD.Location = New System.Drawing.Point(10, 170)
        Me.lblGrHD.Name = "lblGrHD"
        Me.lblGrHD.Size = New System.Drawing.Size(240, 110)
        Me.lblGrHD.TabIndex = 6
        '
        'lblGrSP
        '
        Me.lblGrSP.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrSP.Location = New System.Drawing.Point(265, 45)
        Me.lblGrSP.Name = "lblGrSP"
        Me.lblGrSP.Size = New System.Drawing.Size(225, 110)
        Me.lblGrSP.TabIndex = 7
        '
        'lblGrKH
        '
        Me.lblGrKH.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrKH.Location = New System.Drawing.Point(10, 45)
        Me.lblGrKH.Name = "lblGrKH"
        Me.lblGrKH.Size = New System.Drawing.Size(240, 110)
        Me.lblGrKH.TabIndex = 8
        '
        'btnInf
        '
        Me.btnInf.BackgroundImage = Global.QLBanHang.My.Resources.Resources.info
        Me.btnInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInf.Location = New System.Drawing.Point(479, 257)
        Me.btnInf.Name = "btnInf"
        Me.btnInf.Size = New System.Drawing.Size(23, 23)
        Me.btnInf.TabIndex = 17
        Me.btnInf.UseVisualStyleBackColor = True
        '
        'btnTK
        '
        Me.btnTK.BackgroundImage = Global.QLBanHang.My.Resources.Resources.bao_cao_thong_ke
        Me.btnTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTK.Location = New System.Drawing.Point(279, 186)
        Me.btnTK.Name = "btnTK"
        Me.btnTK.Size = New System.Drawing.Size(80, 80)
        Me.btnTK.TabIndex = 9
        Me.btnTK.TabStop = False
        Me.btnTK.UseVisualStyleBackColor = True
        '
        'btnHD
        '
        Me.btnHD.BackgroundImage = Global.QLBanHang.My.Resources.Resources.invoice
        Me.btnHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHD.Location = New System.Drawing.Point(24, 186)
        Me.btnHD.Name = "btnHD"
        Me.btnHD.Size = New System.Drawing.Size(80, 80)
        Me.btnHD.TabIndex = 10
        Me.btnHD.TabStop = False
        Me.btnHD.UseVisualStyleBackColor = True
        '
        'btnSP
        '
        Me.btnSP.BackgroundImage = Global.QLBanHang.My.Resources.Resources.product
        Me.btnSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSP.Location = New System.Drawing.Point(279, 61)
        Me.btnSP.Name = "btnSP"
        Me.btnSP.Size = New System.Drawing.Size(80, 80)
        Me.btnSP.TabIndex = 11
        Me.btnSP.TabStop = False
        Me.btnSP.UseVisualStyleBackColor = True
        '
        'btnKH
        '
        Me.btnKH.BackgroundImage = Global.QLBanHang.My.Resources.Resources.customer
        Me.btnKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnKH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKH.Location = New System.Drawing.Point(24, 61)
        Me.btnKH.Name = "btnKH"
        Me.btnKH.Size = New System.Drawing.Size(80, 80)
        Me.btnKH.TabIndex = 12
        Me.btnKH.TabStop = False
        Me.btnKH.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 291)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblKH)
        Me.Controls.Add(Me.btnTK)
        Me.Controls.Add(Me.btnHD)
        Me.Controls.Add(Me.btnSP)
        Me.Controls.Add(Me.lblGrInf)
        Me.Controls.Add(Me.btnKH)
        Me.Controls.Add(Me.lblGrHD)
        Me.Controls.Add(Me.lblGrSP)
        Me.Controls.Add(Me.lblGrKH)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý bán hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInf As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblKH As System.Windows.Forms.Label
    Friend WithEvents btnTK As System.Windows.Forms.Button
    Friend WithEvents btnHD As System.Windows.Forms.Button
    Friend WithEvents btnSP As System.Windows.Forms.Button
    Friend WithEvents lblGrInf As System.Windows.Forms.Label
    Friend WithEvents btnKH As System.Windows.Forms.Button
    Friend WithEvents lblGrHD As System.Windows.Forms.Label
    Friend WithEvents lblGrSP As System.Windows.Forms.Label
    Friend WithEvents lblGrKH As System.Windows.Forms.Label

End Class
