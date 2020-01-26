Public Class MenuUtama
    Private Sub btn_lap_masuk_Click(sender As Object, e As EventArgs) Handles btn_lap_masuk.Click
        Laporan_Barang_Masuk.Show()
    End Sub

    Private Sub btn_lap_master_Click(sender As Object, e As EventArgs) Handles btn_lap_master.Click
        Laporan_Master.Show()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        User.Show()
    End Sub
End Class
