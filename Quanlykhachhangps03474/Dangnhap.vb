Public Class frmDangnhap

    Private Sub tlsmenuKhachhang_Click(sender As Object, e As EventArgs) Handles tlsmenuKhachhang.Click

        ' frmthemkhachhang.MdiParent = Me
        frmthemkhachhang.Show()
        '  frmthemkhachhang.BringToFront()
        ' frmDangnhap.Hide()
    End Sub

    Private Sub TlmenuHoadon_Click(sender As Object, e As EventArgs) Handles TlmenuHoadon.Click
        frmhoadon.Show()
    End Sub

    Private Sub frmDangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TlmenuChitiethd_Click(sender As Object, e As EventArgs) Handles TlmenuChitiethd.Click
        frmTimkiemKH.Show()
    End Sub
End Class