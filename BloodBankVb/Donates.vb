Imports System.Data.SqlClient
Imports System.Windows.Input

Public Class Donates
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARTIK\Documents\BloodBankVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayDonors()
        Con.Open()
        Dim query = "select DName,DBGroup from DonorTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet()
        adapter.Fill(ds)
        DonorsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub DisplayBlood()
        Con.Open()
        Dim query = "select * from BStockTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet()
        adapter.Fill(ds)
        BloodDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Donates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDonors()
        DisplayBlood()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Dim Key As Integer
    Private Sub DonorsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DonorsDGV.CellMouseClick
        Dim row As DataGridViewRow = DonorsDGV.Rows(e.RowIndex)
        DNameTb.Text = row.Cells(0).Value.ToString
        DBGroupTb.Text = row.Cells(1).Value.ToString
    End Sub
    Dim OldStock
    Private Sub FetchQty()
        Con.Open()
        Dim query = "select * from BStockTbl where BGroup = '" & DBGroupTb.Text & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            OldStock = Convert.ToInt32(reader(2))
        End While
        Con.Close()
    End Sub
    Private Sub DonateBtn_Click(sender As Object, e As EventArgs) Handles DonateBtn.Click
        If DNameTb.Text = "" Or DBGroupTb.Text = "" Then
            MsgBox("Select a Donor")
        Else
            FetchQty()
            Dim NewStock As Integer
            NewStock = OldStock + 1
            Con.Open()
            Dim query = "update BStockTbl set BStock='" & NewStock & "' where BGroup='" & DBGroupTb.Text & "'"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Blood data Updated Successfully")
            Con.Close()
            DisplayBlood()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj As New Donors
        Obj.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New Patients
        Obj.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj As New Transfers
        Obj.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New Dashboard
        Obj.Show()
    End Sub
End Class