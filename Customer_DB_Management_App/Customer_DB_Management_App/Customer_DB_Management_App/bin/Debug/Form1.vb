Option Explicit On
Option Strict On
Option Infer On

Public Class Form1
    Private Sub CUSTOMERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERBindingNavigatorSaveItem.Click


        Try
            Me.Validate()
            Me.CUSTOMERBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CustomerDatabaseDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Restricted Chemical Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDatabaseDataSet.SALESREP' table. You can move, or remove it, as needed.
        Me.SALESREPTableAdapter.Fill(Me.CustomerDatabaseDataSet.SALESREP)
        'TODO: This line of code loads data into the 'CustomerDatabaseDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.CustomerDatabaseDataSet.CUSTOMER)

        'Load values for combo boxes


        ClassificationComboBox.Items.Add("Preferred")
        ClassificationComboBox.Items.Add("Not Preferred")
        ActiveStatusComboBox.Items.Add("Yes")
        ActiveStatusComboBox.Items.Add("No")

        Dim count As Integer = 1

        Do While count < 6

            PaymentTermsCodeComboBox.Items.Add(count.ToString)
            count = count + 1
        Loop

        CountryComboBox.Items.Add("USA")
        CountryComboBox.Items.Add("CAN")




        'This loop reads sales rep valid values and loads them into list box. 

        For Each record As DataRow In Me.CustomerDatabaseDataSet.SALESREP
            SalesRepIDComboBox.Items.Add(record.Item("SalesRepID").ToString)
        Next


        joins()


    End Sub


    Private Sub joins()

        'Joins CUSTOMER and SALESREP tables; writes sales rep name and region
        Dim queryResults = From CUSTOMER In Me.CustomerDatabaseDataSet.CUSTOMER, SALESREP In CustomerDatabaseDataSet.SALESREP
                           Where CUSTOMER.SalesRepID = SALESREP.SalesRepID And SALESREP.SalesRepID = SalesRepIDComboBox.Text
                           Select SALESREP.SalesRepLastName, SALESREP.SalesRepFirstName, SALESREP.SalesRepRegion
                           Distinct

        'Write the result to the interface
        For Each result In queryResults
            salesRepInfoLabel.Text = result.SalesRepFirstName & "  " & result.SalesRepLastName & " - " & result.SalesRepRegion
        Next


        'Joins CUSTOMER and PAYMENT tables; writes payment description
        Dim queryResultsPayment = From CUSTOMER In Me.CustomerDatabaseDataSet.CUSTOMER, PAYMENT In CustomerDatabaseDataSet.PAYMENT
                                  Where CUSTOMER.PaymentTermsCode = PAYMENT.PaymentTermID And PAYMENT.PaymentTermID = PaymentTermsCodeComboBox.Text
                                  Select PAYMENT.Description, PAYMENT.PaymentTermID
                                  Distinct

        For Each result In queryResultsPayment
            paymentTermsLabel.Text = result.Description
        Next

    End Sub

    Private Sub SalesRepIDLabel_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles salesRepInfoLabel.Click

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        'Confirmation of closing the application
        If MessageBox.Show("Are you sure you want to exit?",
              "Are you sure?",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

            'Closes the application
            Me.Close()

        End If
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        'Move to the next record
        Me.CUSTOMERBindingSource.MoveNext()

        joins()


    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click

        'Move to the previous record
        Me.CUSTOMERBindingSource.MovePrevious()

        joins()

    End Sub

    Private Sub firstButton_Click(sender As Object, e As EventArgs) Handles firstButton.Click

        'Move to the first record
        Me.CUSTOMERBindingSource.MoveFirst()

        joins()

    End Sub

    Private Sub lastButton_Click(sender As Object, e As EventArgs) Handles lastButton.Click

        'Move to the last record
        Me.CUSTOMERBindingSource.MoveLast()

        joins()

    End Sub

    Private Sub CustomerIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustomerIDTextBox.KeyPress

        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub YTDSalesTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles YTDSalesTextBox.KeyPress

        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub YTDLoyaltyPointsTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles YTDLoyaltyPointsTextBox.KeyPress

        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub PhoneNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhoneNumberTextBox.KeyPress

        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub SalesRepIDComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SalesRepIDComboBox.KeyPress

        ' accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

End Class
