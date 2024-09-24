Public Class Form1
    Private Sub btnnested_Click(sender As Object, e As EventArgs) Handles btnnested.Click
        For i As Integer = 1 To 10
            For j As Integer = 1 To 10
                MessageBox.Show(i & " * " & j)
            Next
        Next
    End Sub
End Class
