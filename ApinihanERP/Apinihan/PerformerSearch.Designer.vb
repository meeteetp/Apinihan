<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerformerSearch
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PerformerSearch))
        Me.lbl = New System.Windows.Forms.Label()
        Me.grpRate = New System.Windows.Forms.GroupBox()
        Me.radRate10 = New System.Windows.Forms.RadioButton()
        Me.radRate9 = New System.Windows.Forms.RadioButton()
        Me.radRate8 = New System.Windows.Forms.RadioButton()
        Me.radRate7 = New System.Windows.Forms.RadioButton()
        Me.radRate1 = New System.Windows.Forms.RadioButton()
        Me.radRate2 = New System.Windows.Forms.RadioButton()
        Me.radRate6 = New System.Windows.Forms.RadioButton()
        Me.radRate5 = New System.Windows.Forms.RadioButton()
        Me.radRate4 = New System.Windows.Forms.RadioButton()
        Me.radRate3 = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PerformerDataGridView = New System.Windows.Forms.DataGridView()
        Me.PerformerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerformerCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerformerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApinihanDataSet = New Apinihan.ApinihanDataSet()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AvgPriceLabel = New System.Windows.Forms.Label()
        Me.nMatchesLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PerformerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.PerformerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.grpCost = New System.Windows.Forms.GroupBox()
        Me.txtMaxPerformerCost = New System.Windows.Forms.TextBox()
        Me.txtMinPerformerCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PerformerTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.PerformerTableAdapter()
        Me.TableAdapterManager = New Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager()
        Me.ManagerTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.ManagerTableAdapter()
        Me.ManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpRate.SuspendLayout()
        CType(Me.PerformerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PerformerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PerformerBindingNavigator.SuspendLayout()
        Me.grpCost.SuspendLayout()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Location = New System.Drawing.Point(481, 323)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(101, 17)
        Me.lbl.TabIndex = 31
        Me.lbl.Text = "Average Price:"
        '
        'grpRate
        '
        Me.grpRate.BackColor = System.Drawing.Color.Transparent
        Me.grpRate.Controls.Add(Me.radRate10)
        Me.grpRate.Controls.Add(Me.radRate9)
        Me.grpRate.Controls.Add(Me.radRate8)
        Me.grpRate.Controls.Add(Me.radRate7)
        Me.grpRate.Controls.Add(Me.radRate1)
        Me.grpRate.Controls.Add(Me.radRate2)
        Me.grpRate.Controls.Add(Me.radRate6)
        Me.grpRate.Controls.Add(Me.radRate5)
        Me.grpRate.Controls.Add(Me.radRate4)
        Me.grpRate.Controls.Add(Me.radRate3)
        Me.grpRate.Location = New System.Drawing.Point(31, 197)
        Me.grpRate.Name = "grpRate"
        Me.grpRate.Size = New System.Drawing.Size(446, 58)
        Me.grpRate.TabIndex = 25
        Me.grpRate.TabStop = False
        Me.grpRate.Text = "Performer Rating"
        '
        'radRate10
        '
        Me.radRate10.AutoSize = True
        Me.radRate10.Checked = True
        Me.radRate10.Location = New System.Drawing.Point(393, 25)
        Me.radRate10.Name = "radRate10"
        Me.radRate10.Size = New System.Drawing.Size(45, 21)
        Me.radRate10.TabIndex = 15
        Me.radRate10.TabStop = True
        Me.radRate10.Tag = "10"
        Me.radRate10.Text = "10"
        Me.radRate10.UseVisualStyleBackColor = True
        '
        'radRate9
        '
        Me.radRate9.AutoSize = True
        Me.radRate9.Location = New System.Drawing.Point(350, 25)
        Me.radRate9.Name = "radRate9"
        Me.radRate9.Size = New System.Drawing.Size(37, 21)
        Me.radRate9.TabIndex = 16
        Me.radRate9.Tag = "9"
        Me.radRate9.Text = "9"
        Me.radRate9.UseVisualStyleBackColor = True
        '
        'radRate8
        '
        Me.radRate8.AutoSize = True
        Me.radRate8.Location = New System.Drawing.Point(307, 25)
        Me.radRate8.Name = "radRate8"
        Me.radRate8.Size = New System.Drawing.Size(37, 21)
        Me.radRate8.TabIndex = 17
        Me.radRate8.Tag = "8"
        Me.radRate8.Text = "8"
        Me.radRate8.UseVisualStyleBackColor = True
        '
        'radRate7
        '
        Me.radRate7.AutoSize = True
        Me.radRate7.Location = New System.Drawing.Point(264, 25)
        Me.radRate7.Name = "radRate7"
        Me.radRate7.Size = New System.Drawing.Size(37, 21)
        Me.radRate7.TabIndex = 18
        Me.radRate7.Tag = "7"
        Me.radRate7.Text = "7"
        Me.radRate7.UseVisualStyleBackColor = True
        '
        'radRate1
        '
        Me.radRate1.AutoSize = True
        Me.radRate1.Location = New System.Drawing.Point(6, 25)
        Me.radRate1.Name = "radRate1"
        Me.radRate1.Size = New System.Drawing.Size(37, 21)
        Me.radRate1.TabIndex = 8
        Me.radRate1.Tag = "1"
        Me.radRate1.Text = "1"
        Me.radRate1.UseVisualStyleBackColor = True
        '
        'radRate2
        '
        Me.radRate2.AutoSize = True
        Me.radRate2.Location = New System.Drawing.Point(49, 25)
        Me.radRate2.Name = "radRate2"
        Me.radRate2.Size = New System.Drawing.Size(37, 21)
        Me.radRate2.TabIndex = 7
        Me.radRate2.Tag = "2"
        Me.radRate2.Text = "2"
        Me.radRate2.UseVisualStyleBackColor = True
        '
        'radRate6
        '
        Me.radRate6.AutoSize = True
        Me.radRate6.Location = New System.Drawing.Point(221, 25)
        Me.radRate6.Name = "radRate6"
        Me.radRate6.Size = New System.Drawing.Size(37, 21)
        Me.radRate6.TabIndex = 4
        Me.radRate6.Tag = "6"
        Me.radRate6.Text = "6"
        Me.radRate6.UseVisualStyleBackColor = True
        '
        'radRate5
        '
        Me.radRate5.AutoSize = True
        Me.radRate5.Location = New System.Drawing.Point(178, 25)
        Me.radRate5.Name = "radRate5"
        Me.radRate5.Size = New System.Drawing.Size(37, 21)
        Me.radRate5.TabIndex = 5
        Me.radRate5.Tag = "5"
        Me.radRate5.Text = "5"
        Me.radRate5.UseVisualStyleBackColor = True
        '
        'radRate4
        '
        Me.radRate4.AutoSize = True
        Me.radRate4.Location = New System.Drawing.Point(135, 25)
        Me.radRate4.Name = "radRate4"
        Me.radRate4.Size = New System.Drawing.Size(37, 21)
        Me.radRate4.TabIndex = 12
        Me.radRate4.Tag = "4"
        Me.radRate4.Text = "4"
        Me.radRate4.UseVisualStyleBackColor = True
        '
        'radRate3
        '
        Me.radRate3.AutoSize = True
        Me.radRate3.Location = New System.Drawing.Point(92, 25)
        Me.radRate3.Name = "radRate3"
        Me.radRate3.Size = New System.Drawing.Size(37, 21)
        Me.radRate3.TabIndex = 6
        Me.radRate3.Tag = "3"
        Me.radRate3.Text = "3"
        Me.radRate3.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(67, 4)
        '
        'PerformerDataGridView
        '
        Me.PerformerDataGridView.AutoGenerateColumns = False
        Me.PerformerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PerformerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PerformerID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.PerformerCost, Me.DataGridViewTextBoxColumn5})
        Me.PerformerDataGridView.DataSource = Me.PerformerBindingSource
        Me.PerformerDataGridView.Location = New System.Drawing.Point(24, 343)
        Me.PerformerDataGridView.Name = "PerformerDataGridView"
        Me.PerformerDataGridView.RowTemplate.Height = 24
        Me.PerformerDataGridView.Size = New System.Drawing.Size(716, 274)
        Me.PerformerDataGridView.TabIndex = 27
        '
        'PerformerID
        '
        Me.PerformerID.DataPropertyName = "PerformerID"
        Me.PerformerID.HeaderText = "PerformerID"
        Me.PerformerID.Name = "PerformerID"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PerformerName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PerformerName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PerformerRating"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PerformerRating"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'PerformerCost
        '
        Me.PerformerCost.DataPropertyName = "PerformerCost"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PerformerCost.DefaultCellStyle = DataGridViewCellStyle1
        Me.PerformerCost.HeaderText = "PerformerCost"
        Me.PerformerCost.Name = "PerformerCost"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PerformerEmail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PerformerEmail"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'PerformerBindingSource
        '
        Me.PerformerBindingSource.DataMember = "Performer"
        Me.PerformerBindingSource.DataSource = Me.ApinihanDataSet
        '
        'ApinihanDataSet
        '
        Me.ApinihanDataSet.DataSetName = "ApinihanDataSet"
        Me.ApinihanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(358, 286)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(71, 25)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(18, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 94)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "To find an artist, please enter your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " desired minimum and maximum costs and the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " performer rating of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your choice, then press search!"
        '
        'AvgPriceLabel
        '
        Me.AvgPriceLabel.AutoSize = True
        Me.AvgPriceLabel.Location = New System.Drawing.Point(588, 323)
        Me.AvgPriceLabel.Name = "AvgPriceLabel"
        Me.AvgPriceLabel.Size = New System.Drawing.Size(0, 17)
        Me.AvgPriceLabel.TabIndex = 30
        '
        'nMatchesLabel
        '
        Me.nMatchesLabel.AutoSize = True
        Me.nMatchesLabel.Location = New System.Drawing.Point(588, 289)
        Me.nMatchesLabel.Name = "nMatchesLabel"
        Me.nMatchesLabel.Size = New System.Drawing.Size(0, 17)
        Me.nMatchesLabel.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(461, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Number of Artists:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(511, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 142)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "To Use This Form"
        '
        'PerformerBindingNavigator
        '
        Me.PerformerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PerformerBindingNavigator.BindingSource = Me.PerformerBindingSource
        Me.PerformerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PerformerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PerformerBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PerformerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PerformerBindingNavigatorSaveItem})
        Me.PerformerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PerformerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PerformerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PerformerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PerformerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PerformerBindingNavigator.Name = "PerformerBindingNavigator"
        Me.PerformerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PerformerBindingNavigator.Size = New System.Drawing.Size(804, 27)
        Me.PerformerBindingNavigator.TabIndex = 22
        Me.PerformerBindingNavigator.Text = "BindingNavigator1"
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
        'PerformerBindingNavigatorSaveItem
        '
        Me.PerformerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PerformerBindingNavigatorSaveItem.Image = CType(resources.GetObject("PerformerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PerformerBindingNavigatorSaveItem.Name = "PerformerBindingNavigatorSaveItem"
        Me.PerformerBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.PerformerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'grpCost
        '
        Me.grpCost.BackColor = System.Drawing.Color.Transparent
        Me.grpCost.Controls.Add(Me.txtMaxPerformerCost)
        Me.grpCost.Controls.Add(Me.txtMinPerformerCost)
        Me.grpCost.Controls.Add(Me.Label5)
        Me.grpCost.Controls.Add(Me.Label4)
        Me.grpCost.Location = New System.Drawing.Point(31, 113)
        Me.grpCost.Name = "grpCost"
        Me.grpCost.Size = New System.Drawing.Size(446, 78)
        Me.grpCost.TabIndex = 24
        Me.grpCost.TabStop = False
        Me.grpCost.Text = "Performer Cost"
        '
        'txtMaxPerformerCost
        '
        Me.txtMaxPerformerCost.Location = New System.Drawing.Point(280, 40)
        Me.txtMaxPerformerCost.Name = "txtMaxPerformerCost"
        Me.txtMaxPerformerCost.Size = New System.Drawing.Size(146, 22)
        Me.txtMaxPerformerCost.TabIndex = 3
        Me.txtMaxPerformerCost.Text = "50000"
        '
        'txtMinPerformerCost
        '
        Me.txtMinPerformerCost.Location = New System.Drawing.Point(74, 40)
        Me.txtMinPerformerCost.Name = "txtMinPerformerCost"
        Me.txtMinPerformerCost.Size = New System.Drawing.Size(145, 22)
        Me.txtMinPerformerCost.TabIndex = 2
        Me.txtMinPerformerCost.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Max: $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Min: $"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Performer Search"
        '
        'PerformerTableAdapter
        '
        Me.PerformerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AssignmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EquipmentTableAdapter = Nothing
        Me.TableAdapterManager.EventTableAdapter = Nothing
        Me.TableAdapterManager.InstallTableAdapter = Nothing
        Me.TableAdapterManager.ManagerTableAdapter = Me.ManagerTableAdapter
        Me.TableAdapterManager.PerformerTableAdapter = Me.PerformerTableAdapter
        Me.TableAdapterManager.UpdateOrder = Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsernamepassTableAdapter = Nothing
        Me.TableAdapterManager.WorkerTableAdapter = Nothing
        '
        'ManagerTableAdapter
        '
        Me.ManagerTableAdapter.ClearBeforeFill = True
        '
        'ManagerBindingSource
        '
        Me.ManagerBindingSource.DataMember = "Manager"
        Me.ManagerBindingSource.DataSource = Me.ApinihanDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(28, 620)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(329, 17)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Double Click on PerformerID to see booking history"
        '
        'PerformerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Apinihan.My.Resources.Resources.background31
        Me.ClientSize = New System.Drawing.Size(804, 666)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.grpRate)
        Me.Controls.Add(Me.PerformerDataGridView)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.AvgPriceLabel)
        Me.Controls.Add(Me.nMatchesLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PerformerBindingNavigator)
        Me.Controls.Add(Me.grpCost)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PerformerSearch"
        Me.Text = "PerformerSearch"
        Me.grpRate.ResumeLayout(False)
        Me.grpRate.PerformLayout()
        CType(Me.PerformerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PerformerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PerformerBindingNavigator.ResumeLayout(False)
        Me.PerformerBindingNavigator.PerformLayout()
        Me.grpCost.ResumeLayout(False)
        Me.grpCost.PerformLayout()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl As Label
    Friend WithEvents grpRate As GroupBox
    Friend WithEvents radRate10 As RadioButton
    Friend WithEvents radRate9 As RadioButton
    Friend WithEvents radRate8 As RadioButton
    Friend WithEvents radRate7 As RadioButton
    Friend WithEvents radRate1 As RadioButton
    Friend WithEvents radRate2 As RadioButton
    Friend WithEvents radRate6 As RadioButton
    Friend WithEvents radRate5 As RadioButton
    Friend WithEvents radRate4 As RadioButton
    Friend WithEvents radRate3 As RadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PerformerDataGridView As DataGridView
    Friend WithEvents PerformerID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PerformerCost As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PerformerBindingSource As BindingSource
    Friend WithEvents ApinihanDataSet As ApinihanDataSet
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PerformerTableAdapter As ApinihanDataSetTableAdapters.PerformerTableAdapter
    Friend WithEvents TableAdapterManager As ApinihanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ManagerTableAdapter As ApinihanDataSetTableAdapters.ManagerTableAdapter
    Friend WithEvents ManagerBindingSource As BindingSource
    Friend WithEvents AvgPriceLabel As Label
    Friend WithEvents nMatchesLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PerformerBindingNavigator As BindingNavigator
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
    Friend WithEvents PerformerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents grpCost As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaxPerformerCost As TextBox
    Friend WithEvents txtMinPerformerCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
