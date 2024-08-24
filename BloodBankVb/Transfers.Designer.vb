<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transfers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transfers))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TransferBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PatIdCb = New System.Windows.Forms.ComboBox()
        Me.PatNameTb = New System.Windows.Forms.TextBox()
        Me.BGroupTb = New System.Windows.Forms.TextBox()
        Me.AvailableBtn = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 180)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1143, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 62)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(725, 104)
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
        Me.Label6.Location = New System.Drawing.Point(1002, 125)
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
        Me.Label4.Location = New System.Drawing.Point(732, 125)
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
        Me.Label3.Location = New System.Drawing.Point(296, 125)
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
        Me.Label5.Location = New System.Drawing.Point(518, 125)
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
        Me.Label1.Location = New System.Drawing.Point(85, 125)
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
        Me.Label2.Location = New System.Drawing.Point(418, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Blood Bank Management System"
        '
        'TransferBtn
        '
        Me.TransferBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TransferBtn.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferBtn.ForeColor = System.Drawing.Color.Red
        Me.TransferBtn.Location = New System.Drawing.Point(606, 523)
        Me.TransferBtn.Name = "TransferBtn"
        Me.TransferBtn.Size = New System.Drawing.Size(167, 47)
        Me.TransferBtn.TabIndex = 19
        Me.TransferBtn.Text = "Transfer"
        Me.TransferBtn.UseVisualStyleBackColor = True
        Me.TransferBtn.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(584, 268)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 35)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "Name"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Red
        Me.TextBox2.Location = New System.Drawing.Point(810, 268)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 35)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.Text = "Blood Group"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(562, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 38)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Blood Transfer"
        '
        'PatIdCb
        '
        Me.PatIdCb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatIdCb.ForeColor = System.Drawing.Color.Red
        Me.PatIdCb.FormattingEnabled = True
        Me.PatIdCb.Location = New System.Drawing.Point(364, 320)
        Me.PatIdCb.Name = "PatIdCb"
        Me.PatIdCb.Size = New System.Drawing.Size(152, 42)
        Me.PatIdCb.TabIndex = 22
        '
        'PatNameTb
        '
        Me.PatNameTb.BackColor = System.Drawing.Color.White
        Me.PatNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatNameTb.Enabled = False
        Me.PatNameTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatNameTb.ForeColor = System.Drawing.Color.Red
        Me.PatNameTb.Location = New System.Drawing.Point(584, 321)
        Me.PatNameTb.Name = "PatNameTb"
        Me.PatNameTb.Size = New System.Drawing.Size(178, 42)
        Me.PatNameTb.TabIndex = 23
        '
        'BGroupTb
        '
        Me.BGroupTb.BackColor = System.Drawing.Color.White
        Me.BGroupTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BGroupTb.Enabled = False
        Me.BGroupTb.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGroupTb.ForeColor = System.Drawing.Color.Red
        Me.BGroupTb.Location = New System.Drawing.Point(810, 321)
        Me.BGroupTb.Name = "BGroupTb"
        Me.BGroupTb.Size = New System.Drawing.Size(193, 42)
        Me.BGroupTb.TabIndex = 24
        '
        'AvailableBtn
        '
        Me.AvailableBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvailableBtn.AutoSize = True
        Me.AvailableBtn.BackColor = System.Drawing.Color.White
        Me.AvailableBtn.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableBtn.ForeColor = System.Drawing.Color.Red
        Me.AvailableBtn.Location = New System.Drawing.Point(545, 455)
        Me.AvailableBtn.Name = "AvailableBtn"
        Me.AvailableBtn.Size = New System.Drawing.Size(316, 39)
        Me.AvailableBtn.TabIndex = 25
        Me.AvailableBtn.Text = "No Blood Available"
        Me.AvailableBtn.Visible = False
        '
        'Transfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1364, 819)
        Me.Controls.Add(Me.AvailableBtn)
        Me.Controls.Add(Me.BGroupTb)
        Me.Controls.Add(Me.PatNameTb)
        Me.Controls.Add(Me.PatIdCb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TransferBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transfers"
        Me.Text = "Transfers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TransferBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PatIdCb As ComboBox
    Friend WithEvents PatNameTb As TextBox
    Friend WithEvents BGroupTb As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AvailableBtn As Label
End Class
