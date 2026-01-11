' Program Name: Pizza Selection
' Developer:    Macayla Honeywell
' Date:         9-15-2020
' Purpose:      This application displays two pizza types. 
'               User can choose either deep dish or thin crust.
Public Class Form1
    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        ' This code is executed when the user taps or clicks
        ' the Deep Dish button. It displays the Deep Dish picture,
        ' hides the thin Crust picture, and enables the Select
        ' Pizza button.

        picDeepDish.Visible = True
        picThinCrust.Visible = False
        btnSelectPizza.Enabled = True

    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        ' This code is executed when the user taps or clicks the 
        ' Select Pizza button. it disables the Deep Dish button, the 
        ' Select Pizza button, and the Thin Crust button.
        ' It hides the Instructions label, displays the 
        ' Confirmation label, and enables the Exit Window button.

        btnDeepDish.Enabled = False
        btnSelectPizza.Enabled = False
        btnThinCrust.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True

    End Sub

    Private Sub picDeepDish_Click(sender As Object, e As EventArgs) Handles picDeepDish.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user taps or clicks the Exit Window 
        ' button. it closes the window and terminates the program execution.

        Close()

    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        ' This code is executed when the user taps or clicks
        ' the Thin Crust button. It displays the Thin Crust picture,
        ' hides the Deep Dish picture, and enables the Select
        ' Pizza button.

        picThinCrust.Visible = True
        picDeepDish.Visible = False
        btnSelectPizza.Enabled = True

    End Sub
End Class
