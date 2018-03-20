<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resultListBox = New System.Windows.Forms.ListBox()
        Me.startTextBox = New System.Windows.Forms.TextBox()
        Me.endTextBox = New System.Windows.Forms.TextBox()
        Me.sumButton = New System.Windows.Forms.Button()
        Me.averageButton = New System.Windows.Forms.Button()
        Me.ascendingButton = New System.Windows.Forms.Button()
        Me.differenceButton = New System.Windows.Forms.Button()
        Me.minButton = New System.Windows.Forms.Button()
        Me.primeButton = New System.Windows.Forms.Button()
        Me.productButton = New System.Windows.Forms.Button()
        Me.maxButton = New System.Windows.Forms.Button()
        Me.fibonacciButton = New System.Windows.Forms.Button()
        Me.quotientButton = New System.Windows.Forms.Button()
        Me.expoButton = New System.Windows.Forms.Button()
        Me.factorialButton = New System.Windows.Forms.Button()
        Me.multiplicationButton = New System.Windows.Forms.Button()
        Me.squareRootButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "End number:"
        '
        'resultListBox
        '
        Me.resultListBox.FormattingEnabled = True
        Me.resultListBox.ItemHeight = 15
        Me.resultListBox.Location = New System.Drawing.Point(15, 105)
        Me.resultListBox.Name = "resultListBox"
        Me.resultListBox.Size = New System.Drawing.Size(403, 94)
        Me.resultListBox.TabIndex = 3
        '
        'startTextBox
        '
        Me.startTextBox.Location = New System.Drawing.Point(15, 39)
        Me.startTextBox.Name = "startTextBox"
        Me.startTextBox.Size = New System.Drawing.Size(116, 23)
        Me.startTextBox.TabIndex = 4
        '
        'endTextBox
        '
        Me.endTextBox.Location = New System.Drawing.Point(212, 39)
        Me.endTextBox.Name = "endTextBox"
        Me.endTextBox.Size = New System.Drawing.Size(116, 23)
        Me.endTextBox.TabIndex = 5
        '
        'sumButton
        '
        Me.sumButton.Location = New System.Drawing.Point(19, 238)
        Me.sumButton.Name = "sumButton"
        Me.sumButton.Size = New System.Drawing.Size(113, 51)
        Me.sumButton.TabIndex = 6
        Me.sumButton.Text = "Sum"
        Me.sumButton.UseVisualStyleBackColor = True
        '
        'averageButton
        '
        Me.averageButton.Location = New System.Drawing.Point(161, 238)
        Me.averageButton.Name = "averageButton"
        Me.averageButton.Size = New System.Drawing.Size(113, 51)
        Me.averageButton.TabIndex = 7
        Me.averageButton.Text = "Average"
        Me.averageButton.UseVisualStyleBackColor = True
        '
        'ascendingButton
        '
        Me.ascendingButton.Location = New System.Drawing.Point(306, 238)
        Me.ascendingButton.Name = "ascendingButton"
        Me.ascendingButton.Size = New System.Drawing.Size(113, 51)
        Me.ascendingButton.TabIndex = 8
        Me.ascendingButton.Text = "Ascending Sort"
        Me.ascendingButton.UseVisualStyleBackColor = True
        '
        'differenceButton
        '
        Me.differenceButton.Location = New System.Drawing.Point(19, 302)
        Me.differenceButton.Name = "differenceButton"
        Me.differenceButton.Size = New System.Drawing.Size(113, 51)
        Me.differenceButton.TabIndex = 9
        Me.differenceButton.Text = "Difference"
        Me.differenceButton.UseVisualStyleBackColor = True
        '
        'minButton
        '
        Me.minButton.Location = New System.Drawing.Point(161, 302)
        Me.minButton.Name = "minButton"
        Me.minButton.Size = New System.Drawing.Size(113, 51)
        Me.minButton.TabIndex = 10
        Me.minButton.Text = "Min"
        Me.minButton.UseVisualStyleBackColor = True
        '
        'primeButton
        '
        Me.primeButton.Location = New System.Drawing.Point(306, 302)
        Me.primeButton.Name = "primeButton"
        Me.primeButton.Size = New System.Drawing.Size(113, 51)
        Me.primeButton.TabIndex = 11
        Me.primeButton.Text = "Prime"
        Me.primeButton.UseVisualStyleBackColor = True
        '
        'productButton
        '
        Me.productButton.Location = New System.Drawing.Point(19, 367)
        Me.productButton.Name = "productButton"
        Me.productButton.Size = New System.Drawing.Size(113, 51)
        Me.productButton.TabIndex = 12
        Me.productButton.Text = "Product"
        Me.productButton.UseVisualStyleBackColor = True
        '
        'maxButton
        '
        Me.maxButton.Location = New System.Drawing.Point(161, 367)
        Me.maxButton.Name = "maxButton"
        Me.maxButton.Size = New System.Drawing.Size(113, 51)
        Me.maxButton.TabIndex = 13
        Me.maxButton.Text = "Max"
        Me.maxButton.UseVisualStyleBackColor = True
        '
        'fibonacciButton
        '
        Me.fibonacciButton.Location = New System.Drawing.Point(306, 367)
        Me.fibonacciButton.Name = "fibonacciButton"
        Me.fibonacciButton.Size = New System.Drawing.Size(113, 51)
        Me.fibonacciButton.TabIndex = 14
        Me.fibonacciButton.Text = "Fibonacci"
        Me.fibonacciButton.UseVisualStyleBackColor = True
        '
        'quotientButton
        '
        Me.quotientButton.Location = New System.Drawing.Point(19, 432)
        Me.quotientButton.Name = "quotientButton"
        Me.quotientButton.Size = New System.Drawing.Size(113, 51)
        Me.quotientButton.TabIndex = 15
        Me.quotientButton.Text = "Quotient"
        Me.quotientButton.UseVisualStyleBackColor = True
        '
        'expoButton
        '
        Me.expoButton.Location = New System.Drawing.Point(161, 432)
        Me.expoButton.Name = "expoButton"
        Me.expoButton.Size = New System.Drawing.Size(113, 51)
        Me.expoButton.TabIndex = 16
        Me.expoButton.Text = "Exponentiation"
        Me.expoButton.UseVisualStyleBackColor = True
        '
        'factorialButton
        '
        Me.factorialButton.Location = New System.Drawing.Point(306, 432)
        Me.factorialButton.Name = "factorialButton"
        Me.factorialButton.Size = New System.Drawing.Size(113, 51)
        Me.factorialButton.TabIndex = 17
        Me.factorialButton.Text = "Factorial"
        Me.factorialButton.UseVisualStyleBackColor = True
        '
        'multiplicationButton
        '
        Me.multiplicationButton.Location = New System.Drawing.Point(19, 496)
        Me.multiplicationButton.Name = "multiplicationButton"
        Me.multiplicationButton.Size = New System.Drawing.Size(113, 51)
        Me.multiplicationButton.TabIndex = 18
        Me.multiplicationButton.Text = "Multiplication Table"
        Me.multiplicationButton.UseVisualStyleBackColor = True
        '
        'squareRootButton
        '
        Me.squareRootButton.Location = New System.Drawing.Point(161, 496)
        Me.squareRootButton.Name = "squareRootButton"
        Me.squareRootButton.Size = New System.Drawing.Size(113, 51)
        Me.squareRootButton.TabIndex = 19
        Me.squareRootButton.Text = "Square Root"
        Me.squareRootButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(306, 496)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(113, 51)
        Me.exitButton.TabIndex = 20
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Result:"
        '
        'MainForm
        '
        Me.AcceptButton = Me.sumButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(439, 578)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.squareRootButton)
        Me.Controls.Add(Me.multiplicationButton)
        Me.Controls.Add(Me.factorialButton)
        Me.Controls.Add(Me.expoButton)
        Me.Controls.Add(Me.quotientButton)
        Me.Controls.Add(Me.fibonacciButton)
        Me.Controls.Add(Me.maxButton)
        Me.Controls.Add(Me.productButton)
        Me.Controls.Add(Me.primeButton)
        Me.Controls.Add(Me.minButton)
        Me.Controls.Add(Me.differenceButton)
        Me.Controls.Add(Me.ascendingButton)
        Me.Controls.Add(Me.averageButton)
        Me.Controls.Add(Me.sumButton)
        Me.Controls.Add(Me.endTextBox)
        Me.Controls.Add(Me.startTextBox)
        Me.Controls.Add(Me.resultListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "Calculator App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents resultListBox As System.Windows.Forms.ListBox
    Friend WithEvents startTextBox As System.Windows.Forms.TextBox
    Friend WithEvents endTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sumButton As System.Windows.Forms.Button
    Friend WithEvents averageButton As System.Windows.Forms.Button
    Friend WithEvents ascendingButton As System.Windows.Forms.Button
    Friend WithEvents differenceButton As System.Windows.Forms.Button
    Friend WithEvents minButton As System.Windows.Forms.Button
    Friend WithEvents primeButton As System.Windows.Forms.Button
    Friend WithEvents productButton As System.Windows.Forms.Button
    Friend WithEvents maxButton As System.Windows.Forms.Button
    Friend WithEvents fibonacciButton As System.Windows.Forms.Button
    Friend WithEvents quotientButton As System.Windows.Forms.Button
    Friend WithEvents expoButton As System.Windows.Forms.Button
    Friend WithEvents factorialButton As System.Windows.Forms.Button
    Friend WithEvents multiplicationButton As System.Windows.Forms.Button
    Friend WithEvents squareRootButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
