Imports System.Security.Cryptography
Imports System.Text
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.User_Bool_IsPP Then
            PictureBox1.ImageLocation = My.Settings.User_String_PPLoc
        End If
        Label1.Text = "Login to " & My.Settings.User_String_SysName
        Label2.Text = "Welcome back, " & My.Settings.User_String_FName & " " & My.Settings.User_String_LName
        If My.Settings.User_Bool_IsPWD Then
            Panel3.Visible = True

        Else
            Panel1.Height = Panel1.Height - Panel3.Height
            Button2.Top = Button2.Top - Panel3.Height + 8
            Panel3.Visible = False
        End If
    End Sub

    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter
        If TextBox4.Text = "Password" Then
            TextBox4.Text = ""
            Label6.Visible = True

        End If
        Panel6.BackColor = Color.MidnightBlue
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If TextBox4.TextLength = 0 Then
            Label6.Visible = False
            TextBox4.Text = "Password"
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.TextLength > 0 Then
            TextBox4.ForeColor = Color.Black
            TextBox4.UseSystemPasswordChar = True
        Else
            TextBox4.ForeColor = Color.DimGray
            TextBox4.UseSystemPasswordChar = False
            Label6.Show()
        End If
        If TextBox4.Text = "Password" Then
            TextBox4.ForeColor = Color.DimGray
            TextBox4.UseSystemPasswordChar = False
        End If
        Panel6.BackColor = Color.MidnightBlue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            Login()
        End If
    End Sub
    Sub Login()
        If My.Settings.User_Bool_IsPWD Then
            If Not TextBox4.Text = "Password" Or Not TextBox4.Text = "" Then
                If My.Settings.User_String_PWD = Functions.GetHash(TextBox4.Text) Then
                    Desktop.Show()
                    Me.Close()
                Else
                    Panel6.BackColor = Color.Red
                    If Not My.Settings.User_String_PHint = "Password Hint" Then
                        Button3.Show()
                    End If
                End If
            Else
                Panel6.BackColor = Color.Red
            End If
        Else
            Desktop.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ToolTip1.Show(My.Settings.User_String_PHint, Button3)
    End Sub
End Class