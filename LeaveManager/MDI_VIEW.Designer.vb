<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_VIEW
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nœud0")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nœud1")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nœud2")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_VIEW))
        Me.DateItem1 = New Pabo.Calendar.DateItem()
        Me.DateItem2 = New Pabo.Calendar.DateItem()
        Me.LV_List = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.NUD_Mo = New System.Windows.Forms.NumericUpDown()
        Me.DT_FROM = New System.Windows.Forms.DateTimePicker()
        Me.LBL_DATE = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GanttChart1 = New LeaveManager.GanttChart()
        Me.GanttChart2 = New LeaveManager.GanttChart()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.NUD_Mo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateItem1
        '
        Me.DateItem1.BackColor1 = System.Drawing.Color.Red
        Me.DateItem1.BackColor2 = System.Drawing.Color.White
        Me.DateItem1.BackgroundImage = Nothing
        Me.DateItem1.BoldedDate = False
        Me.DateItem1.Date = New Date(2015, 6, 10, 0, 0, 0, 0)
        Me.DateItem1.DateColor = System.Drawing.Color.Empty
        Me.DateItem1.Enabled = True
        Me.DateItem1.GradientMode = Pabo.Calendar.mcGradientMode.None
        Me.DateItem1.Image = Nothing
        Me.DateItem1.ImageListIndex = -1
        Me.DateItem1.Pattern = Pabo.Calendar.mcDayInfoRecurrence.None
        Me.DateItem1.Range = New Date(2015, 6, 10, 0, 0, 0, 0)
        Me.DateItem1.Tag = Nothing
        Me.DateItem1.Text = ""
        Me.DateItem1.TextColor = System.Drawing.Color.Empty
        Me.DateItem1.Weekend = False
        '
        'DateItem2
        '
        Me.DateItem2.BackColor1 = System.Drawing.Color.Yellow
        Me.DateItem2.BackColor2 = System.Drawing.Color.White
        Me.DateItem2.BackgroundImage = Nothing
        Me.DateItem2.BoldedDate = False
        Me.DateItem2.Date = New Date(2015, 6, 2, 0, 0, 0, 0)
        Me.DateItem2.DateColor = System.Drawing.Color.Empty
        Me.DateItem2.Enabled = True
        Me.DateItem2.GradientMode = Pabo.Calendar.mcGradientMode.None
        Me.DateItem2.Image = Nothing
        Me.DateItem2.ImageListIndex = -1
        Me.DateItem2.Pattern = Pabo.Calendar.mcDayInfoRecurrence.None
        Me.DateItem2.Range = New Date(2015, 6, 2, 0, 0, 0, 0)
        Me.DateItem2.Tag = Nothing
        Me.DateItem2.Text = ""
        Me.DateItem2.TextColor = System.Drawing.Color.Empty
        Me.DateItem2.Weekend = False
        '
        'LV_List
        '
        Me.LV_List.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LV_List.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LV_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_List.HideSelection = False
        Me.LV_List.Location = New System.Drawing.Point(0, 0)
        Me.LV_List.Name = "LV_List"
        Me.LV_List.Size = New System.Drawing.Size(511, 225)
        Me.LV_List.TabIndex = 2
        Me.LV_List.UseCompatibleStateImageBehavior = False
        Me.LV_List.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Prénom"
        Me.ColumnHeader2.Width = 132
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "De :"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "A :"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Type :"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nbr Jours :"
        Me.ColumnHeader6.Width = 163
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID :"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.EditToolStripMenuItem.Text = "Save as JPG"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NUD_Mo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DT_FROM)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LBL_DATE)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GanttChart1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LV_List)
        Me.SplitContainer1.Size = New System.Drawing.Size(511, 472)
        Me.SplitContainer1.SplitterDistance = 243
        Me.SplitContainer1.TabIndex = 4
        '
        'NUD_Mo
        '
        Me.NUD_Mo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NUD_Mo.Location = New System.Drawing.Point(84, 220)
        Me.NUD_Mo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Mo.Name = "NUD_Mo"
        Me.NUD_Mo.Size = New System.Drawing.Size(58, 20)
        Me.NUD_Mo.TabIndex = 5
        Me.NUD_Mo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DT_FROM
        '
        Me.DT_FROM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DT_FROM.CustomFormat = "M/yy"
        Me.DT_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_FROM.Location = New System.Drawing.Point(4, 220)
        Me.DT_FROM.Name = "DT_FROM"
        Me.DT_FROM.Size = New System.Drawing.Size(68, 20)
        Me.DT_FROM.TabIndex = 4
        '
        'LBL_DATE
        '
        Me.LBL_DATE.AutoSize = True
        Me.LBL_DATE.Location = New System.Drawing.Point(3, 15)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(39, 13)
        Me.LBL_DATE.TabIndex = 3
        Me.LBL_DATE.Text = "Label1"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(23, 23)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(769, 472)
        Me.SplitContainer2.SplitterDistance = 254
        Me.SplitContainer2.TabIndex = 5
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode4.Name = "Nœud0"
        TreeNode4.Text = "Nœud0"
        TreeNode5.Name = "Nœud1"
        TreeNode5.Text = "Nœud1"
        TreeNode6.Checked = True
        TreeNode6.Name = "Nœud2"
        TreeNode6.Text = "Nœud2"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Me.TreeView1.Size = New System.Drawing.Size(254, 472)
        Me.TreeView1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(815, 518)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'GanttChart1
        '
        Me.GanttChart1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GanttChart1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GanttChart1.DateFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GanttChart1.FromDate = New Date(2015, 6, 1, 0, 0, 0, 0)
        Me.GanttChart1.Location = New System.Drawing.Point(0, 0)
        Me.GanttChart1.Name = "GanttChart1"
        Me.GanttChart1.RowFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart1.Size = New System.Drawing.Size(511, 243)
        Me.GanttChart1.TabIndex = 0
        Me.GanttChart1.Text = "GANT"
        Me.GanttChart1.TimeFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart1.ToDate = New Date(2015, 10, 1, 0, 0, 0, 0)
        Me.GanttChart1.ToolTipText = CType(resources.GetObject("GanttChart1.ToolTipText"), System.Collections.Generic.List(Of String))
        Me.GanttChart1.ToolTipTextTitle = ""
        '
        'GanttChart2
        '
        Me.GanttChart2.DateFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart2.FromDate = New Date(CType(0, Long))
        Me.GanttChart2.Location = New System.Drawing.Point(148, 116)
        Me.GanttChart2.Name = "GanttChart2"
        Me.GanttChart2.RowFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart2.Size = New System.Drawing.Size(75, 23)
        Me.GanttChart2.TabIndex = 4
        Me.GanttChart2.Text = "GanttChart2"
        Me.GanttChart2.TimeFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.GanttChart2.ToDate = New Date(CType(0, Long))
        Me.GanttChart2.ToolTipText = CType(resources.GetObject("GanttChart2.ToolTipText"), System.Collections.Generic.List(Of String))
        Me.GanttChart2.ToolTipTextTitle = ""
        '
        'SFD
        '
        Me.SFD.Filter = "Jpeg |*.jpg"
        '
        'MDI_VIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 518)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "MDI_VIEW"
        Me.Text = "MDI_VIEW"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.NUD_Mo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateItem1 As Pabo.Calendar.DateItem
    Friend WithEvents DateItem2 As Pabo.Calendar.DateItem
    Friend WithEvents GanttChart1 As LeaveManager.GanttChart
    Friend WithEvents LV_List As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LBL_DATE As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents GanttChart2 As LeaveManager.GanttChart
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DT_FROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents NUD_Mo As System.Windows.Forms.NumericUpDown
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
End Class
