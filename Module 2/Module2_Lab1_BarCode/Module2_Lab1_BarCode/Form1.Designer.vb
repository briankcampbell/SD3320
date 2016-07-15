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
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.btnDisplayChart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSales
        '
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.Location = New System.Drawing.Point(12, 12)
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(260, 95)
        Me.lstSales.TabIndex = 0
        '
        'btnDisplayChart
        '
        Me.btnDisplayChart.Location = New System.Drawing.Point(30, 133)
        Me.btnDisplayChart.Name = "btnDisplayChart"
        Me.btnDisplayChart.Size = New System.Drawing.Size(100, 39)
        Me.btnDisplayChart.TabIndex = 1
        Me.btnDisplayChart.Text = "&Display Chart"
        Me.btnDisplayChart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(146, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 39)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 184)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplayChart)
        Me.Controls.Add(Me.lstSales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Bar Code"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSales As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplayChart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
