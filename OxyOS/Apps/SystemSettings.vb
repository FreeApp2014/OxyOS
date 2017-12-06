Public Class SystemSettings
    Dim CurLocation, MeLocation As New Point(0, 0)
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
    Private Sub Sync()
        MeLocation = Me.Location
        CurLocation = MousePosition
    End Sub

End Class