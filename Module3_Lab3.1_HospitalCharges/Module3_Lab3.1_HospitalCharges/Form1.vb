Public Class Form1
    Const intROOMCHARGE As Integer = 350                    ' Holds constant value of 350.
    Dim intLengthStay As Integer                            ' Holds input of the number of days to be charged for room.
    Dim dblTotalRoomCharges As Double                       ' Holds total of room charge times number of days charged.
    Dim dblMedication As Double                             ' Holds input of the charges for Medications.
    Dim dblLabFees As Double                                ' Holds input of the Lab Fees.
    Dim dblSurgical As Double                               ' Holds input of the charges for Surgical.
    Dim dblPhysical As Double                               ' Holds input of the charges for Physical Rehab.
    Dim dblMiscCharges As Double                            ' Holds the total of the misc charges.
    Dim dblTotalCharges As Double                           ' Holds the total of all charges.
    Dim formClear As Boolean                                ' Holds status of form cleared.


    Private Sub btnCalcCharges_Click(sender As Object, e As EventArgs) Handles btnCalcCharges.Click
        If (ValidateInputFields()) Then
            intLengthStay = CInt(txtLengthStay.Text)
            'MessageBox.Show("Length of stay: " & CStr(intLengthStay, "0.00"), "intLengthStay", MessageBoxButtons.OK)
            dblMedication = CDbl(txtMedication.Text)
            'MessageBox.Show("Medications: $" & Format(dblMedication, "0.00"), "dblMedication", MessageBoxButtons.OK)
            dblSurgical = CDbl(txtSurgCharges.Text)
            'MessageBox.Show("Surgical Costs: $" & Format(dblSurgical, "0.00"), "dblSurgical", MessageBoxButtons.OK)
            dblLabFees = CDbl(txtLabFees.Text)
            'MessageBox.Show("Lab Fees: $" & Format(dblLabFees, "0.00"), "dblLabFees", MessageBoxButtons.OK)
            dblPhysical = CDbl(txtPhysical.Text)
            'MessageBox.Show("Physical Rehab Costs: $" & Format(dblPhysical, "0.00"), "dblPhysical", MessageBoxButtons.OK)

            MessageBox.Show("Length of stay: " & intLengthStay.ToString("N0") + " Days" & vbNewLine &
                            "Medications: " & dblMedication.ToString("C2") & vbNewLine &
                            "Surgical Costs: " & dblSurgical.ToString("C2") & vbNewLine &
                            "Lab Fees: " & dblLabFees.ToString("C2") & vbNewLine &
                            "Physical Rehab Costs: " & dblPhysical.ToString("C2") & vbNewLine & vbNewLine &
                            "Click OK to continue", "Verify Inputs", MessageBoxButtons.OK, MessageBoxIcon.Information)

            dblTotalRoomCharges = CalcStayCharges(intLengthStay, intROOMCHARGE)
            'MessageBox.Show("Total Room charges: $" & Format(dblTotalRoomCharges, ".00"), "dblTotalRoomCharges", MessageBoxButtons.OK)
            dblMiscCharges = CalcMiscCharges(dblMedication, dblSurgical, dblLabFees, dblPhysical)
            'MessageBox.Show("Total Misc Charges: $" & Format(dblMiscCharges, ".00"), "dblMiscCharges", MessageBoxButtons.OK)

            MessageBox.Show("Total Room charges: " & dblTotalRoomCharges.ToString("C2") & vbNewLine &
                            "Total Misc Charges: " & dblMiscCharges.ToString("C2") & vbNewLine & vbNewLine &
                            "Click OK to continue", "Verify Inputs", MessageBoxButtons.OK, MessageBoxIcon.Information)

            dblTotalCharges = CalcTotalCharges(dblTotalRoomCharges, dblMiscCharges)
            lblTotalCostCalc.Text = dblTotalCharges.ToString("C2")
        End If
    End Sub
    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        formClear = True
        txtLengthStay.ResetText()
        txtMedication.ResetText()
        txtSurgCharges.ResetText()
        txtLabFees.ResetText()
        txtPhysical.ResetText()
        lblTotalCostCalc.Text = ""
        txtLengthStay.Focus()
        formClear = False
    End Sub
    Function CalcStayCharges(ByVal intLengthStay As Integer, ByRef intROOMCHARGE As Double) As Double
        ' Calculates and returns the base charges for the hospital stay. 
        ' This Is computed as $350 times the number of days in the hospital.
        dblTotalRoomCharges = Double.Parse(intROOMCHARGE * intLengthStay)
        Return dblTotalRoomCharges
    End Function
    Function CalcMiscCharges(ByVal dblMedication, ByVal dblSurgical, ByVal dblLabFees, ByVal dblPhysical) As Double
        ' Calculates and returns the total of the medication, surgical, lab, and physical rehabilitation charges.
        dblMiscCharges = dblMedication + dblSurgical + dblLabFees + dblPhysical
        Return dblMiscCharges
    End Function
    Function CalcTotalCharges(ByVal dblTotalRoomCharges, ByVal dblMiscCharges)
        ' Calculates and returns the total charges.
        dblTotalCharges = dblTotalRoomCharges + dblMiscCharges
        Return dblTotalCharges
    End Function
    Function ValidateInputField(ByVal txtBox As TextBox) As Boolean
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
        Dim lstTxtBoxes As New List(Of TextBox) _
            From {txtLengthStay, txtMedication, txtSurgCharges, txtLabFees, txtPhysical}
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txtLengthStay.Focus()
    End Sub
    Private Function CheckInput(ByVal txtBox As TextBox)
        Dim input As String = txtBox.Text
        Dim strNegNumError = "Must not be a negative number."
        Dim strNumEntError = "Must enter a number."
        Dim strMissingField = "Missing fields found."
        Dim intNumber As Integer
        Dim dblNumber As Double
        'If txtBox.Text = "" Then
        'Return strMissingField
        If txtBox.Equals(txtLengthStay) Then
            If Integer.TryParse(txtBox.Text, intNumber) Then
                If intNumber < 0 Then
                    Return strNegNumError
                Else Return True
                End If
            End If
        ElseIf Double.TryParse(txtBox.Text, dblNumber) Then
            If dblNumber < 0.0 Then
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
    Private Sub txtLengthStay_TextChanged(sender As Object, e As EventArgs) Handles txtLengthStay.TextChanged
        If formClear.Equals(False) Then
            ValidateInputField(txtLengthStay)
        End If
    End Sub
    Private Sub txtMedication_TextChanged(sender As Object, e As EventArgs) Handles txtMedication.TextChanged
        If formClear.Equals(False) Then
            ValidateInputField(txtMedication)
        End If
    End Sub
    Private Sub txtSurgCharges_TextChanged(sender As Object, e As EventArgs) Handles txtSurgCharges.TextChanged
        If formClear.Equals(False) Then
            ValidateInputField(txtSurgCharges)
        End If
    End Sub
    Private Sub txtLabFees_TextChanged(sender As Object, e As EventArgs) Handles txtLabFees.TextChanged
        If formClear.Equals(False) Then
            ValidateInputField(txtLabFees)
        End If
    End Sub
    Private Sub txtPhysical_TextChanged(sender As Object, e As EventArgs) Handles txtPhysical.TextChanged
        If formClear.Equals(False) Then
            ValidateInputField(txtPhysical)
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
