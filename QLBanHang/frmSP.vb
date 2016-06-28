Imports System.Data.SqlClient

Public Class frmSP

    Private Sub Clear()
        txtDVT.Clear()
        txtGia.Clear()
        txtMa.Clear()
        txtMota.Clear()
        txtTen.Clear()
        cboLoai.SelectedIndex = 0
    End Sub

    Private Sub FillSP()
        Dim Sql As String =
            <sql>
                SELECT San_Pham.MaSP, San_Pham.TenSP, Loai_San_Pham.TenLoaiSP, San_Pham.DVT, San_Pham.Gia, San_Pham.MoTa
                FROM Loai_San_Pham INNER JOIN San_Pham ON Loai_San_Pham.MaLoaiSP = San_Pham.MaLoai
            </sql>
        Connect(Sql, "SanPham")
        bsSP.DataSource = ds.Tables("SanPham")
        dgvSP.DataSource = bsSP
        bsSP.ResetBindings(False)
    End Sub

    Private Sub SP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sql As String = "SELECT * FROM Loai_San_Pham"
        Connect(Sql, "Loai_San_Pham")
        cboLoai.DataSource = ds.Tables("Loai_San_Pham")
        cboLoai.DisplayMember = "TenLoaiSP"
        cboLoai.ValueMember = "MaLoaiSP"
        FillSP()
    End Sub

    Private Sub dgvSP_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSP.SelectionChanged
        Try
            Dim RowView As DataRowView = bsSP.Current
            Dim Row As DataRow = RowView.Row

            txtMa.Text = Row("MaSP")
            txtTen.Text = Row("TenSP")
            cboLoai.Text = Row("TenLoaiSP")
            txtDVT.Text = Row("DVT")
            txtGia.Text = Row("Gia")
            txtMota.Text = Row("MoTa")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                delete from San_Pham where (MaSP='{0}')
            </sql>
        Sql = String.Format(Sql, txtMa.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        Clear()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        Dim Sql As String =
            <sql>
                UPDATE  San_Pham
                SET     TenSP = N'{0}', MaLoai = '{1}', DVT = N'{2}', Gia = '{3}', MoTa = N'{4}'
                WHERE   (MaSP = '{5}')
            </sql>

        Sql = String.Format(Sql, txtTen.Text, cboLoai.SelectedValue, txtDVT.Text, txtGia.Text, txtMota.Text, txtMa.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
            <sql>
                INSERT INTO San_Pham (MaSP, TenSP, MaLoai, DVT, Gia, MoTa)
                VALUES  ('{0}', N'{1}', '{2}', N'{3}', '{4}', N'{5}')
            </sql>

        Sql = String.Format(Sql, txtMa.Text, txtTen.Text, cboLoai.SelectedValue, txtDVT.Text, txtGia.Text, txtMota.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        Dim Sql As String =
            <sql>
                SELECT San_Pham.MaSP, San_Pham.TenSP, Loai_San_Pham.TenLoaiSP, San_Pham.DVT, San_Pham.Gia, San_Pham.MoTa
                FROM Loai_San_Pham INNER JOIN San_Pham ON Loai_San_Pham.MaLoaiSP = San_Pham.MaLoai
                WHERE Loai_San_Pham.TenLoaiSP like N'%{0}%' and San_Pham.TenSP like N'%{1}%'
            </sql>
        Sql = String.Format(Sql, txtTimLoai.Text, txtTimTen.Text)

        Connect(Sql, "San_Pham")

        dgvSP.DataSource = ds.Tables("San_Pham")
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        txtTimLoai.Clear()
        txtTimTen.Clear()
        FillSP()
    End Sub
End Class