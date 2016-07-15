<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLengthStay = New System.Windows.Forms.Label()
        Me.txtLengthStay = New System.Windows.Forms.TextBox()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.txtSurgCharges = New System.Windows.Forms.TextBox()
        Me.lblSurgicalCharges = New System.Windows.Forms.Label()
        Me.txtLabFees = New System.Windows.Forms.TextBox()
        Me.lblLabFees = New System.Windows.Forms.Label()
        Me.txtPhysical = New System.Windows.Forms.TextBox()
        Me.lblPhysical = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalCostCalc = New System.Windows.Forms.Label()
        Me.btnCalcCharges = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpHospStayInfo = New System.Windows.Forms.GroupBox()
        Me.grpTotalCost = New System.Windows.Forms.GroupBox()
        Me.grpHospStayInfo.SuspendLayout()
        Me.grpTotalCost.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLengthStay
        '
        Me.lblLengthStay.AutoSize = True
        Me.lblLengthStay.Location = New System.Drawing.Point(21, 26)
        Me.lblLengthStay.Name = "lblLengthStay"
        Me.lblLengthStay.Size = New System.Drawing.Size(109, 13)
        Me.lblLengthStay.TabIndex = 0
        Me.lblLengthStay.Text = "Length of Stay (Days)"
        Me.lblLengthStay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLengthStay
        '
        Me.txtLengthStay.Location = New System.Drawing.Point(147, 19)
        Me.txtLengthStay.Name = "txtLengthStay"
        Me.txtLengthStay.Size = New System.Drawing.Size(150, 20)
        Me.txtLengthStay.TabIndex = 1
        '
        'txtMedication
        '
        Me.txtMedication.Location = New System.Drawing.Point(147, 45)
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(150, 20)
        Me.txtMedication.TabIndex = 3
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Location = New System.Drawing.Point(71, 52)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(59, 13)
        Me.lblMedication.TabIndex = 2
        Me.lblMedication.Text = "Medication"
        Me.lblMedication.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSurgCharges
        '
        Me.txtSurgCharges.Location = New System.Drawing.Point(147, 71)
        Me.txtSurgCharges.Name = "txtSurgCharges"
        Me.txtSurgCharges.Size = New System.Drawing.Size(150, 20)
        Me.txtSurgCharges.TabIndex = 5
        '
        'lblSurgicalCharges
        '
        Me.lblSurgicalCharges.AutoSize = True
        Me.lblSurgicalCharges.Location = New System.Drawing.Point(43, 78)
        Me.lblSurgicalCharges.Name = "lblSurgicalCharges"
        Me.lblSurgicalCharges.Size = New System.Drawing.Size(87, 13)
        Me.lblSurgicalCharges.TabIndex = 4
        Me.lblSurgicalCharges.Text = "Surgical Charges"
        Me.lblSurgicalCharges.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLabFees
        '
        Me.txtLabFees.Location = New System.Drawing.Point(147, 97)
        Me.txtLabFees.Name = "txtLabFees"
        Me.txtLabFees.Size = New System.Drawing.Size(150, 20)
        Me.txtLabFees.TabIndex = 7
        '
        'lblLabFees
        '
        Me.lblLabFees.AutoSize = True
        Me.lblLabFees.Location = New System.Drawing.Point(79, 104)
        Me.lblLabFees.Name = "lblLabFees"
        Me.lblLabFees.Size = New System.Drawing.Size(51, 13)
        Me.lblLabFees.TabIndex = 6
        Me.lblLabFees.Text = "Lab Fees"
        Me.lblLabFees.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPhysical
        '
        Me.txtPhysical.Location = New System.Drawing.Point(147, 123)
        Me.txtPhysical.Name = "txtPhysical"
        Me.txtPhysical.Size = New System.Drawing.Size(150, 20)
        Me.txtPhysical.TabIndex = 9
        '
        'lblPhysical
        '
        Me.lblPhysical.AutoSize = True
        Me.lblPhysical.Location = New System.Drawing.Point(84, 130)
        Me.lblPhysical.Name = "lblPhysical"
        Me.lblPhysical.Size = New System.Drawing.Size(46, 13)
        Me.lblPhysical.TabIndex = 8
        Me.lblPhysical.Text = "Physical"
        Me.lblPhysical.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Total Cost: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalCostCalc
        '
        Me.lblTotalCostCalc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCostCalc.Location = New System.Drawing.Point(147, 22)
        Me.lblTotalCostCalc.Name = "lblTotalCostCalc"
        Me.lblTotalCostCalc.Size = New System.Drawing.Size(150, 20)
        Me.lblTotalCostCalc.TabIndex = 11
        Me.lblTotalCostCalc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalcCharges
        '
        Me.btnCalcCharges.Location = New System.Drawing.Point(17, 271)
        Me.btnCalcCharges.Name = "btnCalcCharges"
        Me.btnCalcCharges.Size = New System.Drawing.Size(100, 40)
        Me.btnCalcCharges.TabIndex = 12
        Me.btnCalcCharges.Text = "Calculate Charges"
        Me.btnCalcCharges.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearForm.Location = New System.Drawing.Point(124, 271)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(100, 40)
        Me.btnClearForm.TabIndex = 13
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(229, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpHospStayInfo
        '
        Me.grpHospStayInfo.Controls.Add(Me.txtLengthStay)
        Me.grpHospStayInfo.Controls.Add(Me.lblLengthStay)
        Me.grpHospStayInfo.Controls.Add(Me.lblMedication)
        Me.grpHospStayInfo.Controls.Add(Me.txtMedication)
        Me.grpHospStayInfo.Controls.Add(Me.lblSurgicalCharges)
        Me.grpHospStayInfo.Controls.Add(Me.txtPhysical)
        Me.grpHospStayInfo.Controls.Add(Me.txtSurgCharges)
        Me.grpHospStayInfo.Controls.Add(Me.lblPhysical)
        Me.grpHospStayInfo.Controls.Add(Me.lblLabFees)
        Me.grpHospStayInfo.Controls.Add(Me.txtLabFees)
        Me.grpHospStayInfo.Location = New System.Drawing.Point(12, 12)
        Me.grpHospStayInfo.Name = "grpHospStayInfo"
        Me.grpHospStayInfo.Size = New System.Drawing.Size(324, 157)
        Me.grpHospStayInfo.TabIndex = 15
        Me.grpHospStayInfo.TabStop = False
        Me.grpHospStayInfo.Text = "Hospital Stay Information"
        '
        'grpTotalCost
        '
        Me.grpTotalCost.Controls.Add(Me.lblTotalCostCalc)
        Me.grpTotalCost.Controls.Add(Me.Label1)
        Me.grpTotalCost.Location = New System.Drawing.Point(12, 207)
        Me.grpTotalCost.Name = "grpTotalCost"
        Me.grpTotalCost.Size = New System.Drawing.Size(324, 58)
        Me.grpTotalCost.TabIndex = 16
        Me.grpTotalCost.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalcCharges
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClearForm
        Me.ClientSize = New System.Drawing.Size(348, 319)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalcCharges)
        Me.Controls.Add(Me.grpHospStayInfo)
        Me.Controls.Add(Me.grpTotalCost)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpHospStayInfo.ResumeLayout(False)
        Me.grpHospStayInfo.PerformLayout()
        Me.grpTotalCost.ResumeLayout(False)
        Me.grpTotalCost.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLengthStay As Label
    Friend WithEvents txtLengthStay As TextBox
    Friend WithEvents txtMedication As TextBox
    Friend WithEvents lblMedication As Label
    Friend WithEvents txtSurgCharges As TextBox
    Friend WithEvents lblSurgicalCharges As Label
    Friend WithEvents txtLabFees As TextBox
    Friend WithEvents lblLabFees As Label
    Friend WithEvents txtPhysical As TextBox
    Friend WithEvents lblPhysical As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalCostCalc As Label
    Friend WithEvents btnCalcCharges As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpHospStayInfo As GroupBox
    Friend WithEvents grpTotalCost As GroupBox
End Class
