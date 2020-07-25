<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NFCform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NFCform))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.searchBTN = New System.Windows.Forms.Button()
        Me.projectname = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.disapprovedGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.approvedGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.disapprovedGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.approvedGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.LoadingPBOX)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 96)
        Me.Panel1.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.searchBTN)
        Me.Panel6.Controls.Add(Me.projectname)
        Me.Panel6.Controls.Add(Me.KryptonLabel6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 45)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1050, 51)
        Me.Panel6.TabIndex = 612
        '
        'searchBTN
        '
        Me.searchBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.searchBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBTN.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBTN.ForeColor = System.Drawing.Color.White
        Me.searchBTN.Location = New System.Drawing.Point(967, 15)
        Me.searchBTN.Name = "searchBTN"
        Me.searchBTN.Size = New System.Drawing.Size(72, 26)
        Me.searchBTN.TabIndex = 605
        Me.searchBTN.Text = "search"
        Me.searchBTN.UseVisualStyleBackColor = False
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
        Me.projectname.CustomButton.Location = New System.Drawing.Point(160, 1)
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
        Me.projectname.Size = New System.Drawing.Size(184, 25)
        Me.projectname.TabIndex = 606
        Me.projectname.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.projectname.UseCustomBackColor = True
        Me.projectname.UseCustomForeColor = True
        Me.projectname.UseSelectable = True
        Me.projectname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.projectname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(715, 16)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(63, 20)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Ivory
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 607
        Me.KryptonLabel6.Values.Text = "PROJECT"
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(964, 4)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(74, 36)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 609
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 14)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(194, 26)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 608
        Me.KryptonLabel2.Values.Text = "NOTICE FOR CLEANING"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1050, 366)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 8
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1042, 328)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Disapproved"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.disapprovedGV)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1036, 322)
        Me.Panel12.TabIndex = 6
        '
        'disapprovedGV
        '
        Me.disapprovedGV.AllowUserToAddRows = False
        Me.disapprovedGV.AllowUserToDeleteRows = False
        Me.disapprovedGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.disapprovedGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.disapprovedGV.ColumnHeadersHeight = 32
        Me.disapprovedGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.disapprovedGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.disapprovedGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.disapprovedGV.Location = New System.Drawing.Point(0, 39)
        Me.disapprovedGV.MultiSelect = False
        Me.disapprovedGV.Name = "disapprovedGV"
        Me.disapprovedGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.disapprovedGV.RowHeadersWidth = 30
        Me.disapprovedGV.RowTemplate.Height = 35
        Me.disapprovedGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.disapprovedGV.Size = New System.Drawing.Size(1036, 283)
        Me.disapprovedGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.disapprovedGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.disapprovedGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.disapprovedGV.StateCommon.DataCell.Border.Width = 0
        Me.disapprovedGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disapprovedGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.disapprovedGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.disapprovedGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.disapprovedGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.disapprovedGV.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.disapprovedGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.disapprovedGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.disapprovedGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.disapprovedGV.TabIndex = 614
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel13.Controls.Add(Me.KryptonLabel10)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1036, 39)
        Me.Panel13.TabIndex = 2
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(12, 6)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(266, 26)
        Me.KryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.KryptonLabel10.TabIndex = 604
        Me.KryptonLabel10.Values.Text = "Pending/Hold/Subject for approval"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1042, 328)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Approved"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.approvedGV)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1036, 322)
        Me.Panel7.TabIndex = 5
        '
        'approvedGV
        '
        Me.approvedGV.AllowUserToAddRows = False
        Me.approvedGV.AllowUserToDeleteRows = False
        Me.approvedGV.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.approvedGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.approvedGV.ColumnHeadersHeight = 32
        Me.approvedGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.approvedGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.approvedGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.approvedGV.Location = New System.Drawing.Point(0, 39)
        Me.approvedGV.MultiSelect = False
        Me.approvedGV.Name = "approvedGV"
        Me.approvedGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.approvedGV.RowHeadersWidth = 30
        Me.approvedGV.RowTemplate.Height = 35
        Me.approvedGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.approvedGV.Size = New System.Drawing.Size(1036, 283)
        Me.approvedGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.approvedGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.approvedGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.approvedGV.StateCommon.DataCell.Border.Width = 0
        Me.approvedGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approvedGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.approvedGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.approvedGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.approvedGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.approvedGV.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.approvedGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.approvedGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.approvedGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.approvedGV.TabIndex = 614
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel8.Controls.Add(Me.KryptonLabel1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1036, 39)
        Me.Panel8.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 6)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(155, 26)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.KryptonLabel1.TabIndex = 604
        Me.KryptonLabel1.Values.Text = "Approved summary"
        '
        'NFCform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 462)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NFCform"
        Me.Text = "NFCform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.disapprovedGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.approvedGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents searchBTN As Button
    Friend WithEvents projectname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel12 As Panel
    Friend WithEvents disapprovedGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel13 As Panel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents approvedGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
