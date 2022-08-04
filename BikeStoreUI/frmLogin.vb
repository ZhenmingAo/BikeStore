Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Login button to authenticate the user and grant the user access to other forms and buttons
        If txtUsername.Text.Equals(modShoppingCart.LOGIN_USERNAME, StringComparison.CurrentCultureIgnoreCase) And txtPassword.Text.Equals(modShoppingCart.LOGIN_PASSWORD) Then
            MsgBox("Login Successful!", MsgBoxStyle.Information, "Login")
            txtUsername.Text = ""
            txtPassword.Text = ""
            Me.Hide()
            frmBikeStoreMain.mnuLogOut.Enabled = True
            frmBikeStoreMain.ShowDialog()
        Else
            MsgBox("Incorrect credentials! Please try again!", MsgBoxStyle.Information, "Login Error")
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If

        'MsgBox("Login Successful!", MsgBoxStyle.Information, "Login")
        'txtUsername.Text = ""
        'txtPassword.Text = ""
        'Me.Hide()
        'frmBikeStoreMain.mnuLogOut.Enabled = True
        'frmBikeStoreMain.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the application
        Me.Close()
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Enter Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Enter Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Enter Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Enter Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "Enter Username"
        txtUsername.ForeColor = Color.Gray
        txtPassword.Text = "Enter Password"
        txtPassword.ForeColor = Color.Gray
    End Sub
End Class