Public Class PictureViewer
    Dim CurLocation, MeLocation As New Point(0, 0)
    Dim MinimalX As Integer = 540
    Dim el As Integer = 1
    Dim elema As Button
    Dim MinimalY As Integer = 419
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PickFile.Show()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Not PickFile.purpose = "" Then
            PictureBox1.ImageLocation = PickFile.purpose
            PickFile.Close()
            Timer2.Stop()
        End If
    End Sub
    Public Sub LoadExt(ByVal fpath As String)
        PictureBox1.ImageLocation = fpath
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer4.Start()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PictureViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Owner = Desktop
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyPic")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        elema = Desktop.AddToTaskbar("3")
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyPic")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Width = MousePosition.X - Me.Left
        Me.Height = MousePosition.Y - Me.Top
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        Timer3.Start()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
            Panel3.Visible = False
        Else
            Panel3.Visible = True
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PV_LoadUrl.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Panel6.Visible Then
            Panel6.Hide()
        Else
            Panel6.Show()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
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

    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        Timer3.Stop()
        If Me.Width < MinimalX Then
            Me.Width = MinimalX
        End If
        If Me.Height < MinimalY Then
            Me.Height = MinimalY
        End If
    End Sub

    Private Sub PictureViewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.RemoveFromTaskbar(elema)
    End Sub
End Class