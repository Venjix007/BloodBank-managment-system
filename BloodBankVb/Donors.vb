Imports System.Data.SqlClient
Imports System.Windows.Input

Public Class Donors
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles DNameTb.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DGenCb.SelectedIndexChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles DPhoneTb.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBGroupCb.SelectedIndexChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARTIK\Documents\BloodBankVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayDonors()
        Con.Open()
        Dim query = "select * from DonorTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet()
        adapter.Fill(ds)
        DonorsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Con.Open()
            Dim query = "insert into DonorTbl(DName,DAge,DGen,DPhone,DBGroup,DAdd) values (@DonName,@DonAge,@DonGen,@DonPhone,@DonBGroup,@DonAdd)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@DonName", DNameTb.Text)
            cmd.Parameters.AddWithValue("@DonAge", DAgeTb.Text)
            cmd.Parameters.AddWithValue("@DonGen", DGenCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@DonPhone", DPhoneTb.Text)
            cmd.Parameters.AddWithValue("@DonBGroup", DBGroupCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@DonAdd", DAddressTb.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Donor Saved")
            Con.Close()
            DisplayDonors()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Private Sub Donors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDonors()
    End Sub
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Key = 0 Or DNameTb.Text = "" Or DAgeTb.Text = "" Or DPhoneTb.Text = "" Or DAddressTb.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim query = "update DonorTbl set DName='" & DNameTb.Text & "',DAge=" & DAgeTb.Text & ",DGen='" & DGenCb.SelectedItem.ToString & "',DPhone='" & DPhoneTb.Text & "',DBGroup='" & DBGroupCb.SelectedItem.ToString() & "',DAdd='" & DAddressTb.Text & "' where DId=" & Key
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Donor Deleted Successfully")
            Con.Close()
            DisplayDonors()
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Key = 0 Then
            MsgBox("Select Donor that is to be deleted")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            Dim query = "delete from DonorTbl where DId=" & Key & ""
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Donor Deleted Successfully")
            Con.Close()
            DisplayDonors()
        End If
    End Sub
    Dim Key As Integer
    Private Sub DonorsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DonorsDGV.CellMouseClick
        Dim row As DataGridViewRow = DonorsDGV.Rows(e.RowIndex)
        DNameTb.Text = row.Cells(1).Value.ToString
        DAgeTb.Text = row.Cells(2).Value.ToString
        DGenCb.SelectedItem = row.Cells(3).Value.ToString
        DPhoneTb.Text = row.Cells(4).Value.ToString
        DBGroupCb.SelectedItem = row.Cells(5).Value.ToString
        DAddressTb.Text = row.Cells(6).Value.ToString
        If DNameTb.Text = "Donor Name" Or DNameTb.Text = "" Then
            Key = 0
        Else
            Key = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New Patients
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New Dashboard
        Obj.Show()
    End Sub
End Class