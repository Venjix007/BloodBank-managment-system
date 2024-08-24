Public Class Login
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Enter both Username and Password")
        ElseIf UnameTb.Text = "Admin" And PasswordTb.Text = "Password" Then
            Dim Obj As New Patients()
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        UnameTb.Text = ""
        PasswordTb.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class