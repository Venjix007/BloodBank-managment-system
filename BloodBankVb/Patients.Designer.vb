<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patients))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.PBGroupCb = New System.Windows.Forms.ComboBox()
        Me.PAddressTb = New System.Windows.Forms.TextBox()
        Me.PnameTb = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PAgeTb = New System.Windows.Forms.TextBox()
        Me.PPhoneTb = New System.Windows.Forms.TextBox()
        Me.PGenCb = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.PatientsDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PatientsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1866, 174)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1237, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 62)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(365, 107)
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
        Me.Label6.Location = New System.Drawing.Point(1100, 128)
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
        Me.Label4.Location = New System.Drawing.Point(817, 128)
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
        Me.Label3.Location = New System.Drawing.Point(371, 127)
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
        Me.Label5.Location = New System.Drawing.Point(593, 128)
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
        Me.Label1.Location = New System.Drawing.Point(136, 127)
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
        Me.Label2.Location = New System.Drawing.Point(413, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Blood Bank Management System"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DeleteBtn)
        Me.Panel3.Controls.Add(Me.EditBtn)
        Me.Panel3.Controls.Add(Me.AddBtn)
        Me.Panel3.Controls.Add(Me.PBGroupCb)
        Me.Panel3.Controls.Add(Me.PAddressTb)
        Me.Panel3.Controls.Add(Me.PnameTb)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.PAgeTb)
        Me.Panel3.Controls.Add(Me.PPhoneTb)
        Me.Panel3.Controls.Add(Me.PGenCb)
        Me.Panel3.Location = New System.Drawing.Point(87, 178)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1186, 278)
        Me.Panel3.TabIndex = 10
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DeleteBtn.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Red
        Me.DeleteBtn.Location = New System.Drawing.Point(512, 212)
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
        Me.EditBtn.Location = New System.Drawing.Point(334, 212)
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
        Me.AddBtn.Location = New System.Drawing.Point(168, 212)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(130, 48)
        Me.AddBtn.TabIndex = 9
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'PBGroupCb
        '
        Me.PBGroupCb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBGroupCb.ForeColor = System.Drawing.Color.Red
        Me.PBGroupCb.FormattingEnabled = True
        Me.PBGroupCb.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.PBGroupCb.Location = New System.Drawing.Point(736, 32)
        Me.PBGroupCb.Name = "PBGroupCb"
        Me.PBGroupCb.Size = New System.Drawing.Size(211, 42)
        Me.PBGroupCb.TabIndex = 6
        Me.PBGroupCb.Text = "Blood Group"
        '
        'PAddressTb
        '
        Me.PAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PAddressTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAddressTb.ForeColor = System.Drawing.Color.Red
        Me.PAddressTb.Location = New System.Drawing.Point(970, 82)
        Me.PAddressTb.Multiline = True
        Me.PAddressTb.Name = "PAddressTb"
        Me.PAddressTb.Size = New System.Drawing.Size(186, 94)
        Me.PAddressTb.TabIndex = 8
        '
        'PnameTb
        '
        Me.PnameTb.BackColor = System.Drawing.Color.White
        Me.PnameTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnameTb.ForeColor = System.Drawing.Color.Red
        Me.PnameTb.Location = New System.Drawing.Point(9, 32)
        Me.PnameTb.Name = "PnameTb"
        Me.PnameTb.Size = New System.Drawing.Size(199, 42)
        Me.PnameTb.TabIndex = 2
        Me.PnameTb.Text = "Patient Name"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Red
        Me.TextBox4.Location = New System.Drawing.Point(970, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(186, 42)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = "Address"
        '
        'PAgeTb
        '
        Me.PAgeTb.BackColor = System.Drawing.Color.White
        Me.PAgeTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAgeTb.ForeColor = System.Drawing.Color.Red
        Me.PAgeTb.Location = New System.Drawing.Point(244, 32)
        Me.PAgeTb.Name = "PAgeTb"
        Me.PAgeTb.Size = New System.Drawing.Size(90, 42)
        Me.PAgeTb.TabIndex = 3
        Me.PAgeTb.Text = "Age"
        '
        'PPhoneTb
        '
        Me.PPhoneTb.BackColor = System.Drawing.Color.White
        Me.PPhoneTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPhoneTb.ForeColor = System.Drawing.Color.Red
        Me.PPhoneTb.Location = New System.Drawing.Point(538, 32)
        Me.PPhoneTb.Name = "PPhoneTb"
        Me.PPhoneTb.Size = New System.Drawing.Size(170, 42)
        Me.PPhoneTb.TabIndex = 4
        Me.PPhoneTb.Text = "Phone"
        '
        'PGenCb
        '
        Me.PGenCb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PGenCb.ForeColor = System.Drawing.Color.Red
        Me.PGenCb.FormattingEnabled = True
        Me.PGenCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.PGenCb.Location = New System.Drawing.Point(368, 32)
        Me.PGenCb.Name = "PGenCb"
        Me.PGenCb.Size = New System.Drawing.Size(152, 42)
        Me.PGenCb.TabIndex = 5
        Me.PGenCb.Text = "Gender"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Red
        Me.TextBox6.Location = New System.Drawing.Point(609, 479)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(186, 42)
        Me.TextBox6.TabIndex = 14
        Me.TextBox6.Text = "Patient's List"
        '
        'PatientsDGV
        '
        Me.PatientsDGV.AllowUserToOrderColumns = True
        Me.PatientsDGV.BackgroundColor = System.Drawing.Color.White
        Me.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientsDGV.Location = New System.Drawing.Point(87, 527)
        Me.PatientsDGV.Name = "PatientsDGV"
        Me.PatientsDGV.RowHeadersWidth = 62
        Me.PatientsDGV.RowTemplate.Height = 28
        Me.PatientsDGV.Size = New System.Drawing.Size(1186, 208)
        Me.PatientsDGV.TabIndex = 15
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1468, 850)
        Me.Controls.Add(Me.PatientsDGV)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patients"
        Me.Text = "Patients"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PatientsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents PBGroupCb As ComboBox
    Friend WithEvents PAddressTb As TextBox
    Friend WithEvents PnameTb As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PAgeTb As TextBox
    Friend WithEvents PPhoneTb As TextBox
    Friend WithEvents PGenCb As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents PatientsDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
