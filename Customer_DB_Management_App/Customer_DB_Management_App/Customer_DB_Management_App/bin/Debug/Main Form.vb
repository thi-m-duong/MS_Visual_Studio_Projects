'Application Name: Customer Database & Front End Application
'Team Members: Christopher Diaz, Gabby Rosenboro, Thi Duong, Susan Mykalcio
'Last Updated: April 26th 2016

'All on because we are connected to a database
Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm

    Private validationCheck As Boolean

    Private Sub CUSTOMERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERBindingNavigatorSaveItem.Click
        'Save item
        validation()
        If validationCheck = True Then
            Try
                Me.Validate()
                Me.CUSTOMERBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.CustomerDatabaseDataSet)
                addRecordToolStripButton.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Data Entry Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                customerIDTextBox.Focus()
                customerIDTextBox.SelectAll()
            End Try

            'Enable the calculate button on save
            calculateButton.Enabled = True

            'Enable querying on save
            queriesToolStripDropDownButton.Enabled = True

            'Enable ordering on save
            orderByToolStripDropDownButton.Enabled = True

            'Enable the search feature on save
            searchByFirstNameToolStripMenuItem.Enabled = True

        Else

        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load values for combo boxes
        classificationComboBox.Items.Add("Preferred")
        classificationComboBox.Items.Add("Not Preferred")
        activeStatusComboBox.Items.Add("Yes")
        activeStatusComboBox.Items.Add("No")

        'Load values with a loop to the payment terms 1-5
        Dim count As Integer = 1
        Do While count < 6
            paymentTermsCodeComboBox.Items.Add(count.ToString)
            count = count + 1
        Loop

        'Add the Country items in the combobox 
        countryComboBox.Items.Add("USA")
        countryComboBox.Items.Add("CAN")

        'Add the State/Province Abbreviations
        stateComboBox.Items.Add("NY")
        stateComboBox.Items.Add("NJ")
        stateComboBox.Items.Add("VT")
        stateComboBox.Items.Add("MA")
        stateComboBox.Items.Add("RI")
        stateComboBox.Items.Add("DE")
        stateComboBox.Items.Add("NS")
        stateComboBox.Items.Add("QC")
        stateComboBox.Items.Add("ON")
        stateComboBox.Items.Add("PE")
        stateComboBox.Items.Add("NB")

        'This line of code loads data into the 'CustomerDatabaseDataSet.SALESREP' table.
        Me.SALESREPTableAdapter.Fill(Me.CustomerDatabaseDataSet.SALESREP)

        'This loop reads sales rep valid values and loads them into list box. 
        For Each record As DataRow In Me.CustomerDatabaseDataSet.SALESREP
            salesRepIDComboBox.Items.Add(record.Item("SalesRepID").ToString)
        Next

        'This line of code loads data into the 'CustomerDatabaseDataSet.CUSTOMER' table.
        Me.CUSTOMERTableAdapter.Fill(Me.CustomerDatabaseDataSet.CUSTOMER)

        joins()
    End Sub
    Private Sub joins()
        'Joins CUSTOMER and SALESREP tables; writes sales rep name and region
        Dim queryResults = From CUSTOMER In Me.CustomerDatabaseDataSet.CUSTOMER, SALESREP In CustomerDatabaseDataSet.SALESREP
                           Where CUSTOMER.SalesRepID = SALESREP.SalesRepID AndAlso SALESREP.SalesRepID = salesRepIDComboBox.Text
                           Select SALESREP.SalesRepLastName, SALESREP.SalesRepFirstName, SALESREP.SalesRepRegion
                           Distinct
        'Write the result to the interface
        For Each result In queryResults
            salesRepInfoLabel.Text = result.SalesRepFirstName & "  " & result.SalesRepLastName & " - " & result.SalesRepRegion
        Next

    End Sub
    Private Sub clearCalculatedLabels()
        'This is a sub procedure to clear the following labels
        'Total Sales
        'Average Sales
        'Max Sale
        'Min Sale

        totalSalesLabel.Text = String.Empty
        averageSaleLabel.Text = String.Empty
        maxSaleLabel.Text = String.Empty
        minSaleLabel.Text = String.Empty

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'Confirmation of closing the application
        If MessageBox.Show("Are you sure you want to exit?",
              "Exit Confirmation",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

            'Closes the application
            Me.Close()
        Else
            customerIDTextBox.Focus()
            customerIDTextBox.SelectAll()
        End If
    End Sub

    Private Sub validation()

        validationCheck = False

        If customerIDTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a customer ID.",
                            "Customer ID Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            customerIDTextBox.Focus()
        ElseIf customerNameTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a customer Name.",
                            "Customer Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            customerNameTextBox.Focus()
        ElseIf emailAddressTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter an email address.",
                            "Email Address Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            emailAddressTextBox.Focus()
        ElseIf phoneNumberTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a phone number.",
                            "Phone Number Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            phoneNumberTextBox.Focus()
        ElseIf websiteAddressTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a website address.",
                            "Web Address Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            websiteAddressTextBox.Focus()
        ElseIf billToAddress1TextBox.Text = String.Empty Then
            MessageBox.Show("Please enter an address.",
                            "Address Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            billToAddress1TextBox.Focus()
        ElseIf countryComboBox.Text = String.Empty Then
            MessageBox.Show("Please enter a country.",
                            "Country Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            countryComboBox.Focus()
        ElseIf stateComboBox.Text = String.Empty Then
            MessageBox.Show("Please enter a state.",
                            "State Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            stateComboBox.Focus()
        ElseIf billToCityTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a city.",
                            "City Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            billToCityTextBox.Focus()
        ElseIf billToPostalCodeTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a postal code.",
                            "Postal Code Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            billToPostalCodeTextBox.Focus()
        ElseIf classificationComboBox.Text = String.Empty Then
            MessageBox.Show("Please enter a Classification.",
                            "Classification Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            classificationComboBox.Focus()
        ElseIf paymentTermsCodeComboBox.Text = String.Empty Then
            MessageBox.Show("Please enter a payment term code.",
                            "Term Code Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            paymentTermsCodeComboBox.Focus()
        ElseIf activeStatusComboBox.Text = String.Empty Then
            MessageBox.Show("Please enter an active status.",
                            "Active Status Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            activeStatusComboBox.Focus()

        ElseIf salesRepIDComboBox.Text = String.Empty Then
            MessageBox.Show("Please enter a sales representitive.",
                           "Active Status Missing", MessageBoxButtons.OK, MessageBoxIcon.Error
                           )
            salesRepIDComboBox.Focus()
        Else
            'If the record passes all of the validations then set validationCheck to true to use throughout the code
            validationCheck = True
        End If

    End Sub
    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        'Validate the data for null values and other validations
        validation()

        'If the record passses all of the validations then move to the next record
        If validationCheck = True Then
            Try
                'Move to the next record
                Me.CUSTOMERBindingSource.MoveNext()
                joins()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please finish this record.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                customerIDTextBox.Focus()

            End Try

            'If the record does not pass validation do nothing
            'The validation sub procedure will generate meaningful error messages
        Else

        End If
    End Sub
    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        'Validate the data for null values and other validations
        validation()

        'If the record passses all of the validations then move to the previous record
        If validationCheck = True Then
            Try
                'Move to the previous record
                Me.CUSTOMERBindingSource.MovePrevious()
                joins()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please finish this record.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                customerIDTextBox.Focus()

            End Try

            'If the record does not pass validation do nothing
            'The validation sub procedure will generate meaningful error messages
        Else

        End If

    End Sub
    Private Sub firstButton_Click(sender As Object, e As EventArgs) Handles firstButton.Click
        'Validate the data for null values and other validations
        validation()

        'If the record passses all of the validations then move to the first record
        If validationCheck = True Then
            Try
                'Move to the first record
                Me.CUSTOMERBindingSource.MoveFirst()
                joins()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please finish this record.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                customerIDTextBox.Focus()

            End Try

            'If the record does not pass validation do nothing
            'The validation sub procedure will generate meaningful error messages
        Else

        End If
    End Sub
    Private Sub lastButton_Click(sender As Object, e As EventArgs) Handles lastButton.Click
        'Validate the data for null values and other validations
        validation()

        'If the record passses all of the validations then move to the last record
        If validationCheck = True Then
            Try
                'Move to the last record
                Me.CUSTOMERBindingSource.MoveLast()
                joins()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please finish this record.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                customerIDTextBox.Focus()

            End Try

            'If the record does not pass validation do nothing
            'The validation sub procedure will generate meaningful error messages
        Else

        End If
    End Sub
    Private Sub CustomerIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles customerIDTextBox.KeyPress
        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub YTDSalesTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ytdSalesTextBox.KeyPress
        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub YTDLoyaltyPointsTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ytdLoyaltyPointsTextBox.KeyPress
        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub PhoneNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phoneNumberTextBox.KeyPress
        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub SalesRepIDComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salesRepIDComboBox.KeyPress
        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        'Clear the salesrep label information if there
        salesRepInfoLabel.Text = String.Empty
    End Sub
    Private Sub SalesRepIDComboBox_TextChanged(sender As Object, e As EventArgs) Handles salesRepIDComboBox.TextChanged
        'This is what will run when the text is changed in the salesrepidcombobox

        'If the combobox is empty then clear the label that shows the associated information
        If salesRepIDComboBox.Text = String.Empty Then
            salesRepInfoLabel.Text = String.Empty
        Else
            'Query to get the sales rep information from the specific ID in the salesrep combobox
            Dim queryResults = From SALESREP In CustomerDatabaseDataSet.SALESREP
                               Where SALESREP.SalesRepID = salesRepIDComboBox.Text
                               Select SALESREP.SalesRepLastName, SALESREP.SalesRepFirstName, SALESREP.SalesRepRegion
                               Distinct

            'This displays the information of the specific salesrep when the ID is changed into the label below it 
            For Each result In queryResults
                salesRepInfoLabel.Text = result.SalesRepFirstName & "  " & result.SalesRepLastName & " - " & result.SalesRepRegion
            Next
        End If
    End Sub
    Private Sub SearchByFirstNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles searchByFirstNameToolStripMenuItem.Click
        Dim queryResults = From CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                           Where CUSTOMER.CustomerName.ToUpper Like searchTextBox.Text.ToUpper & "*"
        Try
            If queryResults.Count = 0 Then
                MessageBox.Show("No matching records.", "No records found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.CUSTOMERBindingSource.DataSource = queryResults.AsDataView
                'Disable the calculate button 
                calculateButton.Enabled = False
                'Clear the sales list box 
                salesListBox.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("No matching customer names.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click


        'Selects all of the rows in the customer database to refresh the list of people
        Dim queryResults = From CUSTOMER In CustomerDatabaseDataSet.CUSTOMER

        Try
            Me.CUSTOMERBindingSource.DataSource = queryResults.AsDataView

            'Clear the labels 
            clearCalculatedLabels()

            'Clear the sales list box
            salesListBox.Items.Clear()

            'Allow the calculate button to be pressed again
            calculateButton.Enabled = True

            'Enable the add button 
            addRecordToolStripButton.Enabled = True

            'Enable querying
            queriesToolStripDropDownButton.Enabled = True

            'Enable the order by feature
            orderByToolStripDropDownButton.Enabled = True

            'Enable the search feature
            searchByFirstNameToolStripMenuItem.Enabled = True



        Catch ex As Exception
            MessageBox.Show("Data Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        'Query to get all of the records 
        Dim queryResults = From CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                           Select CUSTOMER.YTDSales, CUSTOMER.CustomerName
                           Distinct
        'Add each result (each customer) and display their name and total sales in the sales list box
        Try
            salesListBox.Items.Add("Customer" & "Sales")
            salesListBox.Items.Add("")
            For Each result In queryResults
                salesListBox.Items.Add(result.CustomerName & result.YTDSales.ToString("C2").PadLeft(5))
            Next
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            customerIDTextBox.Focus()
            customerIDTextBox.SelectAll()
        End Try
        'Calculate the total sales 
        Dim totalSales As Double = Aggregate CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                                       Select CUSTOMER.YTDSales Into Sum()
        'Display the total sales
        totalSalesLabel.Text = totalSales.ToString("C2")

        'Calculate the average sales 
        Dim averageSales As Double = Aggregate CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                                       Select CUSTOMER.YTDSales Into Average()

        'Display the average sales
        averageSaleLabel.Text = averageSales.ToString("C2")

        'Calculate the maximum sales
        Dim maxSale As Double = Aggregate CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                                       Select CUSTOMER.YTDSales Into Max()

        'Display the max sales
        maxSaleLabel.Text = maxSale.ToString("C2")

        'Calculate the minimum sales
        Dim minSale As Double = Aggregate CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                                       Select CUSTOMER.YTDSales Into Min()

        'Display the minimum sales
        minSaleLabel.Text = minSale.ToString("C2")
    End Sub

    Private Sub CountryComboBox_TextChanged(sender As Object, e As EventArgs) Handles countryComboBox.TextChanged
        'This serves to validate the state combo box 
        'If Country is USA then clear the state combobox and then add only the associated USA sates
        If countryComboBox.Text = "USA" Then
            stateComboBox.Items.Clear()
            stateComboBox.Items.Add("NY")
            stateComboBox.Items.Add("NJ")
            stateComboBox.Items.Add("VT")
            stateComboBox.Items.Add("MA")
            stateComboBox.Items.Add("RI")
            stateComboBox.Items.Add("DE")

            'If Country is CAN then clear the state combobox and then add only the associated CAN sates
        ElseIf countryComboBox.Text = "CAN" Then
            stateComboBox.Items.Clear()
            stateComboBox.Items.Add("NS")
            stateComboBox.Items.Add("QC")
            stateComboBox.Items.Add("ON")
            stateComboBox.Items.Add("PE")
            stateComboBox.Items.Add("NB")

            'If the Country is null then load all of the state abbreviations
        ElseIf countryComboBox.Text = String.Empty Then
            'Add the State/Province Abbreviations
            stateComboBox.Items.Clear()
            stateComboBox.Items.Add("NY")
            stateComboBox.Items.Add("NJ")
            stateComboBox.Items.Add("VT")
            stateComboBox.Items.Add("MA")
            stateComboBox.Items.Add("RI")
            stateComboBox.Items.Add("DE")
            stateComboBox.Items.Add("NS")
            stateComboBox.Items.Add("QC")
            stateComboBox.Items.Add("ON")
            stateComboBox.Items.Add("PE")
            stateComboBox.Items.Add("NB")
        End If
    End Sub

    Private Sub CANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles canToolStripMenuItem.Click

        'This is the query that retrieves the Canadian customers
        Dim queryResults = From CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                           Where CUSTOMER.Country = "CAN"
        Try
            If queryResults.Count = 0 Then
                MessageBox.Show("No matching records.", "No records found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                customerIDTextBox.Focus()
                customerIDTextBox.SelectAll()
            Else
                'This sets the data source as the results from the above query
                Me.CUSTOMERBindingSource.DataSource = queryResults.AsDataView

                calculateButton.Enabled = False

                'Clear the calculated labels to remove what is there
                clearCalculatedLabels()

                'Clear the calculated sales box 
                salesListBox.Items.Clear()

            End If
        Catch ex As Exception
            MessageBox.Show("No matching customers.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerIDTextBox.Focus()
            customerIDTextBox.SelectAll()
        End Try
    End Sub

    Private Sub USAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles usaToolStripMenuItem.Click
        'This is the query that retrieves the USA customers
        Dim queryResults = From CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                           Where CUSTOMER.Country = "USA"
        Try
            If queryResults.Count = 0 Then
                MessageBox.Show("No matching customers.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                customerIDTextBox.Focus()
                customerIDTextBox.SelectAll()
            Else
                'This sets the data source as the results from the above query
                Me.CUSTOMERBindingSource.DataSource = queryResults.AsDataView

                calculateButton.Enabled = False

                'Clear the calculated labels to remove what is there
                clearCalculatedLabels()

                'Clear the calculated sales box 
                salesListBox.Items.Clear()

            End If
        Catch ex As Exception
            MessageBox.Show("No matching customers.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerIDTextBox.Focus()
            customerIDTextBox.SelectAll()
        End Try
    End Sub
    Private Sub NYCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles nyCustomersToolStripMenuItem.Click
        'This is the query that retrieves the NY customers
        Dim queryResults = From CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                           Where CUSTOMER.State = "NY"
        Try
            If queryResults.Count = 0 Then
                MessageBox.Show("No matching customers.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                customerIDTextBox.Focus()
                customerIDTextBox.SelectAll()
            Else
                'This sets the data source as the results from the above query
                Me.CUSTOMERBindingSource.DataSource = queryResults.AsDataView
                calculateButton.Enabled = False

                'Clear the calculated labels to remove what is there
                clearCalculatedLabels()

                'Clear the calculated sales box 
                salesListBox.Items.Clear()

            End If
        Catch ex As Exception
            MessageBox.Show("No matching customers.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerIDTextBox.Focus()
            customerIDTextBox.SelectAll()
        End Try
    End Sub
    Private Sub addRecordToolStripButton_Click(sender As Object, e As EventArgs) Handles addRecordToolStripButton.Click

        Try

            'Create a new record in the database
            CUSTOMERBindingNavigator.BindingSource.AddNew()

        Catch ex As Exception

            MessageBox.Show("Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        'Disable the add record button to prevent saving of null entries
        addRecordToolStripButton.Enabled = False

        'Disable the calculate button when creating a new record
        calculateButton.Enabled = False

        'Disable querying when creating a new record
        queriesToolStripDropDownButton.Enabled = False

        'Disable ordering by when creating a new record
        orderByToolStripDropDownButton.Enabled = False

        'Disable the search feauture while creating a new record
        searchByFirstNameToolStripMenuItem.Enabled = False


        'Change all the drop down list boxes on the form to have no selections 
        classificationComboBox.SelectedIndex() = -1
        countryComboBox.SelectedIndex() = -1
        activeStatusComboBox.SelectedIndex() = -1
        paymentTermsCodeComboBox.SelectedIndex() = -1
        salesRepIDComboBox.SelectedIndex() = -1


    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        'After deletion of a record enable the add record button
        addRecordToolStripButton.Enabled = True
    End Sub
    Private Sub CustomerNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles customerNameToolStripMenuItem.Click
        'Query to get all of the customers and order by customer name
        Dim queryResults = From CUSTOMER In CustomerDatabaseDataSet.CUSTOMER
                           Order By CUSTOMER.CustomerName
        Try
            If queryResults.Count = 0 Then
                MessageBox.Show("No records.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                customerIDTextBox.Focus()
                customerIDTextBox.SelectAll()
            Else
                'Set the data set to that query
                Me.CUSTOMERBindingSource.DataSource = queryResults.AsDataView
                calculateButton.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("No records.", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerIDTextBox.Focus()
            customerIDTextBox.SelectAll()
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles deleteToolStripButton.Click
        If MessageBox.Show("Are you sure you want to delete this record?",
              "Are you sure?",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            CUSTOMERBindingSource.RemoveCurrent()
            CUSTOMERBindingNavigatorSaveItem.PerformClick()
        Else

        End If
    End Sub
    Private Sub PaymentTermsCodeComboBox_TextChanged(sender As Object, e As EventArgs) Handles paymentTermsCodeComboBox.TextChanged
        If paymentTermsCodeComboBox.Text = "1" Then
            paymentTermsLabel.Text = "(Net 30) requires that the customer pay their palance owed within 30 days"

        ElseIf paymentTermsCodeComboBox.Text = "2" Then
            paymentTermsLabel.Text = "(10 Net 30) allows payment within 30 days with a 10% discount"

        ElseIf paymentTermsCodeComboBox.Text = "3" Then
            paymentTermsLabel.Text = "requires cash in advance"

        ElseIf paymentTermsCodeComboBox.Text = "4" Then
            paymentTermsLabel.Text = "requires cash on delivery"

        ElseIf paymentTermsCodeComboBox.Text = "5" Then
            paymentTermsLabel.Text = "(5 Net 30) allows for payment within 30 days with a 5% discount"

        ElseIf paymentTermsCodeComboBox.Text = String.Empty Then
            paymentTermsLabel.Text = String.Empty

        End If
    End Sub
    Private Sub DiscountTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles discountTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
