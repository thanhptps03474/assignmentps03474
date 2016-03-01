Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=qlbh03474.mssql.somee.com;packet size=4096;user id=ps03474;pwd=ps@03474;data source=qlbh03474.mssql.somee.com;persist security info=False;initial catalog=qlbh03474"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng',gioitinh as'Giới Tính', diachi as 'Địa chỉ', dienthoai as 'SĐT' from MAKHACHHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    
End Class
