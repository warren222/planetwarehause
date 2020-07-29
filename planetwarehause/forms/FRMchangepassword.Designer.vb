<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMchangepassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMchangepassword))
        Me.newusername = New System.Windows.Forms.TextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.retypepassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.oldpassword = New System.Windows.Forms.TextBox()
        Me.BTNsave = New System.Windows.Forms.Button()
        Me.LBLretypeerror = New System.Windows.Forms.Label()
        Me.LBLolpassworderror = New System.Windows.Forms.Label()
        Me.LBLusernameerror = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newusername
        '
        Me.newusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newusername.Location = New System.Drawing.Point(12, 93)
        Me.newusername.Name = "newusername"
        Me.newusername.Size = New System.Drawing.Size(391, 30)
        Me.newusername.TabIndex = 0
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(135, 21)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(155, 26)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 855
        Me.KryptonLabel6.Values.Text = "Update User Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 854
        Me.Label3.Text = "New Username"
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(321, 12)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(82, 35)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 853
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 857
        Me.Label1.Text = "New Password"
        '
        'newpassword
        '
        Me.newpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpassword.Location = New System.Drawing.Point(12, 165)
        Me.newpassword.Name = "newpassword"
        Me.newpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpassword.Size = New System.Drawing.Size(391, 30)
        Me.newpassword.TabIndex = 856
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 859
        Me.Label2.Text = "Retype Password"
        '
        'retypepassword
        '
        Me.retypepassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retypepassword.Location = New System.Drawing.Point(12, 227)
        Me.retypepassword.Name = "retypepassword"
        Me.retypepassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.retypepassword.Size = New System.Drawing.Size(391, 30)
        Me.retypepassword.TabIndex = 858
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 861
        Me.Label4.Text = "Old Password"
        '
        'oldpassword
        '
        Me.oldpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldpassword.Location = New System.Drawing.Point(12, 295)
        Me.oldpassword.Name = "oldpassword"
        Me.oldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpassword.Size = New System.Drawing.Size(391, 30)
        Me.oldpassword.TabIndex = 860
        '
        'BTNsave
        '
        Me.BTNsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsave.Location = New System.Drawing.Point(289, 371)
        Me.BTNsave.Name = "BTNsave"
        Me.BTNsave.Size = New System.Drawing.Size(114, 33)
        Me.BTNsave.TabIndex = 862
        Me.BTNsave.Text = "Update"
        Me.BTNsave.UseVisualStyleBackColor = True
        '
        'LBLretypeerror
        '
        Me.LBLretypeerror.AutoSize = True
        Me.LBLretypeerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLretypeerror.ForeColor = System.Drawing.Color.Red
        Me.LBLretypeerror.Location = New System.Drawing.Point(133, 207)
        Me.LBLretypeerror.Name = "LBLretypeerror"
        Me.LBLretypeerror.Size = New System.Drawing.Size(0, 17)
        Me.LBLretypeerror.TabIndex = 863
        '
        'LBLolpassworderror
        '
        Me.LBLolpassworderror.AutoSize = True
        Me.LBLolpassworderror.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLolpassworderror.ForeColor = System.Drawing.Color.Red
        Me.LBLolpassworderror.Location = New System.Drawing.Point(133, 275)
        Me.LBLolpassworderror.Name = "LBLolpassworderror"
        Me.LBLolpassworderror.Size = New System.Drawing.Size(0, 17)
        Me.LBLolpassworderror.TabIndex = 864
        '
        'LBLusernameerror
        '
        Me.LBLusernameerror.AutoSize = True
        Me.LBLusernameerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLusernameerror.ForeColor = System.Drawing.Color.Red
        Me.LBLusernameerror.Location = New System.Drawing.Point(133, 73)
        Me.LBLusernameerror.Name = "LBLusernameerror"
        Me.LBLusernameerror.Size = New System.Drawing.Size(0, 17)
        Me.LBLusernameerror.TabIndex = 865
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(169, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 33)
        Me.Button1.TabIndex = 866
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRMchangepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBLusernameerror)
        Me.Controls.Add(Me.LBLolpassworderror)
        Me.Controls.Add(Me.LBLretypeerror)
        Me.Controls.Add(Me.BTNsave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.oldpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.retypepassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newpassword)
        Me.Controls.Add(Me.KryptonLabel6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LoadingPBOX)
        Me.Controls.Add(Me.newusername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRMchangepassword"
        Me.Text = "FRMchangepassword"
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newusername As TextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents retypepassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents oldpassword As TextBox
    Friend WithEvents BTNsave As Button
    Friend WithEvents LBLretypeerror As Label
    Friend WithEvents LBLolpassworderror As Label
    Friend WithEvents LBLusernameerror As Label
    Friend WithEvents Button1 As Button
End Class
