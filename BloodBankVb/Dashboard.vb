Imports System.Data.SqlClient

Public Class Dashboard
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARTIK\Documents\BloodBankVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub CountPatients()
        Dim PatNum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from PatientTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        PatNum = cmd.ExecuteScalar
        PatNumLbl.Text = PatNum
        Con.Close()
    End Sub
    Private Sub CountDonors()
        Dim DonNum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from DonorTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        DonNum = cmd.ExecuteScalar
        TrNumLbl.Text = DonNum
        Con.Close()
    End Sub
    Private Sub CountTransfers()
        Dim TrNum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from TransferTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        TrNum = cmd.ExecuteScalar
        DonNumLbl.Text = TrNum
        Con.Close()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountPatients()
        CountDonors()
        CountTransfers()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New Patients
        Obj.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj As New Donors
        Obj.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj As New Donates
        Obj.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj As New Transfers
        Obj.Show()
    End Sub
End Class