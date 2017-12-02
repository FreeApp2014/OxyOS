Public Class OxyWrite
    Dim CurLocation, MeLocation As New Point(0, 0)
    Dim path As String
    Dim mode As Byte = 1
    Dim MinimalX As Integer = 400
    Dim MinimalY As Integer = 300
    Dim elema As Button
    Dim el As Integer = 1
    Private Sub Sync()
        MeLocation = Me.Location
        CurLocation = MousePosition
    End Sub
    Dim FileEditor As String = ""
    Private Sub OxyWrite_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub OxyWrite_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Owner = Desktop
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyWrite")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        elema = Desktop.AddToTaskbar("1")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PickFile.Show()
        PickFile.SetPurpose(FileEditor)
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer5.Start()

        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyOS Desktop")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not PickFile.purpose = "" Then
            Dim linee As String
            Timer1.Stop()
            Try
                Using abc As New IO.StreamReader(PickFile.purpose.ToString)
                    linee = abc.ReadToEnd
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            path = PickFile.purpose
            Button9.Enabled = True
            Try
                RichTextBox1.Rtf = linee
                mode = 1
                Button6.Visible = True
                Button10.Visible = True
            Catch ex As Exception
                mode = 2
                RichTextBox1.Text = linee
                Button6.Visible = False
                Button10.Visible = False
                Button15.Text = "Convert to RTF..."
                RichTextBox1.Font = New System.Drawing.Font(FontFamily.GenericMonospace, 9, FontStyle.Regular)
            End Try
            Label1.Text = path.Split("\").Last & " - OxyWrite"
            PickFile.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel5.Visible = False
        If Panel4.Visible Then
            Panel4.Hide()
        Else
            Panel4.Show()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FontDialog1.Font = RichTextBox1.SelectionFont
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font

    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ColorDialog1.Color = RichTextBox1.SelectionColor
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveFile.Show()
        If mode = 1 Then
            SaveFile.setwritedata(RichTextBox1.Rtf)
        Else
            SaveFile.setwritedata(RichTextBox1.Text)
        End If
        Timer3.Start()
    End Sub

    Private Sub OxyWrite_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyWrite")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyWrite")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Location = MeLocation - CurLocation + MousePosition

    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Sync()
        Timer2.Start()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Using sass As New IO.StreamWriter(path)
                If mode = 1 Then
                    sass.WriteLine(RichTextBox1.Rtf)
                Else
                    sass.WriteLine(RichTextBox1.Text)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        Timer2.Stop()
        Sync()
        If Me.Top < Desktop.Panel2.Bottom Then
            Me.Top = Desktop.Panel2.Bottom
        End If
        If Me.Bottom > Desktop.Panel1.Top Then
            Me.Top = Desktop.Panel1.Top - Me.Height
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Not SaveFile.finallocation = "" Then
            path = SaveFile.finallocation
            Button9.Enabled = True
            Timer3.Stop()
            SaveFile.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Public Sub LoadExt(ByVal fpath As String)
        Dim linee As String
        Timer1.Stop()
        Try
            Using abc As New IO.StreamReader(fpath)
                linee = abc.ReadToEnd
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        path = fpath
        Button9.Enabled = True
        Try
            RichTextBox1.Rtf = linee
            mode = 1
            Button6.Visible = True
            Button10.Visible = True
        Catch ex As Exception
            RichTextBox1.Text = linee
            mode = 2
            Button6.Visible = False
            Button10.Visible = False
            Button15.Text = "Convert to RTF..."
            RichTextBox1.Font = New System.Drawing.Font(FontFamily.GenericMonospace, 9, FontStyle.Regular)
        End Try
        Label1.Text = path.Split("\").Last & " - OxyWrite"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        Me.Width = MousePosition.X - Me.Left
        Me.Height = MousePosition.Y - Me.Top
    End Sub

    Private Sub Button2_DoubleClick(sender As Object, e As EventArgs) Handles Button2.DoubleClick

    End Sub

    Private Sub Button2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseDoubleClick

    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        Timer4.Start()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
        Panel5.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        Panel5.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel4.Visible = False
        If Panel5.Visible Then
            Panel5.Hide()
        Else
            Panel5.Show()
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        Timer4.Stop()
        If Me.Width < MinimalX Then
            Me.Width = MinimalX
        End If
        If Me.Height < MinimalY Then
            Me.Height = MinimalY
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
        Panel5.Hide()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Panel6.Visible Then
            Panel6.Hide()
        Else
            Panel6.Show()
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        RichTextBox1.Font = New Font(FontFamily.GenericSerif, 14.5, FontStyle.Regular)
        Panel6.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If mode = 1 Then
            mode = 2
            Button15.Text = "Convert to RTF..."
            Button6.Visible = False
            Button10.Visible = False
            RichTextBox1.Font = New System.Drawing.Font(FontFamily.GenericMonospace, 9, FontStyle.Regular)
        Else
            mode = 1
            Button15.Text = "Convert to plain text..."
            Button6.Visible = True
            Button10.Visible = True
            RichTextBox1.Font = New System.Drawing.Font(FontFamily.GenericSerif, 14.5, FontStyle.Regular)
        End If
        Panel6.Hide()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
            Panel3.Visible = False
            Button18.Text = "Exit full screen"
        Else
            Button18.Text = "Full screen mode"
            Panel3.Visible = True
            Me.WindowState = WindowState.Normal
        End If
        Panel4.Top = Panel1.Bottom
        Panel5.Top = Panel1.Bottom
        Panel6.Top = Panel1.Bottom
    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        Panel5.Hide()
        Panel4.Hide()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If el < 4 Then
            Me.Opacity -= 0.24
            el += 1
        Else
            Timer5.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub OxyWrite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.RemoveFromTaskbar(elema)
    End Sub
End Class