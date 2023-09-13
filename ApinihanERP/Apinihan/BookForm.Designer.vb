<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookForm))
        Me.BookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BookDataGridView = New System.Windows.Forms.DataGridView()
        Me.BookTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.BookTableAdapter()
        Me.TableAdapterManager = New Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager()
        Me.PerformerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerformerTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.PerformerTableAdapter()
        Me.FillBy2ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PerformerIDToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PerformerIDToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy2ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookBindingNavigator.SuspendLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy2ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookBindingNavigator
        '
        Me.BookBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BookBindingNavigator.BindingSource = Me.BookBindingSource
        Me.BookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BookBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BookBindingNavigatorSaveItem})
        Me.BookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BookBindingNavigator.Name = "BookBindingNavigator"
        Me.BookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BookBindingNavigator.Size = New System.Drawing.Size(681, 27)
        Me.BookBindingNavigator.TabIndex = 0
        Me.BookBindingNavigator.Text = "BindingNavigator1"
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
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.ApinihanDataSet
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
        'BookBindingNavigatorSaveItem
        '
        Me.BookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BookBindingNavigatorSaveItem.Image = CType(resources.GetObject("BookBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BookBindingNavigatorSaveItem.Name = "BookBindingNavigatorSaveItem"
        Me.BookBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.BookBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BookDataGridView
        '
        Me.BookDataGridView.AutoGenerateColumns = False
        Me.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.BookDataGridView.DataSource = Me.BookBindingSource
        Me.BookDataGridView.Location = New System.Drawing.Point(24, 105)
        Me.BookDataGridView.Name = "BookDataGridView"
        Me.BookDataGridView.RowTemplate.Height = 24
        Me.BookDataGridView.Size = New System.Drawing.Size(640, 268)
        Me.BookDataGridView.TabIndex = 1
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AssignmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Me.BookTableAdapter
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
        'PerformerBindingSource
        '
        Me.PerformerBindingSource.DataMember = "Performer"
        Me.PerformerBindingSource.DataSource = Me.ApinihanDataSet
        '
        'PerformerTableAdapter
        '
        Me.PerformerTableAdapter.ClearBeforeFill = True
        '
        'FillBy2ToolStrip
        '
        Me.FillBy2ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillBy2ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerformerIDToolStripLabel1, Me.PerformerIDToolStripTextBox1, Me.FillBy2ToolStripButton})
        Me.FillBy2ToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.FillBy2ToolStrip.Name = "FillBy2ToolStrip"
        Me.FillBy2ToolStrip.Size = New System.Drawing.Size(681, 27)
        Me.FillBy2ToolStrip.TabIndex = 6
        Me.FillBy2ToolStrip.Text = "FillBy2ToolStrip"
        '
        'PerformerIDToolStripLabel1
        '
        Me.PerformerIDToolStripLabel1.Name = "PerformerIDToolStripLabel1"
        Me.PerformerIDToolStripLabel1.Size = New System.Drawing.Size(92, 24)
        Me.PerformerIDToolStripLabel1.Text = "PerformerID:"
        '
        'PerformerIDToolStripTextBox1
        '
        Me.PerformerIDToolStripTextBox1.Name = "PerformerIDToolStripTextBox1"
        Me.PerformerIDToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'FillBy2ToolStripButton
        '
        Me.FillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy2ToolStripButton.Name = "FillBy2ToolStripButton"
        Me.FillBy2ToolStripButton.Size = New System.Drawing.Size(57, 24)
        Me.FillBy2ToolStripButton.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Book History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Double click on blank row to add booking"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(589, 30)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BookDateTo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "BookDateTo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BookDateFrom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BookDateFrom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PerformerID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PerformerID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EventID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EventID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 414)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FillBy2ToolStrip)
        Me.Controls.Add(Me.BookDataGridView)
        Me.Controls.Add(Me.BookBindingNavigator)
        Me.Name = "BookForm"
        Me.Text = "BookForm"
        CType(Me.BookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookBindingNavigator.ResumeLayout(False)
        Me.BookBindingNavigator.PerformLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy2ToolStrip.ResumeLayout(False)
        Me.FillBy2ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ApinihanDataSet As ApinihanDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As ApinihanDataSetTableAdapters.BookTableAdapter
    Friend WithEvents TableAdapterManager As ApinihanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookBindingNavigator As BindingNavigator
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
    Friend WithEvents BookBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BookDataGridView As DataGridView
    Friend WithEvents PerformerBindingSource As BindingSource
    Friend WithEvents PerformerTableAdapter As ApinihanDataSetTableAdapters.PerformerTableAdapter
    Friend WithEvents FillBy2ToolStrip As ToolStrip
    Friend WithEvents PerformerIDToolStripLabel1 As ToolStripLabel
    Friend WithEvents PerformerIDToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillBy2ToolStripButton As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
