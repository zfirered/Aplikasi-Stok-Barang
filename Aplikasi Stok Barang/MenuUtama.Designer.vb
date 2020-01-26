<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_lap_kartu_stok = New System.Windows.Forms.Button()
        Me.btn_lap_keluar = New System.Windows.Forms.Button()
        Me.btn_lap_masuk = New System.Windows.Forms.Button()
        Me.btn_lap_master = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_tr_keluar = New System.Windows.Forms.Button()
        Me.btn_tr_masuk = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_supplier = New System.Windows.Forms.Button()
        Me.btn_barang = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_lap_kartu_stok)
        Me.GroupBox4.Controls.Add(Me.btn_lap_keluar)
        Me.GroupBox4.Controls.Add(Me.btn_lap_masuk)
        Me.GroupBox4.Controls.Add(Me.btn_lap_master)
        Me.GroupBox4.Location = New System.Drawing.Point(530, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(330, 100)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan"
        '
        'btn_lap_kartu_stok
        '
        Me.btn_lap_kartu_stok.Location = New System.Drawing.Point(249, 19)
        Me.btn_lap_kartu_stok.Name = "btn_lap_kartu_stok"
        Me.btn_lap_kartu_stok.Size = New System.Drawing.Size(75, 75)
        Me.btn_lap_kartu_stok.TabIndex = 5
        Me.btn_lap_kartu_stok.Text = "Kartu Stok"
        Me.btn_lap_kartu_stok.UseVisualStyleBackColor = True
        '
        'btn_lap_keluar
        '
        Me.btn_lap_keluar.Location = New System.Drawing.Point(168, 19)
        Me.btn_lap_keluar.Name = "btn_lap_keluar"
        Me.btn_lap_keluar.Size = New System.Drawing.Size(75, 75)
        Me.btn_lap_keluar.TabIndex = 4
        Me.btn_lap_keluar.Text = "Keluar"
        Me.btn_lap_keluar.UseVisualStyleBackColor = True
        '
        'btn_lap_masuk
        '
        Me.btn_lap_masuk.Location = New System.Drawing.Point(87, 19)
        Me.btn_lap_masuk.Name = "btn_lap_masuk"
        Me.btn_lap_masuk.Size = New System.Drawing.Size(75, 75)
        Me.btn_lap_masuk.TabIndex = 3
        Me.btn_lap_masuk.Text = "Masuk"
        Me.btn_lap_masuk.UseVisualStyleBackColor = True
        '
        'btn_lap_master
        '
        Me.btn_lap_master.Location = New System.Drawing.Point(6, 19)
        Me.btn_lap_master.Name = "btn_lap_master"
        Me.btn_lap_master.Size = New System.Drawing.Size(75, 75)
        Me.btn_lap_master.TabIndex = 2
        Me.btn_lap_master.Text = "Master"
        Me.btn_lap_master.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_tr_keluar)
        Me.GroupBox3.Controls.Add(Me.btn_tr_masuk)
        Me.GroupBox3.Location = New System.Drawing.Point(354, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(170, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaksi Barang"
        '
        'btn_tr_keluar
        '
        Me.btn_tr_keluar.Location = New System.Drawing.Point(87, 19)
        Me.btn_tr_keluar.Name = "btn_tr_keluar"
        Me.btn_tr_keluar.Size = New System.Drawing.Size(75, 75)
        Me.btn_tr_keluar.TabIndex = 1
        Me.btn_tr_keluar.Text = "Keluar"
        Me.btn_tr_keluar.UseVisualStyleBackColor = True
        '
        'btn_tr_masuk
        '
        Me.btn_tr_masuk.Location = New System.Drawing.Point(6, 19)
        Me.btn_tr_masuk.Name = "btn_tr_masuk"
        Me.btn_tr_masuk.Size = New System.Drawing.Size(75, 75)
        Me.btn_tr_masuk.TabIndex = 0
        Me.btn_tr_masuk.Text = "Masuk"
        Me.btn_tr_masuk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_customer)
        Me.GroupBox2.Controls.Add(Me.btn_supplier)
        Me.GroupBox2.Controls.Add(Me.btn_barang)
        Me.GroupBox2.Controls.Add(Me.btn_user)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Master"
        '
        'btn_customer
        '
        Me.btn_customer.Location = New System.Drawing.Point(249, 19)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(75, 75)
        Me.btn_customer.TabIndex = 3
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_supplier
        '
        Me.btn_supplier.Location = New System.Drawing.Point(168, 19)
        Me.btn_supplier.Name = "btn_supplier"
        Me.btn_supplier.Size = New System.Drawing.Size(75, 75)
        Me.btn_supplier.TabIndex = 2
        Me.btn_supplier.Text = "Supplier"
        Me.btn_supplier.UseVisualStyleBackColor = True
        '
        'btn_barang
        '
        Me.btn_barang.Location = New System.Drawing.Point(87, 19)
        Me.btn_barang.Name = "btn_barang"
        Me.btn_barang.Size = New System.Drawing.Size(75, 75)
        Me.btn_barang.TabIndex = 1
        Me.btn_barang.Text = "Barang"
        Me.btn_barang.UseVisualStyleBackColor = True
        '
        'btn_user
        '
        Me.btn_user.Location = New System.Drawing.Point(6, 19)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(75, 75)
        Me.btn_user.TabIndex = 0
        Me.btn_user.Text = "User"
        Me.btn_user.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(866, 368)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 497)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_supplier As Button
    Friend WithEvents btn_barang As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_lap_kartu_stok As Button
    Friend WithEvents btn_lap_keluar As Button
    Friend WithEvents btn_lap_masuk As Button
    Friend WithEvents btn_lap_master As Button
    Friend WithEvents btn_tr_keluar As Button
    Friend WithEvents btn_tr_masuk As Button
End Class
