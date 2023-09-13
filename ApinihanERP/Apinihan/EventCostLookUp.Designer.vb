<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventCostLookUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventCostLookUp))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Vw_EventVarCostBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Vw_EventVarCostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Vw_EventVarCostBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Vw_EventVarCostDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerformerCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMinPerformer = New System.Windows.Forms.TextBox()
        Me.txtMaxPerformer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalPerformerCost = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAvgPerformerCost = New System.Windows.Forms.Label()
        Me.nMatchesLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Vw_EventVarCostTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.vw_EventVarCostTableAdapter()
        Me.TableAdapterManager = New Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager()
        CType(Me.Vw_EventVarCostBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vw_EventVarCostBindingNavigator.SuspendLayout()
        CType(Me.Vw_EventVarCostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_EventVarCostDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(413, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Event Variable Cost Search"
        '
        'Vw_EventVarCostBindingNavigator
        '
        Me.Vw_EventVarCostBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vw_EventVarCostBindingNavigator.BindingSource = Me.Vw_EventVarCostBindingSource
        Me.Vw_EventVarCostBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vw_EventVarCostBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vw_EventVarCostBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Vw_EventVarCostBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vw_EventVarCostBindingNavigatorSaveItem})
        Me.Vw_EventVarCostBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vw_EventVarCostBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vw_EventVarCostBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vw_EventVarCostBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vw_EventVarCostBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vw_EventVarCostBindingNavigator.Name = "Vw_EventVarCostBindingNavigator"
        Me.Vw_EventVarCostBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vw_EventVarCostBindingNavigator.Size = New System.Drawing.Size(1065, 27)
        Me.Vw_EventVarCostBindingNavigator.TabIndex = 9
        Me.Vw_EventVarCostBindingNavigator.Text = "BindingNavigator1"
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
        'Vw_EventVarCostBindingSource
        '
        Me.Vw_EventVarCostBindingSource.DataMember = "vw_EventVarCost"
        Me.Vw_EventVarCostBindingSource.DataSource = Me.ApinihanDataSet
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
        'Vw_EventVarCostBindingNavigatorSaveItem
        '
        Me.Vw_EventVarCostBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vw_EventVarCostBindingNavigatorSaveItem.Enabled = False
        Me.Vw_EventVarCostBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vw_EventVarCostBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vw_EventVarCostBindingNavigatorSaveItem.Name = "Vw_EventVarCostBindingNavigatorSaveItem"
        Me.Vw_EventVarCostBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.Vw_EventVarCostBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(878, 122)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 36)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Vw_EventVarCostDataGridView
        '
        Me.Vw_EventVarCostDataGridView.AutoGenerateColumns = False
        Me.Vw_EventVarCostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_EventVarCostDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.PerformerCost})
        Me.Vw_EventVarCostDataGridView.DataSource = Me.Vw_EventVarCostBindingSource
        Me.Vw_EventVarCostDataGridView.Location = New System.Drawing.Point(26, 187)
        Me.Vw_EventVarCostDataGridView.Name = "Vw_EventVarCostDataGridView"
        Me.Vw_EventVarCostDataGridView.RowTemplate.Height = 24
        Me.Vw_EventVarCostDataGridView.Size = New System.Drawing.Size(1013, 254)
        Me.Vw_EventVarCostDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Manager Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Manager Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EventName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EventName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EventStartDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EventStartDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EventEndDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EventEndDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Number of Days"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Number of Days"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Number of Performers"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Number of Performers"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'PerformerCost
        '
        Me.PerformerCost.DataPropertyName = "Performer Cost"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PerformerCost.DefaultCellStyle = DataGridViewCellStyle1
        Me.PerformerCost.HeaderText = "Performer Cost"
        Me.PerformerCost.Name = "PerformerCost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(445, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Minimum #Performers"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(445, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Maximum #Performers"
        '
        'txtMinPerformer
        '
        Me.txtMinPerformer.Location = New System.Drawing.Point(613, 87)
        Me.txtMinPerformer.Name = "txtMinPerformer"
        Me.txtMinPerformer.Size = New System.Drawing.Size(100, 22)
        Me.txtMinPerformer.TabIndex = 13
        Me.txtMinPerformer.Text = "0"
        '
        'txtMaxPerformer
        '
        Me.txtMaxPerformer.Location = New System.Drawing.Point(613, 130)
        Me.txtMaxPerformer.Name = "txtMaxPerformer"
        Me.txtMaxPerformer.Size = New System.Drawing.Size(100, 22)
        Me.txtMaxPerformer.TabIndex = 14
        Me.txtMaxPerformer.Text = "3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(72, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(23, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Date From"
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(116, 90)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerFrom.TabIndex = 17
        Me.DateTimePickerFrom.Value = New Date(2015, 11, 25, 0, 0, 0, 0)
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(116, 133)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerTo.TabIndex = 18
        Me.DateTimePickerTo.Value = New Date(2016, 3, 7, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(681, 509)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total Performer Cost:"
        '
        'lblTotalPerformerCost
        '
        Me.lblTotalPerformerCost.AutoSize = True
        Me.lblTotalPerformerCost.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPerformerCost.Location = New System.Drawing.Point(872, 509)
        Me.lblTotalPerformerCost.Name = "lblTotalPerformerCost"
        Me.lblTotalPerformerCost.Size = New System.Drawing.Size(24, 17)
        Me.lblTotalPerformerCost.TabIndex = 22
        Me.lblTotalPerformerCost.Text = "$0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(660, 547)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Average Performer Cost:"
        '
        'lblAvgPerformerCost
        '
        Me.lblAvgPerformerCost.AutoSize = True
        Me.lblAvgPerformerCost.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgPerformerCost.Location = New System.Drawing.Point(872, 547)
        Me.lblAvgPerformerCost.Name = "lblAvgPerformerCost"
        Me.lblAvgPerformerCost.Size = New System.Drawing.Size(24, 17)
        Me.lblAvgPerformerCost.TabIndex = 24
        Me.lblAvgPerformerCost.Text = "$0"
        '
        'nMatchesLabel
        '
        Me.nMatchesLabel.AutoSize = True
        Me.nMatchesLabel.BackColor = System.Drawing.Color.Transparent
        Me.nMatchesLabel.Location = New System.Drawing.Point(880, 470)
        Me.nMatchesLabel.Name = "nMatchesLabel"
        Me.nMatchesLabel.Size = New System.Drawing.Size(16, 17)
        Me.nMatchesLabel.TabIndex = 25
        Me.nMatchesLabel.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(642, 470)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Number of Matches/Events:"
        '
        'Vw_EventVarCostTableAdapter
        '
        Me.Vw_EventVarCostTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AssignmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'EventCostLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Apinihan.My.Resources.Resources.background31
        Me.ClientSize = New System.Drawing.Size(1065, 597)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.nMatchesLabel)
        Me.Controls.Add(Me.lblAvgPerformerCost)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblTotalPerformerCost)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePickerTo)
        Me.Controls.Add(Me.DateTimePickerFrom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMaxPerformer)
        Me.Controls.Add(Me.txtMinPerformer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Vw_EventVarCostDataGridView)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Vw_EventVarCostBindingNavigator)
        Me.Controls.Add(Me.Label7)
        Me.Name = "EventCostLookUp"
        Me.Text = "EventCostLookUp"
        CType(Me.Vw_EventVarCostBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vw_EventVarCostBindingNavigator.ResumeLayout(False)
        Me.Vw_EventVarCostBindingNavigator.PerformLayout()
        CType(Me.Vw_EventVarCostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_EventVarCostDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents ApinihanDataSet As ApinihanDataSet
    Friend WithEvents Vw_EventVarCostBindingSource As BindingSource
    Friend WithEvents Vw_EventVarCostTableAdapter As ApinihanDataSetTableAdapters.vw_EventVarCostTableAdapter
    Friend WithEvents TableAdapterManager As ApinihanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Vw_EventVarCostBindingNavigator As BindingNavigator
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
    Friend WithEvents Vw_EventVarCostBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents Vw_EventVarCostDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMinPerformer As TextBox
    Friend WithEvents txtMaxPerformer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePickerFrom As DateTimePicker
    Friend WithEvents DateTimePickerTo As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalPerformerCost As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblAvgPerformerCost As Label
    Friend WithEvents nMatchesLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PerformerCost As DataGridViewTextBoxColumn
End Class
