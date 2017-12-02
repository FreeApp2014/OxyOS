Imports System.IO
Public Class SaveFile
    Dim CurLocation, MeLocation As New Point(0, 0)
    Private Sub Sync()
        MeLocation = Me.Location
        CurLocation = MousePosition
    End Sub
    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        Timer1.Stop()
        Sync()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Location = MeLocation - CurLocation + MousePosition
        If Me.Top < Desktop.Panel2.Bottom Then
            Me.Top = Desktop.Panel2.Bottom
        End If
        If Me.Bottom > Desktop.Panel1.Top Then
            Me.Top = Desktop.Panel1.Top - Me.Height
        End If
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Sync()
        Timer1.Start()
    End Sub
    Dim rtfcontent As String
    Public finallocation As String
    Private Sub SaveFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Application.StartupPath & "\UserDocs"
        For Each File In Directory.GetDirectories(Application.StartupPath & "\UserDocs")
            ListBox1.Items.Add(File)
        Next
        For Each File In Directory.GetFiles(Application.StartupPath & "\UserDocs")
            ListBox1.Items.Add(File)
        Next
        Me.Owner = Desktop
    End Sub
    Sub fetchdirectory()
        Dim p As String = ListBox1.SelectedItem.ToString
        TextBox1.Text = ListBox1.SelectedItem.ToString
        ListBox1.Items.Clear()
        For Each File In Directory.GetDirectories(p)
            ListBox1.Items.Add(File)
        Next
        For Each File In Directory.GetFiles(p)
            ListBox1.Items.Add(File)
        Next
    End Sub
    Sub fetchdirectorytxtb()
        ListBox1.Items.Clear()
        For Each File In Directory.GetDirectories(TextBox1.Text)
            ListBox1.Items.Add(File)
        Next
        For Each File In Directory.GetFiles(TextBox1.Text)
            ListBox1.Items.Add(File)
        Next

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            fetchdirectorytxtb()
        End If
    End Sub
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If File.GetAttributes(ListBox1.SelectedItem.ToString) = FileAttributes.Directory Then fetchdirectory()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not TextBox2.Text = "" And Not File.Exists(TextBox1.Text & "\" & TextBox2.Text) Then
            Try
                Using abc As New StreamWriter(TextBox1.Text & "\" & TextBox2.Text)
                    abc.WriteLine(rtfcontent)
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            finallocation = TextBox1.Text & "\" & TextBox2.Text
        Else
            RewriteFileDialog.Show()
        End If
    End Sub
    Public Sub saveanyway()
        Try
            Using abc As New StreamWriter(Me.TextBox1.Text & "\" & Me.TextBox2.Text)
                abc.WriteLine(rtfcontent)
            End Using
            finallocation = TextBox1.Text & "\" & TextBox2.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub setwritedata(ByVal Data As String)
        rtfcontent = Data
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        TextBox1.Text = Directory.GetParent(TextBox1.Text).FullName
        For Each File In Directory.GetDirectories(TextBox1.Text)
            ListBox1.Items.Add(File)
        Next
        For Each File In Directory.GetFiles(TextBox1.Text)
            ListBox1.Items.Add(File)
        Next
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class