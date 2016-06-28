Imports System.Data.SqlClient

Public Class frmKH
    Private Sub FillKH()
        Dim Sql As String =
            <sql>
                SELECT * FROM Khach_Hang
            </sql>
        Connect(Sql, "Khach_Hang")
        bsKH.DataSource = ds.Tables("Khach_Hang")
        dgvKH.DataSource = bsKH
        bsKH.ResetBindings(False)
    End Sub

    Private Sub Clear()
        txtMa.Clear()
        txtTen.Clear()
        txtEmail.Clear()
        txtSdt.Clear()
        txtDC.Clear()
    End Sub

    Private Sub frmKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillKH()
    End Sub

    Private Sub dgvKH_SelectionChanged(sender As Object, e As EventArgs) Handles dgvKH.SelectionChanged
        Try
            Dim RowView As DataRowView = bsKH.Current
            Dim Row As DataRow = RowView.Row

            txtMa.Text = Row("MaKH")
            txtTen.Text = Row("TenKH")
            txtEmail.Text = Row("Email")
            txtSdt.Text = Row("SDT")
            txtDC.Text = Row("DiaChi")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                DELETE FROM Khach_Hang
                WHERE        (Khach_Hang.MaKH = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMa.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
            <sql>
                insert into Khach_Hang(MaKH, TenKH, email, SDT, DiaChi)
                values ('{0}', N'{1}', '{2}', '{3}', N'{4}')
            </sql>

        Sql = String.Format(Sql, txtMa.Text, txtTen.Text, txtEmail.Text, txtSdt.Text, txtDC.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        Clear()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
            <sql>
                UPDATE      Khach_Hang
                SET         TenKH =N'{0}', Email ='{1}', SDT ='{2}', DiaChi =N'{3}'
                WHERE        (MaKH = '{4}')
            </sql>

        Sql = String.Format(Sql, txtTen.Text, txtEmail.Text, txtSdt.Text, txtDC.Text, txtMa.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        Dim Sql As String =
            <sql>
                SELECT  *
                FROM    Khach_Hang
                WHERE   (MaKH like '%{0}%' and TenKH like N'%{1}%')
            </sql>

        Sql = String.Format(Sql, txtTimMa.Text, txtTimTen.Text)

        Connect(Sql, "Khach_Hang")

        dgvKH.DataSource = ds.Tables("Khach_Hang")

    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        txtTimMa.Clear()
        txtTimTen.Clear()
        FillKH()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmHome.Show()
    End Sub
End Class