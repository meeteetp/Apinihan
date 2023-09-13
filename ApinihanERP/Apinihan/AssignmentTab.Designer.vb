<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignmentTab
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
        Dim WorkerIDLabel As System.Windows.Forms.Label
        Dim WorkerFirstNameLabel As System.Windows.Forms.Label
        Dim WorkerLastNameLabel As System.Windows.Forms.Label
        Dim WorkerSalaryLabel As System.Windows.Forms.Label
        Dim WorkerEmailLabel As System.Windows.Forms.Label
        Me.TabWorker = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.WorkerPhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.WorkerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApinihanDataSet = New Apinihan.ApinihanDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WorkerIDTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerEmailTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AssignmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApinihanDataSet1 = New Apinihan.ApinihanDataSet()
        Me.WorkerID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.WorkerIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.WorkerIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AssignmentTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.AssignmentTableAdapter()
        Me.TableAdapterManager = New Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager()
        Me.WorkerTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.WorkerTableAdapter()
        Me.ManagerTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.ManagerTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        WorkerIDLabel = New System.Windows.Forms.Label()
        WorkerFirstNameLabel = New System.Windows.Forms.Label()
        WorkerLastNameLabel = New System.Windows.Forms.Label()
        WorkerSalaryLabel = New System.Windows.Forms.Label()
        WorkerEmailLabel = New System.Windows.Forms.Label()
        Me.TabWorker.SuspendLayout()
        CType(Me.WorkerPhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.AssignmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApinihanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WorkerIDLabel
        '
        WorkerIDLabel.AutoSize = True
        WorkerIDLabel.Location = New System.Drawing.Point(171, 358)
        WorkerIDLabel.Name = "WorkerIDLabel"
        WorkerIDLabel.Size = New System.Drawing.Size(75, 17)
        WorkerIDLabel.TabIndex = 0
        WorkerIDLabel.Text = "Worker ID:"
        '
        'WorkerFirstNameLabel
        '
        WorkerFirstNameLabel.AutoSize = True
        WorkerFirstNameLabel.Location = New System.Drawing.Point(171, 386)
        WorkerFirstNameLabel.Name = "WorkerFirstNameLabel"
        WorkerFirstNameLabel.Size = New System.Drawing.Size(130, 17)
        WorkerFirstNameLabel.TabIndex = 2
        WorkerFirstNameLabel.Text = "Worker First Name:"
        '
        'WorkerLastNameLabel
        '
        WorkerLastNameLabel.AutoSize = True
        WorkerLastNameLabel.Location = New System.Drawing.Point(171, 414)
        WorkerLastNameLabel.Name = "WorkerLastNameLabel"
        WorkerLastNameLabel.Size = New System.Drawing.Size(130, 17)
        WorkerLastNameLabel.TabIndex = 4
        WorkerLastNameLabel.Text = "Worker Last Name:"
        '
        'WorkerSalaryLabel
        '
        WorkerSalaryLabel.AutoSize = True
        WorkerSalaryLabel.Location = New System.Drawing.Point(171, 442)
        WorkerSalaryLabel.Name = "WorkerSalaryLabel"
        WorkerSalaryLabel.Size = New System.Drawing.Size(102, 17)
        WorkerSalaryLabel.TabIndex = 6
        WorkerSalaryLabel.Text = "Worker Salary:"
        '
        'WorkerEmailLabel
        '
        WorkerEmailLabel.AutoSize = True
        WorkerEmailLabel.Location = New System.Drawing.Point(171, 470)
        WorkerEmailLabel.Name = "WorkerEmailLabel"
        WorkerEmailLabel.Size = New System.Drawing.Size(96, 17)
        WorkerEmailLabel.TabIndex = 8
        WorkerEmailLabel.Text = "Worker Email:"
        '
        'TabWorker
        '
        Me.TabWorker.Controls.Add(Me.Button1)
        Me.TabWorker.Controls.Add(Me.btnRemove)
        Me.TabWorker.Controls.Add(Me.btnUpload)
        Me.TabWorker.Controls.Add(Me.btnBrowse)
        Me.TabWorker.Controls.Add(Me.txtFilePath)
        Me.TabWorker.Controls.Add(Me.WorkerPhotoPictureBox)
        Me.TabWorker.Controls.Add(Me.Label6)
        Me.TabWorker.Controls.Add(Me.Label5)
        Me.TabWorker.Controls.Add(WorkerIDLabel)
        Me.TabWorker.Controls.Add(Me.WorkerIDTextBox)
        Me.TabWorker.Controls.Add(WorkerFirstNameLabel)
        Me.TabWorker.Controls.Add(Me.WorkerFirstNameTextBox)
        Me.TabWorker.Controls.Add(WorkerLastNameLabel)
        Me.TabWorker.Controls.Add(Me.WorkerLastNameTextBox)
        Me.TabWorker.Controls.Add(WorkerSalaryLabel)
        Me.TabWorker.Controls.Add(Me.WorkerSalaryTextBox)
        Me.TabWorker.Controls.Add(WorkerEmailLabel)
        Me.TabWorker.Controls.Add(Me.WorkerEmailTextBox)
        Me.TabWorker.Location = New System.Drawing.Point(4, 25)
        Me.TabWorker.Name = "TabWorker"
        Me.TabWorker.Padding = New System.Windows.Forms.Padding(3)
        Me.TabWorker.Size = New System.Drawing.Size(661, 553)
        Me.TabWorker.TabIndex = 1
        Me.TabWorker.Text = "Worker Detail"
        Me.TabWorker.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(413, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 33)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(413, 245)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(86, 33)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(413, 203)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(86, 33)
        Me.btnUpload.TabIndex = 16
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(413, 111)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(86, 33)
        Me.btnBrowse.TabIndex = 15
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(403, 150)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(170, 22)
        Me.txtFilePath.TabIndex = 14
        '
        'WorkerPhotoPictureBox
        '
        Me.WorkerPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.WorkerPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WorkerPhotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.WorkerBindingSource, "WorkerPhoto", True))
        Me.WorkerPhotoPictureBox.Location = New System.Drawing.Point(156, 69)
        Me.WorkerPhotoPictureBox.Name = "WorkerPhotoPictureBox"
        Me.WorkerPhotoPictureBox.Size = New System.Drawing.Size(227, 252)
        Me.WorkerPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WorkerPhotoPictureBox.TabIndex = 13
        Me.WorkerPhotoPictureBox.TabStop = False
        '
        'WorkerBindingSource
        '
        Me.WorkerBindingSource.DataMember = "Worker"
        Me.WorkerBindingSource.DataSource = Me.ApinihanDataSet
        '
        'ApinihanDataSet
        '
        Me.ApinihanDataSet.DataSetName = "ApinihanDataSet"
        Me.ApinihanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Detail"
        '
        'WorkerIDTextBox
        '
        Me.WorkerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerBindingSource, "WorkerID", True))
        Me.WorkerIDTextBox.Location = New System.Drawing.Point(322, 355)
        Me.WorkerIDTextBox.Name = "WorkerIDTextBox"
        Me.WorkerIDTextBox.ReadOnly = True
        Me.WorkerIDTextBox.Size = New System.Drawing.Size(177, 22)
        Me.WorkerIDTextBox.TabIndex = 1
        '
        'WorkerFirstNameTextBox
        '
        Me.WorkerFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerBindingSource, "WorkerFirstName", True))
        Me.WorkerFirstNameTextBox.Location = New System.Drawing.Point(322, 383)
        Me.WorkerFirstNameTextBox.Name = "WorkerFirstNameTextBox"
        Me.WorkerFirstNameTextBox.ReadOnly = True
        Me.WorkerFirstNameTextBox.Size = New System.Drawing.Size(177, 22)
        Me.WorkerFirstNameTextBox.TabIndex = 3
        '
        'WorkerLastNameTextBox
        '
        Me.WorkerLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerBindingSource, "WorkerLastName", True))
        Me.WorkerLastNameTextBox.Location = New System.Drawing.Point(322, 411)
        Me.WorkerLastNameTextBox.Name = "WorkerLastNameTextBox"
        Me.WorkerLastNameTextBox.ReadOnly = True
        Me.WorkerLastNameTextBox.Size = New System.Drawing.Size(177, 22)
        Me.WorkerLastNameTextBox.TabIndex = 5
        '
        'WorkerSalaryTextBox
        '
        Me.WorkerSalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerBindingSource, "WorkerSalary", True))
        Me.WorkerSalaryTextBox.Location = New System.Drawing.Point(322, 439)
        Me.WorkerSalaryTextBox.Name = "WorkerSalaryTextBox"
        Me.WorkerSalaryTextBox.ReadOnly = True
        Me.WorkerSalaryTextBox.Size = New System.Drawing.Size(177, 22)
        Me.WorkerSalaryTextBox.TabIndex = 7
        '
        'WorkerEmailTextBox
        '
        Me.WorkerEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerBindingSource, "WorkerEmail", True))
        Me.WorkerEmailTextBox.Location = New System.Drawing.Point(322, 467)
        Me.WorkerEmailTextBox.Name = "WorkerEmailTextBox"
        Me.WorkerEmailTextBox.ReadOnly = True
        Me.WorkerEmailTextBox.Size = New System.Drawing.Size(177, 22)
        Me.WorkerEmailTextBox.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.btnFilter)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DateTimePickerTo)
        Me.TabPage1.Controls.Add(Me.DateTimePickerFrom)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.AssignmentDataGridView)
        Me.TabPage1.Controls.Add(Me.FillByToolStrip)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(661, 553)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Assignment"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(564, 514)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 514)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 511)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(261, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Click on blank row to add an assignment"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(550, 162)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 32)
        Me.btnFilter.TabIndex = 19
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Assignment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "to:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Select assigned date range from:"
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(449, 126)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerTo.TabIndex = 15
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(449, 98)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerFrom.TabIndex = 14
        Me.DateTimePickerFrom.Value = New Date(2015, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Double click on Worker Name (Worker ID) to see Worker Detail"
        '
        'AssignmentDataGridView
        '
        Me.AssignmentDataGridView.AutoGenerateColumns = False
        Me.AssignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssignmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.WorkerID, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AssignmentDataGridView.DataSource = Me.AssignmentBindingSource
        Me.AssignmentDataGridView.Location = New System.Drawing.Point(0, 213)
        Me.AssignmentDataGridView.Name = "AssignmentDataGridView"
        Me.AssignmentDataGridView.RowTemplate.Height = 24
        Me.AssignmentDataGridView.Size = New System.Drawing.Size(649, 295)
        Me.AssignmentDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ManagerID"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.ManagerBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "ManagerFullName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ManagerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "ManagerID"
        '
        'ManagerBindingSource
        '
        Me.ManagerBindingSource.DataMember = "Manager"
        Me.ManagerBindingSource.DataSource = Me.ApinihanDataSet1
        '
        'ApinihanDataSet1
        '
        Me.ApinihanDataSet1.DataSetName = "ApinihanDataSet"
        Me.ApinihanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkerID
        '
        Me.WorkerID.DataPropertyName = "WorkerID"
        Me.WorkerID.DataSource = Me.WorkerBindingSource
        Me.WorkerID.DisplayMember = "WorkerFullName"
        Me.WorkerID.HeaderText = "WorkerID"
        Me.WorkerID.Name = "WorkerID"
        Me.WorkerID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WorkerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.WorkerID.ValueMember = "WorkerID"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AssignmentDateFrom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AssignmentDateFrom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AssignmentDateTo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AssignmentDateTo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'AssignmentBindingSource
        '
        Me.AssignmentBindingSource.DataMember = "Assignment"
        Me.AssignmentBindingSource.DataSource = Me.ApinihanDataSet
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkerIDToolStripLabel, Me.WorkerIDToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(655, 27)
        Me.FillByToolStrip.TabIndex = 11
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'WorkerIDToolStripLabel
        '
        Me.WorkerIDToolStripLabel.Name = "WorkerIDToolStripLabel"
        Me.WorkerIDToolStripLabel.Size = New System.Drawing.Size(74, 24)
        Me.WorkerIDToolStripLabel.Text = "WorkerID:"
        '
        'WorkerIDToolStripTextBox
        '
        Me.WorkerIDToolStripTextBox.Name = "WorkerIDToolStripTextBox"
        Me.WorkerIDToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(57, 24)
        Me.FillByToolStripButton.Text = "Search"
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.TabPage1)
        Me.Tab1.Controls.Add(Me.TabWorker)
        Me.Tab1.Location = New System.Drawing.Point(12, 12)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(669, 582)
        Me.Tab1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AssignmentTableAdapter
        '
        Me.AssignmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AssignmentTableAdapter = Me.AssignmentTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EquipmentTableAdapter = Nothing
        Me.TableAdapterManager.EventTableAdapter = Nothing
        Me.TableAdapterManager.InstallTableAdapter = Nothing
        Me.TableAdapterManager.ManagerTableAdapter = Nothing
        Me.TableAdapterManager.PerformerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsernamepassTableAdapter = Nothing
        Me.TableAdapterManager.WorkerTableAdapter = Nothing
        '
        'WorkerTableAdapter
        '
        Me.WorkerTableAdapter.ClearBeforeFill = True
        '
        'ManagerTableAdapter
        '
        Me.ManagerTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(354, 511)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(261, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Click on blank row to add an assignment"
        '
        'AssignmentTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Apinihan.My.Resources.Resources.background31
        Me.ClientSize = New System.Drawing.Size(693, 641)
        Me.Controls.Add(Me.Tab1)
        Me.Name = "AssignmentTab"
        Me.Text = "AssignmentTab"
        Me.TabWorker.ResumeLayout(False)
        Me.TabWorker.PerformLayout()
        CType(Me.WorkerPhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.AssignmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApinihanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.Tab1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AssignmentTableAdapter As ApinihanDataSetTableAdapters.AssignmentTableAdapter
    Friend WithEvents TabWorker As TabPage
    Friend WithEvents WorkerIDTextBox As TextBox
    Friend WithEvents WorkerBindingSource As BindingSource
    Friend WithEvents ApinihanDataSet As ApinihanDataSet
    Friend WithEvents WorkerFirstNameTextBox As TextBox
    Friend WithEvents WorkerLastNameTextBox As TextBox
    Friend WithEvents WorkerSalaryTextBox As TextBox
    Friend WithEvents WorkerEmailTextBox As TextBox
    Friend WithEvents TableAdapterManager As ApinihanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkerTableAdapter As ApinihanDataSetTableAdapters.WorkerTableAdapter
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents AssignmentDataGridView As DataGridView
    Friend WithEvents AssignmentBindingSource As BindingSource
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents WorkerIDToolStripLabel As ToolStripLabel
    Friend WithEvents WorkerIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents Tab1 As TabControl
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerTo As DateTimePicker
    Friend WithEvents DateTimePickerFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ApinihanDataSet1 As ApinihanDataSet
    Friend WithEvents ManagerBindingSource As BindingSource
    Friend WithEvents ManagerTableAdapter As ApinihanDataSetTableAdapters.ManagerTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents WorkerPhotoPictureBox As PictureBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents WorkerID As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label8 As Label
End Class
