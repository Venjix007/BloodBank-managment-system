Imports System.Data.SqlClient
Imports System.Drawing.Text

Public Class Transfers
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARTIK\Documents\BloodBankVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub GetPatients()
        Con.Open()
        Dim Sql = "select * from PatientTbl"
        Dim cmd As New SqlCommand(Sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        PatIdCb.DataSource = Tbl
        PatIdCb.DisplayMember = "PId"
        PatIdCb.ValueMember = "PId"
        Con.Close()
    End Sub
    Private Sub Transfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPatients()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Private Sub GetData()
        Con.Open()
        Dim query = "select * from PatientTbl where PId=" & PatIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            PatNameTb.Text = reader(1).ToString()
            BGroupTb.Text = reader(5).ToString()
        End While
        Con.Close()
    End Sub
    Private Sub PatIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PatIdCb.SelectionChangeCommitted
        GetData()
        FetchQty()
        If AvailableStock = 0 Then
            AvailableBtn.Text = "No Blood Available"
            AvailableBtn.Visible = True
        Else
            AvailableBtn.Text = AvailableStock
            AvailableBtn.Visible = True
            TransferBtn.Visible = True
        End If
    End Sub
    Dim AvailableStock As Integer
    Private Sub FetchQty()
        Con.Open()
        Dim query = "select * from BStockTbl where BGroup = '" & BGroupTb.Text & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            AvailableStock = Convert.ToInt32(reader(2))
        End While
        Con.Close()
    End Sub
    Private Sub UpdateBlood()
        FetchQty()
        Dim NewStock As Integer
        NewStock = AvailableStock - 1
        Con.Open()
        Dim query = "update BStockTbl set BStock='" & NewStock & "' where BGroup='" & BGroupTb.Text & "'"
        Dim cmd As New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        ' AvailableBtn.Text = AvailableStock
        ' MsgBox("Blood data Updated Successfully")
        Con.Close()
        ' DisplayBlood()
    End Sub
    Private Sub TransferBtn_Click(sender As Object, e As EventArgs) Handles TransferBtn.Click
        Try
            Con.Open()
            Dim query = "insert into TransferTbl(Tpat,TBGroup) values (@TrPat,@TrBGroup)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@Trpat", PatNameTb.Text)
            cmd.Parameters.AddWithValue("@TrBGroup", BGroupTb.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Blood Transfered")
            Con.Close()
            FetchQty()
            UpdateBlood()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj As New Donors
        Obj.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New Patients
        Obj.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj As New Donates
        Obj.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New Dashboard
        Obj.Show()
    End Sub
End Class