<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkerUpdate
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
        Dim WorkerIDLabel As System.Windows.Forms.Label
        Dim WorkerFullNameLabel As System.Windows.Forms.Label
        Dim WorkerPhotoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WorkerDataGridView = New System.Windows.Forms.DataGridView()
        Me.WorkerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApinihanDataSet = New Apinihan.ApinihanDataSet()
        Me.TabWorker = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.WorkerIDTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerPhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableAdapterManager = New Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager()
        Me.WorkerTableAdapter = New Apinihan.ApinihanDataSetTableAdapters.WorkerTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        WorkerIDLabel = New System.Windows.Forms.Label()
        WorkerFullNameLabel = New System.Windows.Forms.Label()
        WorkerPhotoLabel = New System.Windows.Forms.Label()
        Me.Tab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.WorkerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabWorker.SuspendLayout()
        CType(Me.WorkerPhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WorkerIDLabel
        '
        WorkerIDLabel.AutoSize = True
        WorkerIDLabel.Location = New System.Drawing.Point(177, 27)
        WorkerIDLabel.Name = "WorkerIDLabel"
        WorkerIDLabel.Size = New System.Drawing.Size(75, 17)
        WorkerIDLabel.TabIndex = 4
        WorkerIDLabel.Text = "Worker ID:"
        '
        'WorkerFullNameLabel
        '
        WorkerFullNameLabel.AutoSize = True
        WorkerFullNameLabel.Location = New System.Drawing.Point(127, 346)
        WorkerFullNameLabel.Name = "WorkerFullNameLabel"
        WorkerFullNameLabel.Size = New System.Drawing.Size(125, 17)
        WorkerFullNameLabel.TabIndex = 2
        WorkerFullNameLabel.Text = "Worker Full Name:"
        '
        'WorkerPhotoLabel
        '
        WorkerPhotoLabel.AutoSize = True
        WorkerPhotoLabel.Location = New System.Drawing.Point(153, 69)
        WorkerPhotoLabel.Name = "WorkerPhotoLabel"
        WorkerPhotoLabel.Size = New System.Drawing.Size(99, 17)
        WorkerPhotoLabel.TabIndex = 0
        WorkerPhotoLabel.Text = "Worker Photo:"
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.TabPage1)
        Me.Tab1.Controls.Add(Me.TabWorker)
        Me.Tab1.Location = New System.Drawing.Point(12, 71)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(802, 364)
        Me.Tab1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WorkerDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(794, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Worker List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WorkerDataGridView
        '
        Me.WorkerDataGridView.AutoGenerateColumns = False
        Me.WorkerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.WorkerDataGridView.DataSource = Me.WorkerBindingSource
        Me.WorkerDataGridView.Location = New System.Drawing.Point(0, 6)
        Me.WorkerDataGridView.Name = "WorkerDataGridView"
        Me.WorkerDataGridView.RowTemplate.Height = 24
        Me.WorkerDataGridView.Size = New System.Drawing.Size(794, 329)
        Me.WorkerDataGridView.TabIndex = 0
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
        'TabWorker
        '
        Me.TabWorker.Controls.Add(Me.Button1)
        Me.TabWorker.Controls.Add(Me.btnRemove)
        Me.TabWorker.Controls.Add(Me.btnUpload)
        Me.TabWorker.Controls.Add(Me.btnBrowse)
        Me.TabWorker.Controls.Add(Me.txtFilePath)
        Me.TabWorker.Controls.Add(WorkerIDLabel)
        Me.TabWorker.Controls.Add(Me.WorkerIDTextBox)
        Me.TabWorker.Controls.Add(WorkerFullNameLabel)
        Me.TabWorker.Controls.Add(Me.WorkerFullNameTextBox)
        Me.TabWorker.Controls.Add(WorkerPhotoLabel)
        Me.TabWorker.Controls.Add(Me.WorkerPhotoPictureBox)
        Me.TabWorker.Location = New System.Drawing.Point(4, 25)
        Me.TabWorker.Name = "TabWorker"
        Me.TabWorker.Padding = New System.Windows.Forms.Padding(3)
        Me.TabWorker.Size = New System.Drawing.Size(794, 335)
        Me.TabWorker.TabIndex = 1
        Me.TabWorker.Text = "Upload Photo"
        Me.TabWorker.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 33)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(513, 226)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(86, 33)
        Me.btnRemove.TabIndex = 22
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(513, 184)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(86, 33)
        Me.btnUpload.TabIndex = 21
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(513, 92)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(86, 33)
        Me.btnBrowse.TabIndex = 20
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(503, 131)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(170, 22)
        Me.txtFilePath.TabIndex = 19
        '
        'WorkerIDTextBox
        '
        Me.WorkerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerBindingSource, "WorkerID", True))
        Me.WorkerIDTextBox.Location = New System.Drawing.Point(258, 24)
        Me.WorkerIDTextBox.Name = "WorkerIDTextBox"
        Me.WorkerIDTextBox.Size = New System.Drawing.Size(125, 22)
        Me.WorkerIDTextBox.TabIndex = 5
        '
        'WorkerFullNameTextBox
        '
        Me.WorkerFullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerBindingSource, "WorkerFullName", True))
        Me.WorkerFullNameTextBox.Location = New System.Drawing.Point(258, 343)
        Me.WorkerFullNameTextBox.Name = "WorkerFullNameTextBox"
        Me.WorkerFullNameTextBox.Size = New System.Drawing.Size(231, 22)
        Me.WorkerFullNameTextBox.TabIndex = 3
        '
        'WorkerPhotoPictureBox
        '
        Me.WorkerPhotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.WorkerBindingSource, "WorkerPhoto", True))
        Me.WorkerPhotoPictureBox.Location = New System.Drawing.Point(258, 69)
        Me.WorkerPhotoPictureBox.Name = "WorkerPhotoPictureBox"
        Me.WorkerPhotoPictureBox.Size = New System.Drawing.Size(231, 251)
        Me.WorkerPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WorkerPhotoPictureBox.TabIndex = 1
        Me.WorkerPhotoPictureBox.TabStop = False
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
        Me.TableAdapterManager.ManagerTableAdapter = Nothing
        Me.TableAdapterManager.PerformerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Apinihan.ApinihanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsernamepassTableAdapter = Nothing
        Me.TableAdapterManager.WorkerTableAdapter = Me.WorkerTableAdapter
        '
        'WorkerTableAdapter
        '
        Me.WorkerTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 438)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Click on Worker ID to upload a profile photo or to see it."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(693, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 33)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(129, 465)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(535, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "To add a new worker, click on the blank row on the bottom and click the save butt" &
    "on"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(724, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 40)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Worker List"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WorkerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Worker ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WorkerFirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Worker Firstname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "WorkerLastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Worker Lastname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "WorkerSalary"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Worker Salary"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "WorkerEmail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Worker Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'WorkerUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Apinihan.My.Resources.Resources.background31
        Me.ClientSize = New System.Drawing.Size(826, 510)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tab1)
        Me.Name = "WorkerUpdate"
        Me.Text = "WorkerUpdate"
        Me.Tab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.WorkerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabWorker.ResumeLayout(False)
        Me.TabWorker.PerformLayout()
        CType(Me.WorkerPhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tab1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WorkerDataGridView As DataGridView
    Friend WithEvents WorkerBindingSource As BindingSource
    Friend WithEvents ApinihanDataSet As ApinihanDataSet
    Friend WithEvents TabWorker As TabPage
    Friend WithEvents WorkerIDTextBox As TextBox
    Friend WithEvents WorkerFullNameTextBox As TextBox
    Friend WithEvents WorkerPhotoPictureBox As PictureBox
    Friend WithEvents TableAdapterManager As ApinihanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkerTableAdapter As ApinihanDataSetTableAdapters.WorkerTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
