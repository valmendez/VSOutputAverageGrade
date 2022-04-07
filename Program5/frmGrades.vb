Public Class frmGrades
    Private Sub lblLetterGrade_Click(sender As Object, e As EventArgs) Handles lblLetterGrade.Click

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'hide input

        grpInput.Visible = False
        grpOutput.Visible = True

        'variables

        Dim average As Double
        Dim g1, g2, g3, g4, g5, g6 As Double
        Dim averageGoal As Double

        'input

        g1 = CDbl(txtGrade1.Text)
        g2 = CDbl(txtGrade2.Text)
        g3 = CDbl(txtGrade3.Text)
        g4 = CDbl(txtGrade4.Text)
        g5 = CDbl(txtGrade5.Text)

        'process 

        average = (g1 + g2 + g3 + g4 + g5) / 5   'NOTE: Does not work right without parentheses

        'output

        txtAverage.Text = Str(average)
        'lstAverage.Items.Add(average)

        'process

        'average = txtAverage.Text
        Select Case average
            Case 90 To 100
                txtLetterGrade.Text = "A"
            Case 80 To 89.9
                txtLetterGrade.Text = "B"
            Case 70 To 79.9
                txtLetterGrade.Text = "C"
            Case 60 To 69.9
                txtLetterGrade.Text = "D"
            Case Else
                txtLetterGrade.Text = "F"
        End Select

        If txtLetterGrade.Text = "A" Then
            picHappy.Visible = True
        ElseIf txtLetterGrade.Text = "B" Then
            picHappy.Visible = True
        ElseIf txtLetterGrade.Text = "C" Then
            picMediocre.Visible = True
        Else
            picUpset.Visible = True
        End If

        'average goal calculation

        g6 = 100

        averageGoal = (g1 + g2 + g3 + g4 + g5 + g6) / 5

        'output

        txtAverageGoal.Text = Str(averageGoal)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'end program

        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'reset everything

        txtAverage.Clear()
        txtGrade1.Clear()
        txtGrade2.Clear()
        txtGrade3.Clear()
        txtGrade4.Clear()
        txtGrade5.Clear()
        grpInput.Visible = True
        grpOutput.Visible = False
        picHappy.Visible = False
        picMediocre.Visible = False
        picUpset.Visible = False




    End Sub
End Class
