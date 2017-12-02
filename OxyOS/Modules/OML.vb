Imports System.IO
Module OML
    Dim linee As String
    Dim delim As String() = New String(0) {"

"}
    Public Function RemoveComments(ByVal OmlDoc As String)
        Dim el As String() = OmlDoc.Split(delim, StringSplitOptions.None)
        Dim refactored As String = ""
        For Each ee In el
            If Not ee.StartsWith("[") And Not ee.EndsWith("]") Then
                refactored &= ee & "

"
            End If
        Next
        Return refactored
    End Function
    Public Function ParseOMLDocument(ByVal Path As String)
        Try
            Using sr As New StreamReader(Path)
                linee = sr.ReadToEnd
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Dim ElemArr As String()
        Dim parseline As String = RemoveComments(linee)
        ElemArr = parseline.Split(delim, StringSplitOptions.None)
        Return ElemArr
    End Function
    Public Function ParseOMLNode(ByVal OmlNode As String)
        Return OmlNode.Split("
")
    End Function
    Public Function NodeIsComment(ByVal OmlNode As String)
        If Not OmlNode.StartsWith("[") And Not OmlNode.EndsWith("]") Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function NodeIsStructure(ByVal OmlNode As String)
        If Not OmlNode.StartsWith("{") And Not OmlNode.EndsWith("}") Then
            Return False
        Else
            Return True
        End If
    End Function
End Module