<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangnhap))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tlsmenuKhachhang = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlmenuHoadon = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlmenuChitiethd = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ptbthunhat = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Ptbthunhat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Quản Lý Bán Hàng - PS03474"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(107, 281)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(278, 31)
        Me.Lbl1.TabIndex = 18
        Me.Lbl1.Text = "Điện Toán Đám Mây"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsmenuKhachhang, Me.TlmenuHoadon, Me.TlmenuChitiethd})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(517, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tlsmenuKhachhang
        '
        Me.tlsmenuKhachhang.Name = "tlsmenuKhachhang"
        Me.tlsmenuKhachhang.Size = New System.Drawing.Size(84, 20)
        Me.tlsmenuKhachhang.Text = "Khách Hàng"
        '
        'TlmenuHoadon
        '
        Me.TlmenuHoadon.Name = "TlmenuHoadon"
        Me.TlmenuHoadon.Size = New System.Drawing.Size(66, 20)
        Me.TlmenuHoadon.Text = "Hóa Đơn"
        '
        'TlmenuChitiethd
        '
        Me.TlmenuChitiethd.Name = "TlmenuChitiethd"
        Me.TlmenuChitiethd.Size = New System.Drawing.Size(138, 20)
        Me.TlmenuChitiethd.Text = "Tìm Kiếm Khách Hàng"
        '
        'Ptbthunhat
        '
        Me.Ptbthunhat.BackgroundImage = Global.Quanlykhachhangps03474.My.Resources.Resources.Capture1
        Me.Ptbthunhat.ErrorImage = CType(resources.GetObject("Ptbthunhat.ErrorImage"), System.Drawing.Image)
        Me.Ptbthunhat.InitialImage = CType(resources.GetObject("Ptbthunhat.InitialImage"), System.Drawing.Image)
        Me.Ptbthunhat.Location = New System.Drawing.Point(0, 85)
        Me.Ptbthunhat.Name = "Ptbthunhat"
        Me.Ptbthunhat.Size = New System.Drawing.Size(517, 193)
        Me.Ptbthunhat.TabIndex = 17
        Me.Ptbthunhat.TabStop = False
        '
        'frmDangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = Global.Quanlykhachhangps03474.My.Resources.Resources.sapphire_blue
        Me.ClientSize = New System.Drawing.Size(517, 315)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Ptbthunhat)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmDangnhap"
        Me.Text = "Đăng Nhập"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Ptbthunhat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Ptbthunhat As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tlsmenuKhachhang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TlmenuHoadon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TlmenuChitiethd As System.Windows.Forms.ToolStripMenuItem
End Class
