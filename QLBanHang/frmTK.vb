Public Class frmTK

    Private Sub btnKH_SP_Click(sender As Object, e As EventArgs) Handles btnKH_SP.Click
        Select Case cboLoai.SelectedIndex
            Case 0
                Dim Sql As String =
                    <sql>
                        SELECT	San_Pham.TenSP,Loai_San_Pham.TenLoaiSP, Sum(Chi_Tiet_Hoa_Don.SoLuong) as N'Số lượng', 
                                sum(Chi_Tiet_Hoa_Don.SoLuong * San_Pham.Gia) as N'Thành tiền'
                        FROM	Chi_Tiet_Hoa_Don INNER JOIN
		                        Hoa_Don ON Chi_Tiet_Hoa_Don.MaHD = Hoa_Don.MaHD INNER JOIN
		                        Khach_Hang ON Hoa_Don.MaKH = Khach_Hang.MaKH INNER JOIN
		                        San_Pham ON Chi_Tiet_Hoa_Don.MaSP = San_Pham.MaSP INNER JOIN
		                        Loai_San_Pham ON San_Pham.MaLoai = Loai_San_Pham.MaLoaiSP
                        WHERE   YEAR(Hoa_Don.NgayLapHD) = {0}
                        GROUP BY San_Pham.TenSP, Loai_San_Pham.TenLoaiSP
                    </sql>
                Sql = String.Format(Sql, txtTK.Text)
                Connect(Sql, "SP")
                dgvTK.DataSource = ds.Tables("SP")
            Case 1
                Dim Sql As String =
                    <sql>
                        SELECT	Khach_Hang.TenKH,sum(Chi_Tiet_Hoa_Don.SoLuong) as N'Số lượng', 
                                Sum(Chi_Tiet_Hoa_Don.SoLuong * San_Pham.Gia)  As Total
                        FROM	Chi_Tiet_Hoa_Don INNER JOIN
		                        Hoa_Don ON Chi_Tiet_Hoa_Don.MaHD = Hoa_Don.MaHD INNER JOIN
		                        Khach_Hang ON Hoa_Don.MaKH = Khach_Hang.MaKH INNER JOIN
		                        San_Pham ON Chi_Tiet_Hoa_Don.MaSP = San_Pham.MaSP INNER JOIN
		                        Loai_San_Pham ON San_Pham.MaLoai = Loai_San_Pham.MaLoaiSP
                        WHERE   YEAR(Hoa_Don.NgayLapHD) = {0}
                        GROUP BY	Khach_Hang.TenKH
                    </sql>
                Sql = String.Format(Sql, txtTK.Text)
                Connect(Sql, "KH")
                dgvTK.DataSource = ds.Tables("KH")
        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub btnQuy_Click(sender As Object, e As EventArgs) Handles btnQuy.Click
        Dim min, max As Integer
        Select Case cboQuy.SelectedIndex
            Case 0
                min = 1
                max = 3
            Case 1
                min = 4
                max = 6
            Case 2
                min = 7
                max = 9
            Case 3
                min = 10
                max = 12
            Case Else
                min = 1
                max = 12
        End Select
        Dim Sql As String =
            <sql>
                SELECT	Khach_Hang.TenKH, San_Pham.TenSP, Chi_Tiet_Hoa_Don.SoLuong,Hoa_Don.NgayLapHD, 
		                (Chi_Tiet_Hoa_Don.SoLuong * San_Pham.Gia) as N'Thành tiền'
                FROM	Chi_Tiet_Hoa_Don INNER JOIN
		                Hoa_Don ON Chi_Tiet_Hoa_Don.MaHD = Hoa_Don.MaHD INNER JOIN
		                Khach_Hang ON Hoa_Don.MaKH = Khach_Hang.MaKH INNER JOIN
		                San_Pham ON Chi_Tiet_Hoa_Don.MaSP = San_Pham.MaSP INNER JOIN
		                Loai_San_Pham ON San_Pham.MaLoai = Loai_San_Pham.MaLoaiSP
                WHERE	MONTH(Hoa_Don.NgayLapHD) between {0} and {1} and YEAR(Hoa_Don.NgayLapHD) = {2}
            </sql>
        Sql = String.Format(Sql, min, max, txtTKQuy.Text)
        Connect(Sql, "TK")
        dgvTK.DataSource = ds.Tables("TK")
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        cboLoai.ResetText()
        cboQuy.ResetText()
        txtTK.Clear()
        txtTKQuy.Clear()
    End Sub

End Class