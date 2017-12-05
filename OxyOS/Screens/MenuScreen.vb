Public Class MenuScreen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuBG.Close()
        Me.Close()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim require = OML.ParseOMLDocument(Application.StartupPath & "\OS_Data\apps.oml")
        'For Each elem In require
        '    If Not OML.NodeIsStructure(elem) And Not OML.NodeIsComment(elem) Then
        '        MsgBox(elem)
        '    End If
        'Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuBG.Close()
        Me.Close()
        Desktop.Hide()
        Login.Show()
        Login.TextBox4.Text = "Password"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If My.Settings.User_Bool_IsPP Then
            PictureBox1.ImageLocation = My.Settings.User_String_PPLoc
        End If
        Label2.Text = "Logged in as: " & My.Settings.User_String_FName & " " & My.Settings.User_String_LName
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel2.Visible Then
            Panel2.Hide()
        Else
            Panel2.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Restart()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MenuBG.Close()
        Me.Close()
        OxyWrite.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MenuBG.Close()
        Me.Close()
        FileManager.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MenuBG.Close()
        Me.Close()
        PictureViewer.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MenuBG.Close()
        Me.Close()
        Terminal.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MenuBG.Close()
        Me.Close()
        Help.Show()
    End Sub
End Class