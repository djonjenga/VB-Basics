Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub btnLoadObjectDemo_Click(sender As Object, e As EventArgs) Handles btnLoadObjectDemo.Click
        Dim objDemoForm As New ObjectDemonstrationsForm()
        objDemoForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnLoadObjectDemo, "Load Object Demonstrations Form")
        ToolTip1.SetToolTip(btnExit, "Exit Application")
    End Sub


End Class
