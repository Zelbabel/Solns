Public Class Form1

    Private Sub btnevaluate_Click(sender As Object, e As EventArgs) Handles btnevaluate.Click
        Dim marks As Integer

        'input validation for marks to ensure numeric input'
        If Not Integer.TryParse(txtentermarks.Text, marks) Then
            MessageBox.Show("please enter a valid numeric avalue for marks.")
            Exit Sub
        End If
        ' check for marks exceed 100'
        If marks > 100 Then
            MessageBox.Show("wrong entry, please re-enter the mark")
            Exit Sub
        End If
        ' using select case to determine the grade based on marks'
        Select Case marks
            Case 90 To 100
                txtgrade.Text = "Excellent"
            Case 80 To 89
                txtgrade.Text = "Very Good"
            Case 70 To 79
                txtgrade.Text = "Good"
            Case 60 To 69
                txtgrade.Text = "Medium"
            Case 50 To 59
                txtgrade.Text = "Pass"
            Case 0 To 49
                txtgrade.Text = "Fail"
            Case Else
                txtgrade.Text = "Invalid Marks"
        End Select
    End Sub
End Class
