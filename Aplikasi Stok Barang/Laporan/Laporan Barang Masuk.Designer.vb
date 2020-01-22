<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Barang_Masuk
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.list_nomor_masuk = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tgl_harian = New System.Windows.Forms.DateTimePicker()
        Me.periodik_1 = New System.Windows.Forms.DateTimePicker()
        Me.periodik_2 = New System.Windows.Forms.DateTimePicker()
        Me.tgl_bulanan = New System.Windows.Forms.DateTimePicker()
        Me.list_supplier = New System.Windows.Forms.ListBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_view_harian = New System.Windows.Forms.Button()
        Me.btn_view_periodik = New System.Windows.Forms.Button()
        Me.btn_view_bulanan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.list_nomor_masuk)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 127)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nomor Masuk"
        '
        'list_nomor_masuk
        '
        Me.list_nomor_masuk.FormattingEnabled = True
        Me.list_nomor_masuk.Location = New System.Drawing.Point(6, 19)
        Me.list_nomor_masuk.Name = "list_nomor_masuk"
        Me.list_nomor_masuk.Size = New System.Drawing.Size(120, 95)
        Me.list_nomor_masuk.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.list_supplier)
        Me.GroupBox3.Location = New System.Drawing.Point(149, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 127)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Supplier"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_view_harian)
        Me.GroupBox4.Controls.Add(Me.tgl_harian)
        Me.GroupBox4.Location = New System.Drawing.Point(355, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(147, 127)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Harian"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_view_periodik)
        Me.GroupBox5.Controls.Add(Me.periodik_2)
        Me.GroupBox5.Controls.Add(Me.periodik_1)
        Me.GroupBox5.Location = New System.Drawing.Point(508, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(152, 127)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Periodik"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btn_view_bulanan)
        Me.GroupBox6.Controls.Add(Me.tgl_bulanan)
        Me.GroupBox6.Location = New System.Drawing.Point(666, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(153, 127)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Bulanan"
        '
        'tgl_harian
        '
        Me.tgl_harian.Location = New System.Drawing.Point(6, 19)
        Me.tgl_harian.Name = "tgl_harian"
        Me.tgl_harian.Size = New System.Drawing.Size(135, 20)
        Me.tgl_harian.TabIndex = 0
        '
        'periodik_1
        '
        Me.periodik_1.Location = New System.Drawing.Point(6, 19)
        Me.periodik_1.Name = "periodik_1"
        Me.periodik_1.Size = New System.Drawing.Size(135, 20)
        Me.periodik_1.TabIndex = 1
        '
        'periodik_2
        '
        Me.periodik_2.Location = New System.Drawing.Point(6, 45)
        Me.periodik_2.Name = "periodik_2"
        Me.periodik_2.Size = New System.Drawing.Size(135, 20)
        Me.periodik_2.TabIndex = 2
        '
        'tgl_bulanan
        '
        Me.tgl_bulanan.CustomFormat = ""
        Me.tgl_bulanan.Location = New System.Drawing.Point(6, 19)
        Me.tgl_bulanan.Name = "tgl_bulanan"
        Me.tgl_bulanan.Size = New System.Drawing.Size(141, 20)
        Me.tgl_bulanan.TabIndex = 0
        '
        'list_supplier
        '
        Me.list_supplier.FormattingEnabled = True
        Me.list_supplier.Location = New System.Drawing.Point(6, 19)
        Me.list_supplier.Name = "list_supplier"
        Me.list_supplier.Size = New System.Drawing.Size(188, 95)
        Me.list_supplier.TabIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 173)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(834, 265)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btn_view_harian
        '
        Me.btn_view_harian.Location = New System.Drawing.Point(6, 91)
        Me.btn_view_harian.Name = "btn_view_harian"
        Me.btn_view_harian.Size = New System.Drawing.Size(135, 23)
        Me.btn_view_harian.TabIndex = 1
        Me.btn_view_harian.Text = "View"
        Me.btn_view_harian.UseVisualStyleBackColor = True
        '
        'btn_view_periodik
        '
        Me.btn_view_periodik.Location = New System.Drawing.Point(6, 91)
        Me.btn_view_periodik.Name = "btn_view_periodik"
        Me.btn_view_periodik.Size = New System.Drawing.Size(135, 23)
        Me.btn_view_periodik.TabIndex = 3
        Me.btn_view_periodik.Text = "View"
        Me.btn_view_periodik.UseVisualStyleBackColor = True
        '
        'btn_view_bulanan
        '
        Me.btn_view_bulanan.Location = New System.Drawing.Point(6, 91)
        Me.btn_view_bulanan.Name = "btn_view_bulanan"
        Me.btn_view_bulanan.Size = New System.Drawing.Size(141, 23)
        Me.btn_view_bulanan.TabIndex = 2
        Me.btn_view_bulanan.Text = "View"
        Me.btn_view_bulanan.UseVisualStyleBackColor = True
        '
        'Laporan_Barang_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Laporan_Barang_Masuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Laporan Barang Masuk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents periodik_2 As DateTimePicker
    Friend WithEvents periodik_1 As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tgl_harian As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents list_nomor_masuk As ListBox
    Friend WithEvents tgl_bulanan As DateTimePicker
    Friend WithEvents list_supplier As ListBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_view_bulanan As Button
    Friend WithEvents btn_view_periodik As Button
    Friend WithEvents btn_view_harian As Button
End Class
