<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNdelete = New System.Windows.Forms.Button()
        Me.BTNnew = New System.Windows.Forms.Button()
        Me.BTNedit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.BTNreload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNfind = New System.Windows.Forms.Button()
        Me.TBOXkey = New System.Windows.Forms.TextBox()
        Me.CBXcolumn = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BTNdelete)
        Me.Panel1.Controls.Add(Me.BTNnew)
        Me.Panel1.Controls.Add(Me.BTNedit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LoadingPBOX)
        Me.Panel1.Controls.Add(Me.BTNreload)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 121)
        Me.Panel1.TabIndex = 2
        '
        'BTNdelete
        '
        Me.BTNdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNdelete.Location = New System.Drawing.Point(174, 75)
        Me.BTNdelete.Name = "BTNdelete"
        Me.BTNdelete.Size = New System.Drawing.Size(75, 26)
        Me.BTNdelete.TabIndex = 625
        Me.BTNdelete.Text = "delete"
        Me.BTNdelete.UseVisualStyleBackColor = True
        '
        'BTNnew
        '
        Me.BTNnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNnew.Location = New System.Drawing.Point(12, 75)
        Me.BTNnew.Name = "BTNnew"
        Me.BTNnew.Size = New System.Drawing.Size(75, 26)
        Me.BTNnew.TabIndex = 618
        Me.BTNnew.Text = "new"
        Me.BTNnew.UseVisualStyleBackColor = True
        '
        'BTNedit
        '
        Me.BTNedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNedit.Location = New System.Drawing.Point(93, 75)
        Me.BTNedit.Name = "BTNedit"
        Me.BTNedit.Size = New System.Drawing.Size(75, 26)
        Me.BTNedit.TabIndex = 617
        Me.BTNedit.Text = "edit"
        Me.BTNedit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 39)
        Me.Label1.TabIndex = 616
        Me.Label1.Text = "Handle Inventory Table"
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(980, 0)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(82, 35)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 615
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'BTNreload
        '
        Me.BTNreload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNreload.Location = New System.Drawing.Point(253, 75)
        Me.BTNreload.Name = "BTNreload"
        Me.BTNreload.Size = New System.Drawing.Size(75, 26)
        Me.BTNreload.TabIndex = 0
        Me.BTNreload.Text = "reload"
        Me.BTNreload.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BTNfind)
        Me.GroupBox1.Controls.Add(Me.TBOXkey)
        Me.GroupBox1.Controls.Add(Me.CBXcolumn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(481, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 82)
        Me.GroupBox1.TabIndex = 624
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 623
        Me.Label3.Text = "select column"
        '
        'BTNfind
        '
        Me.BTNfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNfind.Location = New System.Drawing.Point(451, 50)
        Me.BTNfind.Name = "BTNfind"
        Me.BTNfind.Size = New System.Drawing.Size(75, 23)
        Me.BTNfind.TabIndex = 621
        Me.BTNfind.Text = "Find"
        Me.BTNfind.UseVisualStyleBackColor = True
        '
        'TBOXkey
        '
        Me.TBOXkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOXkey.Location = New System.Drawing.Point(166, 50)
        Me.TBOXkey.Name = "TBOXkey"
        Me.TBOXkey.Size = New System.Drawing.Size(279, 23)
        Me.TBOXkey.TabIndex = 619
        '
        'CBXcolumn
        '
        Me.CBXcolumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBXcolumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBXcolumn.FormattingEnabled = True
        Me.CBXcolumn.Items.AddRange(New Object() {"DATED", "PROJECT", "[ADDRESS]", "CLNO", "KNO", "LOCATION", "COLOR", "QTY", "HANDLETYPE", "ADDITIONAL", "[DESCRIPTION]", "RELEASED", "DATERELEASED", "RECEIVEDBY", "CTRLNO"})
        Me.CBXcolumn.Location = New System.Drawing.Point(39, 50)
        Me.CBXcolumn.Name = "CBXcolumn"
        Me.CBXcolumn.Size = New System.Drawing.Size(121, 24)
        Me.CBXcolumn.TabIndex = 620
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 622
        Me.Label2.Text = "Enter text to find"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 359)
        Me.Panel2.TabIndex = 3
        '
        'gv
        '
        Me.gv.AllowUserToAddRows = False
        Me.gv.AllowUserToDeleteRows = False
        Me.gv.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gv.ColumnHeadersHeight = 32
        Me.gv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gv.Location = New System.Drawing.Point(0, 0)
        Me.gv.Name = "gv"
        Me.gv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.gv.RowHeadersWidth = 30
        Me.gv.RowTemplate.Height = 35
        Me.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gv.Size = New System.Drawing.Size(1062, 359)
        Me.gv.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.gv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gv.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.gv.StateCommon.DataCell.Border.Width = 0
        Me.gv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.gv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.gv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.gv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.gv.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.gv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.gv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.gv.TabIndex = 557
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 480)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNdelete As Button
    Friend WithEvents BTNnew As Button
    Friend WithEvents BTNedit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents BTNreload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNfind As Button
    Friend WithEvents TBOXkey As TextBox
    Friend WithEvents CBXcolumn As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
