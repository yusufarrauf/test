Public Class Hasil
    Public Q1 As String = "Tidak"
    Public Q2 As String = "Tidak"
    Public SQ2 As String = ""
    Public Q3 As String = "Tidak"
    Public Q4 As String = "Tidak"
    Public SQ4 As String = ""
    Public Q5 As String = "Tidak"
    Private Sub kalkulasi()
        Dim jenis, penyebab, solusi As String
        If Q1 = "Ya" Then
            jenis = "Cacat Karat Gelap Dan Terang"
            penyebab = ""
            solusi = ""
        ElseIf Q2 = "Ya" Then
            If SQ2 = "Pinggiran" Then
                jenis = "Cacat Edge dan Cacat Hole"
                penyebab = ""
                solusi = ""
            Else
                jenis = "Cacat Hole Lapis Galvanis"
                penyebab = ""
                solusi = ""
            End If
        ElseIf Q3 = "Ya" Then
            jenis = "Cacat Garis"
            penyebab = ""
            solusi = ""
        ElseIf Q4 = "Ya" Then
            If SQ4 = "Karat" Then
                jenis = "Cacat Uncoated Galvalum"
                penyebab = ""
                solusi = ""
            Else
                jenis = "Cacat Oil Mark Pelat HRPO"
                penyebab = ""
                solusi = ""
            End If
        ElseIf Q5 = "Ya" Then
            jenis = "Cacat Laps Lipat"
            penyebab = ""
            solusi = ""
        End If
        TextBox1.Text = jenis
        TextBox2.Text = penyebab
        TextBox3.Text = solusi
    End Sub
    Private Sub Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Q2
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        kalkulasi()
    End Sub
End Class