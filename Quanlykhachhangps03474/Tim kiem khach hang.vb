Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmTimkiemKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=qlbh03474.mssql.somee.com;packet size=4096;user id=ps03474;pwd=ps@03474;data source=qlbh03474.mssql.somee.com;persist security info=False;initial catalog=qlbh03474"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        conn.Open()
        Dim sql As String = "select * from MAKHACHHANG where TenKH like '%" & txtTim.Text & "%'"
        Dim xem As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        db.Clear()
        xem.Fill(db)
        conn.Close()
        dgvHT.DataSource = db.DefaultView
    End Sub
End Class