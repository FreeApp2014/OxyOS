Public Class frmcalculator
    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim [Operator] As String

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnzero.Click
        txtsource.Text = txtsource.Text & sender.text
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtsource.Text = ""
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Operand1 = Val(txtsource.Text)
        txtsource.Text = ""
        txtsource.Focus()
        [Operator] = "+"
    End Sub


    Private Sub btndecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndecimal.Click
        If InStr(txtsource.Text, ".") > 0 Then
            Exit Sub
        Else
            txtsource.Text = txtsource.Text & "."
        End If
    End Sub

    Private Sub btnequals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnequals.Click
        Dim Result As Double
        Operand2 = Val(txtsource.Text)

        'If [Operator] = "+" Then
        '    Result = Operand1 + Operand2
        'ElseIf [Operator] = "-" Then
        '    Result = Operand1 - Operand2
        'ElseIf [Operator] = "/" Then
        '    Result = Operand1 / Operand2
        'ElseIf [Operator] = "*" Then
        '    Result = Operand1 * Operand2
        'End If

        Select Case [Operator]
            Case "+"
                Result = Operand1 + Operand2
                txtsource.Text = Result.ToString("#,###.00")
            Case "-"
                Result = Operand1 - Operand2

                txtsource.Text = Result.ToString("#,###.00")
            Case "/"
                Result = Operand1 / Operand2

                txtsource.Text = Result.ToString("#,###.00")
            Case "*"
                Result = Operand1 * Operand2

                txtsource.Text = Result.ToString("#,###.00")
        End Select

        txtsource.Text = Result.ToString("#,###.00")

    End Sub

    Private Sub btnminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminus.Click
        Operand1 = Val(txtsource.Text)
        txtsource.Text = ""
        txtsource.Focus()
        [Operator] = "-"
    End Sub

    Private Sub btnmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmultiply.Click
        Operand1 = Val(txtsource.Text)
        txtsource.Text = ""
        txtsource.Focus()
        [Operator] = "*"
    End Sub

    Private Sub btndivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndivide.Click
        Operand1 = Val(txtsource.Text)
        txtsource.Text = ""
        txtsource.Focus()
        [Operator] = "/"
    End Sub

    Private Sub btnaddminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddminus.Click
        txtsource.Text = -1 * txtsource.Text
    End Sub
    Private Sub btnx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnx.Click
        Dim convert As Single
        If txtsource.Text <> 0 Then
            convert = 1 / Val(txtsource.Text)
            txtsource.Text = convert
        End If
    End Sub
    Private Sub frmcalculator_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnequals_Click(sender, e)
        End If
    End Sub
End Class
