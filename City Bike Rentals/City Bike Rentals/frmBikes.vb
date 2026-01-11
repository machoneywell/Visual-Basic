' Program:  City Bike Rentals
' Author:   Macayla Honeywell
' Date:     September 24, 2020
' Purposes: This application calculates and displays the total cost of renting multiple bikes for 24 hour periods

Option Strict On

Public Class frmBikes
    ' Cost per bike rental - used in multiple procedures

    Const _cdecPricePerBike As Decimal = 9.95D

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This event handler is executed when the user taps or clicks the
        ' Calculate button. It calculates and displays the cost 
        ' of the bikes rented (number of ikes times the cost per bike).

        Dim strNumberOfBikes As String
        Dim intNumberOfBikes As Integer
        Dim decTotalCost As Decimal

        strNumberOfBikes = txtNumberOfBikes.Text
        intNumberOfBikes = Convert.ToInt32(strNumberOfBikes)
        decTotalCost = intNumberOfBikes * _cdecPricePerBike
        lblTotalCost.Text = decTotalCost.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user taps or clicks the
        ' Clear button. It clears the number of bikes teext box
        ' and the Text Property of the Total Cost label.
        ' Then, it sets the focus on the txtNumberOfBikes Textbox object

        txtNumberOfBikes.Clear()
        lblTotalCost.Text = ""
        txtNumberOfBikes.Focus()

    End Sub

    Private Sub frmBikes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handleris executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the 
        ' Total Cost label, and sets the focus on
        ' the txtNumberOfBikes Textbox object.

        lblCostHeading.Text = _cdecPricePerBike.ToString("C") & " Per Bike for 24 Hours"
        lblTotalCost.Text = ""
        txtNumberOfBikes.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' CLose the window and terminate the application

        Close()

    End Sub
End Class
