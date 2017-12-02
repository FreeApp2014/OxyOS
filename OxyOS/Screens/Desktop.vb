Public Class Desktop
    Public Taskbar As String() = New String(5) {"", "", "", "", "", ""}
    Public TaskbarAction As Form() = New Form(6) {}
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuBG.Show()
        MenuBGTimer.Start()
    End Sub
    Public Sub RemoveFromTaskbar(ByRef elema As Button)
        Dim elemcode As Integer
        If elema.Name = "TaskBar1" Then elemcode = 0
        If elema.Name = "TaskBar2" Then elemcode = 1
        If elema.Name = "TaskBar3" Then elemcode = 2
        If elema.Name = "TaskBar4" Then elemcode = 3
        If elema.Name = "TaskBar5" Then elemcode = 4
        If elema.Name = "TaskBar6" Then elemcode = 5
        Dim asd As Integer = elemcode
        For asd = elemcode To 4
            Taskbar(asd) = Taskbar(asd + 1)
        Next
        TaskBar1.Hide()
        TaskBar2.Hide()
        TaskBar3.Hide()
        TaskBar4.Hide()
        TaskBar5.Hide()
        TaskBar6.Hide()
        Dim elem As Button
        For Each tbelem In Taskbar
            If Not tbelem = "" Then
                If TaskBar1.Visible = False Then
                    elem = TaskBar1
                    elemcode = 0
                ElseIf TaskBar2.Visible = False Then
                    elem = TaskBar2
                    elemcode = 1
                ElseIf TaskBar3.Visible = False Then
                    elem = TaskBar3
                    elemcode = 2
                ElseIf TaskBar4.Visible = False Then
                    elem = TaskBar4
                    elemcode = 3
                ElseIf TaskBar5.Visible = False Then
                    elem = TaskBar5
                    elemcode = 4
                ElseIf TaskBar6.Visible = False Then
                    elem = TaskBar6
                    elemcode = 5
                End If
                elem.Visible = True
            Else
                elem = Nothing
            End If
            If tbelem.Split(".")(0) = "1" Then
                If tbelem.Split(".")(1) = "1" Then
                    TaskbarAction(elemcode) = OxyWrite
                    elem.BackgroundImage = My.Resources.Pen_96
                ElseIf tbelem.Split(".")(1) = "2" Then
                    TaskbarAction(elemcode) = FileManager
                    elem.BackgroundImage = My.Resources.Folder_96
                ElseIf tbelem.Split(".")(1) = "3" Then
                    TaskbarAction(elemcode) = PictureViewer
                    elem.BackgroundImage = My.Resources.Xlarge_Icons_96
                ElseIf tbelem.Split(".")(1) = "4" Then
                    TaskbarAction(elemcode) = Terminal
                    elem.BackgroundImage = My.Resources.terminal
                ElseIf tbelem.Split(".")(1) = "5" Then
                    TaskbarAction(elemcode) = Help
                    elem.BackgroundImage = My.Resources.help_app
                End If
            End If
        Next


    End Sub
    Public Function AddToTaskbar(ByVal AppID As String)
        TaskBar1.Hide()
        TaskBar2.Hide()
        TaskBar3.Hide()
        TaskBar4.Hide()
        TaskBar5.Hide()
        TaskBar6.Hide()
        Dim asd As Integer = 0
        Do While asd < 5
            If Taskbar(asd) = "" Then
                Taskbar(asd) = "1." & AppID
                Exit Do
            End If
            asd = asd + 1
        Loop
        Dim elemcode As Integer
        Dim elem As Button
        Dim elema As button
        For Each tbelem In Taskbar
            If Not tbelem = "" Then
                If TaskBar1.Visible = False Then
                    elem = TaskBar1
                    elemcode = 0
                ElseIf TaskBar2.Visible = False Then
                    elem = TaskBar2
                    elemcode = 1
                ElseIf TaskBar3.Visible = False Then
                    elem = TaskBar3
                    elemcode = 2
                ElseIf TaskBar4.Visible = False Then
                    elem = TaskBar4
                    elemcode = 3
                ElseIf TaskBar5.Visible = False Then
                    elem = TaskBar5
                    elemcode = 4
                ElseIf TaskBar6.Visible = False Then
                    elem = TaskBar6
                    elemcode = 5
                End If
                elem.Visible = True
                If tbelem = "1." & AppID Then elema = elem
            Else
                elem = Nothing
            End If
            If tbelem.Split(".")(0) = "1" Then
                If tbelem.Split(".")(1) = "1" Then
                    TaskbarAction(elemcode) = OxyWrite
                    elem.BackgroundImage = My.Resources.Pen_96
                ElseIf tbelem.Split(".")(1) = "2" Then
                    TaskbarAction(elemcode) = FileManager
                    elem.BackgroundImage = My.Resources.Folder_96
                ElseIf tbelem.Split(".")(1) = "3" Then
                    TaskbarAction(elemcode) = PictureViewer
                    elem.BackgroundImage = My.Resources.Xlarge_Icons_96
                ElseIf tbelem.Split(".")(1) = "4" Then
                    TaskbarAction(elemcode) = Terminal
                    elem.BackgroundImage = My.Resources.terminal
                ElseIf tbelem.Split(".")(1) = "5" Then
                    TaskbarAction(elemcode) = Help
                    elem.BackgroundImage = My.Resources.help_app
                End If
            End If
        Next
        Return elema
    End Function

    Private Sub MenuBGTimer_Tick(sender As Object, e As EventArgs) Handles MenuBGTimer.Tick
        If i < 7 Then
            MenuBG.Opacity = MenuBG.Opacity + 0.113
            If i = 4 Then
                MenuScreen.Show()
            End If
            i += 1
        Else
            MenuBGTimer.Stop()
            i = 1
        End If
    End Sub

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TimeUpdater_Tick(sender As Object, e As EventArgs) Handles TimeUpdater.Tick
        Label2.Text = Today.DayOfWeek.ToString & ", " & Today & " " & TimeOfDay
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As EventArgs) Handles Panel3.Click, Label2.Click
        If Panel4.Visible Then
            Panel4.Hide()
        Else
            Panel4.Show()

        End If
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs)
        Try
            Using sass As New IO.StreamReader(Application.StartupPath & "\OS_Data\current_app.ostring")
                Label1.Text = sass.ReadToEnd
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TitleUpdater_Tick(sender As Object, e As EventArgs) Handles TitleUpdater.Tick
        Try
            Using sass As New IO.StreamReader(Application.StartupPath & "\OS_Data\current_app.ostring")
                Label1.Text = sass.ReadToEnd
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desktop_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyOS Desktop")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desktop_Click(sender As Object, e As EventArgs) Handles Me.Click
        Try
            Using sass As New IO.StreamWriter(Application.StartupPath & "\OS_Data\current_app.ostring")
                sass.WriteLine("OxyOS Desktop")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles Panel3.ChangeUICues

    End Sub

    Private Sub TaskBar1_Click(sender As Object, e As EventArgs) Handles TaskBar1.Click
        TaskbarAction(0).Show()
        TaskbarAction(0).BringToFront()
    End Sub

    Private Sub TaskBar2_Click(sender As Object, e As EventArgs) Handles TaskBar2.Click
        TaskbarAction(1).Show()
        TaskbarAction(1).BringToFront()
    End Sub

    Private Sub TaskBar3_Click(sender As Object, e As EventArgs) Handles TaskBar3.Click
        TaskbarAction(2).Show()
        TaskbarAction(2).BringToFront()
    End Sub

    Private Sub TaskBar4_Click(sender As Object, e As EventArgs) Handles TaskBar4.Click
        TaskbarAction(3).Show()
        TaskbarAction(3).BringToFront()
    End Sub

    Private Sub TaskBar5_Click(sender As Object, e As EventArgs) Handles TaskBar5.Click
        TaskbarAction(4).Show()
        TaskbarAction(4).BringToFront()
    End Sub

    Private Sub TaskBar6_Click(sender As Object, e As EventArgs) Handles TaskBar6.Click
        TaskbarAction(5).Show()
        TaskbarAction(5).BringToFront()
    End Sub
End Class