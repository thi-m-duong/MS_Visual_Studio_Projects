<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim customerIDLabel As System.Windows.Forms.Label
        Dim classificationLabel As System.Windows.Forms.Label
        Dim activeStatusLabel As System.Windows.Forms.Label
        Dim billToAddress1Label As System.Windows.Forms.Label
        Dim billToAddress2Label As System.Windows.Forms.Label
        Dim countryLabel As System.Windows.Forms.Label
        Dim stateLabel As System.Windows.Forms.Label
        Dim billToCityLabel As System.Windows.Forms.Label
        Dim billToPostalCodeLabel As System.Windows.Forms.Label
        Dim emailAddressLabel As System.Windows.Forms.Label
        Dim phoneNumberLabel As System.Windows.Forms.Label
        Dim websiteAddressLabel As System.Windows.Forms.Label
        Dim ytdLoyaltyPointsLabel As System.Windows.Forms.Label
        Dim ytdSalesLabel As System.Windows.Forms.Label
        Dim discountLabel As System.Windows.Forms.Label
        Dim notesLabel As System.Windows.Forms.Label
        Dim customerNameLabel As System.Windows.Forms.Label
        Dim paymentTermsCodeLabel As System.Windows.Forms.Label
        Dim salesRepIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CustomerDatabaseDataSet = New FinalProject.CustomerDatabaseDataSet()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMERTableAdapter = New FinalProject.CustomerDatabaseDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.TableAdapterManager = New FinalProject.CustomerDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CUSTOMERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.queriesToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.canToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.usaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nyCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.orderByToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.customerNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addRecordToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.deleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CUSTOMERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.searchTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.searchToolStripButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.searchByFirstNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.customerIDTextBox = New System.Windows.Forms.TextBox()
        Me.classificationComboBox = New System.Windows.Forms.ComboBox()
        Me.activeStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.billToAddress1TextBox = New System.Windows.Forms.TextBox()
        Me.billToAddress2TextBox = New System.Windows.Forms.TextBox()
        Me.countryComboBox = New System.Windows.Forms.ComboBox()
        Me.stateComboBox = New System.Windows.Forms.ComboBox()
        Me.billToCityTextBox = New System.Windows.Forms.TextBox()
        Me.billToPostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.emailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.websiteAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ytdLoyaltyPointsTextBox = New System.Windows.Forms.TextBox()
        Me.ytdSalesTextBox = New System.Windows.Forms.TextBox()
        Me.discountTextBox = New System.Windows.Forms.TextBox()
        Me.salesRepInfoLabel = New System.Windows.Forms.Label()
        Me.SALESREPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALESREPTableAdapter = New FinalProject.CustomerDatabaseDataSetTableAdapters.SALESREPTableAdapter()
        Me.notesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.firstButton = New System.Windows.Forms.Button()
        Me.lastButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.customerInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.customerNameTextBox = New System.Windows.Forms.TextBox()
        Me.addressGroupBox = New System.Windows.Forms.GroupBox()
        Me.paymentTermsLabel = New System.Windows.Forms.Label()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.salesListBox = New System.Windows.Forms.ListBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.paymentTermsCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalSalesLabel = New System.Windows.Forms.Label()
        Me.averageSaleLabel = New System.Windows.Forms.Label()
        Me.maxSaleLabel = New System.Windows.Forms.Label()
        Me.minSaleLabel = New System.Windows.Forms.Label()
        Me.salesRepIDComboBox = New System.Windows.Forms.ComboBox()
        Me.salesGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.paymentGroupBox = New System.Windows.Forms.GroupBox()
        Me.termsLbl = New System.Windows.Forms.Label()
        customerIDLabel = New System.Windows.Forms.Label()
        classificationLabel = New System.Windows.Forms.Label()
        activeStatusLabel = New System.Windows.Forms.Label()
        billToAddress1Label = New System.Windows.Forms.Label()
        billToAddress2Label = New System.Windows.Forms.Label()
        countryLabel = New System.Windows.Forms.Label()
        stateLabel = New System.Windows.Forms.Label()
        billToCityLabel = New System.Windows.Forms.Label()
        billToPostalCodeLabel = New System.Windows.Forms.Label()
        emailAddressLabel = New System.Windows.Forms.Label()
        phoneNumberLabel = New System.Windows.Forms.Label()
        websiteAddressLabel = New System.Windows.Forms.Label()
        ytdLoyaltyPointsLabel = New System.Windows.Forms.Label()
        ytdSalesLabel = New System.Windows.Forms.Label()
        discountLabel = New System.Windows.Forms.Label()
        notesLabel = New System.Windows.Forms.Label()
        customerNameLabel = New System.Windows.Forms.Label()
        paymentTermsCodeLabel = New System.Windows.Forms.Label()
        salesRepIDLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CUSTOMERBindingNavigator.SuspendLayout()
        CType(Me.SALESREPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.customerInfoGroupBox.SuspendLayout()
        Me.addressGroupBox.SuspendLayout()
        Me.salesGroupBox.SuspendLayout()
        Me.paymentGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'customerIDLabel
        '
        customerIDLabel.AutoSize = True
        customerIDLabel.Location = New System.Drawing.Point(9, 22)
        customerIDLabel.Name = "customerIDLabel"
        customerIDLabel.Size = New System.Drawing.Size(81, 15)
        customerIDLabel.TabIndex = 0
        customerIDLabel.Text = "*Customer ID:"
        '
        'classificationLabel
        '
        classificationLabel.AutoSize = True
        classificationLabel.Location = New System.Drawing.Point(6, 31)
        classificationLabel.Name = "classificationLabel"
        classificationLabel.Size = New System.Drawing.Size(85, 15)
        classificationLabel.TabIndex = 0
        classificationLabel.Text = "*Classification:"
        '
        'activeStatusLabel
        '
        activeStatusLabel.AutoSize = True
        activeStatusLabel.Location = New System.Drawing.Point(6, 62)
        activeStatusLabel.Name = "activeStatusLabel"
        activeStatusLabel.Size = New System.Drawing.Size(83, 15)
        activeStatusLabel.TabIndex = 4
        activeStatusLabel.Text = "*Active Status:"
        '
        'billToAddress1Label
        '
        billToAddress1Label.AutoSize = True
        billToAddress1Label.Location = New System.Drawing.Point(6, 25)
        billToAddress1Label.Name = "billToAddress1Label"
        billToAddress1Label.Size = New System.Drawing.Size(88, 15)
        billToAddress1Label.TabIndex = 0
        billToAddress1Label.Text = "*Address line 1:"
        '
        'billToAddress2Label
        '
        billToAddress2Label.AutoSize = True
        billToAddress2Label.Location = New System.Drawing.Point(6, 61)
        billToAddress2Label.Name = "billToAddress2Label"
        billToAddress2Label.Size = New System.Drawing.Size(83, 15)
        billToAddress2Label.TabIndex = 2
        billToAddress2Label.Text = "Address line 2:"
        '
        'countryLabel
        '
        countryLabel.AutoSize = True
        countryLabel.Location = New System.Drawing.Point(6, 193)
        countryLabel.Name = "countryLabel"
        countryLabel.Size = New System.Drawing.Size(58, 15)
        countryLabel.TabIndex = 10
        countryLabel.Text = "*Country:"
        '
        'stateLabel
        '
        stateLabel.AutoSize = True
        stateLabel.Location = New System.Drawing.Point(6, 127)
        stateLabel.Name = "stateLabel"
        stateLabel.Size = New System.Drawing.Size(41, 15)
        stateLabel.TabIndex = 6
        stateLabel.Text = "*State:"
        '
        'billToCityLabel
        '
        billToCityLabel.AutoSize = True
        billToCityLabel.Location = New System.Drawing.Point(9, 89)
        billToCityLabel.Name = "billToCityLabel"
        billToCityLabel.Size = New System.Drawing.Size(36, 15)
        billToCityLabel.TabIndex = 4
        billToCityLabel.Text = "*City:"
        '
        'billToPostalCodeLabel
        '
        billToPostalCodeLabel.AutoSize = True
        billToPostalCodeLabel.Location = New System.Drawing.Point(6, 160)
        billToPostalCodeLabel.Name = "billToPostalCodeLabel"
        billToPostalCodeLabel.Size = New System.Drawing.Size(78, 15)
        billToPostalCodeLabel.TabIndex = 8
        billToPostalCodeLabel.Text = "*Postal Code:"
        '
        'emailAddressLabel
        '
        emailAddressLabel.AutoSize = True
        emailAddressLabel.Location = New System.Drawing.Point(9, 78)
        emailAddressLabel.Name = "emailAddressLabel"
        emailAddressLabel.Size = New System.Drawing.Size(87, 15)
        emailAddressLabel.TabIndex = 5
        emailAddressLabel.Text = "*Email address:"
        '
        'phoneNumberLabel
        '
        phoneNumberLabel.AutoSize = True
        phoneNumberLabel.Location = New System.Drawing.Point(9, 106)
        phoneNumberLabel.Name = "phoneNumberLabel"
        phoneNumberLabel.Size = New System.Drawing.Size(94, 15)
        phoneNumberLabel.TabIndex = 7
        phoneNumberLabel.Text = "*Phone number:"
        '
        'websiteAddressLabel
        '
        websiteAddressLabel.AutoSize = True
        websiteAddressLabel.Location = New System.Drawing.Point(9, 134)
        websiteAddressLabel.Name = "websiteAddressLabel"
        websiteAddressLabel.Size = New System.Drawing.Size(100, 15)
        websiteAddressLabel.TabIndex = 9
        websiteAddressLabel.Text = "*Website address:"
        '
        'ytdLoyaltyPointsLabel
        '
        ytdLoyaltyPointsLabel.AutoSize = True
        ytdLoyaltyPointsLabel.Location = New System.Drawing.Point(209, 151)
        ytdLoyaltyPointsLabel.Name = "ytdLoyaltyPointsLabel"
        ytdLoyaltyPointsLabel.Size = New System.Drawing.Size(106, 15)
        ytdLoyaltyPointsLabel.TabIndex = 14
        ytdLoyaltyPointsLabel.Text = "YTDLoyalty Points:"
        '
        'ytdSalesLabel
        '
        ytdSalesLabel.AutoSize = True
        ytdSalesLabel.Location = New System.Drawing.Point(209, 124)
        ytdSalesLabel.Name = "ytdSalesLabel"
        ytdSalesLabel.Size = New System.Drawing.Size(80, 15)
        ytdSalesLabel.TabIndex = 12
        ytdSalesLabel.Text = "*YTDSales ($):"
        '
        'discountLabel
        '
        discountLabel.AutoSize = True
        discountLabel.Location = New System.Drawing.Point(6, 86)
        discountLabel.Name = "discountLabel"
        discountLabel.Size = New System.Drawing.Size(57, 15)
        discountLabel.TabIndex = 7
        discountLabel.Text = "Discount:"
        '
        'notesLabel
        '
        notesLabel.AutoSize = True
        notesLabel.Location = New System.Drawing.Point(6, 124)
        notesLabel.Name = "notesLabel"
        notesLabel.Size = New System.Drawing.Size(41, 15)
        notesLabel.TabIndex = 10
        notesLabel.Text = "Notes:"
        '
        'customerNameLabel
        '
        customerNameLabel.AutoSize = True
        customerNameLabel.Location = New System.Drawing.Point(9, 50)
        customerNameLabel.Name = "customerNameLabel"
        customerNameLabel.Size = New System.Drawing.Size(102, 15)
        customerNameLabel.TabIndex = 3
        customerNameLabel.Text = "*Customer Name:"
        '
        'paymentTermsCodeLabel
        '
        paymentTermsCodeLabel.AutoSize = True
        paymentTermsCodeLabel.Location = New System.Drawing.Point(209, 34)
        paymentTermsCodeLabel.Name = "paymentTermsCodeLabel"
        paymentTermsCodeLabel.Size = New System.Drawing.Size(128, 15)
        paymentTermsCodeLabel.TabIndex = 2
        paymentTermsCodeLabel.Text = "*Payment Terms Code:"
        '
        'salesRepIDLabel
        '
        salesRepIDLabel.AutoSize = True
        salesRepIDLabel.Location = New System.Drawing.Point(6, 23)
        salesRepIDLabel.Name = "salesRepIDLabel"
        salesRepIDLabel.Size = New System.Drawing.Size(78, 15)
        salesRepIDLabel.TabIndex = 0
        salesRepIDLabel.Text = "*Sales Rep ID:"
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
        Me.CUSTOMERBindingNavigator.AddNewItem = Nothing
        Me.CUSTOMERBindingNavigator.BindingSource = Me.CUSTOMERBindingSource
        Me.CUSTOMERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CUSTOMERBindingNavigator.DeleteItem = Nothing
        Me.CUSTOMERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.addRecordToolStripButton, Me.deleteToolStripButton, Me.CUSTOMERBindingNavigatorSaveItem, Me.queriesToolStripDropDownButton, Me.orderByToolStripDropDownButton, Me.searchTextBox, Me.searchToolStripButton})
        Me.CUSTOMERBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CUSTOMERBindingNavigator.MoveFirstItem = Nothing
        Me.CUSTOMERBindingNavigator.MoveLastItem = Nothing
        Me.CUSTOMERBindingNavigator.MoveNextItem = Nothing
        Me.CUSTOMERBindingNavigator.MovePreviousItem = Nothing
        Me.CUSTOMERBindingNavigator.Name = "CUSTOMERBindingNavigator"
        Me.CUSTOMERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CUSTOMERBindingNavigator.Size = New System.Drawing.Size(780, 25)
        Me.CUSTOMERBindingNavigator.TabIndex = 0
        Me.CUSTOMERBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'queriesToolStripDropDownButton
        '
        Me.queriesToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.queriesToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.canToolStripMenuItem, Me.usaToolStripMenuItem, Me.nyCustomersToolStripMenuItem})
        Me.queriesToolStripDropDownButton.Image = CType(resources.GetObject("queriesToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.queriesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.queriesToolStripDropDownButton.Name = "queriesToolStripDropDownButton"
        Me.queriesToolStripDropDownButton.Size = New System.Drawing.Size(60, 22)
        Me.queriesToolStripDropDownButton.Text = "Queries"
        '
        'canToolStripMenuItem
        '
        Me.canToolStripMenuItem.Name = "canToolStripMenuItem"
        Me.canToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.canToolStripMenuItem.Text = "CAN Customers"
        '
        'usaToolStripMenuItem
        '
        Me.usaToolStripMenuItem.Name = "usaToolStripMenuItem"
        Me.usaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.usaToolStripMenuItem.Text = "USA Customers"
        '
        'nyCustomersToolStripMenuItem
        '
        Me.nyCustomersToolStripMenuItem.Name = "nyCustomersToolStripMenuItem"
        Me.nyCustomersToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.nyCustomersToolStripMenuItem.Text = "NY Customers"
        '
        'orderByToolStripDropDownButton
        '
        Me.orderByToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.orderByToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.customerNameToolStripMenuItem})
        Me.orderByToolStripDropDownButton.Image = CType(resources.GetObject("orderByToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.orderByToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.orderByToolStripDropDownButton.Name = "orderByToolStripDropDownButton"
        Me.orderByToolStripDropDownButton.Size = New System.Drawing.Size(66, 22)
        Me.orderByToolStripDropDownButton.Text = "Order By"
        '
        'customerNameToolStripMenuItem
        '
        Me.customerNameToolStripMenuItem.Name = "customerNameToolStripMenuItem"
        Me.customerNameToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.customerNameToolStripMenuItem.Text = "Customer Name"
        '
        'addRecordToolStripButton
        '
        Me.addRecordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.addRecordToolStripButton.Image = Global.FinalProject.My.Resources.Resources.add1
        Me.addRecordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.addRecordToolStripButton.Name = "addRecordToolStripButton"
        Me.addRecordToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.addRecordToolStripButton.Text = "Add Record"
        '
        'deleteToolStripButton
        '
        Me.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.deleteToolStripButton.Image = Global.FinalProject.My.Resources.Resources.delete
        Me.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.deleteToolStripButton.Name = "deleteToolStripButton"
        Me.deleteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.deleteToolStripButton.Text = "Delete Record"
        '
        'CUSTOMERBindingNavigatorSaveItem
        '
        Me.CUSTOMERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CUSTOMERBindingNavigatorSaveItem.Image = CType(resources.GetObject("CUSTOMERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CUSTOMERBindingNavigatorSaveItem.Name = "CUSTOMERBindingNavigatorSaveItem"
        Me.CUSTOMERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CUSTOMERBindingNavigatorSaveItem.Text = "Save Data"
        '
        'searchTextBox
        '
        Me.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(200, 25)
        '
        'searchToolStripButton
        '
        Me.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.searchToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.searchByFirstNameToolStripMenuItem})
        Me.searchToolStripButton.Image = Global.FinalProject.My.Resources.Resources.Search_icon
        Me.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.searchToolStripButton.Name = "searchToolStripButton"
        Me.searchToolStripButton.Size = New System.Drawing.Size(29, 22)
        Me.searchToolStripButton.Text = "Search Button"
        '
        'searchByFirstNameToolStripMenuItem
        '
        Me.searchByFirstNameToolStripMenuItem.Name = "searchByFirstNameToolStripMenuItem"
        Me.searchByFirstNameToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.searchByFirstNameToolStripMenuItem.Text = "Search by Name"
        '
        'customerIDTextBox
        '
        Me.customerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CustomerID", True))
        Me.customerIDTextBox.Location = New System.Drawing.Point(117, 22)
        Me.customerIDTextBox.MaxLength = 9
        Me.customerIDTextBox.Name = "customerIDTextBox"
        Me.customerIDTextBox.Size = New System.Drawing.Size(89, 23)
        Me.customerIDTextBox.TabIndex = 1
        '
        'classificationComboBox
        '
        Me.classificationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Classification", True))
        Me.classificationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classificationComboBox.FormattingEnabled = True
        Me.classificationComboBox.Location = New System.Drawing.Point(97, 31)
        Me.classificationComboBox.Name = "classificationComboBox"
        Me.classificationComboBox.Size = New System.Drawing.Size(100, 23)
        Me.classificationComboBox.Sorted = True
        Me.classificationComboBox.TabIndex = 1
        '
        'activeStatusComboBox
        '
        Me.activeStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "ActiveStatus", True))
        Me.activeStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.activeStatusComboBox.FormattingEnabled = True
        Me.activeStatusComboBox.Location = New System.Drawing.Point(97, 62)
        Me.activeStatusComboBox.Name = "activeStatusComboBox"
        Me.activeStatusComboBox.Size = New System.Drawing.Size(100, 23)
        Me.activeStatusComboBox.Sorted = True
        Me.activeStatusComboBox.TabIndex = 5
        '
        'billToAddress1TextBox
        '
        Me.billToAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "BillToAddress1", True))
        Me.billToAddress1TextBox.Location = New System.Drawing.Point(103, 22)
        Me.billToAddress1TextBox.Name = "billToAddress1TextBox"
        Me.billToAddress1TextBox.Size = New System.Drawing.Size(169, 23)
        Me.billToAddress1TextBox.TabIndex = 1
        '
        'billToAddress2TextBox
        '
        Me.billToAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "BillToAddress2", True))
        Me.billToAddress2TextBox.Location = New System.Drawing.Point(103, 58)
        Me.billToAddress2TextBox.Name = "billToAddress2TextBox"
        Me.billToAddress2TextBox.Size = New System.Drawing.Size(169, 23)
        Me.billToAddress2TextBox.TabIndex = 3
        '
        'countryComboBox
        '
        Me.countryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Country", True))
        Me.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.countryComboBox.FormattingEnabled = True
        Me.countryComboBox.Location = New System.Drawing.Point(103, 189)
        Me.countryComboBox.Name = "countryComboBox"
        Me.countryComboBox.Size = New System.Drawing.Size(100, 23)
        Me.countryComboBox.Sorted = True
        Me.countryComboBox.TabIndex = 11
        '
        'stateComboBox
        '
        Me.stateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "State", True))
        Me.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stateComboBox.FormattingEnabled = True
        Me.stateComboBox.Location = New System.Drawing.Point(103, 124)
        Me.stateComboBox.Name = "stateComboBox"
        Me.stateComboBox.Size = New System.Drawing.Size(100, 23)
        Me.stateComboBox.Sorted = True
        Me.stateComboBox.TabIndex = 7
        '
        'billToCityTextBox
        '
        Me.billToCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "BillToCity", True))
        Me.billToCityTextBox.Location = New System.Drawing.Point(103, 86)
        Me.billToCityTextBox.MaxLength = 25
        Me.billToCityTextBox.Name = "billToCityTextBox"
        Me.billToCityTextBox.Size = New System.Drawing.Size(100, 23)
        Me.billToCityTextBox.TabIndex = 5
        '
        'billToPostalCodeTextBox
        '
        Me.billToPostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "BillToPostalCode", True))
        Me.billToPostalCodeTextBox.Location = New System.Drawing.Point(103, 157)
        Me.billToPostalCodeTextBox.MaxLength = 9
        Me.billToPostalCodeTextBox.Name = "billToPostalCodeTextBox"
        Me.billToPostalCodeTextBox.Size = New System.Drawing.Size(100, 23)
        Me.billToPostalCodeTextBox.TabIndex = 9
        '
        'emailAddressTextBox
        '
        Me.emailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "EmailAddress", True))
        Me.emailAddressTextBox.Location = New System.Drawing.Point(117, 78)
        Me.emailAddressTextBox.MaxLength = 20
        Me.emailAddressTextBox.Name = "emailAddressTextBox"
        Me.emailAddressTextBox.Size = New System.Drawing.Size(166, 23)
        Me.emailAddressTextBox.TabIndex = 6
        '
        'phoneNumberTextBox
        '
        Me.phoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "PhoneNumber", True))
        Me.phoneNumberTextBox.Location = New System.Drawing.Point(117, 106)
        Me.phoneNumberTextBox.MaxLength = 10
        Me.phoneNumberTextBox.Name = "phoneNumberTextBox"
        Me.phoneNumberTextBox.Size = New System.Drawing.Size(166, 23)
        Me.phoneNumberTextBox.TabIndex = 8
        '
        'websiteAddressTextBox
        '
        Me.websiteAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "WebsiteAddress", True))
        Me.websiteAddressTextBox.Location = New System.Drawing.Point(117, 134)
        Me.websiteAddressTextBox.MaxLength = 25
        Me.websiteAddressTextBox.Name = "websiteAddressTextBox"
        Me.websiteAddressTextBox.Size = New System.Drawing.Size(166, 23)
        Me.websiteAddressTextBox.TabIndex = 0
        '
        'ytdLoyaltyPointsTextBox
        '
        Me.ytdLoyaltyPointsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "YTDLoyaltyPoints", True))
        Me.ytdLoyaltyPointsTextBox.Location = New System.Drawing.Point(321, 154)
        Me.ytdLoyaltyPointsTextBox.MaxLength = 6
        Me.ytdLoyaltyPointsTextBox.Name = "ytdLoyaltyPointsTextBox"
        Me.ytdLoyaltyPointsTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ytdLoyaltyPointsTextBox.TabIndex = 15
        '
        'ytdSalesTextBox
        '
        Me.ytdSalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "YTDSales", True))
        Me.ytdSalesTextBox.Location = New System.Drawing.Point(321, 125)
        Me.ytdSalesTextBox.MaxLength = 12
        Me.ytdSalesTextBox.Name = "ytdSalesTextBox"
        Me.ytdSalesTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ytdSalesTextBox.TabIndex = 13
        '
        'discountTextBox
        '
        Me.discountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Discount", True))
        Me.discountTextBox.Location = New System.Drawing.Point(97, 91)
        Me.discountTextBox.MaxLength = 5
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.Size = New System.Drawing.Size(100, 23)
        Me.discountTextBox.TabIndex = 8
        '
        'salesRepInfoLabel
        '
        Me.salesRepInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salesRepInfoLabel.Location = New System.Drawing.Point(6, 63)
        Me.salesRepInfoLabel.Name = "salesRepInfoLabel"
        Me.salesRepInfoLabel.Size = New System.Drawing.Size(181, 28)
        Me.salesRepInfoLabel.TabIndex = 3
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
        'notesRichTextBox
        '
        Me.notesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Notes", True))
        Me.notesRichTextBox.Location = New System.Drawing.Point(53, 120)
        Me.notesRichTextBox.MaxLength = 50
        Me.notesRichTextBox.Name = "notesRichTextBox"
        Me.notesRichTextBox.Size = New System.Drawing.Size(142, 66)
        Me.notesRichTextBox.TabIndex = 11
        Me.notesRichTextBox.Text = ""
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(405, 479)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(79, 24)
        Me.nextButton.TabIndex = 7
        Me.nextButton.Text = "&Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(307, 479)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(79, 24)
        Me.previousButton.TabIndex = 6
        Me.previousButton.Text = "&Previous"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'firstButton
        '
        Me.firstButton.Location = New System.Drawing.Point(212, 479)
        Me.firstButton.Name = "firstButton"
        Me.firstButton.Size = New System.Drawing.Size(79, 24)
        Me.firstButton.TabIndex = 5
        Me.firstButton.Text = "&First"
        Me.firstButton.UseVisualStyleBackColor = True
        '
        'lastButton
        '
        Me.lastButton.Location = New System.Drawing.Point(507, 479)
        Me.lastButton.Name = "lastButton"
        Me.lastButton.Size = New System.Drawing.Size(79, 24)
        Me.lastButton.TabIndex = 8
        Me.lastButton.Text = "&Last"
        Me.lastButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(689, 479)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(79, 24)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'customerInfoGroupBox
        '
        Me.customerInfoGroupBox.Controls.Add(customerNameLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.customerNameTextBox)
        Me.customerInfoGroupBox.Controls.Add(customerIDLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.customerIDTextBox)
        Me.customerInfoGroupBox.Controls.Add(emailAddressLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.emailAddressTextBox)
        Me.customerInfoGroupBox.Controls.Add(phoneNumberLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.phoneNumberTextBox)
        Me.customerInfoGroupBox.Controls.Add(websiteAddressLabel)
        Me.customerInfoGroupBox.Controls.Add(Me.websiteAddressTextBox)
        Me.customerInfoGroupBox.Location = New System.Drawing.Point(8, 36)
        Me.customerInfoGroupBox.Name = "customerInfoGroupBox"
        Me.customerInfoGroupBox.Size = New System.Drawing.Size(299, 178)
        Me.customerInfoGroupBox.TabIndex = 0
        Me.customerInfoGroupBox.TabStop = False
        Me.customerInfoGroupBox.Text = "C&ustomer Information"
        '
        'customerNameTextBox
        '
        Me.customerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CustomerName", True))
        Me.customerNameTextBox.Location = New System.Drawing.Point(117, 50)
        Me.customerNameTextBox.Name = "customerNameTextBox"
        Me.customerNameTextBox.Size = New System.Drawing.Size(166, 23)
        Me.customerNameTextBox.TabIndex = 4
        '
        'addressGroupBox
        '
        Me.addressGroupBox.Controls.Add(billToAddress1Label)
        Me.addressGroupBox.Controls.Add(billToPostalCodeLabel)
        Me.addressGroupBox.Controls.Add(Me.billToPostalCodeTextBox)
        Me.addressGroupBox.Controls.Add(billToCityLabel)
        Me.addressGroupBox.Controls.Add(Me.billToAddress1TextBox)
        Me.addressGroupBox.Controls.Add(billToAddress2Label)
        Me.addressGroupBox.Controls.Add(Me.billToAddress2TextBox)
        Me.addressGroupBox.Controls.Add(countryLabel)
        Me.addressGroupBox.Controls.Add(Me.countryComboBox)
        Me.addressGroupBox.Controls.Add(Me.stateComboBox)
        Me.addressGroupBox.Controls.Add(Me.billToCityTextBox)
        Me.addressGroupBox.Controls.Add(stateLabel)
        Me.addressGroupBox.Location = New System.Drawing.Point(12, 212)
        Me.addressGroupBox.Name = "addressGroupBox"
        Me.addressGroupBox.Size = New System.Drawing.Size(299, 236)
        Me.addressGroupBox.TabIndex = 1
        Me.addressGroupBox.TabStop = False
        Me.addressGroupBox.Text = "&Billing Information"
        '
        'paymentTermsLabel
        '
        Me.paymentTermsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paymentTermsLabel.Location = New System.Drawing.Point(209, 80)
        Me.paymentTermsLabel.Name = "paymentTermsLabel"
        Me.paymentTermsLabel.Size = New System.Drawing.Size(223, 33)
        Me.paymentTermsLabel.TabIndex = 9
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(12, 479)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(79, 24)
        Me.refreshButton.TabIndex = 4
        Me.refreshButton.Text = "&Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'salesListBox
        '
        Me.salesListBox.FormattingEnabled = True
        Me.salesListBox.ItemHeight = 15
        Me.salesListBox.Location = New System.Drawing.Point(6, 114)
        Me.salesListBox.Name = "salesListBox"
        Me.salesListBox.Size = New System.Drawing.Size(181, 109)
        Me.salesListBox.TabIndex = 9
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(277, 180)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(79, 33)
        Me.calculateButton.TabIndex = 14
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'paymentTermsCodeComboBox
        '
        Me.paymentTermsCodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "PaymentTermsCode", True))
        Me.paymentTermsCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.paymentTermsCodeComboBox.FormattingEnabled = True
        Me.paymentTermsCodeComboBox.Location = New System.Drawing.Point(344, 34)
        Me.paymentTermsCodeComboBox.Name = "paymentTermsCodeComboBox"
        Me.paymentTermsCodeComboBox.Size = New System.Drawing.Size(91, 23)
        Me.paymentTermsCodeComboBox.Sorted = True
        Me.paymentTermsCodeComboBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Max:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Average:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Min:"
        '
        'totalSalesLabel
        '
        Me.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalSalesLabel.Location = New System.Drawing.Point(206, 65)
        Me.totalSalesLabel.Name = "totalSalesLabel"
        Me.totalSalesLabel.Size = New System.Drawing.Size(99, 31)
        Me.totalSalesLabel.TabIndex = 5
        Me.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'averageSaleLabel
        '
        Me.averageSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.averageSaleLabel.Location = New System.Drawing.Point(206, 120)
        Me.averageSaleLabel.Name = "averageSaleLabel"
        Me.averageSaleLabel.Size = New System.Drawing.Size(99, 30)
        Me.averageSaleLabel.TabIndex = 11
        Me.averageSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maxSaleLabel
        '
        Me.maxSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.maxSaleLabel.Location = New System.Drawing.Point(337, 120)
        Me.maxSaleLabel.Name = "maxSaleLabel"
        Me.maxSaleLabel.Size = New System.Drawing.Size(99, 30)
        Me.maxSaleLabel.TabIndex = 13
        Me.maxSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minSaleLabel
        '
        Me.minSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.minSaleLabel.Location = New System.Drawing.Point(337, 65)
        Me.minSaleLabel.Name = "minSaleLabel"
        Me.minSaleLabel.Size = New System.Drawing.Size(99, 33)
        Me.minSaleLabel.TabIndex = 7
        Me.minSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesRepIDComboBox
        '
        Me.salesRepIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "SalesRepID", True))
        Me.salesRepIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.salesRepIDComboBox.FormattingEnabled = True
        Me.salesRepIDComboBox.Location = New System.Drawing.Point(87, 23)
        Me.salesRepIDComboBox.Name = "salesRepIDComboBox"
        Me.salesRepIDComboBox.Size = New System.Drawing.Size(100, 23)
        Me.salesRepIDComboBox.Sorted = True
        Me.salesRepIDComboBox.TabIndex = 1
        '
        'salesGroupBox
        '
        Me.salesGroupBox.Controls.Add(Me.Label7)
        Me.salesGroupBox.Controls.Add(Me.Label6)
        Me.salesGroupBox.Controls.Add(salesRepIDLabel)
        Me.salesGroupBox.Controls.Add(Me.Label1)
        Me.salesGroupBox.Controls.Add(Me.minSaleLabel)
        Me.salesGroupBox.Controls.Add(Me.salesRepIDComboBox)
        Me.salesGroupBox.Controls.Add(Me.calculateButton)
        Me.salesGroupBox.Controls.Add(Me.maxSaleLabel)
        Me.salesGroupBox.Controls.Add(Me.salesRepInfoLabel)
        Me.salesGroupBox.Controls.Add(Me.averageSaleLabel)
        Me.salesGroupBox.Controls.Add(Me.salesListBox)
        Me.salesGroupBox.Controls.Add(Me.totalSalesLabel)
        Me.salesGroupBox.Controls.Add(Me.Label2)
        Me.salesGroupBox.Controls.Add(Me.Label4)
        Me.salesGroupBox.Controls.Add(Me.Label3)
        Me.salesGroupBox.Location = New System.Drawing.Point(313, 239)
        Me.salesGroupBox.Name = "salesGroupBox"
        Me.salesGroupBox.Size = New System.Drawing.Size(447, 229)
        Me.salesGroupBox.TabIndex = 3
        Me.salesGroupBox.TabStop = False
        Me.salesGroupBox.Text = "Sales &Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Sales Rep Name:"
        '
        'paymentGroupBox
        '
        Me.paymentGroupBox.Controls.Add(Me.paymentTermsCodeComboBox)
        Me.paymentGroupBox.Controls.Add(paymentTermsCodeLabel)
        Me.paymentGroupBox.Controls.Add(Me.termsLbl)
        Me.paymentGroupBox.Controls.Add(Me.notesRichTextBox)
        Me.paymentGroupBox.Controls.Add(ytdSalesLabel)
        Me.paymentGroupBox.Controls.Add(Me.ytdLoyaltyPointsTextBox)
        Me.paymentGroupBox.Controls.Add(ytdLoyaltyPointsLabel)
        Me.paymentGroupBox.Controls.Add(Me.paymentTermsLabel)
        Me.paymentGroupBox.Controls.Add(Me.ytdSalesTextBox)
        Me.paymentGroupBox.Controls.Add(classificationLabel)
        Me.paymentGroupBox.Controls.Add(Me.classificationComboBox)
        Me.paymentGroupBox.Controls.Add(activeStatusLabel)
        Me.paymentGroupBox.Controls.Add(notesLabel)
        Me.paymentGroupBox.Controls.Add(Me.activeStatusComboBox)
        Me.paymentGroupBox.Controls.Add(Me.discountTextBox)
        Me.paymentGroupBox.Controls.Add(discountLabel)
        Me.paymentGroupBox.Location = New System.Drawing.Point(313, 36)
        Me.paymentGroupBox.Name = "paymentGroupBox"
        Me.paymentGroupBox.Size = New System.Drawing.Size(447, 197)
        Me.paymentGroupBox.TabIndex = 2
        Me.paymentGroupBox.TabStop = False
        Me.paymentGroupBox.Text = "&Sales and Payments"
        '
        'termsLbl
        '
        Me.termsLbl.AutoSize = True
        Me.termsLbl.Location = New System.Drawing.Point(209, 60)
        Me.termsLbl.Name = "termsLbl"
        Me.termsLbl.Size = New System.Drawing.Size(158, 15)
        Me.termsLbl.TabIndex = 6
        Me.termsLbl.Text = "Payment Terms Information:"
        '
        'MainForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(780, 515)
        Me.Controls.Add(Me.addressGroupBox)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.customerInfoGroupBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.lastButton)
        Me.Controls.Add(Me.firstButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.CUSTOMERBindingNavigator)
        Me.Controls.Add(Me.salesGroupBox)
        Me.Controls.Add(Me.paymentGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "X Y Solutions"
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
        Me.salesGroupBox.ResumeLayout(False)
        Me.salesGroupBox.PerformLayout()
        Me.paymentGroupBox.ResumeLayout(False)
        Me.paymentGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerDatabaseDataSet As CustomerDatabaseDataSet
    Friend WithEvents CUSTOMERBindingSource As BindingSource
    Friend WithEvents CUSTOMERTableAdapter As CustomerDatabaseDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents TableAdapterManager As CustomerDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CUSTOMERBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents CUSTOMERBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents customerIDTextBox As TextBox
    Friend WithEvents classificationComboBox As ComboBox
    Friend WithEvents activeStatusComboBox As ComboBox
    Friend WithEvents billToAddress1TextBox As TextBox
    Friend WithEvents billToAddress2TextBox As TextBox
    Friend WithEvents countryComboBox As ComboBox
    Friend WithEvents stateComboBox As ComboBox
    Friend WithEvents billToCityTextBox As TextBox
    Friend WithEvents billToPostalCodeTextBox As TextBox
    Friend WithEvents emailAddressTextBox As TextBox
    Friend WithEvents phoneNumberTextBox As TextBox
    Friend WithEvents websiteAddressTextBox As TextBox
    Friend WithEvents ytdLoyaltyPointsTextBox As TextBox
    Friend WithEvents ytdSalesTextBox As TextBox
    Friend WithEvents discountTextBox As TextBox
    Friend WithEvents salesRepInfoLabel As Label
    Friend WithEvents SALESREPBindingSource As BindingSource
    Friend WithEvents SALESREPTableAdapter As CustomerDatabaseDataSetTableAdapters.SALESREPTableAdapter
    Friend WithEvents notesRichTextBox As RichTextBox
    Friend WithEvents nextButton As Button
    Friend WithEvents previousButton As Button
    Friend WithEvents firstButton As Button
    Friend WithEvents lastButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents customerInfoGroupBox As GroupBox
    Friend WithEvents addressGroupBox As GroupBox
    Friend WithEvents paymentTermsLabel As Label
    Friend WithEvents customerNameTextBox As TextBox
    Friend WithEvents searchTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents searchToolStripButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents searchByFirstNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents salesListBox As System.Windows.Forms.ListBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents paymentTermsCodeComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalSalesLabel As Label
    Friend WithEvents averageSaleLabel As Label
    Friend WithEvents maxSaleLabel As Label
    Friend WithEvents minSaleLabel As Label
    Friend WithEvents queriesToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents canToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents usaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents nyCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents salesRepIDComboBox As ComboBox
    Friend WithEvents addRecordToolStripButton As ToolStripButton
    Friend WithEvents orderByToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents customerNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents deleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents salesGroupBox As GroupBox
    Friend WithEvents paymentGroupBox As GroupBox
    Friend WithEvents termsLbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
