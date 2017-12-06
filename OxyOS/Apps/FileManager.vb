Imports System.IO
Public Class FileManager
    Dim CurLocation, MeLocation As New Point(0, 0)
    Dim elema As Button
    Dim el As Integer = 1
    Private Sub Sync()
        MeLocation = Me.Location
        CurLocation = MousePosition
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FileManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = Desktop
        TextBox1.Text = Application.StartupPath & "\UserDocs"
        Label1.Text = "UserDocs - File Manager"
        For Each File In Directory.GetDirectories(Application.StartupPath & "\UserDocs")
            ListBox1.Items.Add(File.Split("\").Last).ImageIndex = 0
        Next
        For Each File In Directory.GetFiles(Application.StartupPath & "\UserDocs")
            Dim alpha = ListBox1.Items.Add(File.Split("\").Last)
            If alpha.Text.EndsWith(".rtf") Or alpha.Text.EndsWith(".txt") Then
                alpha.ImageIndex = 2
            ElseIf alpha.Text.EndsWith(".jpg") Or alpha.Text.EndsWith(".jpeg") Or alpha.Text.EndsWith(".png") Or alpha.Text.EndsWith(".gif") Or alpha.Text.EndsWith(".bmp") Then
                alpha.ImageIndex = 1
            Else
                alpha.ImageIndex = 3
            End If
        Next
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("File Manager")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        elema = Desktop.AddToTaskbar("2")
        For Each disk In Directory.GetLogicalDrives
            ListBox2.Items.Add(disk)
        Next
    End Sub
    Sub FetchDirectoryByListBoxItem()
        Label1.Text = ListBox1.SelectedItems.Item(0).Text.ToString & " - File Manager"
        If TextBox1.Text = "" Then
            Dim p As String = ListBox1.SelectedItems.Item(0).Text.ToString
            TextBox1.Text = ListBox1.SelectedItems.Item(0).Text.ToString
            ListBox1.Items.Clear()
            For Each File In Directory.GetDirectories(p)
                ListBox1.Items.Add(File.Split("\").Last).ImageIndex = 0
            Next
            For Each File In Directory.GetFiles(p)
                Dim alpha = ListBox1.Items.Add(File.Split("\").Last)
                If alpha.Text.EndsWith(".rtf") Or alpha.Text.EndsWith(".txt") Then
                    alpha.ImageIndex = 2
                ElseIf alpha.Text.EndsWith(".jpg") Or alpha.Text.EndsWith(".jpeg") Or alpha.Text.EndsWith(".png") Or alpha.Text.EndsWith(".gif") Or alpha.Text.EndsWith(".bmp") Then
                    alpha.ImageIndex = 1
                Else
                    alpha.ImageIndex = 3
                End If
            Next
        Else
            Dim p As String = TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text.ToString
            TextBox1.Text = TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text.ToString
            ListBox1.Items.Clear()
            For Each File In Directory.GetDirectories(p)
                ListBox1.Items.Add(File.Split("\").Last).ImageIndex = 0
            Next
            For Each File In Directory.GetFiles(p)
                Dim alpha = ListBox1.Items.Add(File.Split("\").Last)
                If alpha.Text.EndsWith(".rtf") Or alpha.Text.EndsWith(".txt") Then
                    alpha.ImageIndex = 2
                ElseIf alpha.Text.EndsWith(".jpg") Or alpha.Text.EndsWith(".jpeg") Or alpha.Text.EndsWith(".png") Or alpha.Text.EndsWith(".gif") Or alpha.Text.EndsWith(".bmp") Then
                    alpha.ImageIndex = 1
                Else
                    alpha.ImageIndex = 3
                End If
            Next
        End If

    End Sub
    Sub FetchDirectory(ByVal Path As String)
        Label1.Text = Path.Split("\").Last & " - File Manager"
        ListBox1.Items.Clear()
        For Each File In Directory.GetDirectories(Path)
            ListBox1.Items.Add(File.Split("\").Last).ImageIndex = 0
        Next
        For Each File In Directory.GetFiles(Path)
            Dim alpha = ListBox1.Items.Add(File.Split("\").Last)
            If alpha.Text.EndsWith(".rtf") Or alpha.Text.EndsWith(".txt") Then
                alpha.ImageIndex = 2
            ElseIf alpha.Text.EndsWith(".jpg") Or alpha.Text.EndsWith(".jpeg") Or alpha.Text.EndsWith(".png") Or alpha.Text.EndsWith(".gif") Or alpha.Text.EndsWith(".bmp") Then
                alpha.ImageIndex = 1
            Else
                alpha.ImageIndex = 3
            End If
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not TextBox1.Text = "" Then
            ListBox1.Items.Clear()
            If UBound(TextBox1.Text.Split("\")) = 1 And TextBox1.Text.Split("\")(1) = "" Then
                TextBox1.Text = ""
                For Each disk In Directory.GetLogicalDrives
                    ListBox1.Items.Add(disk)
                Next
            Else
                TextBox1.Text = Directory.GetParent(TextBox1.Text).FullName
                For Each File In Directory.GetDirectories(TextBox1.Text)
                    ListBox1.Items.Add(File.Split("\").Last).ImageIndex = 0
                Next
                For Each File In Directory.GetFiles(TextBox1.Text)
                    Dim alpha = ListBox1.Items.Add(File.Split("\").Last)
                    If alpha.Text.EndsWith(".rtf") Or alpha.Text.EndsWith(".txt") Then
                        alpha.ImageIndex = 2
                    ElseIf alpha.Text.EndsWith(".jpg") Or alpha.Text.EndsWith(".jpeg") Or alpha.Text.EndsWith(".png") Or alpha.Text.EndsWith(".gif") Or alpha.Text.EndsWith(".bmp") Then
                        alpha.ImageIndex = 1
                    Else
                        alpha.ImageIndex = 3
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FM_NewDir.Show()
        FM_NewDir.Owner = Me
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub Delete()
        If File.GetAttributes(TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text.ToString) = FileAttributes.Directory Then
            Directory.Delete(TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text, True)
            FetchDirectory(TextBox1.Text)
        Else
            File.Delete(TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text)
            FetchDirectory(TextBox1.Text)
        End If
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        OpenListBoxSelectedFile()
    End Sub
    Private Sub OpenListBoxSelectedFile()
        If Not ListBox1.SelectedItems.Item(0).Text = Nothing Then
            If TextBox1.Text = "" Then
                FetchDirectoryByListBoxItem()
            Else
                If File.GetAttributes(TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text.ToString) = FileAttributes.Directory Then
                    FetchDirectoryByListBoxItem()
                Else
                    If ListBox1.SelectedItems.Item(0).Text.ToString.EndsWith(".rtf") Or ListBox1.SelectedItems.Item(0).Text.ToString.EndsWith(".txt") Or ListBox1.SelectedItems.Item(0).Text.ToString.EndsWith(".oml") Then
                        OxyWrite.Show()
                        OxyWrite.LoadExt(TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text.ToString)
                    End If
                    If ListBox1.SelectedItems.Item(0).Text.ToString.EndsWith(".png") Or ListBox1.SelectedItems.Item(0).Text.ToString.EndsWith(".jpg") Or ListBox1.SelectedItems.Item(0).Text.ToString.EndsWith(".jpeg") Or ListBox1.SelectedItems.Item(0).Text.ToString.EndsWith(".gif") Or ListBox1.SelectedItems.Item(0).Text.ToString.EndsWith(".bmp") Then
                        PictureViewer.Show()
                        PictureViewer.LoadExt(TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If Not ListBox1.SelectedItems.Item(0).Text = Nothing Then
            FM_Delete.Show()
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If Not ListBox1.SelectedItems.Item(0).Text = Nothing Then
            FM_Delete.Show()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(31) Then
            FetchDirectory(TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer4.Start()

        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyOS Desktop")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        If Not ListBox1.SelectedItems.Item(0).Text = Nothing Then
            Directory.Delete(ListBox1.SelectedItems.Item(0).Text, True)
            FetchDirectory(TextBox1.Text)
        End If
    End Sub
    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Sync()
        Timer1.Start()
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
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Location = MeLocation - CurLocation + MousePosition

    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("File Manager")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        FetchDirectory(TextBox1.Text)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ListBox1.SelectedItems.Item(0).Text = Nothing Then
            FM_RenameFile.Show()
            FM_RenameFile.SetOld(ListBox1.SelectedItems.Item(0).Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Sub MkDir(ByVal dirname As String)
        If Not dirname = "" Or Not dirname = "Directory Name" Then
            If Not Directory.Exists(TextBox1.Text & "\" & dirname) Then
                Directory.CreateDirectory(TextBox1.Text & "\" & dirname)
                FetchDirectory(TextBox1.Text)
                FM_NewDir.Close()
            Else
                FM_NewDir.Panel6.BackColor = Color.Red
            End If
        Else
            FM_NewDir.Panel6.BackColor = Color.Red
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub FileManager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.RemoveFromTaskbar(elema)
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Try
            Dim abcd = ListBox1.SelectedItems.Item(0)
            If File.GetAttributes(TextBox1.Text & "\" & abcd.Text) = FileAttributes.Directory Then
                OpenUsingToolStripMenuItem.Visible = False
            Else
                OpenUsingToolStripMenuItem.Visible = True
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenListBoxSelectedFile()
    End Sub

    Private Sub OxyWriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OxyWriteToolStripMenuItem.Click
        OxyWrite.Show()
        OxyWrite.LoadExt(TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text)
    End Sub

    Private Sub OxyPicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OxyPicToolStripMenuItem.Click
        PictureViewer.Show()
        PictureViewer.LoadExt(TextBox1.Text & "\" & ListBox1.SelectedItems.Item(0).Text)
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If el < 4 Then
            Me.Opacity -= 0.24
            el += 1
        Else
            Timer4.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        FM_Delete.Show()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        FM_RenameFile.Show()
        FM_RenameFile.SetOld(ListBox1.SelectedItems.Item(0).Text)
    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick
        TextBox1.Text = ListBox2.SelectedItem
        FetchDirectory(TextBox1.Text)
    End Sub
End Class