Public Class FM_RenameFile
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not TextBox4.Text = "New filename" Then
            If Not FileManager.ListBox1.SelectedItems.Item(0).Text = Nothing Then
                FileSystem.Rename(FileManager.TextBox1.Text & "\" & FileManager.ListBox1.SelectedItems.Item(0).Text.ToString, FileManager.TextBox1.Text & "\" & TextBox4.Text)
                FileManager.FetchDirectory(FileManager.TextBox1.Text)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter
        If TextBox4.Text = "New filename" Then
            TextBox4.Text = ""
            Label6.Visible = True

        End If
        Panel6.BackColor = Color.MidnightBlue
    End Sub
    Public Sub SetOld(ByVal OldName As String)
        TextBox4.Text = OldName
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If TextBox4.TextLength = 0 Then
            Label6.Visible = False
            TextBox4.Text = "New filename"
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.TextLength > 0 Then
            TextBox4.ForeColor = Color.Black
        Else
            TextBox4.ForeColor = Color.DimGray
            Label6.Show()
        End If
        If TextBox4.Text = "New filename" Then
            TextBox4.ForeColor = Color.DimGray
        End If
        Label6.Visible = True
        Panel6.BackColor = Color.MidnightBlue
    End Sub
    Dim CurLocation, MeLocation As New Point(0, 0)
    Private Sub Sync()
        MeLocation = Me.Location
        CurLocation = MousePosition
    End Sub
    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        Timer1.Stop()
        Sync()
        If Me.Top < Desktop.Panel2.Bottom Then
            Me.Top = Desktop.Panel2.Bottom
        End If
        If Me.Bottom > Desktop.Panel1.Top Then
            Me.Top = Desktop.Panel1.Top - Me.Height
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Location = MeLocation - CurLocation + MousePosition
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FM_RenameFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = FileManager
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Sync()
        Timer1.Start()
    End Sub
End Class