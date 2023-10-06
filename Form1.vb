Imports System.Reflection.Metadata.BlobBuilder

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnAbs_Click(sender As Object, e As EventArgs) Handles btnAbs.Click
        Dim n
        n = txtNumber.Text
        txtResult.Text = Math.Abs(Val(n))
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        Dim n
        n = txtNumber.Text
        txtResult.Text = Math.Exp(Val(n))
    End Sub

    Private Sub btnFix_Click(sender As Object, e As EventArgs) Handles btnFix.Click
        Dim n
        n = txtNumber.Text
        txtResult.Text = Fix(Val(n))
    End Sub

    Private Sub btnInt_Click(sender As Object, e As EventArgs) Handles btnInt.Click
        Dim n
        n = txtNumber.Text
        txtResult.Text = Math.Floor(Val(n))
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim n
        n = txtNumber.Text
        txtResult.Text = Math.Log(Val(n))
    End Sub

    Private Sub btnRnd_Click(sender As Object, e As EventArgs) Handles btnRnd.Click
        Dim n
        n = Int(VBMath.Rnd() * 6) + 1
        txtNumber.Text = n
        txtResult.Text = "Rnd() = " & n
    End Sub

    Private Sub btnRound_Click(sender As Object, e As EventArgs) Handles btnRound.Click
        Dim n, m As Integer
        n = txtNumber.Text
        'm = InputBox("How many digits to round to ?")
        txtResult.Text = Math.Round(Val(n))
    End Sub
End Class
