Imports System.IO

Public Class ObjectLog

    Private fileName As String
    Private originPath As String

    Public Sub New(fileName As String, originPath As String)
        Me.fileName = fileName
        Me.originPath = originPath
    End Sub

    Public Sub ChangePath(path As String)
        Me.originPath = path
    End Sub

    Public Sub WriteLog(message As String)
        Dim logPath As String = Path.Combine(originPath, "log" & DateTime.Now.Date.ToString.Replace("/", "").Replace(" 0:00:00", "") & ".txt")

        If Not Directory.Exists(originPath) Then
            Directory.CreateDirectory(originPath)
        End If

        If Not File.Exists(logPath) Then
            Using sw As StreamWriter = File.CreateText(logPath)
                sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + message)
            End Using
        Else
            Using sw As StreamWriter = File.AppendText(logPath)
                sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + message)
            End Using
        End If
    End Sub
End Class
