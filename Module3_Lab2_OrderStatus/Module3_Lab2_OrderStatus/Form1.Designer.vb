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
        Me.btnCalcTot = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumOrdered = New System.Windows.Forms.TextBox()
        Me.lblNumOrdered = New System.Windows.Forms.Label()
        Me.ckbRushDel = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotDue = New System.Windows.Forms.TextBox()
        Me.txtReadyShip = New System.Windows.Forms.TextBox()
        Me.txtBackOrder = New System.Windows.Forms.TextBox()
        Me.txtShipHand = New System.Windows.Forms.TextBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblShipHand = New System.Windows.Forms.Label()
        Me.lblBackOrder = New System.Windows.Forms.Label()
        Me.lblReadyShip = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalcTot
        '
        Me.btnCalcTot.Location = New System.Drawing.Point(34, 349)
        Me.btnCalcTot.Name = "btnCalcTot"
        Me.btnCalcTot.Size = New System.Drawing.Size(108, 32)
        Me.btnCalcTot.TabIndex = 0
        Me.btnCalcTot.Text = "Calculate Total"
        Me.btnCalcTot.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(164, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 32)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 32)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumOrdered)
        Me.GroupBox1.Controls.Add(Me.lblNumOrdered)
        Me.GroupBox1.Controls.Add(Me.ckbRushDel)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 104)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'txtNumOrdered
        '
        Me.txtNumOrdered.Location = New System.Drawing.Point(177, 27)
        Me.txtNumOrdered.Name = "txtNumOrdered"
        Me.txtNumOrdered.Size = New System.Drawing.Size(48, 20)
        Me.txtNumOrdered.TabIndex = 2
        '
        'lblNumOrdered
        '
        Me.lblNumOrdered.AutoSize = True
        Me.lblNumOrdered.Location = New System.Drawing.Point(37, 30)
        Me.lblNumOrdered.Name = "lblNumOrdered"
        Me.lblNumOrdered.Size = New System.Drawing.Size(132, 13)
        Me.lblNumOrdered.TabIndex = 1
        Me.lblNumOrdered.Text = "Number of Spools Ordered"
        '
        'ckbRushDel
        '
        Me.ckbRushDel.AutoSize = True
        Me.ckbRushDel.Location = New System.Drawing.Point(40, 65)
        Me.ckbRushDel.Name = "ckbRushDel"
        Me.ckbRushDel.Size = New System.Drawing.Size(92, 17)
        Me.ckbRushDel.TabIndex = 0
        Me.ckbRushDel.Text = "Rush Delivery"
        Me.ckbRushDel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotDue)
        Me.GroupBox2.Controls.Add(Me.txtReadyShip)
        Me.GroupBox2.Controls.Add(Me.txtBackOrder)
        Me.GroupBox2.Controls.Add(Me.txtShipHand)
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.lblShipHand)
        Me.GroupBox2.Controls.Add(Me.lblBackOrder)
        Me.GroupBox2.Controls.Add(Me.lblReadyShip)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 173)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delivery Information"
        '
        'txtTotDue
        '
        Me.txtTotDue.Location = New System.Drawing.Point(152, 115)
        Me.txtTotDue.Name = "txtTotDue"
        Me.txtTotDue.Size = New System.Drawing.Size(100, 20)
        Me.txtTotDue.TabIndex = 6
        '
        'txtReadyShip
        '
        Me.txtReadyShip.Location = New System.Drawing.Point(193, 19)
        Me.txtReadyShip.Name = "txtReadyShip"
        Me.txtReadyShip.Size = New System.Drawing.Size(59, 20)
        Me.txtReadyShip.TabIndex = 3
        '
        'txtBackOrder
        '
        Me.txtBackOrder.Location = New System.Drawing.Point(193, 48)
        Me.txtBackOrder.Name = "txtBackOrder"
        Me.txtBackOrder.Size = New System.Drawing.Size(59, 20)
        Me.txtBackOrder.TabIndex = 4
        '
        'txtShipHand
        '
        Me.txtShipHand.Location = New System.Drawing.Point(152, 83)
        Me.txtShipHand.Name = "txtShipHand"
        Me.txtShipHand.Size = New System.Drawing.Size(100, 20)
        Me.txtShipHand.TabIndex = 5
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(92, 118)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalDue.TabIndex = 3
        Me.lblTotalDue.Text = "Total Due:"
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShipHand
        '
        Me.lblShipHand.AutoSize = True
        Me.lblShipHand.Location = New System.Drawing.Point(44, 86)
        Me.lblShipHand.Name = "lblShipHand"
        Me.lblShipHand.Size = New System.Drawing.Size(105, 13)
        Me.lblShipHand.TabIndex = 2
        Me.lblShipHand.Text = "Shipping && Handling:"
        Me.lblShipHand.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBackOrder
        '
        Me.lblBackOrder.AutoSize = True
        Me.lblBackOrder.Location = New System.Drawing.Point(35, 51)
        Me.lblBackOrder.Name = "lblBackOrder"
        Me.lblBackOrder.Size = New System.Drawing.Size(114, 13)
        Me.lblBackOrder.TabIndex = 1
        Me.lblBackOrder.Text = "Spools on Back Order:"
        Me.lblBackOrder.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblReadyShip
        '
        Me.lblReadyShip.AutoSize = True
        Me.lblReadyShip.Location = New System.Drawing.Point(37, 22)
        Me.lblReadyShip.Name = "lblReadyShip"
        Me.lblReadyShip.Size = New System.Drawing.Size(112, 13)
        Me.lblReadyShip.TabIndex = 0
        Me.lblReadyShip.Text = "Spools Ready to Ship:"
        Me.lblReadyShip.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 410)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcTot)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalcTot As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumOrdered As TextBox
    Friend WithEvents lblNumOrdered As Label
    Friend WithEvents ckbRushDel As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotDue As TextBox
    Friend WithEvents txtReadyShip As TextBox
    Friend WithEvents txtBackOrder As TextBox
    Friend WithEvents txtShipHand As TextBox
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblShipHand As Label
    Friend WithEvents lblBackOrder As Label
    Friend WithEvents lblReadyShip As Label
End Class
