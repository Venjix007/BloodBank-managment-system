Public Class Splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(1)
        Dim Percentage
        Percentage = ProgressBar.Value.ToString()
        Dim Per As String
        Per = Percentage + "%"
        PercentLbl.Text = Per
        If ProgressBar.Value = 100 Then
            Me.Hide()
            Dim Obj As New Login
            Obj.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
