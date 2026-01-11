'Title:     Creative Art Windows Application
'Author:    Macayla Honeywell
'Date:      11-12-2020
'Purpose:   The application displays the artists who have enetered the Art Prize Competition as an interface
'           for a microsoft Access Database

Public Class frmArtPrize
    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub

    Private Sub frmArtPrize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)

    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        ' Strsql is a SQL statement that selects all the feilds from the Artist table

        Dim strsql As String = "SELECT * FROM Artist"

        ' Strpath provides the database type and path for the Art Database
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=C:\Users\mhwit\Documents\Visual Studio 2015\StudentFiles_Data\Chapter 10\Art.accdb"
        Dim odaArtist As New OleDb.OleDbDataAdapter(strsql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D

        'The DataTable name datValue is filled with the table data
        odaArtist.Fill(datValue)
        'The connection to the database is disconnected
        odaArtist.Dispose()
        For intCount = 0 To datValue.Rows.Count - 1
            decTotalValue += Convert.ToDecimal(datValue.Rows(intCount)("Retail Price"))
        Next
        lblTotalCost.Visible = True
        lblTotalCost.Text = "The total retail value is " & decTotalValue.ToString("C")
    End Sub
End Class
