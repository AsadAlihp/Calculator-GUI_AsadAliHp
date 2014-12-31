Public Class Form1

    Private Sub a_Click(sender As Object, e As EventArgs) Handles a.Click

    End Sub

    Private Sub s_Click(sender As Object, e As EventArgs) Handles s.Click

    End Sub

    Private Sub d_Click(sender As Object, e As EventArgs) Handles d.Click

    End Sub

    Private Sub m_Click(sender As Object, e As EventArgs) Handles m.Click

    End Sub


    Private Function ad(ByVal n1 As Double, ByVal n2 As Double) As Double
        Return n1 + n2
    End Function

    Private Function min(ByVal n1 As Double, ByVal n2 As Double) As Double
        Return n1 - n2
    End Function

    Private Function mul(ByVal n1 As Double, ByVal n2 As Double) As Double
        Return n1 * n2
    End Function

    Private Function div(ByVal n1 As Double, ByVal n2 As Double) As Double
        Return n1 / n2
    End Function

End Class
