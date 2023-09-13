<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerformerNeverBooked
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Performer1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApinihanDataSet = New Apinihan.ApinihanDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Performer1TableAdapter = New Apinihan.ApinihanDataSetTableAdapters.Performer1TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Performer1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Performer1BindingSource
        '
        Me.Performer1BindingSource.DataMember = "Performer1"
        Me.Performer1BindingSource.DataSource = Me.ApinihanDataSet
        '
        'ApinihanDataSet
        '
        Me.ApinihanDataSet.DataSetName = "ApinihanDataSet"
        Me.ApinihanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Performer1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Apinihan.Performers Never Booked.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 68)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(885, 535)
        Me.ReportViewer1.TabIndex = 0
        '
        'Performer1TableAdapter
        '
        Me.Performer1TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Performers Never Booked"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apinihan.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PerformerNeverBooked
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Apinihan.My.Resources.Resources.background31
        Me.ClientSize = New System.Drawing.Size(886, 601)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "PerformerNeverBooked"
        Me.Text = "PerformerNeverBooked"
        CType(Me.Performer1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApinihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Performer1BindingSource As BindingSource
    Friend WithEvents ApinihanDataSet As ApinihanDataSet
    Friend WithEvents Performer1TableAdapter As ApinihanDataSetTableAdapters.Performer1TableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
