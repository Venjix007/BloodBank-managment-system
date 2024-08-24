Imports System.Data.SqlClient
Imports System.Windows.Input

Public Class Patients
    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPatients()
    End Sub

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARTIK\Documents\BloodBankVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayPatients()
        Con.Open()
        Dim query = "select * from PatientTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet()
        adapter.Fill(ds)
        PatientsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Con.Open()
            Dim query = "insert into PatientTbl(PName,PAge,PPhone,PGen,PBGroup,PAddress) values (@PonName,@PonAge,@PonPhone,@PonGen,@PonBGroup,@PonAdd)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@PonName", PNameTb.Text)
            cmd.Parameters.AddWithValue("@PonAge", PAgeTb.Text)
            cmd.Parameters.AddWithValue("@PonPhone", PPhoneTb.Text)
            cmd.Parameters.AddWithValue("@PonGen", PGenCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@PonBGroup", PBGroupCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@PonAdd", PAddressTb.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Patient Saved")
            Con.Close()
            DisplayPatients()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Key = 0 Then
            MsgBox("Select Patient that is to be deleted")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            Dim query = "delete from PatientTbl where PId=" & Key & ""
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient Deleted Successfully")
            Con.Close()
            DisplayPatients()
        End If
    End Sub
    Dim Key As Integer
    Private Sub PatientsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PatientsDGV.CellMouseClick
        Dim row As DataGridViewRow = PatientsDGV.Rows(e.RowIndex)
        PnameTb.Text = row.Cells(1).Value.ToString
        PAgeTb.Text = row.Cells(2).Value.ToString
        PPhoneTb.Text = row.Cells(3).Value.ToString
        PGenCb.SelectedItem = row.Cells(4).Value.ToString
        PBGroupCb.SelectedItem = row.Cells(5).Value.ToString
        PAddressTb.Text = row.Cells(6).Value.ToString
        If PnameTb.Text = "Patient Name" Or PnameTb.Text = "" Then
            Key = 0
        Else
            Key = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Key = 0 Or PnameTb.Text = "" Or PAgeTb.Text = "" Or PPhoneTb.Text = "" Or PAddressTb.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim query = "update PatientTbl set PName='" & PnameTb.Text & "',PAge=" & PAgeTb.Text & ",PGen='" & PGenCb.SelectedItem.ToString & "',PPhone='" & PPhoneTb.Text & "',PBGroup='" & PBGroupCb.SelectedItem.ToString() & "',PAddress='" & PAddressTb.Text & "' where PId=" & Key
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient Updated Successfully")
            Con.Close()
            DisplayPatients()
        End If
    End Sub

    Private Sub PatientsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientsDGV.CellContentClick, PatientsDGV.CellContentClick

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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New Dashboard
        Obj.Show()
    End Sub
End Class