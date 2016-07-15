Public Class Form1

    Private Sub btnDisplayChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayChart.Click
        ' Named constant declarations.
        Const dblASTERISK_AMOUNT As Double = 100.0      ' The dollar amount represented by an asterisk.
        Const strASTERISK As String = "*"               ' The asterisk character.

        ' Local variable declarations.
        Dim intStores As Integer                        ' The number of stores.
        Dim intCurrentStore As Integer                  ' Holds the current store's number.
        Dim dblSales As Double                          ' Holds the current store's daily sales.
        Dim intCurrentAsterisk As Integer               ' Holds the current asterisk number.
        Dim intAsterisks As Integer                     ' Holds the number of asterisks.
        Dim strAsteriskOutput As String                 ' Holds the asterisks output string.

        ' Get the number of stores.
        Try
            intStores = CInt(InputBox("Enter Number of Stores.", "Number of Stores = " &
                                         intStores.ToString()))
        Catch
            ' Display Error message for the current store's daily sales.
            MessageBox.Show("Number of Stores - The value must be a postive real number.", "Invalid Input")
            End Try

        ' Get the daily sales for each store.
        For intCurrentStore = 1 To intStores

            ' Do not continue until input is valid for the current store's daily sales.
            While Not (Double.TryParse(InputBox("Enter today's sales.", "Store " &
                                                     intCurrentStore.ToString() &
                                                     " Daily Sales"), dblSales) And dblSales >= 0.0)


                ' Display Error message for the current store's daily sales.
                MessageBox.Show("Store " & intCurrentStore.ToString() &
                                    " Daily Sales - The value must be a postive real number.", "Invalid Input")
            End While

            ' Calculate the number of asterisks to display.
            intAsterisks = CInt(dblSales / dblASTERISK_AMOUNT)

            ' Empty the asterisk output string.
            strAsteriskOutput = String.Empty

            ' Build the asterisk output string.
            For intCurrentAsterisk = 1 To intAsterisks
                strAsteriskOutput &= strASTERISK
            Next

            ' Display the row of asterisks for the current store's daily sales.
            lstSales.Items.Add("Store " & intCurrentStore.ToString() & ": " & strAsteriskOutput)
            Next

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
