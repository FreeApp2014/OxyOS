Public Class FM_Delete
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileManager.Delete()
        Me.Close()
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

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Sync()
        Timer1.Start()
    End Sub
    Private Sub FM_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = FileManager
    End Sub
End Class