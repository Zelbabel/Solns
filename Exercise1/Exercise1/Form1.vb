Public Class Form1
    Private Sub UserName_Click(sender As Object, e As EventArgs) Handles userName.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles userColor.Click

    End Sub

    Private Sub Displaybtn_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Declare variables to hold user input
        Dim userName As String
        Dim userAge As Integer
        Dim userColor As String

        userName = txtuserName.Text
        userAge = txtuserAge.Text
        userColor = txtuserColor.Text

        ' Display the message
        MessageBox.Show("Hello, " & userName & "! You are " & userAge & "
        years old and your favorite color is " & userColor & ".")
    End Sub

    Private Sub txtuserName_TextChanged(sender As Object, e As EventArgs) Handles txtuserName.TextChanged

    End Sub
End Class
