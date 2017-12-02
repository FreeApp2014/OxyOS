Imports Microsoft.Win32.Registry
Public Class Verify
    Private Sub Verify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaveSetting("oxyos.exe", "*,*", "ExecPath", Application.StartupPath)
        Variables.Path = Application.StartupPath
        If My.Settings.Main_IsFirstRun = True Then
            FirstSetup.Show()
        Else
            Login.Show()
        End If
    End Sub
End Class