Public Class Question
    Private Sub Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KaratTidak.Checked = True
        P_Pola.Visible = False
        BolongTidak.Checked = True
        P_Bolong.Visible = False
        GarisTidak.Checked = True
        LipatanTidak.Checked = True
        PolaTidak.Checked = True
    End Sub
    Private Sub KaratYa_CheckedChanged(sender As Object, e As EventArgs) Handles KaratYa.CheckedChanged
        Hasil.Q1 = "Ya"
    End Sub
    Private Sub KaratTidak_CheckedChanged(sender As Object, e As EventArgs) Handles KaratTidak.CheckedChanged
        Hasil.Q1 = "Tidak"
    End Sub
    Private Sub BolongYa_CheckedChanged(sender As Object, e As EventArgs) Handles BolongYa.CheckedChanged
        P_Bolong.Visible = True
        BolongPinggiran.Checked = True
        Hasil.Q2 = "Ya"
    End Sub
    Private Sub BolongTidak_CheckedChanged(sender As Object, e As EventArgs) Handles BolongTidak.CheckedChanged
        P_Bolong.Visible = False
        BolongPinggiran.Checked = False
        BolongLembaran.Checked = False
        Hasil.Q2 = "Tidak"
        Hasil.SQ2 = ""
    End Sub
    Private Sub BolongPinggiran_CheckedChanged(sender As Object, e As EventArgs) Handles BolongPinggiran.CheckedChanged
        Hasil.SQ2 = "Pinggiran"
    End Sub
    Private Sub BolongLembaran_CheckedChanged(sender As Object, e As EventArgs) Handles BolongLembaran.CheckedChanged
        Hasil.SQ2 = "Lembaran"
    End Sub
    Private Sub GarisYa_CheckedChanged(sender As Object, e As EventArgs) Handles GarisYa.CheckedChanged
        Hasil.Q3 = "Ya"
    End Sub
    Private Sub GarisTidak_CheckedChanged(sender As Object, e As EventArgs) Handles GarisTidak.CheckedChanged
        Hasil.Q3 = "Tidak"
    End Sub
    Private Sub PolaYa_CheckedChanged(sender As Object, e As EventArgs) Handles PolaYa.CheckedChanged
        P_Pola.Visible = True
        PolaKarat.Checked = True
        Hasil.Q4 = "Ya"
    End Sub
    Private Sub PolaTidak_CheckedChanged(sender As Object, e As EventArgs) Handles PolaTidak.CheckedChanged
        P_Pola.Visible = False
        PolaKarat.Checked = False
        PolaOli.Checked = False
        Hasil.Q4 = "Tidak"
        Hasil.SQ4 = ""
    End Sub
    Private Sub PolaKarat_CheckedChanged(sender As Object, e As EventArgs) Handles PolaKarat.CheckedChanged
        Hasil.SQ4 = "Karat"
    End Sub
    Private Sub PolaOli_CheckedChanged(sender As Object, e As EventArgs) Handles PolaOli.CheckedChanged
        Hasil.SQ4 = "Oli"
    End Sub
    Private Sub LipatanYa_CheckedChanged(sender As Object, e As EventArgs) Handles LipatanYa.CheckedChanged
        Hasil.Q5 = "Ya"
    End Sub
    Private Sub LipatanTidak_CheckedChanged(sender As Object, e As EventArgs) Handles LipatanTidak.CheckedChanged
        Hasil.Q5 = "Tidak"
    End Sub
    Private Sub B_Hasil_Click(sender As Object, e As EventArgs) Handles B_Hasil.Click
        Hasil.Show()
        KaratTidak.Checked = True
        P_Pola.Visible = False
        BolongTidak.Checked = True
        P_Bolong.Visible = False
        GarisTidak.Checked = True
        LipatanTidak.Checked = True
        PolaTidak.Checked = True
    End Sub
End Class
