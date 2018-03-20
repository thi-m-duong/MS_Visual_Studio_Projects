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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.majorListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fullnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studentIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.classificationListBox = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.honorsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Classification:"
        '
        'majorListBox
        '
        Me.majorListBox.FormattingEnabled = True
        Me.majorListBox.ItemHeight = 15
        Me.majorListBox.Location = New System.Drawing.Point(40, 150)
        Me.majorListBox.Name = "majorListBox"
        Me.majorListBox.Size = New System.Drawing.Size(241, 94)
        Me.majorListBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Major:"
        '
        'fullnameTextBox
        '
        Me.fullnameTextBox.Location = New System.Drawing.Point(40, 89)
        Me.fullnameTextBox.Name = "fullnameTextBox"
        Me.fullnameTextBox.Size = New System.Drawing.Size(241, 23)
        Me.fullnameTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Full name:"
        '
        'studentIDTextBox
        '
        Me.studentIDTextBox.Location = New System.Drawing.Point(127, 31)
        Me.studentIDTextBox.Name = "studentIDTextBox"
        Me.studentIDTextBox.Size = New System.Drawing.Size(153, 23)
        Me.studentIDTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Student ID:"
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(311, 294)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(135, 52)
        Me.exitButton.TabIndex = 12
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(311, 113)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(135, 52)
        Me.addButton.TabIndex = 11
        Me.addButton.Text = "&Add Student Information"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(311, 31)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(135, 52)
        Me.displayButton.TabIndex = 10
        Me.displayButton.Text = "&Display Student Information"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'classificationListBox
        '
        Me.classificationListBox.FormattingEnabled = True
        Me.classificationListBox.ItemHeight = 15
        Me.classificationListBox.Location = New System.Drawing.Point(40, 282)
        Me.classificationListBox.Name = "classificationListBox"
        Me.classificationListBox.Size = New System.Drawing.Size(131, 64)
        Me.classificationListBox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Honors:"
        '
        'honorsListBox
        '
        Me.honorsListBox.FormattingEnabled = True
        Me.honorsListBox.ItemHeight = 15
        Me.honorsListBox.Location = New System.Drawing.Point(183, 282)
        Me.honorsListBox.Name = "honorsListBox"
        Me.honorsListBox.Size = New System.Drawing.Size(97, 64)
        Me.honorsListBox.TabIndex = 9
        '
        'MainForm
        '
        Me.AcceptButton = Me.displayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(482, 375)
        Me.Controls.Add(Me.honorsListBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.classificationListBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.majorListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fullnameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.studentIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.displayButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "Student Information Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents majorListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fullnameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents studentIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents displayButton As Button
    Friend WithEvents classificationListBox As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents honorsListBox As ListBox
End Class
