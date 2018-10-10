Imports System.IO

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Folder_Path As String
        If TextBox1.TextLength = 4 Then
            If TextBox1.Text.Substring(0, 1) = "6" Then
                Folder_Path = "T:\6000s\"
                Dim files As String() = IO.Directory.GetDirectories(Folder_Path)
                For Each file As String In files
                    Dim fileName As String = IO.Path.GetFileName(file)
                    If fileName.Contains(TextBox1.Text) Then
                        Process.Start(Folder_Path & fileName)
                        Close()
                        End
                    End If
                Next
            End If
            If TextBox1.Text.Substring(0, 1) = "7" Then
                Folder_Path = "T:\7000s\"
                Dim files As String() = IO.Directory.GetDirectories(Folder_Path)
                For Each file As String In files
                    Dim fileName As String = IO.Path.GetFileName(file)
                    If fileName.Contains(TextBox1.Text) Then
                        Process.Start(Folder_Path & fileName)
                        Close()
                        End
                    End If
                Next
            End If
            If TextBox1.Text.Substring(0, 1) = "8" Then
                Folder_Path = "T:\8000s\"
                Dim files As String() = IO.Directory.GetDirectories(Folder_Path)
                For Each file As String In files
                    Dim fileName As String = IO.Path.GetFileName(file)
                    If fileName.Contains(TextBox1.Text) Then
                        Process.Start(Folder_Path & fileName)
                        Close()
                        End
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
