<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KMDIprojectFRM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KMDIprojectFRM))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.pPNL = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.toprow = New System.Windows.Forms.ComboBox()
        Me.searchBTN = New System.Windows.Forms.Button()
        Me.filterall = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.homePNL = New MetroFramework.Controls.MetroTile()
        Me.nfcPNL = New MetroFramework.Controls.MetroTile()
        Me.handletile = New MetroFramework.Controls.MetroTile()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nicknamelabel = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pPNL.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.GV)
        Me.Panel1.Controls.Add(Me.pPNL)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(115, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 422)
        Me.Panel1.TabIndex = 0
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
        Me.GV.Location = New System.Drawing.Point(0, 74)
        Me.GV.Name = "GV"
        Me.GV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.GV.RowHeadersWidth = 30
        Me.GV.RowTemplate.Height = 35
        Me.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GV.Size = New System.Drawing.Size(795, 348)
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
        Me.GV.TabIndex = 556
        '
        'pPNL
        '
        Me.pPNL.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pPNL.Controls.Add(Me.KryptonLabel1)
        Me.pPNL.Controls.Add(Me.toprow)
        Me.pPNL.Controls.Add(Me.searchBTN)
        Me.pPNL.Controls.Add(Me.filterall)
        Me.pPNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.pPNL.Location = New System.Drawing.Point(0, 33)
        Me.pPNL.Name = "pPNL"
        Me.pPNL.Size = New System.Drawing.Size(795, 41)
        Me.pPNL.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(215, 9)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(35, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 851
        Me.KryptonLabel1.Values.Text = "TOP"
        '
        'toprow
        '
        Me.toprow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.toprow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toprow.FormattingEnabled = True
        Me.toprow.Items.AddRange(New Object() {"100", "500", "1000", "MAX"})
        Me.toprow.Location = New System.Drawing.Point(256, 9)
        Me.toprow.Name = "toprow"
        Me.toprow.Size = New System.Drawing.Size(121, 24)
        Me.toprow.TabIndex = 850
        '
        'searchBTN
        '
        Me.searchBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.searchBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBTN.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBTN.ForeColor = System.Drawing.Color.White
        Me.searchBTN.Location = New System.Drawing.Point(693, 9)
        Me.searchBTN.Name = "searchBTN"
        Me.searchBTN.Size = New System.Drawing.Size(72, 26)
        Me.searchBTN.TabIndex = 849
        Me.searchBTN.Text = "search"
        Me.searchBTN.UseVisualStyleBackColor = False
        '
        'filterall
        '
        Me.filterall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.filterall.CustomButton.Image = Nothing
        Me.filterall.CustomButton.Location = New System.Drawing.Point(278, 1)
        Me.filterall.CustomButton.Name = ""
        Me.filterall.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.filterall.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.filterall.CustomButton.TabIndex = 1
        Me.filterall.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.filterall.CustomButton.UseSelectable = True
        Me.filterall.CustomButton.Visible = False
        Me.filterall.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.filterall.Lines = New String(-1) {}
        Me.filterall.Location = New System.Drawing.Point(383, 8)
        Me.filterall.MaxLength = 32767
        Me.filterall.Name = "filterall"
        Me.filterall.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.filterall.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.filterall.SelectedText = ""
        Me.filterall.SelectionLength = 0
        Me.filterall.SelectionStart = 0
        Me.filterall.Size = New System.Drawing.Size(304, 27)
        Me.filterall.TabIndex = 846
        Me.filterall.UseSelectable = True
        Me.filterall.WaterMark = "random search key"
        Me.filterall.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.filterall.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Panel2.Controls.Add(Me.KryptonLabel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 33)
        Me.Panel2.TabIndex = 0
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(247, 3)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(301, 28)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.KryptonLabel5.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel5.TabIndex = 590
        Me.KryptonLabel5.Values.Text = "Project Table"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.homePNL)
        Me.FlowLayoutPanel1.Controls.Add(Me.nfcPNL)
        Me.FlowLayoutPanel1.Controls.Add(Me.handletile)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 40)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(115, 422)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'homePNL
        '
        Me.homePNL.ActiveControl = Nothing
        Me.homePNL.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.homePNL.Location = New System.Drawing.Point(3, 3)
        Me.homePNL.Name = "homePNL"
        Me.homePNL.Size = New System.Drawing.Size(109, 71)
        Me.homePNL.Style = MetroFramework.MetroColorStyle.Silver
        Me.homePNL.TabIndex = 3
        Me.homePNL.Text = "Home"
        Me.homePNL.TileImage = CType(resources.GetObject("homePNL.TileImage"), System.Drawing.Image)
        Me.homePNL.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.homePNL.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.homePNL.UseSelectable = True
        Me.homePNL.UseTileImage = True
        '
        'nfcPNL
        '
        Me.nfcPNL.ActiveControl = Nothing
        Me.nfcPNL.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.nfcPNL.Location = New System.Drawing.Point(3, 80)
        Me.nfcPNL.Name = "nfcPNL"
        Me.nfcPNL.Size = New System.Drawing.Size(109, 71)
        Me.nfcPNL.Style = MetroFramework.MetroColorStyle.Red
        Me.nfcPNL.TabIndex = 4
        Me.nfcPNL.Text = "NFC"
        Me.nfcPNL.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nfcPNL.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.nfcPNL.UseCustomBackColor = True
        Me.nfcPNL.UseSelectable = True
        Me.nfcPNL.UseTileImage = True
        '
        'handletile
        '
        Me.handletile.ActiveControl = Nothing
        Me.handletile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.handletile.Location = New System.Drawing.Point(3, 157)
        Me.handletile.Name = "handletile"
        Me.handletile.Size = New System.Drawing.Size(109, 71)
        Me.handletile.Style = MetroFramework.MetroColorStyle.Red
        Me.handletile.TabIndex = 5
        Me.handletile.Text = "Handle"
        Me.handletile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.handletile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.handletile.UseCustomBackColor = True
        Me.handletile.UseSelectable = True
        Me.handletile.UseTileImage = True
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(833, 2)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(74, 36)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 850
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(82, 8)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(135, 26)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Ivory
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 851
        Me.KryptonLabel6.Values.Text = "Warehouse App"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 615
        Me.PictureBox1.TabStop = False
        '
        'nicknamelabel
        '
        Me.nicknamelabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nicknamelabel.AutoSize = False
        Me.nicknamelabel.Location = New System.Drawing.Point(507, 8)
        Me.nicknamelabel.Name = "nicknamelabel"
        Me.nicknamelabel.Size = New System.Drawing.Size(327, 26)
        Me.nicknamelabel.StateCommon.ShortText.Color1 = System.Drawing.Color.Ivory
        Me.nicknamelabel.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nicknamelabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.nicknamelabel.TabIndex = 852
        Me.nicknamelabel.Values.Text = "nickname"
        '
        'KMDIprojectFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 462)
        Me.Controls.Add(Me.nicknamelabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.KryptonLabel6)
        Me.Controls.Add(Me.LoadingPBOX)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "KMDIprojectFRM"
        Me.Padding = New System.Windows.Forms.Padding(0, 40, 0, 0)
        Me.Text = "KMDI PROJECTS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pPNL.ResumeLayout(False)
        Me.pPNL.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents filterall As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pPNL As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents homePNL As MetroFramework.Controls.MetroTile
    Friend WithEvents nfcPNL As MetroFramework.Controls.MetroTile
    Friend WithEvents searchBTN As Button
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents toprow As ComboBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nicknamelabel As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents handletile As MetroFramework.Controls.MetroTile
End Class
