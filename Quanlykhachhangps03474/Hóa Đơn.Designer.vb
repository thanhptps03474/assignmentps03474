<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhoadon))
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblNgHD = New System.Windows.Forms.Label()
        Me.lblMAHD = New System.Windows.Forms.Label()
        Me.lblDiengiai = New System.Windows.Forms.Label()
        Me.txtMHD = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtNHD = New System.Windows.Forms.TextBox()
        Me.txtCT = New System.Windows.Forms.TextBox()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKH.Location = New System.Drawing.Point(35, 29)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(100, 13)
        Me.lblMaKH.TabIndex = 0
        Me.lblMaKH.Text = "Mã Khách hàng:"
        '
        'lblNgHD
        '
        Me.lblNgHD.AutoSize = True
        Me.lblNgHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgHD.Location = New System.Drawing.Point(286, 29)
        Me.lblNgHD.Name = "lblNgHD"
        Me.lblNgHD.Size = New System.Drawing.Size(95, 13)
        Me.lblNgHD.TabIndex = 0
        Me.lblNgHD.Text = "Ngày hóa đơn :"
        '
        'lblMAHD
        '
        Me.lblMAHD.AutoSize = True
        Me.lblMAHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMAHD.Location = New System.Drawing.Point(35, 60)
        Me.lblMAHD.Name = "lblMAHD"
        Me.lblMAHD.Size = New System.Drawing.Size(84, 13)
        Me.lblMAHD.TabIndex = 0
        Me.lblMAHD.Text = "Mã hóa Đơn :"
        '
        'lblDiengiai
        '
        Me.lblDiengiai.AutoSize = True
        Me.lblDiengiai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiengiai.Location = New System.Drawing.Point(286, 60)
        Me.lblDiengiai.Name = "lblDiengiai"
        Me.lblDiengiai.Size = New System.Drawing.Size(75, 13)
        Me.lblDiengiai.TabIndex = 0
        Me.lblDiengiai.Text = "Chú Thích :"
        '
        'txtMHD
        '
        Me.txtMHD.Location = New System.Drawing.Point(140, 53)
        Me.txtMHD.Name = "txtMHD"
        Me.txtMHD.Size = New System.Drawing.Size(119, 20)
        Me.txtMHD.TabIndex = 1
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(140, 22)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(119, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'txtNHD
        '
        Me.txtNHD.Location = New System.Drawing.Point(375, 24)
        Me.txtNHD.Name = "txtNHD"
        Me.txtNHD.Size = New System.Drawing.Size(119, 20)
        Me.txtNHD.TabIndex = 1
        '
        'txtCT
        '
        Me.txtCT.Location = New System.Drawing.Point(373, 54)
        Me.txtCT.Name = "txtCT"
        Me.txtCT.Size = New System.Drawing.Size(119, 20)
        Me.txtCT.TabIndex = 1
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Location = New System.Drawing.Point(38, 94)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapnhat.TabIndex = 2
        Me.btnCapnhat.Text = "Cập Nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(164, 94)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(417, 94)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Sửa"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(292, 94)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvKH
        '
        Me.dgvKH.AllowUserToOrderColumns = True
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(38, 140)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(456, 150)
        Me.dgvKH.TabIndex = 3
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.ClientSize = New System.Drawing.Size(516, 306)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.txtCT)
        Me.Controls.Add(Me.txtNHD)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtMHD)
        Me.Controls.Add(Me.lblDiengiai)
        Me.Controls.Add(Me.lblMAHD)
        Me.Controls.Add(Me.lblNgHD)
        Me.Controls.Add(Me.lblMaKH)
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmhoadon"
        Me.Text = "Hóa_Đơn"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents lblNgHD As System.Windows.Forms.Label
    Friend WithEvents lblMAHD As System.Windows.Forms.Label
    Friend WithEvents lblDiengiai As System.Windows.Forms.Label
    Friend WithEvents txtMHD As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtNHD As System.Windows.Forms.TextBox
    Friend WithEvents txtCT As System.Windows.Forms.TextBox
    Friend WithEvents btnCapnhat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents dgvKH As System.Windows.Forms.DataGridView
End Class
