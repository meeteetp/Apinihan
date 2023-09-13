<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerForm
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
        Dim CustPhoneLabel As System.Windows.Forms.Label
        Dim CustEmailLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim CustNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerForm))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApinihanDataSet = New Apinihan.ApinihanDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CustEmailTextBox = New System.Windows.Forms.TextBox()
        Me.EventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager()
        Me.EventTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.EventTableAdapter()
        Me.Search_CustNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Search_CustNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.lblEventHistory = New System.Windows.Forms.Label()
        Me.lblCustForm = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalSpending = New System.Windows.Forms.Label()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEventCount = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        CustPhoneLabel = New System.Windows.Forms.Label()
        CustEmailLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        CustNameLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search_CustNameToolStrip.SuspendLayout()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustPhoneLabel
        '
        CustPhoneLabel.AutoSize = True
        CustPhoneLabel.BackColor = System.Drawing.Color.Transparent
        CustPhoneLabel.Location = New System.Drawing.Point(379, 126)
        CustPhoneLabel.Name = "CustPhoneLabel"
        CustPhoneLabel.Size = New System.Drawing.Size(85, 17)
        CustPhoneLabel.TabIndex = 5
        CustPhoneLabel.Text = "Cust Phone:"
        '
        'CustEmailLabel
        '
        CustEmailLabel.AutoSize = True
        CustEmailLabel.BackColor = System.Drawing.Color.Transparent
        CustEmailLabel.Location = New System.Drawing.Point(379, 154)
        CustEmailLabel.Name = "CustEmailLabel"
        CustEmailLabel.Size = New System.Drawing.Size(78, 17)
        CustEmailLabel.TabIndex = 7
        CustEmailLabel.Text = "Cust Email:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(10, 24)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustNameLabel
        '
        CustNameLabel.AutoSize = True
        CustNameLabel.Location = New System.Drawing.Point(10, 52)
        CustNameLabel.Name = "CustNameLabel"
        CustNameLabel.Size = New System.Drawing.Size(113, 17)
        CustNameLabel.TabIndex = 16
        CustNameLabel.Text = "Customer Name:"
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(662, 27)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.ApinihanDataSet
        '
        'ApinihanDataSet
        '
        Me.ApinihanDataSet.DataSetName = "ApinihanDataSet"
        Me.ApinihanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustPhoneTextBox
        '
        Me.CustPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustPhone", True))
        Me.CustPhoneTextBox.Location = New System.Drawing.Point(474, 123)
        Me.CustPhoneTextBox.Name = "CustPhoneTextBox"
        Me.CustPhoneTextBox.Size = New System.Drawing.Size(171, 22)
        Me.CustPhoneTextBox.TabIndex = 6
        '
        'CustEmailTextBox
        '
        Me.CustEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustEmail", True))
        Me.CustEmailTextBox.Location = New System.Drawing.Point(474, 151)
        Me.CustEmailTextBox.Name = "CustEmailTextBox"
        Me.CustEmailTextBox.Size = New System.Drawing.Size(171, 22)
        Me.CustEmailTextBox.TabIndex = 8
        '
        'EventBindingSource
        '
        Me.EventBindingSource.DataMember = "fk_Customer"
        Me.EventBindingSource.DataSource = Me.CustomerBindingSource
        '
        'EventDataGridView
        '
        Me.EventDataGridView.AutoGenerateColumns = False
        Me.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.EventPrice})
        Me.EventDataGridView.DataSource = Me.EventBindingSource
        Me.EventDataGridView.Location = New System.Drawing.Point(12, 338)
        Me.EventDataGridView.Name = "EventDataGridView"
        Me.EventDataGridView.RowTemplate.Height = 24
        Me.EventDataGridView.Size = New System.Drawing.Size(638, 301)
        Me.EventDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ManagerID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ManagerID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EventName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EventName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EventStartDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EventStartDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EventEndDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "EventEndDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'EventPrice
        '
        Me.EventPrice.DataPropertyName = "EventPrice"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.EventPrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.EventPrice.HeaderText = "EventPrice"
        Me.EventPrice.Name = "EventPrice"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AssignmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EquipmentTableAdapter = Nothing
        Me.TableAdapterManager.EventTableAdapter = Me.EventTableAdapter
        Me.TableAdapterManager.InstallTableAdapter = Nothing
        Me.TableAdapterManager.ManagerTableAdapter = Nothing
        Me.TableAdapterManager.PerformerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsernamepassTableAdapter = Nothing
        Me.TableAdapterManager.WorkerTableAdapter = Nothing
        '
        'EventTableAdapter
        '
        Me.EventTableAdapter.ClearBeforeFill = True
        '
        'Search_CustNameToolStrip
        '
        Me.Search_CustNameToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Search_CustNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustNameToolStripLabel, Me.CustNameToolStripTextBox, Me.Search_CustNameToolStripButton})
        Me.Search_CustNameToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.Search_CustNameToolStrip.Name = "Search_CustNameToolStrip"
        Me.Search_CustNameToolStrip.Size = New System.Drawing.Size(662, 27)
        Me.Search_CustNameToolStrip.TabIndex = 10
        Me.Search_CustNameToolStrip.Text = "Search_CustNameToolStrip"
        '
        'CustNameToolStripLabel
        '
        Me.CustNameToolStripLabel.Name = "CustNameToolStripLabel"
        Me.CustNameToolStripLabel.Size = New System.Drawing.Size(80, 24)
        Me.CustNameToolStripLabel.Text = "CustName:"
        '
        'CustNameToolStripTextBox
        '
        Me.CustNameToolStripTextBox.Name = "CustNameToolStripTextBox"
        Me.CustNameToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'Search_CustNameToolStripButton
        '
        Me.Search_CustNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Search_CustNameToolStripButton.Name = "Search_CustNameToolStripButton"
        Me.Search_CustNameToolStripButton.Size = New System.Drawing.Size(57, 24)
        Me.Search_CustNameToolStripButton.Text = "Search"
        '
        'lblEventHistory
        '
        Me.lblEventHistory.AutoSize = True
        Me.lblEventHistory.BackColor = System.Drawing.Color.Transparent
        Me.lblEventHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventHistory.Location = New System.Drawing.Point(280, 299)
        Me.lblEventHistory.Name = "lblEventHistory"
        Me.lblEventHistory.Size = New System.Drawing.Size(110, 20)
        Me.lblEventHistory.TabIndex = 11
        Me.lblEventHistory.Text = "Event History"
        '
        'lblCustForm
        '
        Me.lblCustForm.AutoSize = True
        Me.lblCustForm.BackColor = System.Drawing.Color.Transparent
        Me.lblCustForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustForm.Location = New System.Drawing.Point(267, 71)
        Me.lblCustForm.Name = "lblCustForm"
        Me.lblCustForm.Size = New System.Drawing.Size(147, 25)
        Me.lblCustForm.TabIndex = 12
        Me.lblCustForm.Text = "Customer Form"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 520)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Total Spending:"
        '
        'lblTotalSpending
        '
        Me.lblTotalSpending.AutoSize = True
        Me.lblTotalSpending.Location = New System.Drawing.Point(534, 520)
        Me.lblTotalSpending.Name = "lblTotalSpending"
        Me.lblTotalSpending.Size = New System.Drawing.Size(16, 17)
        Me.lblTotalSpending.TabIndex = 14
        Me.lblTotalSpending.Text = "0"
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.ApinihanDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Number of Events:"
        '
        'lblEventCount
        '
        Me.lblEventCount.AutoSize = True
        Me.lblEventCount.Location = New System.Drawing.Point(281, 520)
        Me.lblEventCount.Name = "lblEventCount"
        Me.lblEventCount.Size = New System.Drawing.Size(16, 17)
        Me.lblEventCount.TabIndex = 19
        Me.lblEventCount.Text = "0"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.txtCustomerID.Location = New System.Drawing.Point(129, 21)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(216, 22)
        Me.txtCustomerID.TabIndex = 2
        '
        'txtCustomerName
        '
        Me.txtCustomerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustName", True))
        Me.txtCustomerName.DataSource = Me.CustomerBindingSource1
        Me.txtCustomerName.DisplayMember = "CustName"
        Me.txtCustomerName.FormattingEnabled = True
        Me.txtCustomerName.Location = New System.Drawing.Point(129, 49)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(216, 24)
        Me.txtCustomerName.TabIndex = 17
        Me.txtCustomerName.ValueMember = "CustName"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnGenerate)
        Me.GroupBox1.Controls.Add(CustNameLabel)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(CustomerIDLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 166)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ID and Name"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 57)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "This button generates Customer ID based on existing IDs in the database and the f" &
    "irst character of the new company name"
        '
        'btnGenerate
        '
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.Location = New System.Drawing.Point(16, 91)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(158, 57)
        Me.btnGenerate.TabIndex = 18
        Me.btnGenerate.Text = "Generate Customer ID from Customer Name"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Apinihan.My.Resources.Resources.background31
        Me.ClientSize = New System.Drawing.Size(662, 651)
        Me.Controls.Add(Me.EventDataGridView)
        Me.Controls.Add(Me.lblEventCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalSpending)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCustForm)
        Me.Controls.Add(Me.lblEventHistory)
        Me.Controls.Add(Me.Search_CustNameToolStrip)
        Me.Controls.Add(CustPhoneLabel)
        Me.Controls.Add(Me.CustPhoneTextBox)
        Me.Controls.Add(CustEmailLabel)
        Me.Controls.Add(Me.CustEmailTextBox)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CustomerForm"
        Me.Text = "Customer"
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search_CustNameToolStrip.ResumeLayout(False)
        Me.Search_CustNameToolStrip.PerformLayout()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ApinihanDataSet As ApinihanDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ApinihanDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As ApinihanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EventTableAdapter As ApinihanDataSetTableAdapters.EventTableAdapter
    Friend WithEvents CustPhoneTextBox As TextBox
    Friend WithEvents CustEmailTextBox As TextBox
    Friend WithEvents EventBindingSource As BindingSource
    Friend WithEvents EventDataGridView As DataGridView
    Friend WithEvents Search_CustNameToolStrip As ToolStrip
    Friend WithEvents CustNameToolStripLabel As ToolStripLabel
    Friend WithEvents CustNameToolStripTextBox As ToolStripTextBox
    Friend WithEvents Search_CustNameToolStripButton As ToolStripButton
    Friend WithEvents lblEventHistory As Label
    Friend WithEvents lblCustForm As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalSpending As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEventCount As Label
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents EventPrice As DataGridViewTextBoxColumn
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label3 As Label
End Class
