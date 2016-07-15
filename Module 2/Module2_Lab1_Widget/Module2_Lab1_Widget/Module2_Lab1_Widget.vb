Public Class frmWidgetCalc
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Set Welcome Message when form loads.
        Dim message As String
        message = "Hello!!! Welcome to the Widget Calculator.  The time is " & DateTime.Now.ToShortTimeString() & "."
        MessageBox.Show(message, "Welcome Message")

        ' Set cursor focus to Pallet Weight field.
        Me.Show()
        txtPalletWeight.Focus()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear all fields.
        txtPalletWeight.Clear()
        txtTotalWeight.Clear()
        lblWidgetTotal.Text = ""

        ' Reset cursor focus to Pallet Weight field.
        Me.Show()
        txtPalletWeight.Focus()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Declare Variable for Pallet Weight and Total Weight of Pallet & Widgets
        Dim palletWeight, totalWeight, widgetWeight As Integer

        If ValidateInputFields() Then
            ' Convert PalletWeight Price 
            palletWeight = CInt(txtPalletWeight.Text)

            ' Convert TotalWeight
            totalWeight = CInt(txtTotalWeight.Text)

            ' Calculate the WidgetWeight 
            widgetWeight = CInt(Decimal.Round(totalWeight - palletWeight) / 9.2)

            ' Format and display results
            lblWidgetTotal.Text = widgetWeight.ToString
        End If
    End Sub
    Function ValidateInputField(ByVal txtBox As TextBox) As Boolean
        ' Checks the validity of the input fields by converting each to a numeric value and checking its range.
        ' If any Then input field Is found To be invalid Or empty, this Function displays an Error message And 
        ' returns the value As False.
        ' Do not accept a negative value for length of stay, medication charges, surgical charges, lab fees, or 
        ' physical rehabilitation charges.
        ' When displaying error messages, use a Label control and specifically name the missing field and the 
        ' Type of data to be entered (integer Or numeric).
        ' Holds the value of a textbox.

        Dim result = CheckInput(txtBox)
        Dim check As Boolean
        While Not Boolean.TryParse(result, check)
            SelectFocus(txtBox)
            MessageBox.Show(result, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End While
        Return True
    End Function

    Function ValidateInputFields() As Boolean
        ' Checks the validity of the input fields by converting each to a numeric value and checking its range.
        ' If any Then input field Is found To be invalid Or empty, this Function displays an Error message And 
        ' returns the value As False.
        ' Do not accept a negative value for length of stay, medication charges, surgical charges, lab fees, or 
        ' physical rehabilitation charges.
        ' When displaying error messages, use a Label control and specifically name the missing field and the 
        ' Type of data to be entered (integer Or numeric).
        ' Holds the value of a textbox.

        Dim lstTxtBoxes As New List(Of TextBox) _
            From {txtPalletWeight, txtTotalWeight}
        For Each txtBox As TextBox In lstTxtBoxes
            Dim result = CheckInput(txtBox)
            Dim check As Boolean
            While Not Boolean.TryParse(result, check)
                SelectFocus(txtBox)
                MessageBox.Show(result, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End While
        Next
        Return True
    End Function
    Private Function CheckInput(ByVal txtBox As TextBox)
        Dim input As String = txtBox.Text
        Dim strNegNumError = "Must not be a negative number."
        Dim strNumEntError = "Must enter a number."
        Dim strMissingField = "Missing fields found."
        Dim intNumber As Integer
        If txtBox.Text = "" Then
            Return strMissingField
        ElseIf Integer.TryParse(txtBox.Text, intNumber) Then
            If intNumber < 0 Then
                Return strNegNumError
            Else Return True
            End If
        End If
        Return strNumEntError
    End Function
    Private Sub SelectFocus(ByVal txtBox As TextBox)
        txtBox.Focus()
        txtBox.SelectAll()
    End Sub

    Private Sub txtPalletWeight_TextChanged(sender As Object, e As EventArgs) Handles txtPalletWeight.TextChanged
        ValidateInputField(txtPalletWeight)
    End Sub

    Private Sub txtTotalWeight_TextChanged(sender As Object, e As EventArgs) Handles txtTotalWeight.TextChanged
        ValidateInputField(txtTotalWeight)
    End Sub
End Class
