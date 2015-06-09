<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_NewLeave
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
        Me.CBX_Nom = New System.Windows.Forms.ComboBox()
        Me.TXT_Comment = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBL_NOM = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WB_Data = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBX_Type = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.TXT_Len = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DTP_from = New System.Windows.Forms.DateTimePicker()
        Me.CHK_AMfrom = New System.Windows.Forms.CheckBox()
        Me.CHK_PMfrom = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DTP_To = New System.Windows.Forms.DateTimePicker()
        Me.CHK_AMto = New System.Windows.Forms.CheckBox()
        Me.CHK_PMTo = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBX_Nom
        '
        Me.CBX_Nom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBX_Nom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBX_Nom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CBX_Nom.FormattingEnabled = True
        Me.CBX_Nom.Location = New System.Drawing.Point(103, 29)
        Me.CBX_Nom.Name = "CBX_Nom"
        Me.CBX_Nom.Size = New System.Drawing.Size(352, 21)
        Me.CBX_Nom.TabIndex = 1
        '
        'TXT_Comment
        '
        Me.TXT_Comment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_Comment.Location = New System.Drawing.Point(103, 223)
        Me.TXT_Comment.Multiline = True
        Me.TXT_Comment.Name = "TXT_Comment"
        Me.TXT_Comment.Size = New System.Drawing.Size(352, 226)
        Me.TXT_Comment.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.65217!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.34783!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TXT_Comment, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LBL_NOM, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CBX_Nom, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TXT_Len, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.WB_Data, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CBX_Type, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(932, 472)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "From :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "To :"
        '
        'LBL_NOM
        '
        Me.LBL_NOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_NOM.AutoSize = True
        Me.LBL_NOM.Location = New System.Drawing.Point(23, 33)
        Me.LBL_NOM.Name = "LBL_NOM"
        Me.LBL_NOM.Size = New System.Drawing.Size(74, 13)
        Me.LBL_NOM.TabIndex = 4
        Me.LBL_NOM.Text = "Nom :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Type :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total  :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Comment  :"
        '
        'WB_Data
        '
        Me.WB_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WB_Data.Location = New System.Drawing.Point(481, 63)
        Me.WB_Data.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB_Data.Name = "WB_Data"
        Me.TableLayoutPanel1.SetRowSpan(Me.WB_Data, 5)
        Me.WB_Data.Size = New System.Drawing.Size(421, 386)
        Me.WB_Data.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(827, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBX_Type
        '
        Me.CBX_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBX_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CBX_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Type.FormattingEnabled = True
        Me.CBX_Type.Location = New System.Drawing.Point(103, 149)
        Me.CBX_Type.Name = "CBX_Type"
        Me.CBX_Type.Size = New System.Drawing.Size(352, 21)
        Me.CBX_Type.TabIndex = 18
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GOToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GOToolStripMenuItem
        '
        Me.GOToolStripMenuItem.Name = "GOToolStripMenuItem"
        Me.GOToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.GOToolStripMenuItem.Text = "SAVE"
        '
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'OFD
        '
        Me.OFD.Filter = "Pdf|*.pdf"
        '
        'TXT_Len
        '
        Me.TXT_Len.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_Len.Location = New System.Drawing.Point(103, 190)
        Me.TXT_Len.Name = "TXT_Len"
        Me.TXT_Len.Size = New System.Drawing.Size(352, 20)
        Me.TXT_Len.TabIndex = 14
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DTP_from)
        Me.FlowLayoutPanel1.Controls.Add(Me.CHK_AMfrom)
        Me.FlowLayoutPanel1.Controls.Add(Me.CHK_PMfrom)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(103, 63)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(352, 34)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'DTP_from
        '
        Me.DTP_from.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DTP_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_from.Location = New System.Drawing.Point(3, 3)
        Me.DTP_from.Name = "DTP_from"
        Me.DTP_from.Size = New System.Drawing.Size(81, 20)
        Me.DTP_from.TabIndex = 3
        '
        'CHK_AMfrom
        '
        Me.CHK_AMfrom.AutoSize = True
        Me.CHK_AMfrom.Location = New System.Drawing.Point(90, 3)
        Me.CHK_AMfrom.Name = "CHK_AMfrom"
        Me.CHK_AMfrom.Size = New System.Drawing.Size(42, 17)
        Me.CHK_AMfrom.TabIndex = 4
        Me.CHK_AMfrom.Text = "AM"
        Me.CHK_AMfrom.UseVisualStyleBackColor = True
        '
        'CHK_PMfrom
        '
        Me.CHK_PMfrom.AutoSize = True
        Me.CHK_PMfrom.Location = New System.Drawing.Point(138, 3)
        Me.CHK_PMfrom.Name = "CHK_PMfrom"
        Me.CHK_PMfrom.Size = New System.Drawing.Size(42, 17)
        Me.CHK_PMfrom.TabIndex = 5
        Me.CHK_PMfrom.Text = "PM"
        Me.CHK_PMfrom.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.DTP_To)
        Me.FlowLayoutPanel2.Controls.Add(Me.CHK_AMto)
        Me.FlowLayoutPanel2.Controls.Add(Me.CHK_PMTo)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(103, 103)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(352, 34)
        Me.FlowLayoutPanel2.TabIndex = 22
        '
        'DTP_To
        '
        Me.DTP_To.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DTP_To.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_To.Location = New System.Drawing.Point(3, 3)
        Me.DTP_To.Name = "DTP_To"
        Me.DTP_To.Size = New System.Drawing.Size(81, 20)
        Me.DTP_To.TabIndex = 3
        '
        'CHK_AMto
        '
        Me.CHK_AMto.AutoSize = True
        Me.CHK_AMto.Location = New System.Drawing.Point(90, 3)
        Me.CHK_AMto.Name = "CHK_AMto"
        Me.CHK_AMto.Size = New System.Drawing.Size(42, 17)
        Me.CHK_AMto.TabIndex = 4
        Me.CHK_AMto.Text = "AM"
        Me.CHK_AMto.UseVisualStyleBackColor = True
        '
        'CHK_PMTo
        '
        Me.CHK_PMTo.AutoSize = True
        Me.CHK_PMTo.Location = New System.Drawing.Point(138, 3)
        Me.CHK_PMTo.Name = "CHK_PMTo"
        Me.CHK_PMTo.Size = New System.Drawing.Size(42, 17)
        Me.CHK_PMTo.TabIndex = 5
        Me.CHK_PMTo.Text = "PM"
        Me.CHK_PMTo.UseVisualStyleBackColor = True
        '
        'MDI_NewLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MDI_NewLeave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI_NewLeave"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBX_Nom As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_Comment As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBL_NOM As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WB_Data As System.Windows.Forms.WebBrowser
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CBX_Type As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_Len As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents DTP_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents CHK_AMto As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_PMTo As System.Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents DTP_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents CHK_AMfrom As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_PMfrom As System.Windows.Forms.CheckBox
End Class
