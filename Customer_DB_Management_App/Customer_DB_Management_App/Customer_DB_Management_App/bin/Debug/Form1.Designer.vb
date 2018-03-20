<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim SalesRepIDLabel As System.Windows.Forms.Label
        Dim ClassificationLabel As System.Windows.Forms.Label
        Dim ActiveStatusLabel As System.Windows.Forms.Label
        Dim PaymentTermsCodeLabel As System.Windows.Forms.Label
        Dim BillToAddress1Label As System.Windows.Forms.Label
        Dim BillToAddress2Label As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim BillToCityLabel As System.Windows.Forms.Label
        Dim BillToPostalCodeLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim WebsiteAddressLabel As System.Windows.Forms.Label
        Dim YTDLoyaltyPointsLabel As System.Windows.Forms.Label
        Dim YTDSalesLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CustomerDatabaseDataSet = New FinalProject.CustomerDatabaseDataSet()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMERTableAdapter = New FinalProject.CustomerDatabaseDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.TableAdapterManager = New FinalProject.CustomerDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CUSTOMERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CUSTOMERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.SalesRepIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ClassificationComboBox = New System.Windows.Forms.ComboBox()
        Me.ActiveStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.PaymentTermsCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.BillToAddress1TextBox = New System.Windows.Forms.TextBox()
        Me.BillToAddress2TextBox = New System.Windows.Forms.TextBox()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.BillToCityTextBox = New System.Windows.Forms.TextBox()
        Me.BillToPostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteAddressTextBox = New System.Windows.Forms.TextBox()
        Me.YTDLoyaltyPointsTextBox = New System.Windows.Forms.TextBox()
        Me.YTDSalesTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.salesRepInfoLabel = New System.Windows.Forms.Label()
        Me.SALESREPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALESREPTableAdapter = New FinalProject.CustomerDatabaseDataSetTableAdapters.SALESREPTableAdapter()
        Me.NotesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.firstButton = New System.Windows.Forms.Button()
        Me.lastButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.customerInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.addressGroupBox = New System.Windows.Forms.GroupBox()
        Me.paymentTermsLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        SalesRepIDLabel = New System.Windows.Forms.Label()
        ClassificationLabel = New System.Windows.Forms.Label()
        ActiveStatusLabel = New System.Windows.Forms.Label()
        PaymentTermsCodeLabel = New System.Windows.Forms.Label()
        BillToAddress1Label = New System.Windows.Forms.Label()
        BillToAddress2Label = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        BillToCityLabel = New System.Windows.Forms.Label()
        BillToPostalCodeLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        WebsiteAddressLabel = New System.Windows.Forms.Label()
        YTDLoyaltyPointsLabel = New System.Windows.Forms.Label()
        YTDSalesLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CUSTOMERBindingNavigator.SuspendLayout()
        CType(Me.SALESREPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.customerInfoGroupBox.SuspendLayout()
        Me.addressGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(9, 28)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(76, 15)
        CustomerIDLabel.TabIndex = 0
        CustomerIDLabel.Text = "Customer ID:"
        '
        'SalesRepIDLabel
        '
        SalesRepIDLabel.AutoSize = True
        SalesRepIDLabel.Location = New System.Drawing.Point(577, 63)
        SalesRepIDLabel.Name = "SalesRepIDLabel"
        SalesRepIDLabel.Size = New System.Drawing.Size(73, 15)
        SalesRepIDLabel.TabIndex = 3
        SalesRepIDLabel.Text = "Sales Rep ID:"
        AddHandler SalesRepIDLabel.Click, AddressOf Me.SalesRepIDLabel_Click
        '
        'ClassificationLabel
        '
        ClassificationLabel.AutoSize = True
        ClassificationLabel.Location = New System.Drawing.Point(37, 310)
        ClassificationLabel.Name = "ClassificationLabel"
        ClassificationLabel.Size = New System.Drawing.Size(80, 15)
        ClassificationLabel.TabIndex = 8
        ClassificationLabel.Text = "Classification:"
        '
        'ActiveStatusLabel
        '
        ActiveStatusLabel.AutoSize = True
        ActiveStatusLabel.Location = New System.Drawing.Point(39, 351)
        ActiveStatusLabel.Name = "ActiveStatusLabel"
        ActiveStatusLabel.Size = New System.Drawing.Size(78, 15)
        ActiveStatusLabel.TabIndex = 12
        ActiveStatusLabel.Text = "Active Status:"
        '
        'PaymentTermsCodeLabel
        '
        PaymentTermsCodeLabel.AutoSize = True
        PaymentTermsCodeLabel.Location = New System.Drawing.Point(286, 310)
        PaymentTermsCodeLabel.Name = "PaymentTermsCodeLabel"
        PaymentTermsCodeLabel.Size = New System.Drawing.Size(123, 15)
        PaymentTermsCodeLabel.TabIndex = 10
        PaymentTermsCodeLabel.Text = "Payment Terms Code:"
        '
        'BillToAddress1Label
        '
        BillToAddress1Label.AutoSize = True
        BillToAddress1Label.Location = New System.Drawing.Point(6, 25)
        BillToAddress1Label.Name = "BillToAddress1Label"
        BillToAddress1Label.Size = New System.Drawing.Size(83, 15)
        BillToAddress1Label.TabIndex = 0
        BillToAddress1Label.Text = "Address line 1:"
        '
        'BillToAddress2Label
        '
        BillToAddress2Label.AutoSize = True
        BillToAddress2Label.Location = New System.Drawing.Point(6, 54)
        BillToAddress2Label.Name = "BillToAddress2Label"
        BillToAddress2Label.Size = New System.Drawing.Size(83, 15)
        BillToAddress2Label.TabIndex = 4
        BillToAddress2Label.Text = "Address line 2:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(6, 83)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(53, 15)
        CountryLabel.TabIndex = 8
        CountryLabel.Text = "Country:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(275, 25)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(36, 15)
        StateLabel.TabIndex = 2
        StateLabel.Text = "State:"
        '
        'BillToCityLabel
        '
        BillToCityLabel.AutoSize = True
        BillToCityLabel.Location = New System.Drawing.Point(275, 54)
        BillToCityLabel.Name = "BillToCityLabel"
        BillToCityLabel.Size = New System.Drawing.Size(31, 15)
        BillToCityLabel.TabIndex = 6
        BillToCityLabel.Text = "City:"
        '
        'BillToPostalCodeLabel
        '
        BillToPostalCodeLabel.AutoSize = True
        BillToPostalCodeLabel.Location = New System.Drawing.Point(275, 83)
        BillToPostalCodeLabel.Name = "BillToPostalCodeLabel"
        BillToPostalCodeLabel.Size = New System.Drawing.Size(73, 15)
        BillToPostalCodeLabel.TabIndex = 10
        BillToPostalCodeLabel.Text = "Postal Code:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(279, 33)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(82, 15)
        EmailAddressLabel.TabIndex = 27
        EmailAddressLabel.Text = "Email address:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(279, 57)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(89, 15)
        PhoneNumberLabel.TabIndex = 5
        PhoneNumberLabel.Text = "Phone number:"
        '
        'WebsiteAddressLabel
        '
        WebsiteAddressLabel.AutoSize = True
        WebsiteAddressLabel.Location = New System.Drawing.Point(279, 86)
        WebsiteAddressLabel.Name = "WebsiteAddressLabel"
        WebsiteAddressLabel.Size = New System.Drawing.Size(95, 15)
        WebsiteAddressLabel.TabIndex = 8
        WebsiteAddressLabel.Text = "Website address:"
        '
        'YTDLoyaltyPointsLabel
        '
        YTDLoyaltyPointsLabel.AutoSize = True
        YTDLoyaltyPointsLabel.Location = New System.Drawing.Point(286, 385)
        YTDLoyaltyPointsLabel.Name = "YTDLoyaltyPointsLabel"
        YTDLoyaltyPointsLabel.Size = New System.Drawing.Size(106, 15)
        YTDLoyaltyPointsLabel.TabIndex = 18
        YTDLoyaltyPointsLabel.Text = "YTDLoyalty Points:"
        '
        'YTDSalesLabel
        '
        YTDSalesLabel.AutoSize = True
        YTDSalesLabel.Location = New System.Drawing.Point(286, 346)
        YTDSalesLabel.Name = "YTDSalesLabel"
        YTDSalesLabel.Size = New System.Drawing.Size(58, 15)
        YTDSalesLabel.TabIndex = 14
        YTDSalesLabel.Text = "YTDSales:"
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(42, 385)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(57, 15)
        DiscountLabel.TabIndex = 16
        DiscountLabel.Text = "Discount:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(46, 436)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(41, 15)
        NotesLabel.TabIndex = 20
        NotesLabel.Text = "Notes:"
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(9, 60)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(97, 15)
        CustomerNameLabel.TabIndex = 27
        CustomerNameLabel.Text = "Customer Name:"
        '
        'CustomerDatabaseDataSet
        '
        Me.CustomerDatabaseDataSet.DataSetName = "CustomerDatabaseDataSet"
        Me.CustomerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.CustomerDatabaseDataSet
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERTableAdapter = Me.CUSTOMERTableAdapter
        Me.TableAdapterManager.PAYMENTTableAdapter = Nothing
        Me.TableAdapterManager.SALESREPTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FinalProject.CustomerDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CUSTOMERBindingNavigator
        '
        Me.CUSTOMERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CUSTOMERBindingNavigator.BindingSource = Me.CUSTOMERBindingSource
        Me.CUSTOMERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CUSTOMERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CUSTOMERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CUSTOMERBindingNavigatorSaveItem})
        Me.CUSTOMERBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CUSTOMERBindingNavigator.MoveFirstItem = Nothing
        Me.CUSTOMERBindingNavigator.MoveLastItem = Nothing
        Me.CUSTOMERBindingNavigator.MoveNextItem = Nothing
        Me.CUSTOMERBindingNavigator.MovePreviousItem = Nothing
        Me.CUSTOMERBindingNavigator.Name = "CUSTOMERBindingNavigator"
        Me.CUSTOMERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CUSTOMERBindingNavigator.Size = New System.Drawing.Size(826, 25)
        Me.CUSTOMERBindingNavigator.TabIndex = 0
        Me.CUSTOMERBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CUSTOMERBindingNavigatorSaveItem
        '
        Me.CUSTOMERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CUSTOMERBindingNavigatorSaveItem.Image = CType(resources.GetObject("CUSTOMERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CUSTOMERBindingNavigatorSaveItem.Name = "CUSTOMERBindingNavigatorSaveItem"
        Me.CUSTOMERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CUSTOMERBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(135, 25)
        Me.CustomerIDTextBox.MaxLength = 9
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CustomerIDTextBox.TabIndex = 1
        '
        'SalesRepIDComboBox
        '
        Me.SalesRepIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "SalesRepID", True))
        Me.SalesRepIDComboBox.FormattingEnabled = True
        Me.SalesRepIDComboBox.Location = New System.Drawing.Point(656, 60)
        Me.SalesRepIDComboBox.Name = "SalesRepIDComboBox"
        Me.SalesRepIDComboBox.Size = New System.Drawing.Size(100, 23)
        Me.SalesRepIDComboBox.TabIndex = 4
        '
        'ClassificationComboBox
        '
        Me.ClassificationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Classification", True))
        Me.ClassificationComboBox.FormattingEnabled = True
        Me.ClassificationComboBox.Location = New System.Drawing.Point(159, 307)
        Me.ClassificationComboBox.Name = "ClassificationComboBox"
        Me.ClassificationComboBox.Size = New System.Drawing.Size(100, 23)
        Me.ClassificationComboBox.TabIndex = 9
        '
        'ActiveStatusComboBox
        '
        Me.ActiveStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "ActiveStatus", True))
        Me.ActiveStatusComboBox.FormattingEnabled = True
        Me.ActiveStatusComboBox.Location = New System.Drawing.Point(159, 343)
        Me.ActiveStatusComboBox.Name = "ActiveStatusComboBox"
        Me.ActiveStatusComboBox.Size = New System.Drawing.Size(100, 23)
        Me.ActiveStatusComboBox.TabIndex = 13
        '
        'PaymentTermsCodeComboBox
        '
        Me.PaymentTermsCodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "PaymentTermsCode", True))
        Me.PaymentTermsCodeComboBox.FormattingEnabled = True
        Me.PaymentTermsCodeComboBox.Location = New System.Drawing.Point(412, 307)
        Me.PaymentTermsCodeComboBox.Name = "PaymentTermsCodeComboBox"
        Me.PaymentTermsCodeComboBox.Size = New System.Drawing.Size(100, 23)
        Me.PaymentTermsCodeComboBox.TabIndex = 11
        '
        'BillToAddress1TextBox
        '
        Me.BillToAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "BillToAddress1", True))
        Me.BillToAddress1TextBox.Location = New System.Drawing.Point(131, 22)
        Me.BillToAddress1TextBox.Name = "BillToAddress1TextBox"
        Me.BillToAddress1TextBox.Size = New System.Drawing.Size(100, 23)
        Me.BillToAddress1TextBox.TabIndex = 1
        '
        'BillToAddress2TextBox
        '
        Me.BillToAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "BillToAddress2", True))
        Me.BillToAddress2TextBox.Location = New System.Drawing.Point(131, 51)
        Me.BillToAddress2TextBox.Name = "BillToAddress2TextBox"
        Me.BillToAddress2TextBox.Size = New System.Drawing.Size(100, 23)
        Me.BillToAddress2TextBox.TabIndex = 5
        '
        'CountryComboBox
        '
        Me.CountryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Country", True))
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Location = New System.Drawing.Point(131, 80)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(100, 23)
        Me.CountryComboBox.TabIndex = 9
        '
        'StateComboBox
        '
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "State", True))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(383, 22)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(100, 23)
        Me.StateComboBox.TabIndex = 3
        '
        'BillToCityTextBox
        '
        Me.BillToCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "BillToCity", True))
        Me.BillToCityTextBox.Location = New System.Drawing.Point(383, 51)
        Me.BillToCityTextBox.MaxLength = 25
        Me.BillToCityTextBox.Name = "BillToCityTextBox"
        Me.BillToCityTextBox.Size = New System.Drawing.Size(100, 23)
        Me.BillToCityTextBox.TabIndex = 7
        '
        'BillToPostalCodeTextBox
        '
        Me.BillToPostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "BillToPostalCode", True))
        Me.BillToPostalCodeTextBox.Location = New System.Drawing.Point(384, 80)
        Me.BillToPostalCodeTextBox.MaxLength = 9
        Me.BillToPostalCodeTextBox.Name = "BillToPostalCodeTextBox"
        Me.BillToPostalCodeTextBox.Size = New System.Drawing.Size(100, 23)
        Me.BillToPostalCodeTextBox.TabIndex = 11
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(387, 25)
        Me.EmailAddressTextBox.MaxLength = 20
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(100, 23)
        Me.EmailAddressTextBox.TabIndex = 2
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(387, 54)
        Me.PhoneNumberTextBox.MaxLength = 10
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PhoneNumberTextBox.TabIndex = 6
        '
        'WebsiteAddressTextBox
        '
        Me.WebsiteAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "WebsiteAddress", True))
        Me.WebsiteAddressTextBox.Location = New System.Drawing.Point(387, 83)
        Me.WebsiteAddressTextBox.MaxLength = 25
        Me.WebsiteAddressTextBox.Name = "WebsiteAddressTextBox"
        Me.WebsiteAddressTextBox.Size = New System.Drawing.Size(100, 23)
        Me.WebsiteAddressTextBox.TabIndex = 9
        '
        'YTDLoyaltyPointsTextBox
        '
        Me.YTDLoyaltyPointsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "YTDLoyaltyPoints", True))
        Me.YTDLoyaltyPointsTextBox.Location = New System.Drawing.Point(412, 382)
        Me.YTDLoyaltyPointsTextBox.MaxLength = 6
        Me.YTDLoyaltyPointsTextBox.Name = "YTDLoyaltyPointsTextBox"
        Me.YTDLoyaltyPointsTextBox.Size = New System.Drawing.Size(100, 23)
        Me.YTDLoyaltyPointsTextBox.TabIndex = 19
        '
        'YTDSalesTextBox
        '
        Me.YTDSalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "YTDSales", True))
        Me.YTDSalesTextBox.Location = New System.Drawing.Point(412, 338)
        Me.YTDSalesTextBox.MaxLength = 12
        Me.YTDSalesTextBox.Name = "YTDSalesTextBox"
        Me.YTDSalesTextBox.Size = New System.Drawing.Size(100, 23)
        Me.YTDSalesTextBox.TabIndex = 15
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Discount", True))
        Me.DiscountTextBox.Location = New System.Drawing.Point(159, 377)
        Me.DiscountTextBox.MaxLength = 5
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(100, 23)
        Me.DiscountTextBox.TabIndex = 17
        '
        'salesRepInfoLabel
        '
        Me.salesRepInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salesRepInfoLabel.Location = New System.Drawing.Point(592, 95)
        Me.salesRepInfoLabel.Name = "salesRepInfoLabel"
        Me.salesRepInfoLabel.Size = New System.Drawing.Size(162, 28)
        Me.salesRepInfoLabel.TabIndex = 5
        '
        'SALESREPBindingSource
        '
        Me.SALESREPBindingSource.DataMember = "SALESREP"
        Me.SALESREPBindingSource.DataSource = Me.CustomerDatabaseDataSet
        '
        'SALESREPTableAdapter
        '
        Me.SALESREPTableAdapter.ClearBeforeFill = True
        '
        'NotesRichTextBox
        '
        Me.NotesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Notes", True))
        Me.NotesRichTextBox.Location = New System.Drawing.Point(159, 436)
        Me.NotesRichTextBox.MaxLength = 50
        Me.NotesRichTextBox.Name = "NotesRichTextBox"
        Me.NotesRichTextBox.Size = New System.Drawing.Size(226, 67)
        Me.NotesRichTextBox.TabIndex = 21
        Me.NotesRichTextBox.Text = ""
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(330, 553)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(79, 33)
        Me.nextButton.TabIndex = 24
        Me.nextButton.Text = "&Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(232, 553)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(79, 33)
        Me.previousButton.TabIndex = 23
        Me.previousButton.Text = "&Previous"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'firstButton
        '
        Me.firstButton.Location = New System.Drawing.Point(137, 553)
        Me.firstButton.Name = "firstButton"
        Me.firstButton.Size = New System.Drawing.Size(79, 33)
        Me.firstButton.TabIndex = 22
        Me.firstButton.Text = "&First"
        Me.firstButton.UseVisualStyleBackColor = True
        '
        'lastButton
        '
        Me.lastButton.Location = New System.Drawing.Point(432, 553)
        Me.lastButton.Name = "lastButton"
        Me.lastButton.Size = New System.Drawing.Size(79, 33)
        Me.lastButton.TabIndex = 0
        Me.lastButton.Text = "&Last"
        Me.lastButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(534, 553)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(79, 33)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'customerInfoGroupBox
        '
        Me.customerInfoGroupBox.Controls.Add(CustomerNameLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.CustomerNameTextBox)
        Me.customerInfoGroupBox.Controls.Add(CustomerIDLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.CustomerIDTextBox)
        Me.customerInfoGroupBox.Controls.Add(EmailAddressLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.EmailAddressTextBox)
        Me.customerInfoGroupBox.Controls.Add(PhoneNumberLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.PhoneNumberTextBox)
        Me.customerInfoGroupBox.Controls.Add(WebsiteAddressLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.WebsiteAddressTextBox)
        Me.customerInfoGroupBox.Location = New System.Drawing.Point(24, 38)
        Me.customerInfoGroupBox.Name = "customerInfoGroupBox"
        Me.customerInfoGroupBox.Size = New System.Drawing.Size(528, 126)
        Me.customerInfoGroupBox.TabIndex = 2
        Me.customerInfoGroupBox.TabStop = False
        Me.customerInfoGroupBox.Text = "&Customer Information"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CustomerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(135, 57)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CustomerNameTextBox.TabIndex = 28
        '
        'addressGroupBox
        '
        Me.addressGroupBox.Controls.Add(BillToAddress1Label)
        Me.addressGroupBox.Controls.Add(BillToPostalCodeLabel)
        Me.addressGroupBox.Controls.Add(Me.BillToPostalCodeTextBox)
        Me.addressGroupBox.Controls.Add(BillToCityLabel)
        Me.addressGroupBox.Controls.Add(Me.BillToAddress1TextBox)
        Me.addressGroupBox.Controls.Add(BillToAddress2Label)
        Me.addressGroupBox.Controls.Add(Me.BillToAddress2TextBox)
        Me.addressGroupBox.Controls.Add(CountryLabel)
        Me.addressGroupBox.Controls.Add(Me.CountryComboBox)
        Me.addressGroupBox.Controls.Add(StateLabel)
        Me.addressGroupBox.Controls.Add(Me.StateComboBox)
        Me.addressGroupBox.Controls.Add(Me.BillToCityTextBox)
        Me.addressGroupBox.Location = New System.Drawing.Point(28, 173)
        Me.addressGroupBox.Name = "addressGroupBox"
        Me.addressGroupBox.Size = New System.Drawing.Size(523, 111)
        Me.addressGroupBox.TabIndex = 7
        Me.addressGroupBox.TabStop = False
        Me.addressGroupBox.Text = "&Billing Information"
        '
        'paymentTermsLabel
        '
        Me.paymentTermsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paymentTermsLabel.Location = New System.Drawing.Point(534, 307)
        Me.paymentTermsLabel.Name = "paymentTermsLabel"
        Me.paymentTermsLabel.Size = New System.Drawing.Size(251, 144)
        Me.paymentTermsLabel.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 641)
        Me.Controls.Add(Me.paymentTermsLabel)
        Me.Controls.Add(Me.addressGroupBox)
        Me.Controls.Add(Me.customerInfoGroupBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.lastButton)
        Me.Controls.Add(Me.firstButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesRichTextBox)
        Me.Controls.Add(Me.salesRepInfoLabel)
        Me.Controls.Add(DiscountLabel)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.ClassificationComboBox)
        Me.Controls.Add(ClassificationLabel)
        Me.Controls.Add(YTDSalesLabel)
        Me.Controls.Add(Me.YTDSalesTextBox)
        Me.Controls.Add(YTDLoyaltyPointsLabel)
        Me.Controls.Add(Me.YTDLoyaltyPointsTextBox)
        Me.Controls.Add(PaymentTermsCodeLabel)
        Me.Controls.Add(Me.PaymentTermsCodeComboBox)
        Me.Controls.Add(ActiveStatusLabel)
        Me.Controls.Add(Me.ActiveStatusComboBox)
        Me.Controls.Add(SalesRepIDLabel)
        Me.Controls.Add(Me.SalesRepIDComboBox)
        Me.Controls.Add(Me.CUSTOMERBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "X Y Solutions?"
        CType(Me.CustomerDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CUSTOMERBindingNavigator.ResumeLayout(False)
        Me.CUSTOMERBindingNavigator.PerformLayout()
        CType(Me.SALESREPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.customerInfoGroupBox.ResumeLayout(False)
        Me.customerInfoGroupBox.PerformLayout()
        Me.addressGroupBox.ResumeLayout(False)
        Me.addressGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerDatabaseDataSet As CustomerDatabaseDataSet
    Friend WithEvents CUSTOMERBindingSource As BindingSource
    Friend WithEvents CUSTOMERTableAdapter As CustomerDatabaseDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents TableAdapterManager As CustomerDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CUSTOMERBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents CUSTOMERBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents SalesRepIDComboBox As ComboBox
    Friend WithEvents ClassificationComboBox As ComboBox
    Friend WithEvents ActiveStatusComboBox As ComboBox
    Friend WithEvents PaymentTermsCodeComboBox As ComboBox
    Friend WithEvents BillToAddress1TextBox As TextBox
    Friend WithEvents BillToAddress2TextBox As TextBox
    Friend WithEvents CountryComboBox As ComboBox
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents BillToCityTextBox As TextBox
    Friend WithEvents BillToPostalCodeTextBox As TextBox
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents WebsiteAddressTextBox As TextBox
    Friend WithEvents YTDLoyaltyPointsTextBox As TextBox
    Friend WithEvents YTDSalesTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents salesRepInfoLabel As Label
    Friend WithEvents SALESREPBindingSource As BindingSource
    Friend WithEvents SALESREPTableAdapter As CustomerDatabaseDataSetTableAdapters.SALESREPTableAdapter
    Friend WithEvents NotesRichTextBox As RichTextBox
    Friend WithEvents nextButton As Button
    Friend WithEvents previousButton As Button
    Friend WithEvents firstButton As Button
    Friend WithEvents lastButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents customerInfoGroupBox As GroupBox
    Friend WithEvents addressGroupBox As GroupBox
    Friend WithEvents paymentTermsLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
End Class
