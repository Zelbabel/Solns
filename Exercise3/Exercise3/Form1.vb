Public Class Form1
    Private Sub btnforLoop_Click(sender As Object, e As EventArgs) Handles btnforLoop.Click
        For i As Integer = 1 To 10
            MessageBox.Show("Number: " & i)
        Next
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim count As Integer
        count = txtnumber.Text

        While count < count
            MessageBox.Show(count)
            count -= 1
        End While



    End Sub
End Class
