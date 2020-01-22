<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Kartu_Stok
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn__view_semua_bulanan = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btn_view_bulanan = New System.Windows.Forms.Button()
        Me.tgl_bulanan = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_view_periodik = New System.Windows.Forms.Button()
        Me.periodik_2 = New System.Windows.Forms.DateTimePicker()
        Me.periodik_1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_view_harian = New System.Windows.Forms.Button()
        Me.tgl_harian = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.list_data_barang = New System.Windows.Forms.ListBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn__view_semua_bulanan)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Location = New System.Drawing.Point(688, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 157)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stok Bulanan Semua  Barang"
        '
        'btn__view_semua_bulanan
        '
        Me.btn__view_semua_bulanan.Location = New System.Drawing.Point(6, 117)
        Me.btn__view_semua_bulanan.Name = "btn__view_semua_bulanan"
        Me.btn__view_semua_bulanan.Size = New System.Drawing.Size(163, 23)
        Me.btn__view_semua_bulanan.TabIndex = 2
        Me.btn__view_semua_bulanan.Text = "View"
        Me.btn__view_semua_bulanan.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(163, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btn_view_bulanan)
        Me.GroupBox6.Controls.Add(Me.tgl_bulanan)
        Me.GroupBox6.Location = New System.Drawing.Point(529, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(153, 157)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Stok Bulanan Per Barang"
        '
        'btn_view_bulanan
        '
        Me.btn_view_bulanan.Location = New System.Drawing.Point(6, 117)
        Me.btn_view_bulanan.Name = "btn_view_bulanan"
        Me.btn_view_bulanan.Size = New System.Drawing.Size(141, 23)
        Me.btn_view_bulanan.TabIndex = 2
        Me.btn_view_bulanan.Text = "View"
        Me.btn_view_bulanan.UseVisualStyleBackColor = True
        '
        'tgl_bulanan
        '
        Me.tgl_bulanan.CustomFormat = ""
        Me.tgl_bulanan.Location = New System.Drawing.Point(6, 19)
        Me.tgl_bulanan.Name = "tgl_bulanan"
        Me.tgl_bulanan.Size = New System.Drawing.Size(141, 20)
        Me.tgl_bulanan.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_view_periodik)
        Me.GroupBox5.Controls.Add(Me.periodik_2)
        Me.GroupBox5.Controls.Add(Me.periodik_1)
        Me.GroupBox5.Location = New System.Drawing.Point(371, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(152, 157)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Stok Periodik Per Barang"
        '
        'btn_view_periodik
        '
        Me.btn_view_periodik.Location = New System.Drawing.Point(6, 117)
        Me.btn_view_periodik.Name = "btn_view_periodik"
        Me.btn_view_periodik.Size = New System.Drawing.Size(135, 23)
        Me.btn_view_periodik.TabIndex = 3
        Me.btn_view_periodik.Text = "View"
        Me.btn_view_periodik.UseVisualStyleBackColor = True
        '
        'periodik_2
        '
        Me.periodik_2.Location = New System.Drawing.Point(6, 45)
        Me.periodik_2.Name = "periodik_2"
        Me.periodik_2.Size = New System.Drawing.Size(135, 20)
        Me.periodik_2.TabIndex = 2
        '
        'periodik_1
        '
        Me.periodik_1.Location = New System.Drawing.Point(6, 19)
        Me.periodik_1.Name = "periodik_1"
        Me.periodik_1.Size = New System.Drawing.Size(135, 20)
        Me.periodik_1.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_view_harian)
        Me.GroupBox4.Controls.Add(Me.tgl_harian)
        Me.GroupBox4.Location = New System.Drawing.Point(218, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(147, 157)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stok Harian Per Barang"
        '
        'btn_view_harian
        '
        Me.btn_view_harian.Location = New System.Drawing.Point(6, 117)
        Me.btn_view_harian.Name = "btn_view_harian"
        Me.btn_view_harian.Size = New System.Drawing.Size(135, 23)
        Me.btn_view_harian.TabIndex = 1
        Me.btn_view_harian.Text = "View"
        Me.btn_view_harian.UseVisualStyleBackColor = True
        '
        'tgl_harian
        '
        Me.tgl_harian.Location = New System.Drawing.Point(6, 19)
        Me.tgl_harian.Name = "tgl_harian"
        Me.tgl_harian.Size = New System.Drawing.Size(135, 20)
        Me.tgl_harian.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.list_data_barang)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 157)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Barang"
        '
        'list_data_barang
        '
        Me.list_data_barang.FormattingEnabled = True
        Me.list_data_barang.Location = New System.Drawing.Point(6, 19)
        Me.list_data_barang.Name = "list_data_barang"
        Me.list_data_barang.Size = New System.Drawing.Size(190, 121)
        Me.list_data_barang.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 244)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(904, 194)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Laporan_Kartu_Stok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Laporan_Kartu_Stok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Laporan Kartu Stok"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents list_data_barang As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btn_view_bulanan As Button
    Friend WithEvents tgl_bulanan As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_view_periodik As Button
    Friend WithEvents periodik_2 As DateTimePicker
    Friend WithEvents periodik_1 As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_view_harian As Button
    Friend WithEvents tgl_harian As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn__view_semua_bulanan As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
