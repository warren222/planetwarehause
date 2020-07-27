<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMaccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMaccount))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNreload = New System.Windows.Forms.Button()
        Me.BTNdelete = New System.Windows.Forms.Button()
        Me.BTNcancel = New System.Windows.Forms.Button()
        Me.BTNsave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.surename = New System.Windows.Forms.TextBox()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.acctype = New System.Windows.Forms.ComboBox()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.BTNreload)
        Me.Panel1.Controls.Add(Me.BTNdelete)
        Me.Panel1.Controls.Add(Me.BTNcancel)
        Me.Panel1.Controls.Add(Me.BTNsave)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.surename)
        Me.Panel1.Controls.Add(Me.firstname)
        Me.Panel1.Controls.Add(Me.acctype)
        Me.Panel1.Controls.Add(Me.LoadingPBOX)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 151)
        Me.Panel1.TabIndex = 0
        '
        'BTNreload
        '
        Me.BTNreload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNreload.Location = New System.Drawing.Point(665, 107)
        Me.BTNreload.Name = "BTNreload"
        Me.BTNreload.Size = New System.Drawing.Size(75, 33)
        Me.BTNreload.TabIndex = 626
        Me.BTNreload.Text = "reload"
        Me.BTNreload.UseVisualStyleBackColor = True
        '
        'BTNdelete
        '
        Me.BTNdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNdelete.Location = New System.Drawing.Point(584, 107)
        Me.BTNdelete.Name = "BTNdelete"
        Me.BTNdelete.Size = New System.Drawing.Size(75, 33)
        Me.BTNdelete.TabIndex = 625
        Me.BTNdelete.Text = "delete"
        Me.BTNdelete.UseVisualStyleBackColor = True
        '
        'BTNcancel
        '
        Me.BTNcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNcancel.Location = New System.Drawing.Point(503, 107)
        Me.BTNcancel.Name = "BTNcancel"
        Me.BTNcancel.Size = New System.Drawing.Size(75, 33)
        Me.BTNcancel.TabIndex = 624
        Me.BTNcancel.Text = "cancel"
        Me.BTNcancel.UseVisualStyleBackColor = True
        '
        'BTNsave
        '
        Me.BTNsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsave.Location = New System.Drawing.Point(422, 107)
        Me.BTNsave.Name = "BTNsave"
        Me.BTNsave.Size = New System.Drawing.Size(75, 33)
        Me.BTNsave.TabIndex = 623
        Me.BTNsave.Text = "add"
        Me.BTNsave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 622
        Me.Label3.Text = "Account Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(461, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 621
        Me.Label2.Text = "Surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 620
        Me.Label1.Text = "First name"
        '
        'surename
        '
        Me.surename.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surename.Location = New System.Drawing.Point(464, 72)
        Me.surename.Name = "surename"
        Me.surename.Size = New System.Drawing.Size(276, 29)
        Me.surename.TabIndex = 619
        '
        'firstname
        '
        Me.firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(203, 72)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(255, 29)
        Me.firstname.TabIndex = 618
        '
        'acctype
        '
        Me.acctype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acctype.FormattingEnabled = True
        Me.acctype.Items.AddRange(New Object() {"Admin", "User"})
        Me.acctype.Location = New System.Drawing.Point(25, 72)
        Me.acctype.Name = "acctype"
        Me.acctype.Size = New System.Drawing.Size(172, 32)
        Me.acctype.TabIndex = 617
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(688, 3)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(82, 35)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 616
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 398)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(773, 39)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GV)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 151)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(773, 247)
        Me.Panel3.TabIndex = 2
        '
        'GV
        '
        Me.GV.AllowUserToAddRows = False
        Me.GV.AllowUserToDeleteRows = False
        Me.GV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GV.ColumnHeadersHeight = 32
        Me.GV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GV.Location = New System.Drawing.Point(0, 0)
        Me.GV.Name = "GV"
        Me.GV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.GV.RowHeadersWidth = 30
        Me.GV.RowTemplate.Height = 35
        Me.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GV.Size = New System.Drawing.Size(773, 247)
        Me.GV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.GV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.GV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GV.StateCommon.DataCell.Border.Width = 0
        Me.GV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.GV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GV.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.GV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.GV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.GV.TabIndex = 557
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(121, 26)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 852
        Me.KryptonLabel6.Values.Text = "Account From"
        '
        'FRMaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 437)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRMaccount"
        Me.Text = "FRMaccount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents BTNcancel As Button
    Friend WithEvents BTNsave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents surename As TextBox
    Friend WithEvents firstname As TextBox
    Friend WithEvents acctype As ComboBox
    Friend WithEvents BTNreload As Button
    Friend WithEvents BTNdelete As Button
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
