Public Class Form1
    Private Sub txtnumber_TextChanged(sender As Object, e As EventArgs) Handles txtnumber.TextChanged

    End Sub

    Private Sub btncheckNumber_Click(sender As Object, e As EventArgs) Handles btncheckNumber.Click
        Dim number As Integer

        number = txtnumber.Text

        If number > 0 Then
            MessageBox.Show("Positive Number")
        ElseIf Number < 0 Then
            MessageBox.Show("Negative Number")
        Else
            MessageBox.Show("Number is Zero")
        End If

    End Sub
End Class
