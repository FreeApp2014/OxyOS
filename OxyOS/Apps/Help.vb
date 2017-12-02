Public Class Help
    Dim CurLocation, MeLocation As New Point(0, 0)
    Dim MinimalX As Integer = 700
    Dim elema As Button
    Dim MinimalY As Integer = 400
    Dim el As Integer
    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        Timer2.Stop()
        If Me.Width < MinimalX Then
            Me.Width = MinimalX
        End If
        If Me.Height < MinimalY Then
            Me.Height = MinimalY
        End If
    End Sub
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

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Sync()
        Timer1.Start()
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Width = MousePosition.X - Me.Left
        Me.Height = MousePosition.Y - Me.Top
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        Timer2.Start()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = Desktop
        WebBrowser1.Navigate("file://" & Application.StartupPath & "\OS_Data\HTMLHelp\index.html")
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyOS Help")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        elema = Desktop.AddToTaskbar("5")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If WebBrowser1.CanGoBack Then WebBrowser1.GoBack()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyOS Help")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub Help_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.RemoveFromTaskbar(elema)
    End Sub
End Class