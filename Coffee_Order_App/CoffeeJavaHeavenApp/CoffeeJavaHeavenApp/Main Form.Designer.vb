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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.dummyLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.surchargeCheckBox = New System.Windows.Forms.CheckBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.freshRadioButton = New System.Windows.Forms.RadioButton()
        Me.thirdlbbagRadioButton = New System.Windows.Forms.RadioButton()
        Me.halflbbagRadioButton = New System.Windows.Forms.RadioButton()
        Me.onelbbagRadioButton = New System.Windows.Forms.RadioButton()
        Me.latteRadioButton = New System.Windows.Forms.RadioButton()
        Me.icedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.icedcappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.espressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.cappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.surchargeLabel = New System.Windows.Forms.Label()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.newButton = New System.Windows.Forms.Button()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.flavorsGroupBox = New System.Windows.Forms.GroupBox()
        Me.addAltButton = New System.Windows.Forms.Button()
        Me.syrupsListBox = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totalFlavorsLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.removeAllButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.flavorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.netOrderLabel = New System.Windows.Forms.Label()
        Me.discountCheckBox = New System.Windows.Forms.CheckBox()
        Me.discountTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.flavorsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clearButton)
        Me.GroupBox1.Controls.Add(Me.amountLabel)
        Me.GroupBox1.Controls.Add(Me.dummyLabel)
        Me.GroupBox1.Controls.Add(Me.calcButton)
        Me.GroupBox1.Controls.Add(Me.surchargeCheckBox)
        Me.GroupBox1.Controls.Add(Me.quantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'clearButton
        '
        Me.clearButton.Enabled = False
        Me.clearButton.Location = New System.Drawing.Point(146, 92)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(84, 50)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear for Next Item"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'amountLabel
        '
        Me.amountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.amountLabel.Location = New System.Drawing.Point(141, 174)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(89, 28)
        Me.amountLabel.TabIndex = 7
        '
        'dummyLabel
        '
        Me.dummyLabel.AutoSize = True
        Me.dummyLabel.Location = New System.Drawing.Point(27, 174)
        Me.dummyLabel.Name = "dummyLabel"
        Me.dummyLabel.Size = New System.Drawing.Size(79, 15)
        Me.dummyLabel.TabIndex = 6
        Me.dummyLabel.Text = "Item amount:"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(27, 92)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(84, 50)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate Selection"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'surchargeCheckBox
        '
        Me.surchargeCheckBox.AutoSize = True
        Me.surchargeCheckBox.Location = New System.Drawing.Point(27, 55)
        Me.surchargeCheckBox.Name = "surchargeCheckBox"
        Me.surchargeCheckBox.Size = New System.Drawing.Size(84, 19)
        Me.surchargeCheckBox.TabIndex = 3
        Me.surchargeCheckBox.Text = "S&urcharge?"
        Me.surchargeCheckBox.UseVisualStyleBackColor = True
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(130, 20)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(100, 23)
        Me.quantityTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Quantity:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.freshRadioButton)
        Me.GroupBox2.Controls.Add(Me.thirdlbbagRadioButton)
        Me.GroupBox2.Controls.Add(Me.halflbbagRadioButton)
        Me.GroupBox2.Controls.Add(Me.onelbbagRadioButton)
        Me.GroupBox2.Controls.Add(Me.latteRadioButton)
        Me.GroupBox2.Controls.Add(Me.icedLatteRadioButton)
        Me.GroupBox2.Controls.Add(Me.icedcappuccinoRadioButton)
        Me.GroupBox2.Controls.Add(Me.espressoRadioButton)
        Me.GroupBox2.Controls.Add(Me.cappuccinoRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 180)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu Selections"
        '
        'freshRadioButton
        '
        Me.freshRadioButton.AutoSize = True
        Me.freshRadioButton.Location = New System.Drawing.Point(217, 32)
        Me.freshRadioButton.Name = "freshRadioButton"
        Me.freshRadioButton.Size = New System.Drawing.Size(95, 19)
        Me.freshRadioButton.TabIndex = 5
        Me.freshRadioButton.TabStop = True
        Me.freshRadioButton.Text = "Fresh Brewed"
        Me.freshRadioButton.UseVisualStyleBackColor = True
        '
        'thirdlbbagRadioButton
        '
        Me.thirdlbbagRadioButton.AutoSize = True
        Me.thirdlbbagRadioButton.Location = New System.Drawing.Point(217, 112)
        Me.thirdlbbagRadioButton.Name = "thirdlbbagRadioButton"
        Me.thirdlbbagRadioButton.Size = New System.Drawing.Size(158, 19)
        Me.thirdlbbagRadioButton.TabIndex = 8
        Me.thirdlbbagRadioButton.Text = "Coffee Beans (1/&3 lb bag)"
        Me.thirdlbbagRadioButton.UseVisualStyleBackColor = True
        '
        'halflbbagRadioButton
        '
        Me.halflbbagRadioButton.AutoSize = True
        Me.halflbbagRadioButton.Location = New System.Drawing.Point(217, 85)
        Me.halflbbagRadioButton.Name = "halflbbagRadioButton"
        Me.halflbbagRadioButton.Size = New System.Drawing.Size(158, 19)
        Me.halflbbagRadioButton.TabIndex = 7
        Me.halflbbagRadioButton.Text = "Coffee Beans (1/&2 lb bag)"
        Me.halflbbagRadioButton.UseVisualStyleBackColor = True
        '
        'onelbbagRadioButton
        '
        Me.onelbbagRadioButton.AutoSize = True
        Me.onelbbagRadioButton.Location = New System.Drawing.Point(217, 59)
        Me.onelbbagRadioButton.Name = "onelbbagRadioButton"
        Me.onelbbagRadioButton.Size = New System.Drawing.Size(144, 19)
        Me.onelbbagRadioButton.TabIndex = 6
        Me.onelbbagRadioButton.Text = "Coffee Beans (&1lb bag)"
        Me.onelbbagRadioButton.UseVisualStyleBackColor = True
        '
        'latteRadioButton
        '
        Me.latteRadioButton.AutoSize = True
        Me.latteRadioButton.Location = New System.Drawing.Point(36, 85)
        Me.latteRadioButton.Name = "latteRadioButton"
        Me.latteRadioButton.Size = New System.Drawing.Size(51, 19)
        Me.latteRadioButton.TabIndex = 2
        Me.latteRadioButton.Text = "La&tte"
        Me.latteRadioButton.UseVisualStyleBackColor = True
        '
        'icedLatteRadioButton
        '
        Me.icedLatteRadioButton.AutoSize = True
        Me.icedLatteRadioButton.Location = New System.Drawing.Point(36, 112)
        Me.icedLatteRadioButton.Name = "icedLatteRadioButton"
        Me.icedLatteRadioButton.Size = New System.Drawing.Size(76, 19)
        Me.icedLatteRadioButton.TabIndex = 3
        Me.icedLatteRadioButton.Text = "&Iced Latte"
        Me.icedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'icedcappuccinoRadioButton
        '
        Me.icedcappuccinoRadioButton.AutoSize = True
        Me.icedcappuccinoRadioButton.Location = New System.Drawing.Point(36, 137)
        Me.icedcappuccinoRadioButton.Name = "icedcappuccinoRadioButton"
        Me.icedcappuccinoRadioButton.Size = New System.Drawing.Size(114, 19)
        Me.icedcappuccinoRadioButton.TabIndex = 4
        Me.icedcappuccinoRadioButton.Text = "Ice&d Cappuccino"
        Me.icedcappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'espressoRadioButton
        '
        Me.espressoRadioButton.AutoSize = True
        Me.espressoRadioButton.Location = New System.Drawing.Point(36, 59)
        Me.espressoRadioButton.Name = "espressoRadioButton"
        Me.espressoRadioButton.Size = New System.Drawing.Size(70, 19)
        Me.espressoRadioButton.TabIndex = 1
        Me.espressoRadioButton.Text = "&Espresso"
        Me.espressoRadioButton.UseVisualStyleBackColor = True
        '
        'cappuccinoRadioButton
        '
        Me.cappuccinoRadioButton.AutoSize = True
        Me.cappuccinoRadioButton.Checked = True
        Me.cappuccinoRadioButton.Location = New System.Drawing.Point(36, 32)
        Me.cappuccinoRadioButton.Name = "cappuccinoRadioButton"
        Me.cappuccinoRadioButton.Size = New System.Drawing.Size(89, 19)
        Me.cappuccinoRadioButton.TabIndex = 0
        Me.cappuccinoRadioButton.TabStop = True
        Me.cappuccinoRadioButton.Text = "C&appuccino"
        Me.cappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.totalLabel)
        Me.GroupBox3.Controls.Add(Me.taxLabel)
        Me.GroupBox3.Controls.Add(Me.surchargeLabel)
        Me.GroupBox3.Controls.Add(Me.subtotalLabel)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(321, 261)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(252, 202)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Totals"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(132, 143)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(89, 28)
        Me.totalLabel.TabIndex = 7
        '
        'taxLabel
        '
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxLabel.Location = New System.Drawing.Point(132, 106)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(89, 28)
        Me.taxLabel.TabIndex = 5
        '
        'surchargeLabel
        '
        Me.surchargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.surchargeLabel.Location = New System.Drawing.Point(132, 67)
        Me.surchargeLabel.Name = "surchargeLabel"
        Me.surchargeLabel.Size = New System.Drawing.Size(89, 28)
        Me.surchargeLabel.TabIndex = 3
        '
        'subtotalLabel
        '
        Me.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subtotalLabel.Location = New System.Drawing.Point(132, 29)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(89, 28)
        Me.subtotalLabel.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Surcharge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subtotal:"
        '
        'newButton
        '
        Me.newButton.Location = New System.Drawing.Point(594, 290)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(102, 48)
        Me.newButton.TabIndex = 10
        Me.newButton.Text = "&New Order"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(594, 351)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(102, 48)
        Me.summaryButton.TabIndex = 11
        Me.summaryButton.Text = "&Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(594, 466)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(102, 48)
        Me.exitButton.TabIndex = 12
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'flavorsGroupBox
        '
        Me.flavorsGroupBox.Controls.Add(Me.addAltButton)
        Me.flavorsGroupBox.Controls.Add(Me.syrupsListBox)
        Me.flavorsGroupBox.Controls.Add(Me.Label8)
        Me.flavorsGroupBox.Controls.Add(Me.totalFlavorsLabel)
        Me.flavorsGroupBox.Controls.Add(Me.Label6)
        Me.flavorsGroupBox.Controls.Add(Me.removeAllButton)
        Me.flavorsGroupBox.Controls.Add(Me.addButton)
        Me.flavorsGroupBox.Controls.Add(Me.removeButton)
        Me.flavorsGroupBox.Controls.Add(Me.flavorComboBox)
        Me.flavorsGroupBox.Location = New System.Drawing.Point(24, 261)
        Me.flavorsGroupBox.Name = "flavorsGroupBox"
        Me.flavorsGroupBox.Size = New System.Drawing.Size(291, 249)
        Me.flavorsGroupBox.TabIndex = 1
        Me.flavorsGroupBox.TabStop = False
        Me.flavorsGroupBox.Text = "Fresh Brewed Flavors and Syrups"
        '
        'addAltButton
        '
        Me.addAltButton.Location = New System.Drawing.Point(191, 79)
        Me.addAltButton.Name = "addAltButton"
        Me.addAltButton.Size = New System.Drawing.Size(84, 50)
        Me.addAltButton.TabIndex = 2
        Me.addAltButton.Text = "Add Al&t Flavor"
        Me.addAltButton.UseVisualStyleBackColor = True
        '
        'syrupsListBox
        '
        Me.syrupsListBox.BackColor = System.Drawing.SystemColors.Window
        Me.syrupsListBox.FormattingEnabled = True
        Me.syrupsListBox.ItemHeight = 15
        Me.syrupsListBox.Location = New System.Drawing.Point(10, 135)
        Me.syrupsListBox.Name = "syrupsListBox"
        Me.syrupsListBox.Size = New System.Drawing.Size(141, 94)
        Me.syrupsListBox.Sorted = True
        Me.syrupsListBox.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Syrup flavors:"
        '
        'totalFlavorsLabel
        '
        Me.totalFlavorsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalFlavorsLabel.Location = New System.Drawing.Point(88, 67)
        Me.totalFlavorsLabel.Name = "totalFlavorsLabel"
        Me.totalFlavorsLabel.Size = New System.Drawing.Size(97, 28)
        Me.totalFlavorsLabel.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total flavors:"
        '
        'removeAllButton
        '
        Me.removeAllButton.Location = New System.Drawing.Point(191, 191)
        Me.removeAllButton.Name = "removeAllButton"
        Me.removeAllButton.Size = New System.Drawing.Size(84, 50)
        Me.removeAllButton.TabIndex = 4
        Me.removeAllButton.Text = "Remove All &Flavors"
        Me.removeAllButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(191, 23)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(84, 50)
        Me.addButton.TabIndex = 1
        Me.addButton.Text = "&Add Flavor"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(191, 135)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(84, 50)
        Me.removeButton.TabIndex = 3
        Me.removeButton.Text = "&Remove Flavor"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'flavorComboBox
        '
        Me.flavorComboBox.FormattingEnabled = True
        Me.flavorComboBox.Location = New System.Drawing.Point(7, 23)
        Me.flavorComboBox.Name = "flavorComboBox"
        Me.flavorComboBox.Size = New System.Drawing.Size(178, 23)
        Me.flavorComboBox.Sorted = True
        Me.flavorComboBox.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(345, 483)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Discount amount:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(345, 523)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Net order total:"
        '
        'discountLabel
        '
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountLabel.Location = New System.Drawing.Point(453, 482)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(89, 28)
        Me.discountLabel.TabIndex = 7
        '
        'netOrderLabel
        '
        Me.netOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.netOrderLabel.Location = New System.Drawing.Point(453, 523)
        Me.netOrderLabel.Name = "netOrderLabel"
        Me.netOrderLabel.Size = New System.Drawing.Size(89, 28)
        Me.netOrderLabel.TabIndex = 9
        '
        'discountCheckBox
        '
        Me.discountCheckBox.AutoSize = True
        Me.discountCheckBox.Location = New System.Drawing.Point(24, 532)
        Me.discountCheckBox.Name = "discountCheckBox"
        Me.discountCheckBox.Size = New System.Drawing.Size(117, 19)
        Me.discountCheckBox.TabIndex = 2
        Me.discountCheckBox.Text = "Volume Discount"
        Me.discountCheckBox.UseVisualStyleBackColor = True
        '
        'discountTextBox
        '
        Me.discountTextBox.Location = New System.Drawing.Point(262, 530)
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.Size = New System.Drawing.Size(53, 23)
        Me.discountTextBox.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(176, 532)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Discount (%):"
        '
        'MainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(725, 573)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.discountTextBox)
        Me.Controls.Add(Me.discountCheckBox)
        Me.Controls.Add(Me.netOrderLabel)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.flavorsGroupBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.newButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "Java Heaven App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.flavorsGroupBox.ResumeLayout(False)
        Me.flavorsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clearButton As Button
    Friend WithEvents amountLabel As Label
    Friend WithEvents dummyLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents surchargeCheckBox As CheckBox
    Friend WithEvents quantityTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents thirdlbbagRadioButton As RadioButton
    Friend WithEvents halflbbagRadioButton As RadioButton
    Friend WithEvents onelbbagRadioButton As RadioButton
    Friend WithEvents latteRadioButton As RadioButton
    Friend WithEvents icedLatteRadioButton As RadioButton
    Friend WithEvents icedcappuccinoRadioButton As RadioButton
    Friend WithEvents espressoRadioButton As RadioButton
    Friend WithEvents cappuccinoRadioButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents totalLabel As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents surchargeLabel As Label
    Friend WithEvents subtotalLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents newButton As Button
    Friend WithEvents summaryButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents freshRadioButton As RadioButton
    Friend WithEvents flavorsGroupBox As GroupBox
    Friend WithEvents syrupsListBox As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents totalFlavorsLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents removeAllButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents removeButton As Button
    Friend WithEvents flavorComboBox As ComboBox
    Friend WithEvents addAltButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents discountLabel As Label
    Friend WithEvents netOrderLabel As Label
    Friend WithEvents discountCheckBox As CheckBox
    Friend WithEvents discountTextBox As TextBox
    Friend WithEvents Label10 As Label
End Class
