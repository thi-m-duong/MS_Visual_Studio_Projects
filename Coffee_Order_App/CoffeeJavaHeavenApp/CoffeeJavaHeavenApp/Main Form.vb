'App Name: Java Heaven Coffee App
'App Date: 2/25/2016
'App Purpose: To help the management calculate and accumulate coffee sales

'Design Notes:
'A TOE chart shows the design of each task, object, and event.
'A flowchart could be used to show the logic within each subprocedure, especially the Calculate subprocedure.

Option Explicit On  'Disallows undeclared variables
Option Infer Off    'Does not infer (assume) a data type based on the data assigned to the memory location.
Option Strict On    'Disallows implicit data type conversions

Public Class MainForm
    'Declare the global variables
    Private dailyTotal As Double
    Private orderCount As Integer
    Private orderTotal As Double
    Private subtotal As Double
    Private currentOrderQuantity As Integer
    Private currentDiscount As Double = 0

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable the clear button and the summary button
        clearButton.Enabled = False
        summaryButton.Enabled = False
        surchargeCheckBox.Enabled = False
        discountTextBox.Enabled = False
        discountCheckBox.Enabled = False

        'Add items into the combo box
        flavorComboBox.Items.Add("Chocolate Almond")
        flavorComboBox.Items.Add("Espresso Roast")
        flavorComboBox.Items.Add("Jamaica Blue Mountain")
        flavorComboBox.Items.Add("Kona Blend")
        flavorComboBox.Items.Add("Vanilla Hazelnut")

        'Add items into the list box
        syrupsListBox.Items.Add("Chocolate")
        syrupsListBox.Items.Add("Hazelnut")
        syrupsListBox.Items.Add("Irish Creme")

        totalFlavorsLabel.Text = flavorComboBox.Items.Count.ToString
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        If MessageBox.Show("Are you sure you want to close the app? Your daily sales summary will be erased!", "Exit Confirmation",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'enable the Clear button when calculate button is hit
        clearButton.Enabled = True

        'calculate the item amount based on quantity and item price
        'declare variables
        Const taxRate As Double = 0.08
        Dim quantity As Integer
        Dim itemAmount As Double

        Dim total As Double
        Dim surcharge As Double
        Dim Tax As Double
        Dim surchargeAmount As Double

        'set prices to each menu item
        Const cappuccinoPrice As Double = 3.25
        Const espressoPrice As Double = 3.5
        Const lattePrice As Double = 3.0
        Const icedlattePrice As Double = 3.75
        Const icedcappuccinoPrice As Double = 3.75
        Const onePrice As Double = 9.99
        Const halfPrice As Double = 5.99
        Const thirdPrice As Double = 3.99

        Dim freshbrewedPrice As Double

        'set price for fresh brewed coffee
        If flavorComboBox.SelectedIndex >= 0 OrElse syrupsListBox.SelectedIndex >= 0 Then
            freshbrewedPrice = 2.5
        Else
            freshbrewedPrice = 2.0
        End If

        'assign selected item price to a variable
        Dim price As Double
        If cappuccinoRadioButton.Checked Then
            price = cappuccinoPrice
        ElseIf espressoRadioButton.Checked Then
            price = espressoPrice
        ElseIf latteRadioButton.Checked Then
            price = lattePrice
        ElseIf icedLatteRadioButton.Checked Then
            price = icedlattePrice
        ElseIf icedcappuccinoRadioButton.Checked Then
            price = icedcappuccinoPrice
        ElseIf onelbbagRadioButton.Checked Then
            price = onePrice
        ElseIf halflbbagRadioButton.Checked Then
            price = halfPrice
        ElseIf thirdlbbagRadioButton.Checked Then
            price = thirdPrice
        ElseIf freshRadioButton.Checked Then
            price = freshbrewedPrice
        End If



        'Assign data to existing variables and display the error message box if the input is not qualified
        If Not Integer.TryParse(quantityTextBox.Text, quantity) OrElse quantity = 0 Then
            MessageBox.Show("You need to enter a valid number!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            'calculate and display the item amount
            itemAmount = quantity * price
            amountLabel.Text = itemAmount.ToString("C2")

            'calculate and display the subtotal
            subtotal += itemAmount
            subtotalLabel.Text = subtotal.ToString("C2")

            'calculate and display the surcharge amount
            If surchargeCheckBox.Checked = True Then
                surchargeAmount = 1.5
            Else
                surchargeAmount = 0
            End If
            surcharge = surchargeAmount * quantity
            surchargeLabel.Text = surcharge.ToString("C2")

            'calculate and display tax
            Tax = taxRate * (subtotal + surcharge)
            taxLabel.Text = Tax.ToString("C2")

            'calculate and display the total
            total = subtotal + surcharge + Tax
            totalLabel.Text = total.ToString("C2")

            'Calculate the discount amount if the current discount is different than 0
            If currentDiscount <> 0 Then
                Dim discountAmount As Double 'discount amount is in dollars
                discountAmount = orderTotal * currentDiscount
                Dim netOrderTotal As Double
                'calculate and display the net order total
                netOrderTotal = orderTotal - discountAmount
                discountLabel.Text = discountAmount.ToString("C2")
                netOrderLabel.Text = netOrderTotal.ToString("c2")


            End If
            'Set orderTotal = total
            orderTotal = total
            currentOrderQuantity += quantity
            If currentOrderQuantity > 10 Then
                discountCheckBox.Enabled = True 'Enable the discount checkbox when the order quantity is greater than 10
            End If
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'reset the form but keep the order totals
        quantityTextBox.Text = String.Empty
        quantityTextBox.Focus()
        surchargeCheckBox.Checked = False
        amountLabel.Text = String.Empty
        cappuccinoRadioButton.Checked = True
        clearButton.Enabled = False
        syrupsListBox.SelectedIndex = -1
        flavorComboBox.SelectedIndex = -1
        flavorComboBox.Text = String.Empty

    End Sub

    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        'reset the form and add the current order totals to the Summary
        'reset all
        quantityTextBox.Text = String.Empty
        quantityTextBox.Focus()
        surchargeCheckBox.Checked = False
        amountLabel.Text = String.Empty
        cappuccinoRadioButton.Checked = True
        clearButton.Enabled = False
        subtotalLabel.Text = String.Empty
        surchargeLabel.Text = String.Empty
        taxLabel.Text = String.Empty
        totalLabel.Text = String.Empty

        'calculate the order total after the discount rate is applied and assign it in "discount" variable
        Dim discount As Double = orderTotal - (orderTotal * currentDiscount)

        'add the value of discount above to dailytotal
        dailyTotal += discount  'the new daily total is now cumulative of the cost after discount

        'reset the ordertotal and subtotal to 0
        orderTotal = 0
        subtotal = 0

        'increase the ordercount by 1
        orderCount += 1

        'enable the summary button after an order
        summaryButton.Enabled = True

        'reset the discount options to default and set the quantity of the order back to 0
        discountTextBox.Text = String.Empty
        discountCheckBox.Checked = False
        discountCheckBox.Enabled = False
        currentOrderQuantity = 0
        discountTextBox.Enabled = False
        'Unselect both the combobox and list box
        syrupsListBox.SelectedIndex = -1
        flavorComboBox.SelectedIndex = -1
        flavorComboBox.Text = String.Empty
    End Sub

    Private Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        'calculate the average order amount for the summary
        Dim average As Double = dailyTotal / orderCount
        'display a message box with information about all orders processed
        MessageBox.Show("Total number of orders: " & orderCount.ToString & ControlChars.NewLine &
                        "Daily total: " & dailyTotal.ToString("C2") & ControlChars.NewLine &
                        "Average: " & average.ToString("C2"), "Daily Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub halflbbagRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles halflbbagRadioButton.CheckedChanged
        'Enable the surcharge checkbox when the 1/2 bag is selected
        surchargeCheckBox.Enabled = True
    End Sub

    Private Sub thirdlbbagRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles thirdlbbagRadioButton.CheckedChanged
        'Enable the surcharge checkbox when the 1/3 bag is selected
        surchargeCheckBox.Enabled = True
    End Sub

    Private Sub quantityTextBox_Click(sender As Object, e As EventArgs) Handles quantityTextBox.Click
        'select all the text in the quantity text box and re-focus it 
        quantityTextBox.Focus()
        quantityTextBox.SelectAll()
    End Sub

    Private Sub quantityTextBox_Enter(sender As Object, e As EventArgs) Handles quantityTextBox.Enter
        'select all the text in the quantity text box
        quantityTextBox.SelectAll()
    End Sub

    Private Sub quantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityTextBox.KeyPress
        'Only allow the user to enter number 0-9 and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub quantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles quantityTextBox.TextChanged
        'clear the item amount whenever user changes the value in the quantity text box
        amountLabel.Text = String.Empty
    End Sub

    'Part 2

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        'add the new flavor typed in the combobox to the combobox's list
        If flavorComboBox.Text = String.Empty Then
            MessageBox.Show("You cannot add a blank flavor!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Declare a boolean variable that will be used to indicate if there is a duplication or not
            Dim checkDup As Boolean
            'Begin the loop
            'the loop goes through the list from the first item to the last item, if the input typed by user is matched with the existing flavor then display a message box
            For count As Integer = 0 To flavorComboBox.Items.Count - 1
                If flavorComboBox.Text = flavorComboBox.Items(count).ToString Then
                    MessageBox.Show("Cannot add! This flavor already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    checkDup = True 'indicates a duplication is found

                End If

            Next
            If checkDup = False Then
                flavorComboBox.Items.Add(flavorComboBox.Text)   'add the new flavor typed by the user into the combobox's list if did not find any duplication
                totalFlavorsLabel.Text = flavorComboBox.Items.Count.ToString    'update the total number of flavors
            End If

        End If


    End Sub

    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click
        'Remove a flavor from the combobox's list
        'Display a message of the user tryies to remove a blank flavor or a flavor that does not exist
        If flavorComboBox.Text = String.Empty Then
            MessageBox.Show("You cannot remove a blank flavor!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flavorComboBox.Items.Contains(flavorComboBox.Text) Then
            flavorComboBox.Items.Remove(flavorComboBox.Text)
        Else
            MessageBox.Show("You cannot remove an item that doesn't exist!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        totalFlavorsLabel.Text = flavorComboBox.Items.Count.ToString    'update the total number of flavors after removal


    End Sub

    Private Sub discountCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles discountCheckBox.CheckedChanged
        'Enable the discount textbox when the discount checkbox is checked
        discountTextBox.Enabled = discountCheckBox.Checked
        'If the discount checkbox is not checked then the discount textbox should be empty
        If discountCheckBox.Checked = False Then
            discountTextBox.Text = String.Empty
        End If
    End Sub

    Private Sub discountTextBox_TextChanged(sender As Object, e As EventArgs) Handles discountTextBox.TextChanged
        'clear the discount amount and the net order total when user changes the value in the discount textbox and reset the currentdiscount to 0
        discountLabel.Text = String.Empty
        netOrderLabel.Text = String.Empty
        currentDiscount = 0

        Dim discountPercentage As Double
        'Assign the discount percentage entered by the user to a variable
        If Double.TryParse(discountTextBox.Text, discountPercentage) AndAlso
             discountPercentage >= 0 AndAlso discountPercentage <= 100 Then
            discountTextBox.BackColor = Color.GreenYellow   'change the color of the discountTextBox to Green when the user enter a value between 0 and 100
            discountPercentage /= 100   'calculate the discount rate
            Dim discountAmount As Double
            discountAmount = orderTotal * discountPercentage    'calculate the discount amount
            Dim netOrderTotal As Double
            netOrderTotal = orderTotal - discountAmount     'calculate the net order total after discount
            'Display the discount amount and the net order total after discount, in dollars
            discountLabel.Text = discountAmount.ToString("C2")
            netOrderLabel.Text = netOrderTotal.ToString("c2")
            currentDiscount = discountPercentage

        ElseIf discountTextBox.Text = String.Empty Then
            discountTextBox.BackColor = Color.White     'If the discount textbox is empty then keep the background color white
        Else
            discountTextBox.BackColor = Color.Red       'Change the background to red when the conditions are not met
        End If

    End Sub

    Private Sub addAltButton_Click(sender As Object, e As EventArgs) Handles addAltButton.Click
        'Add a new flavor to the flavor combobox list
        'Display a message when the user add a blank flavor or add a flavor that already existed
        If flavorComboBox.Text = String.Empty Then
            MessageBox.Show("You cannot add a blank flavor!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf flavorComboBox.Items.Contains(flavorComboBox.Text) Then
            MessageBox.Show("Cannot add! This flavor already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            flavorComboBox.Items.Add(flavorComboBox.Text)      'Add the new flavor if the conditions above is wrong
        End If
        totalFlavorsLabel.Text = flavorComboBox.Items.Count.ToString    'Update the total amount of flavors
    End Sub

    Private Sub removeAllButton_Click(sender As Object, e As EventArgs) Handles removeAllButton.Click
        'Clear the flavor combobox list
        flavorComboBox.Items.Clear()
        'Update the total amount of flavors
        totalFlavorsLabel.Text = flavorComboBox.Items.Count.ToString
    End Sub

    Private Sub discountTextBox_Enter(sender As Object, e As EventArgs) Handles discountTextBox.Enter
        'select all the input in the discount textbox when user tabs up to the field
        discountTextBox.SelectAll()
    End Sub

    Private Sub discountTextBox_Click(sender As Object, e As EventArgs) Handles discountTextBox.Click
        'select all the input in the discount textbox when the user clicks on the textbox
        discountTextBox.SelectAll()
    End Sub

    Private Sub discountTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles discountTextBox.KeyPress
        'Only allow the user to enter numbers, backspace, and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class

