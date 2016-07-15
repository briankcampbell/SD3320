<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWidgetCalc
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblWidgetTotal = New System.Windows.Forms.Label()
        Me.lblTotalWeight = New System.Windows.Forms.Label()
        Me.lblNumberOfWidgets = New System.Windows.Forms.Label()
        Me.lblPalletWeight = New System.Windows.Forms.Label()
        Me.txtTotalWeight = New System.Windows.Forms.TextBox()
        Me.txtPalletWeight = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(75, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 36)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(253, 301)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 36)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.lblWidgetTotal)
        Me.GroupBox1.Controls.Add(Me.lblTotalWeight)
        Me.GroupBox1.Controls.Add(Me.lblNumberOfWidgets)
        Me.GroupBox1.Controls.Add(Me.lblPalletWeight)
        Me.GroupBox1.Controls.Add(Me.txtTotalWeight)
        Me.GroupBox1.Controls.Add(Me.txtPalletWeight)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 266)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(241, 190)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 36)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblWidgetTotal
        '
        Me.lblWidgetTotal.AutoSize = True
        Me.lblWidgetTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidgetTotal.Location = New System.Drawing.Point(245, 131)
        Me.lblWidgetTotal.MaximumSize = New System.Drawing.Size(121, 31)
        Me.lblWidgetTotal.MinimumSize = New System.Drawing.Size(121, 31)
        Me.lblWidgetTotal.Name = "lblWidgetTotal"
        Me.lblWidgetTotal.Size = New System.Drawing.Size(121, 31)
        Me.lblWidgetTotal.TabIndex = 8
        Me.lblWidgetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.AutoSize = True
        Me.lblTotalWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWeight.Location = New System.Drawing.Point(57, 84)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(182, 25)
        Me.lblTotalWeight.TabIndex = 7
        Me.lblTotalWeight.Text = "Pallet && Widgets: "
        '
        'lblNumberOfWidgets
        '
        Me.lblNumberOfWidgets.AutoSize = True
        Me.lblNumberOfWidgets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfWidgets.Location = New System.Drawing.Point(32, 134)
        Me.lblNumberOfWidgets.Name = "lblNumberOfWidgets"
        Me.lblNumberOfWidgets.Size = New System.Drawing.Size(213, 25)
        Me.lblNumberOfWidgets.TabIndex = 5
        Me.lblNumberOfWidgets.Text = "Number of Widgets ="
        '
        'lblPalletWeight
        '
        Me.lblPalletWeight.AutoSize = True
        Me.lblPalletWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalletWeight.Location = New System.Drawing.Point(88, 42)
        Me.lblPalletWeight.Name = "lblPalletWeight"
        Me.lblPalletWeight.Size = New System.Drawing.Size(151, 25)
        Me.lblPalletWeight.TabIndex = 4
        Me.lblPalletWeight.Text = "Pallet Weight: "
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalWeight.Location = New System.Drawing.Point(241, 81)
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.Size = New System.Drawing.Size(121, 31)
        Me.txtTotalWeight.TabIndex = 2
        Me.txtTotalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPalletWeight
        '
        Me.txtPalletWeight.BackColor = System.Drawing.SystemColors.Control
        Me.txtPalletWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalletWeight.Location = New System.Drawing.Point(241, 39)
        Me.txtPalletWeight.Name = "txtPalletWeight"
        Me.txtPalletWeight.Size = New System.Drawing.Size(121, 31)
        Me.txtPalletWeight.TabIndex = 1
        Me.txtPalletWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmWidgetCalc
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(438, 352)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmWidgetCalc"
        Me.Text = "Widget Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotalWeight As TextBox
    Friend WithEvents txtPalletWeight As TextBox
    Friend WithEvents lblTotalWeight As Label
    Friend WithEvents lblNumberOfWidgets As Label
    Friend WithEvents lblPalletWeight As Label
    Friend WithEvents lblWidgetTotal As Label
    Friend WithEvents btnCalculate As Button
End Class
