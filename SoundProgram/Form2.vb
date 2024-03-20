Imports System.IO


Public Class Form2
    Dim fs As FileStream
    Dim sr As StreamWriter
    Dim sread As StreamReader
    'Dim a, b, c, d As String



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fs = New FileStream("E:\file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'code to Create And Write data in file

        sr = New StreamWriter(fs)
        sr.Write(TextBox1.Text)
        sr.Close()
        MsgBox("File wriiten successfully")

        ' Code sTo create file at run time

        'Dim WriteFile As StreamWriter
        'WriteFile = File.CreateText(TextBox1.Text)
        'Dim writedata As String = TextBox3.Text
        'WriteFile.WriteLine(writedata)
        'WriteFile.Close()
        'MsgBox("File wriiten successfully")



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("E:\file1.txt")
        TextBox2.Text = fileReader

    End Sub
End Class