<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimkiemKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimkiemKH))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.txtTim = New System.Windows.Forms.TextBox()
        Me.dgvHT = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Khách Hàng :"
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(56, 60)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(115, 37)
        Me.btnTim.TabIndex = 1
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'txtTim
        '
        Me.txtTim.Location = New System.Drawing.Point(145, 27)
        Me.txtTim.Name = "txtTim"
        Me.txtTim.Size = New System.Drawing.Size(325, 20)
        Me.txtTim.TabIndex = 2
        '
        'dgvHT
        '
        Me.dgvHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHT.Location = New System.Drawing.Point(33, 103)
        Me.dgvHT.Name = "dgvHT"
        Me.dgvHT.Size = New System.Drawing.Size(596, 203)
        Me.dgvHT.TabIndex = 3
        '
        'frmTimkiemKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.ClientSize = New System.Drawing.Size(660, 328)
        Me.Controls.Add(Me.dgvHT)
        Me.Controls.Add(Me.txtTim)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTimkiemKH"
        Me.Text = "Tìm Kiếm Khách Hàng"
        CType(Me.dgvHT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents txtTim As System.Windows.Forms.TextBox
    Friend WithEvents dgvHT As System.Windows.Forms.DataGridView
End Class
