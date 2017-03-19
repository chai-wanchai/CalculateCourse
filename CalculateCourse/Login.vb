Public Class Login
    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Me.BackColor = Color.FromArgb(13, 71, 161)
        Panel1.Dispose()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtID.Text = "chai" And txtPassword.Text = "1234") Then
            MessageBox.Show("pass")
            Dim main = New Profile
            main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Student ID or Password is wrong")

        End If
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        Dim register = New RegisterStudent()
        register.Show()
        Me.Hide()
    End Sub
End Class