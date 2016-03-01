Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data.OleDb
Public Class frmthemkhachhang
    'khai bao biens de truy xuat database 
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=qlbh03474.mssql.somee.com;packet size=4096;user id=ps03474;pwd=ps@03474;data source=qlbh03474.mssql.somee.com;persist security info=False;initial catalog=qlbh03474"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    

    Private Sub themkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng',gioitinh as 'Giới Tính' ,Diachi as 'Địa chỉ', dienthoai as 'SĐT' from MAKHACHHANG ", connect)
        db.Clear()
        xem.Fill(db)
        dgvKH.DataSource = db.DefaultView


    End Sub

    Private Sub btntimkiemnangcao_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        CheckBox1.CheckState = Nothing
        CheckBox2.CheckState = Nothing
        conn.Open()
        Dim sql As String = "select MKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng',gioitinh as 'Giới Tính', diachi as 'Địa chỉ', dienthoai as 'SĐT' from MAKHACHHANG where MKH like '%" & txtMaKH.Text & "%' and tenKH like'%" & txtTenkh.Text & "%' and dienthoai like'%" & txtSDT.Text & "%'and diachi like '%" & txtAdd.Text & "%'"
        Dim xem As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        db.Clear()
        xem.Fill(db)
        conn.Close()
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub dgvKH_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellClick
      
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox2.CheckState = CheckState.Unchecked
        End If
        If CheckBox2.CheckState = CheckState.Checked Then
            CheckBox1.CheckState = CheckState.Unchecked
        End If
        Try
            Dim click As Integer = dgvKH.CurrentCell.RowIndex
            txtMaKH.Text = dgvKH.Item(0, click).Value
            txtTenkh.Text = dgvKH.Item(1, click).Value
            If dgvKH.Item(2, click).Value = "1" Then
                CheckBox1.CheckState = CheckState.Checked

            End If
            If dgvKH.Item(2, click).Value = "0" Then

                CheckBox2.CheckState = CheckState.Checked
            End If
            txtAdd.Text = dgvKH.Item(3, click).Value
            txtSDT.Text = dgvKH.Item(4, click).Value
        Catch ex As Exception
            MsgBox("Lỗi Dữ Liệu")
        End Try

    End Sub
    

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from MAKHACHHANG where MKH=@MKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MKH", txtMaKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMaKH.Text = Nothing
                    txtTenkh.Text = Nothing
                    txtAdd.Text = Nothing
                    txtSDT.Text = Nothing
                    CheckBox1.CheckState = Nothing
                    CheckBox2.CheckState = Nothing

                    txtMaKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
      
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng',gioitinh as 'Giới Tính', diachi as 'Địa chỉ', dienthoai as 'SĐT'from MAKHACHHANG", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update MAKHACHHANG set MKH=@MKH, TenKH=@TenKH, gioitinh=@gioitinh,diachi=@diachi, dienthoai=@dienthoai where MKH=@MKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenkh.Focus()
                    If txtAdd.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtAdd.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSDT.Focus()
                            If CheckBox1.CheckState = CheckState.Unchecked And CheckBox2.CheckState = CheckState.Unchecked Then
                                MessageBox.Show("Bạn chưa chọn giới tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                CheckBox1.Focus()
                            Else

                                addupdate.Parameters.AddWithValue("@MKH", txtMaKH.Text)
                                addupdate.Parameters.AddWithValue("@TenKH", txtTenkh.Text)
                                addupdate.Parameters.AddWithValue("@diachi", txtAdd.Text)
                                addupdate.Parameters.AddWithValue("@dienthoai", txtSDT.Text)
                                If CheckBox1.CheckState = CheckState.Checked Then
                                    addupdate.Parameters.AddWithValue("@gioitinh", 1)
                                Else
                                    addupdate.Parameters.AddWithValue("@gioitinh", 0)
                                End If

                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMaKH.Text = Nothing
                                txtTenkh.Text = Nothing
                                txtAdd.Text = Nothing
                                txtSDT.Text = Nothing
                                CheckBox1.CheckState = Nothing
                                CheckBox2.CheckState = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into MAKHACHHANG values(@MAKH,@TENKH,@GIOITINH,@DIACHI,@SDT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtAdd.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If CheckBox1.CheckState = CheckState.Unchecked And CheckBox2.CheckState = CheckState.Unchecked Then
                            MessageBox.Show("Bạn chưa chọn giới tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            CheckBox1.Focus()
                        Else
                            save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                            If CheckBox1.CheckState = CheckState.Checked Then
                                save.Parameters.AddWithValue("@GIOITINH", 1)
                            Else
                                save.Parameters.AddWithValue("@GIOITINH", 0)
                            End If
                            save.Parameters.AddWithValue("@TENKH", txtTenkh.Text)
                            save.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                            save.Parameters.AddWithValue("@SDT", txtSDT.Text)

                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaKH.Text = Nothing
                            txtTenkh.Text = Nothing
                            txtAdd.Text = Nothing
                            txtSDT.Text = Nothing
                            CheckBox1.CheckState = Nothing
                            CheckBox2.CheckState = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng',gioitinh as 'Giới Tính', diachi as 'Địa chỉ', dienthoai as 'SĐT'from MAKHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub


   

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng',gioitinh as 'Giới Tính' ,Diachi as 'Địa chỉ', dienthoai as 'SĐT' from MAKHACHHANG ", connect)
        db.Clear()
        xem.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub
End Class