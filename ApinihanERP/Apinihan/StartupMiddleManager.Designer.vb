<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartupMiddleManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartupMiddleManager))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnWorker = New System.Windows.Forms.Button()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.btnCustomerRpt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnEventRpt = New System.Windows.Forms.Button()
        Me.btnPerformerBookRpt = New System.Windows.Forms.Button()
        Me.btnPerformer = New System.Windows.Forms.Button()
        Me.btnEquipment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEvent = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblLoggedinAs = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnCustomer)
        Me.GroupBox2.Controls.Add(Me.btnWorker)
        Me.GroupBox2.Controls.Add(Me.btnAssign)
        Me.GroupBox2.Location = New System.Drawing.Point(74, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 159)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forms"
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(23, 31)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(157, 45)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnWorker
        '
        Me.btnWorker.Location = New System.Drawing.Point(217, 31)
        Me.btnWorker.Name = "btnWorker"
        Me.btnWorker.Size = New System.Drawing.Size(157, 45)
        Me.btnWorker.TabIndex = 0
        Me.btnWorker.Text = "Worker"
        Me.btnWorker.UseVisualStyleBackColor = True
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(122, 94)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(157, 45)
        Me.btnAssign.TabIndex = 1
        Me.btnAssign.Text = "Worker Assigning"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'btnCustomerRpt
        '
        Me.btnCustomerRpt.Location = New System.Drawing.Point(38, 146)
        Me.btnCustomerRpt.Name = "btnCustomerRpt"
        Me.btnCustomerRpt.Size = New System.Drawing.Size(157, 45)
        Me.btnCustomerRpt.TabIndex = 1
        Me.btnCustomerRpt.Text = "Income by Event"
        Me.btnCustomerRpt.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnEventRpt)
        Me.GroupBox1.Controls.Add(Me.btnCustomerRpt)
        Me.GroupBox1.Controls.Add(Me.btnPerformerBookRpt)
        Me.GroupBox1.Location = New System.Drawing.Point(489, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 347)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reports"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(38, 271)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 45)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Salaries Payable"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(38, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 45)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Performer Never Booked"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnEventRpt
        '
        Me.btnEventRpt.Location = New System.Drawing.Point(38, 83)
        Me.btnEventRpt.Name = "btnEventRpt"
        Me.btnEventRpt.Size = New System.Drawing.Size(157, 45)
        Me.btnEventRpt.TabIndex = 1
        Me.btnEventRpt.Text = "High Profile Clients"
        Me.btnEventRpt.UseVisualStyleBackColor = True
        '
        'btnPerformerBookRpt
        '
        Me.btnPerformerBookRpt.Location = New System.Drawing.Point(38, 20)
        Me.btnPerformerBookRpt.Name = "btnPerformerBookRpt"
        Me.btnPerformerBookRpt.Size = New System.Drawing.Size(157, 45)
        Me.btnPerformerBookRpt.TabIndex = 2
        Me.btnPerformerBookRpt.Text = "Event by City and Its Chart"
        Me.btnPerformerBookRpt.UseVisualStyleBackColor = True
        '
        'btnPerformer
        '
        Me.btnPerformer.Location = New System.Drawing.Point(97, 410)
        Me.btnPerformer.Name = "btnPerformer"
        Me.btnPerformer.Size = New System.Drawing.Size(157, 45)
        Me.btnPerformer.TabIndex = 22
        Me.btnPerformer.Text = "Performer Lookup and Bookings"
        Me.btnPerformer.UseVisualStyleBackColor = True
        '
        'btnEquipment
        '
        Me.btnEquipment.Location = New System.Drawing.Point(196, 480)
        Me.btnEquipment.Name = "btnEquipment"
        Me.btnEquipment.Size = New System.Drawing.Size(157, 45)
        Me.btnEquipment.TabIndex = 23
        Me.btnEquipment.Text = "Equiptment/Install"
        Me.btnEquipment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "APINIHAN EVENT COMPANY"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btnEvent
        '
        Me.btnEvent.Location = New System.Drawing.Point(291, 410)
        Me.btnEvent.Name = "btnEvent"
        Me.btnEvent.Size = New System.Drawing.Size(157, 45)
        Me.btnEvent.TabIndex = 24
        Me.btnEvent.Text = "Event Cost Lookup"
        Me.btnEvent.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(664, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 39)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblLoggedinAs
        '
        Me.lblLoggedinAs.BackColor = System.Drawing.Color.Transparent
        Me.lblLoggedinAs.Location = New System.Drawing.Point(146, 121)
        Me.lblLoggedinAs.Name = "lblLoggedinAs"
        Me.lblLoggedinAs.Size = New System.Drawing.Size(534, 32)
        Me.lblLoggedinAs.TabIndex = 28
        Me.lblLoggedinAs.Text = "LoggedInAs"
        Me.lblLoggedinAs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Location = New System.Drawing.Point(351, 153)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(122, 17)
        Me.lblPosition.TabIndex = 29
        Me.lblPosition.Text = "Position: Manager"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartupMiddleManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Apinihan.My.Resources.Resources.background31
        Me.ClientSize = New System.Drawing.Size(776, 606)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPerformer)
        Me.Controls.Add(Me.btnEquipment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEvent)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblLoggedinAs)
        Me.Controls.Add(Me.lblPosition)
        Me.Name = "StartupMiddleManager"
        Me.Text = "StartupMiddleManager"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnWorker As Button
    Friend WithEvents btnAssign As Button
    Friend WithEvents btnCustomerRpt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnEventRpt As Button
    Friend WithEvents btnPerformerBookRpt As Button
    Friend WithEvents btnPerformer As Button
    Friend WithEvents btnEquipment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEvent As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblLoggedinAs As Label
    Friend WithEvents lblPosition As Label
End Class
