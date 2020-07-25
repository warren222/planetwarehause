<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginFRM))
        Me.username = New MetroFramework.Controls.MetroTextBox()
        Me.password = New MetroFramework.Controls.MetroTextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.projectname = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'username
        '
        '
        '
        '
        Me.username.CustomButton.Image = Nothing
        Me.username.CustomButton.Location = New System.Drawing.Point(201, 1)
        Me.username.CustomButton.Name = ""
        Me.username.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.username.CustomButton.TabIndex = 1
        Me.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.username.CustomButton.UseSelectable = True
        Me.username.CustomButton.Visible = False
        Me.username.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.username.Lines = New String(-1) {}
        Me.username.Location = New System.Drawing.Point(194, 47)
        Me.username.MaxLength = 32767
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.username.SelectedText = ""
        Me.username.SelectionLength = 0
        Me.username.SelectionStart = 0
        Me.username.Size = New System.Drawing.Size(227, 27)
        Me.username.TabIndex = 847
        Me.username.UseSelectable = True
        Me.username.WaterMark = "USERNAME"
        Me.username.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.username.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'password
        '
        '
        '
        '
        Me.password.CustomButton.Image = Nothing
        Me.password.CustomButton.Location = New System.Drawing.Point(201, 1)
        Me.password.CustomButton.Name = ""
        Me.password.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.password.CustomButton.TabIndex = 1
        Me.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.password.CustomButton.UseSelectable = True
        Me.password.CustomButton.Visible = False
        Me.password.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.password.Lines = New String(-1) {}
        Me.password.Location = New System.Drawing.Point(194, 94)
        Me.password.MaxLength = 32767
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.password.SelectedText = ""
        Me.password.SelectionLength = 0
        Me.password.SelectionStart = 0
        Me.password.Size = New System.Drawing.Size(227, 27)
        Me.password.TabIndex = 848
        Me.password.UseSelectable = True
        Me.password.WaterMark = "PASSWORD"
        Me.password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(349, 144)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(72, 26)
        Me.loginbtn.TabIndex = 849
        Me.loginbtn.Text = "LOGIN"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 852
        Me.PictureBox1.TabStop = False
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(135, 26)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 853
        Me.KryptonLabel6.Values.Text = "Warehouse App"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Controls.Add(Me.projectname)
        Me.Panel6.Controls.Add(Me.KryptonLabel1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 189)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(430, 34)
        Me.Panel6.TabIndex = 854
        '
        'projectname
        '
        Me.projectname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.projectname.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.projectname.CustomButton.Image = Nothing
        Me.projectname.CustomButton.Location = New System.Drawing.Point(-14, 1)
        Me.projectname.CustomButton.Name = ""
        Me.projectname.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.projectname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.projectname.CustomButton.TabIndex = 1
        Me.projectname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.projectname.CustomButton.UseSelectable = True
        Me.projectname.CustomButton.Visible = False
        Me.projectname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.projectname.Lines = New String(-1) {}
        Me.projectname.Location = New System.Drawing.Point(784, 16)
        Me.projectname.MaxLength = 32767
        Me.projectname.Name = "projectname"
        Me.projectname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.projectname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.projectname.SelectedText = ""
        Me.projectname.SelectionLength = 0
        Me.projectname.SelectionStart = 0
        Me.projectname.Size = New System.Drawing.Size(10, 25)
        Me.projectname.TabIndex = 606
        Me.projectname.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.projectname.UseCustomBackColor = True
        Me.projectname.UseCustomForeColor = True
        Me.projectname.UseSelectable = True
        Me.projectname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.projectname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(19, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(314, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Ivory
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 607
        Me.KryptonLabel1.Values.Text = "Kenneth and Mock Windows and Doors App © 2020"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(194, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(103, 21)
        Me.RadioButton1.TabIndex = 855
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "local access"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(304, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(118, 21)
        Me.RadioButton2.TabIndex = 856
        Me.RadioButton2.Text = "remote access"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'loginFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 223)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.KryptonLabel6)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "loginFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log in"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username As MetroFramework.Controls.MetroTextBox
    Friend WithEvents password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents projectname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
