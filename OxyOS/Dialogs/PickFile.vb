Imports System.IO
Public Class PickFile
    Public purpose As Object
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
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Sync()
        Timer1.Start()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PickFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = Desktop
        TextBox1.Text = Application.StartupPath & "\UserDocs"
        For Each File In Directory.GetDirectories(Application.StartupPath & "\UserDocs")
            ListBox1.Items.Add(File.Split("\").Last)
        Next
        For Each File In Directory.GetFiles(Application.StartupPath & "\UserDocs")
            ListBox1.Items.Add(File.Split("\").Last)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If Not ListBox1.SelectedItem = Nothing Then
            If TextBox1.Text = "" Then
                fetchdirectory()
            Else
                If File.GetAttributes(TextBox1.Text & "\" & ListBox1.SelectedItem.ToString) = FileAttributes.Directory Then fetchdirectory() Else purpose = TextBox1.Text & "\" & ListBox1.SelectedItem
            End If
        End If
    End Sub
    Sub fetchdirectory()
        Dim p As String
        If TextBox1.Text = "" Then
            p = ListBox1.SelectedItem
            TextBox1.Text = ListBox1.SelectedItem.ToString
        Else
            p = TextBox1.Text & "\" & ListBox1.SelectedItem.ToString
            TextBox1.Text = TextBox1.Text & "\" & ListBox1.SelectedItem.ToString
        End If

        ListBox1.Items.Clear()
        For Each File In Directory.GetDirectories(p)
            ListBox1.Items.Add(File.Split("\").Last)
        Next
        For Each File In Directory.GetFiles(p)
            ListBox1.Items.Add(File.Split("\").Last)
        Next
    End Sub
    Sub fetchdirectorytxtb()
        ListBox1.Items.Clear()
        For Each File In Directory.GetDirectories(TextBox1.Text)
            ListBox1.Items.Add(File.Split("\").Last)
        Next
        For Each File In Directory.GetFiles(TextBox1.Text)
            ListBox1.Items.Add(File.Split("\").Last)
        Next

    End Sub
    Public Sub SetPurpose(ByRef s As Object)
        purpose = s
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ListBox1.SelectedItem = Nothing Then

            If File.GetAttributes(TextBox1.Text & "\" & ListBox1.SelectedItem.ToString) = FileAttributes.Directory Then
                fetchdirectory()
            Else
                purpose = TextBox1.Text & "\" & ListBox1.SelectedItem
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            fetchdirectorytxtb()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        If UBound(TextBox1.Text.Split("\")) = 1 And TextBox1.Text.Split("\")(1) = "" Then
            For Each disk In Directory.GetLogicalDrives
                ListBox1.Items.Add(disk)
            Next
            TextBox1.Text = ""
        Else
            TextBox1.Text = Directory.GetParent(TextBox1.Text).FullName
            For Each File In Directory.GetDirectories(TextBox1.Text)
                ListBox1.Items.Add(File.Split("\").Last)
            Next
            For Each File In Directory.GetFiles(TextBox1.Text)
                ListBox1.Items.Add(File.Split("\").Last)
            Next
        End If

    End Sub
End Class