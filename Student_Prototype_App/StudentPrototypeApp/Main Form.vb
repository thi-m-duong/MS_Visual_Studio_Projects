'App Name: Student Prototype App
'App Date: 1/25/2016
'App Purpose: To get the quantity of various menu items from the customer and total the order with tax included.
'App Developers/UX designer: Susan Mykalcio, Thi Duong

Option Explicit On  'Disallows undeclared variables
Option Infer Off    'Does not infer (assume) a data type based on the data assigned to the memory location.
Option Strict On    'Disallows implicit data type conversions




Public Class MainForm
    Private columnId As Integer = -1
    Private Const numberOfRows As Integer = 4
    Private studentArray(numberOfRows, columnId) As String



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set focus for student ID Textbox
        studentIDTextBox.Focus()
        studentIDTextBox.SelectAll()


        'add majors to listbox
        majorListBox.Items.Add("Business Administration")
        majorListBox.Items.Add("Accounting")
        majorListBox.Items.Add("Operations")
        majorListBox.Items.Add("Human Resources")
        majorListBox.Items.Add("Finance")
        majorListBox.Items.Add("Information Technology")

        'add items to class listbox
        classificationListBox.Items.Add("Freshman")
        classificationListBox.Items.Add("Sophomore")
        classificationListBox.Items.Add("Junior")
        classificationListBox.Items.Add("Senior")

        'add items to honors listbox
        honorsListBox.Items.Add("Yes")
        honorsListBox.Items.Add("No")

        'set focus for listboxes
        majorListBox.SelectedIndex = 0
        classificationListBox.SelectedIndex = 0
        honorsListBox.SelectedIndex = 0
    End Sub


    Private Sub studentIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studentIDTextBox.KeyPress
        'only allow numbers in ID textbox
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If



    End Sub

    Private Sub fullnameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fullnameTextBox.KeyPress
        'only allow letters and no numbers
        If Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub



    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        'check to see if the Student ID textbox is empty or if Full name text box is empty, if either is blank then display an error message
        If studentIDTextBox.Text = String.Empty OrElse
                fullnameTextBox.Text = String.Empty Then
            MessageBox.Show("You need to enter all the student information!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'studentIDTextBox.Text = String.Empty
            'fullnameTextBox.Text = String.Empty
            studentIDTextBox.Focus()
        End If


        ' see if student ID is found
        Dim findStudentID As String
        Dim didFindID As Boolean
        findStudentID = studentIDTextBox.Text
        didFindID = False

        'if student ID is not blank then determin the highest colum subscript in studentArray
        Dim highCol As Integer
        Dim foundID As Integer
        If findStudentID <> Nothing Then

            highCol = studentArray.GetUpperBound(1)

            For column As Integer = 0 To highCol
                If findStudentID = studentArray(0, column) AndAlso didFindID = False Then
                    foundID = column
                    didFindID = True
                End If
            Next

            If didFindID = False Then


                'all done, now increment counter and expand array
                columnId += 1
                ReDim Preserve studentArray(numberOfRows, columnId)

                'read from interface and write to array            
                studentArray(0, columnId) = studentIDTextBox.Text
                studentArray(1, columnId) = fullnameTextBox.Text
                studentArray(2, columnId) = majorListBox.Text
                studentArray(3, columnId) = classificationListBox.Text
                studentArray(4, columnId) = honorsListBox.Text

            End If

            If didFindID = True Then
                'show messagebox if the student ID is not found
                MessageBox.Show("Student already in system. Please re-enter or add student information.", "Student Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                studentIDTextBox.Focus()
                studentIDTextBox.SelectAll()

            End If

        End If
        studentIDTextBox.Focus()

        'Reset the form to default after a student is added
        studentIDTextBox.Text = String.Empty
        fullnameTextBox.Text = String.Empty
        majorListBox.SelectedIndex = 0
        classificationListBox.SelectedIndex = 0
        honorsListBox.SelectedIndex = 0

    End Sub


    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        'declare variables
        Dim findStudentID As String
        Dim didFindID As Boolean

        Dim highCol As Integer
        Dim foundID As Integer

        Dim findName As String
        Dim didFindName As Boolean
        Dim foundName As Integer

        'Display student information when the user types in either ID or name
        If studentIDTextBox.Text = "" AndAlso fullnameTextBox.Text = "" Then
            MessageBox.Show("You need to enter either student ID or student's full name!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            studentIDTextBox.Focus()
        Else
            ' check to see if student ID or name is found
            findStudentID = studentIDTextBox.Text
            findName = fullnameTextBox.Text
            didFindID = False
            didFindName = False

            ' if student ID is not blank, then determine highest column subscript in studentArray
            If findStudentID <> Nothing Then
                highCol = studentArray.GetUpperBound(1)

                ' traverse two-dimensional array. Search the first row of each column. If it finds it, then save the index and exit
                For column As Integer = 0 To highCol
                    If findStudentID = studentArray(0, column) AndAlso didFindID = False Then
                        foundID = column
                        didFindID = True
                    End If
                Next
            End If

            ' if student name is not blank, then determine highest column subscript in studentArray
            If findName <> Nothing Then
                highCol = studentArray.GetUpperBound(1)

                ' traverse two-dimensional array. Search the second row of each column. If it finds it, then save the index and exit
                For column As Integer = 0 To highCol
                    If findName = studentArray(1, column) AndAlso didFindName = False Then
                        foundName = column
                        didFindName = True
                    End If
                Next
            End If

            If didFindID OrElse didFindName Then
                Dim studentIndex As Integer
                If didFindID Then
                    studentIndex = foundID
                Else
                    studentIndex = foundName
                End If
                'read from array and write to interface
                studentIDTextBox.Text = studentArray(0, studentIndex)
                fullnameTextBox.Text = studentArray(1, studentIndex)
                majorListBox.Text = studentArray(2, studentIndex)
                classificationListBox.Text = studentArray(3, studentIndex)
                honorsListBox.Text = studentArray(4, studentIndex)
            Else
                MessageBox.Show("Student data is not found. Please re-enter or add the student data!", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                studentIDTextBox.Focus()
            End If

        End If

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        If MessageBox.Show("Are you sure you want to close the app?", "Exit Confirmation",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub studentIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles studentIDTextBox.TextChanged
        'Reset the form to default
        fullnameTextBox.Text = String.Empty
        majorListBox.SelectedIndex = 0
        classificationListBox.SelectedIndex = 0
        honorsListBox.SelectedIndex = 0
    End Sub

    Private Sub fullnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles fullnameTextBox.TextChanged
        'Reset the form selections to default
        majorListBox.SelectedIndex = 0
        classificationListBox.SelectedIndex = 0
        honorsListBox.SelectedIndex = 0
    End Sub

    Private Sub studentIDTextBox_Click(sender As Object, e As EventArgs) Handles studentIDTextBox.Click
        'select all the content in the textbox when it receives focus
        studentIDTextBox.Focus()
        studentIDTextBox.SelectAll()
    End Sub

    Private Sub fullnameTextBox_Click(sender As Object, e As EventArgs) Handles fullnameTextBox.Click
        'select all the content in the textbox when it receives focus
        fullnameTextBox.Focus()
        fullnameTextBox.SelectAll()
    End Sub

    Private Sub studentIDTextBox_Enter(sender As Object, e As EventArgs) Handles studentIDTextBox.Enter
        studentIDTextBox.SelectAll()
    End Sub

    Private Sub fullnameTextBox_Enter(sender As Object, e As EventArgs) Handles fullnameTextBox.Enter
        fullnameTextBox.SelectAll()
    End Sub

End Class
