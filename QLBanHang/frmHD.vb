Public Class frmHD

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmHome.Show()
    End Sub
    Private Sub FillHD()
        Dim Sql As String =
            <sql>
                SELECT  Hoa_Don.MaHD, Hoa_Don.MaKH, Khach_Hang.TenKH, 
                        San_Pham.MaSP, San_Pham.TenSP, Loai_San_Pham.TenLoaiSP, 
                        Chi_Tiet_Hoa_Don.SoLuong, Hoa_Don.NgayLapHD, 
                        (San_Pham.Gia*Chi_Tiet_Hoa_Don.SoLuong) as ThanhTien
                FROM    Chi_Tiet_Hoa_Don INNER JOIN
                        Hoa_Don ON Chi_Tiet_Hoa_Don.MaHD = Hoa_Don.MaHD INNER JOIN
                        Khach_Hang ON Hoa_Don.MaKH = Khach_Hang.MaKH INNER JOIN
                        San_Pham ON Chi_Tiet_Hoa_Don.MaSP = San_Pham.MaSP INNER JOIN
                        Loai_San_Pham ON San_Pham.MaLoai = Loai_San_Pham.MaLoaiSP
            </sql>
        Connect(Sql, "Hoa_Don")
        bsHD.DataSource = ds.Tables("Hoa_Don")
        dgvHD.DataSource = bsHD
        bsHD.ResetBindings(False)
    End Sub

    Private Sub frmHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlKH As String = "select * from Khach_Hang"
        Connect(SqlKH, "Khach_Hang")
        cboKH.DataSource = ds.Tables("Khach_Hang")
        cboKH.DisplayMember = "TenKH"
        cboKH.ValueMember = "MaKH"

        Dim SqlSP As String = "select * from San_Pham"
        Connect(SqlSP, "San_Pham")
        cboSP.DataSource = ds.Tables("San_Pham")
        cboSP.DisplayMember = "TenSP"
        cboSP.ValueMember = "MaSP"

        FillHD()
    End Sub

    Private Sub dgvHD_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHD.SelectionChanged
        Try
            Dim RowView As DataRowView = bsHD.Current
            Dim Row As DataRow = RowView.Row

            txtMaHD.Text = Row("MaHD")
            txtSoLuong.Text = Row("SoLuong")
            dtpHD.Text = Row("NgayLapHD")
            txtThanhtien.Text = Row("ThanhTien")
            cboKH.Text = Row("TenKH")
            cboSP.Text = Row("TenSP")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim DateHD As String
        DateHD = Mid(dtpHD.Text, 7, 4) & Mid(dtpHD.Text, 4, 2) & Mid(dtpHD.Text, 1, 2)

        Dim Sql As String =
            <sql>
                INSERT INTO Hoa_Don(MaHD, MaKH, NgayLapHD)
                VALUES  ('{0}','{1}','{2}')
            </sql>
        Sql = String.Format(Sql, txtMaHD.Text, cboKH.SelectedValue, DateHD)
        ExecuteNonQuery(Sql)

        Dim Sql1 As String =
            <sql>
                INSERT INTO Chi_Tiet_Hoa_Don(MaHD, MaSP, SoLuong)
                VALUES  ('{0}','{1}','{2}')
            </sql>
        Sql1 = String.Format(Sql1, txtMaHD.Text, cboSP.SelectedValue, txtSoLuong.Text)
        ExecuteNonQuery(Sql1)

        FillHD()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMaHD.Clear()
        txtSoLuong.Clear()
        txtThanhtien.Clear()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                delete from Hoa_Don where (MaHD = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaHD.Text)

        ExecuteNonQuery(Sql)

        FillHD()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim DateHD As String
        DateHD = Mid(dtpHD.Text, 7, 4) & Mid(dtpHD.Text, 4, 2) & Mid(dtpHD.Text, 1, 2)

        Dim SqlHD As String =
            <sql>
                UPDATE  Hoa_Don
                SET     MaKH ='{0}', NgayLapHD ='{1}'
                WHERE   (MaHD = '{2}')
            </sql>
        SqlHD = String.Format(SqlHD, cboKH.SelectedValue, DateHD, txtMaHD.Text)
        ExecuteNonQuery(SqlHD)

        Dim SqlSP As String =
            <sql>
                UPDATE  Chi_Tiet_Hoa_Don
                SET     MaSP = '{0}', SoLuong = {1}
                WHERE   (MaHD = '{2}')
            </sql>
        SqlSP = String.Format(SqlSP, cboSP.SelectedValue, txtSoLuong.Text, txtMaHD.Text)
        ExecuteNonQuery(SqlSP)

        FillHD()
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        Dim Sql As String =
            <sql>
                SELECT  Hoa_Don.MaHD, Hoa_Don.MaKH, Khach_Hang.TenKH, 
                        San_Pham.MaSP, San_Pham.TenSP, Loai_San_Pham.TenLoaiSP, 
                        Chi_Tiet_Hoa_Don.SoLuong, Hoa_Don.NgayLapHD, 
                        (San_Pham.Gia*Chi_Tiet_Hoa_Don.SoLuong) as ThanhTien
                FROM    Chi_Tiet_Hoa_Don INNER JOIN
                        Hoa_Don ON Chi_Tiet_Hoa_Don.MaHD = Hoa_Don.MaHD INNER JOIN
                        Khach_Hang ON Hoa_Don.MaKH = Khach_Hang.MaKH INNER JOIN
                        San_Pham ON Chi_Tiet_Hoa_Don.MaSP = San_Pham.MaSP INNER JOIN
                        Loai_San_Pham ON San_Pham.MaLoai = Loai_San_Pham.MaLoaiSP
                WHERE   (Khach_Hang.TenKH like N'%{0}%' and
                        Loai_San_Pham.TenLoaiSP like N'%{1}%' and
                        CONVERT(varchar,Hoa_Don.NgayLapHD,103) like '%{2}%/%{3}%/%{4}%')
            </sql>
        Sql = String.Format(Sql, txtTimTen.Text, txtTimLoai.Text, txtNgay.Text, txtThang.Text, txtNam.Text)
        Connect(Sql, "Hoa_Don")
        dgvHD.DataSource = ds.Tables("Hoa_Don")
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        FillHD()
        txtNam.Clear()
        txtNgay.Clear()
        txtThang.Clear()
        txtTimLoai.Clear()
        txtTimTen.Clear()
    End Sub
End Class