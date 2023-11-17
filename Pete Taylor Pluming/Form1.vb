Public Class Form1
    Dim attempts As Integer = 0
    Dim f2 As New Form2


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtPassword.text = "Joshy77" And txtUsername.Text = "Joshsolaaa") Then
            f2.Show()
            Me.Hide()
        ElseIf (txtPassword.text IsNot "Joshy77" And txtUsername.text IsNot "Joshsolaaa") Then
            txtPassword.Text = ""
            txtUsername.Clear()
            txtUsername.Focus()
            attempts += 1

            If attempts = 3 Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim i As DialogResult

        i = MessageBox.Show("Confirm if you want to exit", "Login system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Text = ""
        txtUsername.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOSK.Click

    End Sub
End Class
