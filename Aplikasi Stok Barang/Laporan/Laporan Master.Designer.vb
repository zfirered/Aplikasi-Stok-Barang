<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Master
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_barang = New System.Windows.Forms.Button()
        Me.btn_supplier = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_customer)
        Me.GroupBox1.Controls.Add(Me.btn_supplier)
        Me.GroupBox1.Controls.Add(Me.btn_barang)
        Me.GroupBox1.Controls.Add(Me.btn_user)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 76)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(776, 362)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btn_user
        '
        Me.btn_user.Location = New System.Drawing.Point(6, 19)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(75, 23)
        Me.btn_user.TabIndex = 0
        Me.btn_user.Text = "User"
        Me.btn_user.UseVisualStyleBackColor = True
        '
        'btn_barang
        '
        Me.btn_barang.Location = New System.Drawing.Point(87, 19)
        Me.btn_barang.Name = "btn_barang"
        Me.btn_barang.Size = New System.Drawing.Size(75, 23)
        Me.btn_barang.TabIndex = 1
        Me.btn_barang.Text = "Barang"
        Me.btn_barang.UseVisualStyleBackColor = True
        '
        'btn_supplier
        '
        Me.btn_supplier.Location = New System.Drawing.Point(168, 20)
        Me.btn_supplier.Name = "btn_supplier"
        Me.btn_supplier.Size = New System.Drawing.Size(75, 22)
        Me.btn_supplier.TabIndex = 2
        Me.btn_supplier.Text = "Supplier"
        Me.btn_supplier.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.Location = New System.Drawing.Point(249, 20)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(75, 23)
        Me.btn_customer.TabIndex = 3
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'Laporan_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Laporan_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Laporan Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_supplier As Button
    Friend WithEvents btn_barang As Button
    Friend WithEvents btn_user As Button
End Class
