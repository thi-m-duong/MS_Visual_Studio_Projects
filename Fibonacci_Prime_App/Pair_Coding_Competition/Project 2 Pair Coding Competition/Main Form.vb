' Project name:         CalculatorApp
' Project purpose:      To create a basic calculator
' Created/revised by:   Susan Mykalcio and Thi Duong

Option Explicit On  'Disallows undeclared variables
Option Infer Off    'Does not infer (assume) a data type based on the data assigned to the memory location.
Option Strict On    'Disallows implicit data type conversions

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'start focus in Start Number textbox
        startTextBox.Focus()
    End Sub

    Private Sub multiplicationButton_Click(sender As Object, e As EventArgs) Handles multiplicationButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in the start text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'clear listbox
        resultListBox.Items.Clear()

        'save space
        Dim startNum As Integer
        Dim multiplication As Integer



        'get value
        Integer.TryParse(startTextBox.Text, startNum)


        'display table
        For count As Integer = 1 To 12 Step 1
            multiplication = startNum * count
            resultListBox.Items.Add(startNum.ToString & " * " & count.ToString & " = " & multiplication.ToString)

        Next



        'set focus and select all
        startTextBox.Focus()
        startTextBox.SelectAll()

    End Sub

    Private Sub sumButton_Click(sender As Object, e As EventArgs) Handles sumButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'clear listbox
        resultListBox.Items.Clear()

        'declare variables for start number and end number
        Dim startNum As Double
        Dim endNum As Double
        Dim sum As Double

        Double.TryParse(startTextBox.Text, startNum)
        Double.TryParse(endTextBox.Text, endNum)


        'calculate and display the sum of the 2 numbers
        sum = startNum + endNum

        resultListBox.Items.Add(sum.ToString)

        startTextBox.Focus()

    End Sub

    Private Sub differenceButton_Click(sender As Object, e As EventArgs) Handles differenceButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'clear listbox
        resultListBox.Items.Clear()

        'declare variables for start number and end number
        Dim startNum As Double
        Dim endNum As Double
        Dim difference As Double


        Double.TryParse(startTextBox.Text, startNum)
        Double.TryParse(endTextBox.Text, endNum)


        'calculate and display the difference of the 2 numbers
        difference = startNum - endNum

        resultListBox.Items.Add(difference.ToString)

        startTextBox.Focus()



    End Sub

    Private Sub productButton_Click(sender As Object, e As EventArgs) Handles productButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'clear listbox
        resultListBox.Items.Clear()

        'declare variables for start number and end number
        Dim startNum As Double
        Dim endNum As Double
        Dim product As Double

        Double.TryParse(startTextBox.Text, startNum)
        Double.TryParse(endTextBox.Text, endNum)


        'calculate and display the product of the 2 numbers
        product = startNum * endNum

        resultListBox.Items.Add(product.ToString)

        startTextBox.Focus()


    End Sub

    Private Sub quotientButton_Click(sender As Object, e As EventArgs) Handles quotientButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If


        'clear listbox
        resultListBox.Items.Clear()

        'declare variables for start number and end number
        Dim startNum As Double
        Dim endNum As Double
        Dim quotient As Double

        'calculate and display the quotient of the 2 numbers, end number can not be "0"
        Double.TryParse(startTextBox.Text, startNum)
        Double.TryParse(endTextBox.Text, endNum)

        If endNum = 0 Then
            MessageBox.Show("Can not devide by 0, please enter a valid number for end number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            quotient = startNum / endNum
            resultListBox.Items.Add(quotient.ToString)
        End If

        startTextBox.Focus()

    End Sub

    Private Sub averageButton_Click(sender As Object, e As EventArgs) Handles averageButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'clear listbox
        resultListBox.Items.Clear()

        'declare variables for start number and end number
        Dim startNum As Double
        Dim endNum As Double
        Dim average As Double

        Double.TryParse(startTextBox.Text, startNum)
        Double.TryParse(endTextBox.Text, endNum)


        'calculate and display the sum of the 2 numbers
        average = (startNum + endNum) / 2

        resultListBox.Items.Add(average.ToString)

        startTextBox.Focus()


    End Sub

    Private Sub minButton_Click(sender As Object, e As EventArgs) Handles minButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If


        'clear listbox
        resultListBox.Items.Clear()

        'declare variables for start number and end number
        Dim startNum As Double
        Dim endNum As Double


        Double.TryParse(startTextBox.Text, startNum)
        Double.TryParse(endTextBox.Text, endNum)


        'find min of the 2 numbers
        If startNum < endNum Then
            resultListBox.Items.Add(startNum.ToString)
        Else
            resultListBox.Items.Add(endNum.ToString)
        End If

        startTextBox.Focus()

    End Sub


    Private Sub maxButton_Click(sender As Object, e As EventArgs) Handles maxButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'clear listbox
        resultListBox.Items.Clear()

        'declare variables for start number and end number
        Dim startNum As Double
        Dim endNum As Double

        Double.TryParse(startTextBox.Text, startNum)
        Double.TryParse(endTextBox.Text, endNum)



        'find max of the 2 numbers
        If startNum > endNum Then
            resultListBox.Items.Add(startNum.ToString)
        Else
            resultListBox.Items.Add(endNum.ToString)
        End If

        startTextBox.Focus()


    End Sub

    Private Sub startTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles startTextBox.KeyPress

        'allows only numbers and backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If




    End Sub

    Private Sub endTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles endTextBox.KeyPress

        'allows only numbers and backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If



    End Sub


    Private Sub startTextBox_Click(sender As Object, e As EventArgs) Handles startTextBox.Click
        'selects all and clears result listbox
        startTextBox.SelectAll()



    End Sub

    Private Sub startTextBox_TextChanged(sender As Object, e As EventArgs) Handles startTextBox.TextChanged
        'selects all and clears result listbox
        'startTextBox.SelectAll()
        resultListBox.Items.Clear()
        endTextBox.Clear()





    End Sub

    Private Sub startTextBox_Enter(sender As Object, e As EventArgs) Handles startTextBox.Enter
        'selects all and clears result listbox and input textboxes
        startTextBox.SelectAll()



    End Sub

    Private Sub endTextBox_Click(sender As Object, e As EventArgs) Handles endTextBox.Click

        'selects all and clears result listbox
        endTextBox.SelectAll()


    End Sub

    Private Sub endTextBox_Enter(sender As Object, e As EventArgs) Handles endTextBox.Enter
        'selects all and clears result listbox
        endTextBox.SelectAll()


    End Sub

    Private Sub endTextBox_TextChanged(sender As Object, e As EventArgs) Handles endTextBox.TextChanged

        'selects all and clears result listbox
        resultListBox.Items.Clear()

    End Sub
    Private Sub expoButton_Click(sender As Object, e As EventArgs) Handles expoButton.Click
        resultListBox.Items.Clear()
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'Declare variables
        Dim startNum As Double
        Dim endNum As Double
        Dim result As Double

        'Assign inputs to existing variables and display the error message box if the input is not valid
        If Not Double.TryParse(startTextBox.Text, startNum) OrElse Not Double.TryParse(endTextBox.Text, endNum) Then
            MessageBox.Show("You need to enter a valid number!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Calculate the exponentiation
            result = startNum ^ endNum
            'Display the result
            resultListBox.Items.Add(result.ToString)
        End If
        'refocus the input
        startTextBox.Focus()
        endTextBox.Focus()
    End Sub

    Private Sub squareRootButton_Click(sender As Object, e As EventArgs) Handles squareRootButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in the start text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        resultListBox.Items.Clear()

        'declare variables
        Dim startNum As Double
        Dim result As Double

        'Assign inputs to existing variables and display the error message box if the input is not valid
        If Not Double.TryParse(startTextBox.Text, startNum) Then
            MessageBox.Show("You need to enter a valid number!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Calculate the square root
            result = System.Math.Sqrt(startNum)
        End If
        'display the result in the listbox
        resultListBox.Items.Add(result.ToString)

        'refocus the inputs
        startTextBox.Focus()
        endTextBox.Focus()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        If MessageBox.Show("Are you sure you want to close the app?", "Exit Confirmation",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ascendingButton_Click(sender As Object, e As EventArgs) Handles ascendingButton.Click
        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'reset the app
        resultListBox.Items.Clear()

        'declare variables
        Dim startNum As Double
        Dim endNum As Double
        Dim result As Double

        'Assign inputs to existing variables and display the error message box if the input is not valid
        If Not Double.TryParse(startTextBox.Text, startNum) OrElse Not Double.TryParse(endTextBox.Text, endNum) Then
            MessageBox.Show("You need to enter a valid number!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Display both numbers in ascending order
            resultListBox.Items.Add(startNum.ToString)
            resultListBox.Items.Add(endNum.ToString)
            resultListBox.Sorted = True
        End If
        'refocus the inputs
        startTextBox.Focus()
        endTextBox.Focus()
    End Sub

    Private Sub primeButton_Click(sender As Object, e As EventArgs) Handles primeButton.Click
        'clear the list box
        resultListBox.Items.Clear()

        'declare variables
        Dim startNum As Integer
        Dim endNum As Integer
        Dim isPrime As Boolean = True

        'Display error message for blank input
        If startTextBox.Text = String.Empty OrElse endTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in at least one text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'Disallow the user to enter the end number bigger than 500
        If endNum > 500 Then
            MessageBox.Show("You can't enter the end number > 500! Please re-enter the end number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            endTextBox.Focus()
            endTextBox.SelectAll()
        Else
            'assign inputs into existing variables
            Integer.TryParse(startTextBox.Text, startNum)
            Integer.TryParse(endTextBox.Text, endNum)

            'display a message if both number <= 1
            If startNum <= 1 AndAlso endNum <= 1 Then
                resultListBox.Items.Add("There are no prime numbers, please enter a number greater than 1 please!")
            Else
                'make sure the inputs are ascending
                If startNum > endNum Then
                    MessageBox.Show("Please make sure the start number is less than the end number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                'find the prime numbers
                For count As Integer = Math.Max(startNum, 2) To endNum
                    isPrime = True
                    For i As Integer = 2 To count - 1
                        If count Mod i = 0 Then
                            isPrime = False
                        End If
                    Next

                    If isPrime Then
                        resultListBox.Items.Add(count.ToString)
                    End If

                Next


                'refocus the textbox
                startTextBox.Focus()
            End If

        End If
    End Sub

    Private Sub fibonacciButton_Click(sender As Object, e As EventArgs) Handles fibonacciButton.Click
        'clear listbox
        resultListBox.Items.Clear()

        'declares variable and assign the input into that variable
        Dim startNum As Integer
        Integer.TryParse(startTextBox.Text, startNum)

        'Display error message for blank input
        If startTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in the start text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf startNum = 0 Then
            resultListBox.Items.Add("No fibonacci number")
        ElseIf startNum = 1 Then
            resultListBox.Items.Add("0")
        Else


            'Declare the fibonacci array

            Dim fibArray(startNum - 1) As Integer


            'to limit the number entered to 30 and below
            If startNum > 30 Then
                MessageBox.Show("You cannot enter number higher than 30! Please re-enter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                startTextBox.Focus()
            Else
                'set the 1st two value equal 0 and 1
                fibArray(0) = 0
                fibArray(1) = 1

                'calculate
                For count As Integer = 2 To fibArray.GetUpperBound(0)
                    fibArray(count) = fibArray(count - 1) + fibArray(count - 2)
                Next
                For Each fibNum As Integer In fibArray
                    resultListBox.Items.Add(fibNum)
                Next
            End If
        End If
        startTextBox.Focus()
    End Sub

    Private Sub factorialButton_Click(sender As Object, e As EventArgs) Handles factorialButton.Click
        'clear listbox
        resultListBox.Items.Clear()

        'Display error message for blank input
        If startTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter a number in the start text box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            startTextBox.Focus()
        End If

        'declare variables for start number and end number
        Dim startNum As Double
        Dim endNum As Double
        Dim factorial As Double = 1

        Double.TryParse(startTextBox.Text, startNum)
        Double.TryParse(endTextBox.Text, endNum)

        ' to calculate the factorial
        If startNum <= 10 Then

            For count As Double = 1 To startNum
                factorial *= count
            Next count
            resultListBox.Items.Add(factorial.ToString)
        Else
            MessageBox.Show("Can not enter number over 10. Please re-enter valid number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
