Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmhoadon
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=qlbh03474.mssql.somee.com;packet size=4096;user id=ps03474;pwd=ps@03474;data source=qlbh03474.mssql.somee.com;persist security info=False;initial catalog=qlbh03474"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from CHITIETHOADON where MHD=@MHD delete from HOADON where MHD=@MHD"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If resulft = Windows.Forms.DialogResult.Yes Then
                delete.Parameters.AddWithValue("@MHD", txtMHD.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                txtMaKH.Text = Nothing
                txtMHD.Text = Nothing
                txtNHD.Text = Nothing
                txtCT.Text = Nothing

                txtMaKH.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã Hóa đơn cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select  MHD as 'Mã Hóa Đơn',MKH as 'Mã Khách Hàng',ngHD as 'Date',diengiai as 'Bình Luận' from HOADON", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView

    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        conn.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select  MHD as 'Mã Hóa Đơn',MKH as 'Mã Khách Hàng',ngHD as 'Date',diengiai as 'Bình Luận' from HOADON ", conn)
        Try

            db.Clear()

            xem.Fill(db)
            If db.Rows.Count > 0 Then
                dgvKH.DataSource = db.DefaultView

            Else
                MessageBox.Show("Không tìm thấy")
                txtMaKH.Text = Nothing
            End If

            conn.Close()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub frmhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select  MHD as 'Mã Hóa Đơn',MKH as 'Mã Khách Hàng',ngHD as 'Date',diengiai as 'Bình Luận' from HOADON ", conn)
        db.Clear()
        xem.Fill(db)
        conn.Close()
        dgvKH.DataSource = db.DefaultView
        
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellClick

        Try
            Dim click As Integer = dgvKH.CurrentCell.RowIndex
            txtMaKH.Text = dgvKH.Item(1, click).Value
            txtMHD.Text = dgvKH.Item(0, click).Value
            txtNHD.Text = dgvKH.Item(2, click).Value
            txtCT.Text = dgvKH.Item(3, click).Value
        Catch ex As Exception
            MsgBox("Lỗi Dữ Liệu")
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into HOADON values(@MHD,@MKH,@ngHD,@chuthich)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtMHD.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtNHD.Focus()
                    If txtNHD.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập ngày hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtCT.Focus()
                        If txtCT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập đánh giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            txtCT.Focus()
                        Else
                            save.Parameters.AddWithValue("@MKH", txtMaKH.Text)
                            save.Parameters.AddWithValue("@MHD", txtMHD.Text)
                            save.Parameters.AddWithValue("@ngHD", txtNHD.Text)
                            save.Parameters.AddWithValue("@chuthich", txtCT.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaKH.Text = Nothing
                            txtMHD.Text = Nothing
                            txtNHD.Text = Nothing
                            txtCT.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("mã Hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select  MHD as 'Mã Hóa Đơn',MKH as 'Mã Khách Hàng', ngHD as 'Date',diengiai as 'Bình Luận' from HOADON", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim queryupdate As String = "update HOADON set MHD=@MHD,MKH=@MKH,ngHD=@ngHD,Diengiai=@chuthich where MHD=@MHD"
        Dim addupdate As SqlCommand = New SqlCommand(queryupdate, conn)
        conn.Open()
        ' Try
        txtMaKH.Focus()
        If txtMaKH.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            txtMaKH.Focus()
            If txtMHD.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtNHD.Focus()
                If txtNHD.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập ngày hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtCT.Focus()
                    If txtCT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập đánh giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        txtCT.Focus()
                    Else
                        addupdate.Parameters.AddWithValue("@MKH", txtMaKH.Text)
                        addupdate.Parameters.AddWithValue("@MHD", txtMHD.Text)
                        addupdate.Parameters.AddWithValue("@ngHD", txtNHD.Text)
                        addupdate.Parameters.AddWithValue("@chuthich", txtCT.Text)

                        addupdate.ExecuteNonQuery()
                        MessageBox.Show("Cập nhật thành công")
                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                        txtMaKH.Text = Nothing
                        txtMHD.Text = Nothing
                        txtNHD.Text = Nothing
                        txtCT.Text = Nothing
                    End If
                End If
            End If
        End If
        ' Catch ex As Exception  'Ngược lại báo lỗi
        ' MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        '   End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select  MHD as 'Mã Hóa Đơn',MKH as 'Mã Khách Hàng',ngHD as 'Date',diengiai as 'Bình Luận' from HOADON", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub dgvKH_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick

    End Sub
End Class