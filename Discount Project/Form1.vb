Option Infer Off
Option Strict On
Option Explicit On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim x As Double
        Dim Total As Double

        If lstDiscounts.SelectedIndex = 0 Then
            x = 0.1
        ElseIf lstDiscounts.SelectedIndex = 1 Then
            x = 0.15
        ElseIf lstDiscounts.SelectedIndex = 2 Then
            x = 0.2
        ElseIf lstDiscounts.SelectedIndex = 3 Then
            x = 0.25
        ElseIf lstDiscounts.SelectedIndex = 4 Then
            x = 0.3
        ElseIf lstDiscounts.SelectedIndex = 5 Then
            x = 0.35
        ElseIf lstDiscounts.SelectedIndex = 6 Then
            x = 0.4
        End If

        Double.TryParse(txtPrice.Text, Total)
        lblTotal.Text = (Total - (Total * x)).ToString("C2")

        lblSaved.Text = (Total * x).ToString("C2")
    End Sub

    Private Sub lstDiscounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDiscounts.SelectedIndexChanged, txtPrice.TextChanged
        lblSaved.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
