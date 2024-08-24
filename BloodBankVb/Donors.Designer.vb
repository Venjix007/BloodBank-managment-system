<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donors))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DNameTb = New System.Windows.Forms.TextBox()
        Me.DAgeTb = New System.Windows.Forms.TextBox()
        Me.DPhoneTb = New System.Windows.Forms.TextBox()
        Me.DGenCb = New System.Windows.Forms.ComboBox()
        Me.DBGroupCb = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DAddressTb = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DonorsDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DonorsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1435, 172)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1179, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 62)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(182, 104)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 55)
        Me.Panel4.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1068, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 34)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "DashBoard"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(795, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Blood Transfer"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(393, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Patients"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(603, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 34)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Donate"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Donors"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(411, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Blood Bank Management System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Location = New System.Drawing.Point(0, 171)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 662)
        Me.Panel2.TabIndex = 1
        '
        'DNameTb
        '
        Me.DNameTb.BackColor = System.Drawing.Color.White
        Me.DNameTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNameTb.ForeColor = System.Drawing.Color.Red
        Me.DNameTb.Location = New System.Drawing.Point(9, 32)
        Me.DNameTb.Name = "DNameTb"
        Me.DNameTb.Size = New System.Drawing.Size(186, 42)
        Me.DNameTb.TabIndex = 2
        Me.DNameTb.Text = "Donor Name"
        '
        'DAgeTb
        '
        Me.DAgeTb.BackColor = System.Drawing.Color.White
        Me.DAgeTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAgeTb.ForeColor = System.Drawing.Color.Red
        Me.DAgeTb.Location = New System.Drawing.Point(244, 32)
        Me.DAgeTb.Name = "DAgeTb"
        Me.DAgeTb.Size = New System.Drawing.Size(74, 42)
        Me.DAgeTb.TabIndex = 3
        Me.DAgeTb.Text = "Age"
        '
        'DPhoneTb
        '
        Me.DPhoneTb.BackColor = System.Drawing.Color.White
        Me.DPhoneTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPhoneTb.ForeColor = System.Drawing.Color.Red
        Me.DPhoneTb.Location = New System.Drawing.Point(538, 32)
        Me.DPhoneTb.Name = "DPhoneTb"
        Me.DPhoneTb.Size = New System.Drawing.Size(194, 42)
        Me.DPhoneTb.TabIndex = 4
        Me.DPhoneTb.Text = "Phone"
        '
        'DGenCb
        '
        Me.DGenCb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGenCb.ForeColor = System.Drawing.Color.Red
        Me.DGenCb.FormattingEnabled = True
        Me.DGenCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.DGenCb.Location = New System.Drawing.Point(368, 32)
        Me.DGenCb.Name = "DGenCb"
        Me.DGenCb.Size = New System.Drawing.Size(152, 42)
        Me.DGenCb.TabIndex = 5
        Me.DGenCb.Text = "Gender"
        '
        'DBGroupCb
        '
        Me.DBGroupCb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBGroupCb.ForeColor = System.Drawing.Color.Red
        Me.DBGroupCb.FormattingEnabled = True
        Me.DBGroupCb.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.DBGroupCb.Location = New System.Drawing.Point(760, 32)
        Me.DBGroupCb.Name = "DBGroupCb"
        Me.DBGroupCb.Size = New System.Drawing.Size(211, 42)
        Me.DBGroupCb.TabIndex = 6
        Me.DBGroupCb.Text = "Blood Group"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Red
        Me.TextBox4.Location = New System.Drawing.Point(1000, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(186, 42)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = "Address"
        '
        'DAddressTb
        '
        Me.DAddressTb.BackColor = System.Drawing.Color.White
        Me.DAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DAddressTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAddressTb.ForeColor = System.Drawing.Color.Red
        Me.DAddressTb.Location = New System.Drawing.Point(1000, 82)
        Me.DAddressTb.Multiline = True
        Me.DAddressTb.Name = "DAddressTb"
        Me.DAddressTb.Size = New System.Drawing.Size(186, 94)
        Me.DAddressTb.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DeleteBtn)
        Me.Panel3.Controls.Add(Me.EditBtn)
        Me.Panel3.Controls.Add(Me.AddBtn)
        Me.Panel3.Controls.Add(Me.DBGroupCb)
        Me.Panel3.Controls.Add(Me.DAddressTb)
        Me.Panel3.Controls.Add(Me.DNameTb)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.DAgeTb)
        Me.Panel3.Controls.Add(Me.DPhoneTb)
        Me.Panel3.Controls.Add(Me.DGenCb)
        Me.Panel3.Location = New System.Drawing.Point(106, 178)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1216, 245)
        Me.Panel3.TabIndex = 9
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DeleteBtn.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Red
        Me.DeleteBtn.Location = New System.Drawing.Point(513, 182)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(130, 48)
        Me.DeleteBtn.TabIndex = 11
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditBtn.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.Red
        Me.EditBtn.Location = New System.Drawing.Point(334, 182)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(130, 48)
        Me.EditBtn.TabIndex = 10
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AddBtn.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.Red
        Me.AddBtn.Location = New System.Drawing.Point(170, 182)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(130, 48)
        Me.AddBtn.TabIndex = 9
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Red
        Me.TextBox6.Location = New System.Drawing.Point(656, 455)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(186, 42)
        Me.TextBox6.TabIndex = 13
        Me.TextBox6.Text = "Donor's List"
        '
        'DonorsDGV
        '
        Me.DonorsDGV.AllowUserToOrderColumns = True
        Me.DonorsDGV.BackgroundColor = System.Drawing.Color.White
        Me.DonorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DonorsDGV.Location = New System.Drawing.Point(104, 503)
        Me.DonorsDGV.Name = "DonorsDGV"
        Me.DonorsDGV.RowHeadersWidth = 62
        Me.DonorsDGV.RowTemplate.Height = 28
        Me.DonorsDGV.Size = New System.Drawing.Size(1218, 177)
        Me.DonorsDGV.TabIndex = 12
        '
        'Donors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1435, 850)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.DonorsDGV)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Donors"
        Me.Text = "Donors"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DonorsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DNameTb As TextBox
    Friend WithEvents DAgeTb As TextBox
    Friend WithEvents DPhoneTb As TextBox
    Friend WithEvents DGenCb As ComboBox
    Friend WithEvents DBGroupCb As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DAddressTb As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DonorsDGV As DataGridView
End Class
