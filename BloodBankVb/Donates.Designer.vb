<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donates))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DonateBtn = New System.Windows.Forms.Button()
        Me.DonorsDGV = New System.Windows.Forms.DataGridView()
        Me.DNameTb = New System.Windows.Forms.TextBox()
        Me.DBGroupTb = New System.Windows.Forms.TextBox()
        Me.BloodDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1430, 174)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1194, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 62)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(620, 107)
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
        Me.Label6.Location = New System.Drawing.Point(1081, 128)
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
        Me.Label4.Location = New System.Drawing.Point(816, 128)
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
        Me.Label3.Location = New System.Drawing.Point(415, 128)
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
        Me.Label5.Location = New System.Drawing.Point(626, 127)
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
        Me.Label1.Location = New System.Drawing.Point(232, 127)
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
        Me.Label2.Location = New System.Drawing.Point(448, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Blood Bank Management System"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(256, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 34)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Blood Stock"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(887, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 34)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Donors' List"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(410, 619)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 42)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "Name"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Red
        Me.TextBox2.Location = New System.Drawing.Point(696, 619)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(202, 42)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "Blood Group"
        '
        'DonateBtn
        '
        Me.DonateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DonateBtn.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonateBtn.ForeColor = System.Drawing.Color.Red
        Me.DonateBtn.Location = New System.Drawing.Point(979, 637)
        Me.DonateBtn.Name = "DonateBtn"
        Me.DonateBtn.Size = New System.Drawing.Size(176, 48)
        Me.DonateBtn.TabIndex = 11
        Me.DonateBtn.Text = "Donate"
        Me.DonateBtn.UseVisualStyleBackColor = True
        '
        'DonorsDGV
        '
        Me.DonorsDGV.AllowUserToOrderColumns = True
        Me.DonorsDGV.BackgroundColor = System.Drawing.Color.White
        Me.DonorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DonorsDGV.Location = New System.Drawing.Point(663, 231)
        Me.DonorsDGV.Name = "DonorsDGV"
        Me.DonorsDGV.RowHeadersWidth = 62
        Me.DonorsDGV.RowTemplate.Height = 28
        Me.DonorsDGV.Size = New System.Drawing.Size(609, 364)
        Me.DonorsDGV.TabIndex = 13
        '
        'DNameTb
        '
        Me.DNameTb.BackColor = System.Drawing.Color.White
        Me.DNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DNameTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNameTb.ForeColor = System.Drawing.Color.Red
        Me.DNameTb.Location = New System.Drawing.Point(410, 667)
        Me.DNameTb.Name = "DNameTb"
        Me.DNameTb.Size = New System.Drawing.Size(186, 42)
        Me.DNameTb.TabIndex = 14
        '
        'DBGroupTb
        '
        Me.DBGroupTb.BackColor = System.Drawing.Color.White
        Me.DBGroupTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DBGroupTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBGroupTb.ForeColor = System.Drawing.Color.Red
        Me.DBGroupTb.Location = New System.Drawing.Point(696, 667)
        Me.DBGroupTb.Name = "DBGroupTb"
        Me.DBGroupTb.Size = New System.Drawing.Size(202, 42)
        Me.DBGroupTb.TabIndex = 15
        '
        'BloodDGV
        '
        Me.BloodDGV.AllowUserToOrderColumns = True
        Me.BloodDGV.BackgroundColor = System.Drawing.Color.White
        Me.BloodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BloodDGV.Location = New System.Drawing.Point(99, 231)
        Me.BloodDGV.Name = "BloodDGV"
        Me.BloodDGV.RowHeadersWidth = 62
        Me.BloodDGV.RowTemplate.Height = 28
        Me.BloodDGV.Size = New System.Drawing.Size(497, 364)
        Me.BloodDGV.TabIndex = 16
        '
        'Donates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1429, 811)
        Me.Controls.Add(Me.BloodDGV)
        Me.Controls.Add(Me.DBGroupTb)
        Me.Controls.Add(Me.DNameTb)
        Me.Controls.Add(Me.DonorsDGV)
        Me.Controls.Add(Me.DonateBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Donates"
        Me.Text = "Donates"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDGV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DonateBtn As Button
    Friend WithEvents DonorsDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DNameTb As TextBox
    Friend WithEvents DBGroupTb As TextBox
    Friend WithEvents BloodDGV As DataGridView
End Class
