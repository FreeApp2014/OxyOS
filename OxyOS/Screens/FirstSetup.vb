Public Class FirstSetup
    Dim PP As Boolean

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub FirstSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Height = 390
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExitFirstSetupDialog.Show()
    End Sub

    Private Sub Tooltip(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ToolTip1.Show("Left click to edit", PictureBox1)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
        PP = True
        LinkLabel1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength > 0 Then
            TextBox1.ForeColor = Color.Black
            If Not TextBox1.Text = "First Name" Then
                If TextBox3.Text.EndsWith("s-oxyos-computer") Or TextBox3.Text = "" Or TextBox3.Text = "System Name" Then
                    TextBox3.Text = TextBox1.Text.ToLower() & "s-oxyos-computer"
                End If
            End If
        Else
            If TextBox3.Text.EndsWith("s-oxyos-computer") Then
                TextBox3.Text = "System Name"
            End If
            TextBox1.ForeColor = Color.DimGray
        End If
        If TextBox1.Text = "First Name" Then
            TextBox1.ForeColor = Color.DimGray
        End If
        Panel1.BackColor = Color.MidnightBlue
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "First Name" Then
            TextBox1.Text = ""
            Label2.Visible = True
        End If
        Panel1.BackColor = Color.MidnightBlue
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.TextLength = 0 Then
            Label2.Visible = False
            TextBox1.Text = "First Name"
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength > 0 Then
            TextBox2.ForeColor = Color.Black
        Else
            TextBox2.ForeColor = Color.DimGray
        End If
        If TextBox2.Text = "Last Name" Then
            TextBox2.ForeColor = Color.DimGray
        End If

        Panel4.BackColor = Color.MidnightBlue
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Last Name" Then
            TextBox2.Text = ""
            Label3.Visible = True
        End If
        Panel4.BackColor = Color.MidnightBlue
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.TextLength = 0 Then
            Label3.Visible = False
            TextBox2.Text = "Last Name"
        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.TextLength > 0 Then
            TextBox3.ForeColor = Color.Black
            Label5.Visible = True
        Else
            TextBox3.ForeColor = Color.DimGray
            Label5.Visible = False
        End If
        If TextBox3.Text = "System Name" Then
            TextBox3.ForeColor = Color.DimGray
            Label5.Visible = False
        End If
        If Not TextBox3.Text = "System Name" Then
            TextBox3.Text = TextBox3.Text.ToLower().Replace(" ", "-")
            TextBox3.SelectionStart = TextBox3.TextLength + 1
        End If
        Panel5.BackColor = Color.MidnightBlue
    End Sub

    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        If TextBox3.Text = "System Name" Then
            TextBox3.Text = ""
            Label5.Visible = True
            Panel5.BackColor = Color.MidnightBlue
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.TextLength = 0 Then
            Label5.Visible = False
            TextBox3.Text = "System Name"
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
        If Not TextBox5.Text = TextBox4.Text And Not TextBox5.Text = "Confirm Password" Then
            Panel7.BackColor = Color.Red
        Else
            Panel7.BackColor = Color.MidnightBlue
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel8.Visible = True
            Panel2.Height = 390
            Button2.Top = 344
        Else
            Panel8.Visible = False
            Panel2.Height = Panel2.Height - Panel8.Height
            Button2.Top = Button2.Top - Panel8.Height
        End If
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Fail As Boolean = False
        If TextBox1.Text = "" Or TextBox1.Text = " " Or TextBox1.Text = "First Name" Then
            Panel1.BackColor = Color.Red
            Fail = True
        End If
        If TextBox2.Text = "" Or TextBox2.Text = " " Or TextBox2.Text = "Last Name" Then
            Panel4.BackColor = Color.Red
            Fail = True
        End If
        If TextBox3.Text = "" Or TextBox3.Text = " " Or TextBox3.Text = "System Name" Then
            Panel5.BackColor = Color.Red
            Fail = True
        End If
        If CheckBox1.Checked = True Then
            If TextBox4.Text = "Password" Or TextBox5.Text = "Confirm Password" Then
                Panel6.BackColor = Color.Red
                Panel7.BackColor = Color.Red
                Fail = True
            End If
            If Not TextBox4.Text = TextBox5.Text Then
                Panel7.BackColor = Color.Red
                Fail = True
            End If
        End If
        If Fail = False Then
            My.Settings.Main_IsFirstRun = False
            My.Settings.User_Bool_IsPP = PP
            My.Settings.User_Bool_IsPWD = CheckBox1.Checked
            My.Settings.User_String_FName = TextBox1.Text
            My.Settings.User_String_LName = TextBox2.Text
            My.Settings.User_String_SysName = TextBox3.Text
            My.Settings.User_String_PPLoc = PictureBox1.ImageLocation
            My.Settings.User_String_PWD = Functions.GetHash(TextBox4.Text)
            My.Settings.User_String_PHint = TextBox6.Text
            Login.Show()
            Me.Close()

        End If
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.TextLength > 0 Then
            TextBox5.ForeColor = Color.Black
            TextBox5.UseSystemPasswordChar = True
        Else
            TextBox5.ForeColor = Color.DimGray
            Label7.Show()
            TextBox5.UseSystemPasswordChar = False
        End If
        If TextBox5.Text = "Confirm Password" Then
            TextBox5.ForeColor = Color.DimGray
            TextBox5.UseSystemPasswordChar = False
        End If
        If Not TextBox5.Text = TextBox4.Text And Not TextBox5.Text = "Confirm Password" Then
            Panel7.BackColor = Color.Red
        Else
            Panel7.BackColor = Color.MidnightBlue
        End If
        Panel6.BackColor = Color.MidnightBlue
    End Sub

    Private Sub TextBox5_Enter(sender As Object, e As EventArgs) Handles TextBox5.Enter
        If TextBox5.Text = "Confirm Password" Then
            TextBox5.Text = ""
            Label7.Visible = True
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave
        If TextBox5.TextLength = 0 Then
            Label8.Visible = False
            TextBox5.Text = "Confirm Password"
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.TextLength > 0 Then
            TextBox6.ForeColor = Color.Black
        Else
            TextBox6.ForeColor = Color.DimGray
        End If
        If TextBox6.Text = "Password Hint" Then
            TextBox6.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub TextBox6_Enter(sender As Object, e As EventArgs) Handles TextBox6.Enter
        If TextBox6.Text = "Password Hint" Then
            TextBox6.Text = ""
            Label8.Visible = True
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        If TextBox6.TextLength = 0 Then
            Label7.Visible = False
            TextBox6.Text = "Password Hint"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PP = False
        PictureBox1.Image = My.Resources.user
        LinkLabel1.Hide()
    End Sub
End Class
