Public Class Laporan_Barang_Masuk
    Private Sub Laporan_Barang_Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgl_bulanan.Format = DateTimePickerFormat.Custom
        tgl_bulanan.CustomFormat = "MMMM" 'or whatever you want
    End Sub
End Class