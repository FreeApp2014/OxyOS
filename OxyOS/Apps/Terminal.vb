Imports System.IO
Public Class Terminal
    Dim CurLocation, MeLocation As New Point(0, 0)
    Dim MinimalX As Integer = Me.Width
    Dim MinimalY As Integer = Me.Height
    Dim pwd As String = Application.StartupPath
    Dim prev As String
    Dim el As Integer
    Dim elema As Button
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
        Timer4.Start()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("Terminal")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Terminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.User_String_FName.ToLower & My.Settings.User_String_LName.ToLower & "@" & My.Settings.User_String_SysName & ">>"

        TextBox1.Left = Label2.Right
        Me.Owner = Desktop
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("Terminal")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        elema = Desktop.AddToTaskbar("4")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            RichTextBox1.Text &= My.Settings.User_String_FName.ToLower & My.Settings.User_String_LName.ToLower & "@" & My.Settings.User_String_SysName & ">>  " & TextBox1.Text & "

"
            ParseCMD()
            prev = TextBox1.Text
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Sub ParseCMD()
        If TextBox1.Text.StartsWith("ls") Then
            RichTextBox1.Text &= "Directory listing 
-------------------
FileName  FileType
------------------
"
            If TextBox1.Text = "ls" Then
                For Each File In Directory.GetDirectories(Path)
                    RichTextBox1.Text &= File.Split("\").Last & "   <DIR> 
"
                Next
                For Each File In Directory.GetFiles(Path)
                    RichTextBox1.Text &= File.Split("\").Last & "   " & File.Split("\").Last.Split(".").Last & " 
"
                Next
            Else
                Try
                    If TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1).StartsWith("C:\") Then
                        For Each File In Directory.GetDirectories(TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1))
                            RichTextBox1.Text &= File.Split("\").Last & "   <DIR> 
"
                        Next
                        For Each File In Directory.GetFiles(TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1))
                            RichTextBox1.Text &= File.Split("\").Last & "   " & File.Split("\").Last.Split(".").Last & " 
"
                        Next
                    Else
                        For Each File In Directory.GetDirectories(Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1))
                            RichTextBox1.Text &= File.Split("\").Last & "   <DIR> 
"
                        Next
                        For Each File In Directory.GetFiles(Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1))
                            RichTextBox1.Text &= File.Split("\").Last & "   " & File.Split("\").Last.Split(".").Last & " 
"
                        Next
                    End If
                Catch ex As Exception
                    RichTextBox1.Text &= "An error has occured
"
                End Try
            End If
        ElseIf TextBox1.Text = "pwd" Then
            RichTextBox1.Text &= Path & "
"
        ElseIf TextBox1.Text = "clear" Then
            RichTextBox1.Text = ""
        ElseIf TextBox1.Text.StartsWith("cd") Then
            If TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1).StartsWith("C:\") Then
                If Directory.Exists(TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1)) Then
                    Path = TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1)
                Else
                    RichTextBox1.Text &= "[Error] cd: directory " & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1) & "not found
"
                End If
            Else
                If TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1) = ".." Then
                    Path = Directory.GetParent(Path).FullName
                Else
                    If Directory.Exists(Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1)) Then
                        Path &= "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1)
                    Else
                        RichTextBox1.Text &= "[Error] cd: directory " & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1) & " not found
"
                    End If
                End If

            End If
        ElseIf TextBox1.Text.StartsWith("oxywrite") Then
            If Not UBound(TextBox1.Text.Split(" ")) = 0 Then

                If TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1).StartsWith("C:\") Then
                    If File.Exists(TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1)) Then
                        OxyWrite.Show()
                        OxyWrite.LoadExt(TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1))
                    Else

                        RichTextBox1.Text &= "[Error] oxywrite: file " & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1) & " not found
"
                    End If
                Else
                    If File.Exists(Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1)) Then
                        OxyWrite.Show()
                        OxyWrite.LoadExt(Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1))
                    Else

                        RichTextBox1.Text &= "[Error] oxywrite: file " & Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1) & " not found
"
                    End If
                End If
            Else
                OxyWrite.Show()
            End If
        ElseIf TextBox1.Text.StartsWith("oxypic") Then
            If Not UBound(TextBox1.Text.Split(" ")) = 0 Then

                If TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1).StartsWith("C:\") Then
                    If File.Exists(TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1)) Then
                        PictureViewer.Show()
                        PictureViewer.LoadExt(TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1))
                    Else

                        RichTextBox1.Text &= "[Error] oxypic: file " & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1) & " not found
"
                    End If
                Else
                    If File.Exists(Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1)) Then
                        PictureViewer.Show()
                        PictureViewer.LoadExt(Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1))
                    Else

                        RichTextBox1.Text &= "[Error] oxypic: file " & Path & "\" & TextBox1.Text.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries)(1) & " not found
"
                    End If
                End If
            Else
                PictureViewer.Show()
            End If
        ElseIf TextBox1.Text.StartsWith("mkdir") Then

        ElseIf TextBox1.Text.StartsWith("ver") Then
            RichTextBox1.Text &= "OxyOS v.0.1 Debug Build 7
"
        ElseIf TextBox1.Text = "halt" Then
            Application.Exit()
        ElseIf TextBox1.Text.StartsWith("reboot") Then
            Application.Restart()
        ElseIf TextBox1.Text.StartsWith("help") Then
            RichTextBox1.Text &= "Terminal commands:
help: shows this list
ls [dirpath]: shows directory listing
cd <dirpath>: changes your working directory
<app_name> [args]: opens apps
pwd: prints your working directory
clear: clears the output
reboot: restarts OxyOS
halt: stops OxyOS
ver: prints the version of OxyOS you are running

Legend: <> - mandatory argument, [] - optional argument

"
        Else
            RichTextBox1.Text &= "[Error] Command """ & TextBox1.Text.Split(" ").First & """ not found
"
        End If
        TextBox1.Text = ""
        RichTextBox1.SelectionStart = RichTextBox1.TextLength

    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Sync()
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Up Then
            TextBox1.Text = prev
            e.Handled = True
        End If
        If e.KeyCode = Keys.Down Then
            TextBox1.Text = ""
            e.Handled = True
        End If
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

    Private Sub Terminal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.RemoveFromTaskbar(elema)
    End Sub
End Class