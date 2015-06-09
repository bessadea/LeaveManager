Imports System.Windows.Forms.Calendar

Public Class MDI_VIEW
    Dim lst As New List(Of BarInformation)
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        TreeView1.Nodes.Clear()
        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        upcmd.Connection = connection
        upcmd.CommandText = "SELECT Nom FROM [User]"
        Try
            dr = upcmd.ExecuteReader()
            While dr.Read()

                TreeView1.Nodes.Add(dr.Item(0))

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        With GanttChart1
            .FromDate = New Date(Now.Year, Now.Month, 1, 0, 0, 0)
            .ToDate = New Date(Now.Year, Now.Month + 2, 1, 0, 0, 0)
            LBL_DATE.Text = .FromDate.Month & "/" & .FromDate.Year
            LBL_DATE.Text &= "->" & .ToDate.Month & "/" & .ToDate.Year
            .BackColor = Color.LightGray
            ''Dim lst As New List(Of BarInformation)

            'lst.Add(New BarInformation("Row 1", New Date(2015, 6, 12), New Date(2015, 6, 16), Color.Aqua, Color.Khaki, 0))
            'lst.Add(New BarInformation("Row 2", New Date(2007, 12, 13), New Date(2007, 12, 20), Color.AliceBlue, Color.Khaki, 1))
            'lst.Add(New BarInformation("Row 3", New Date(2007, 12, 14), New Date(2007, 12, 24), Color.Violet, Color.Khaki, 2))
            'lst.Add(New BarInformation("Row 2", New Date(2007, 12, 21), New Date(2007, 12, 22, 12, 0, 0), Color.Yellow, Color.Khaki, 1))
            'lst.Add(New BarInformation("Row 1", New Date(2007, 12, 17), New Date(2007, 12, 24), Color.LawnGreen, Color.Khaki, 0))

            'For Each bar As BarInformation In lst
            '    .AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index)
            'Next
        End With
        update()
    End Sub







    Private Sub update()

        Dim b As Boolean
        GanttChart1.RemoveBars()

        LV_List.Items.Clear()
        Dim d As Date = GanttChart1.FromDate
        GanttChart1.FromDate = New Date(1999, 6, 1)
        Dim j As Integer = 0
        For Each i As TreeNode In TreeView1.Nodes
            Dim indexnom, prenom As String
            '1 . on retrouve l index associé au nom
            Dim upcmd As New OleDbCommand
            Dim dr As OleDbDataReader
            upcmd.Connection = connection
            upcmd.CommandText = "SELECT index,prenom FROM [User] where Nom='" & i.Text & "'"
            Try
                dr = upcmd.ExecuteReader()
                dr.Read()
                indexnom = dr.Item(0)
                prenom = dr.Item(1)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '2. on retrouve les congés
            upcmd = New OleDbCommand
            upcmd.Connection = connection
            upcmd.CommandText = "SELECT startDate,toDate,typeIndex,total,index FROM [ListLeave] where userIndex=" & indexnom & ""
            Try
                dr = upcmd.ExecuteReader()
                b = False
                While dr.Read()
                    b = True
                    Dim df As Date = dr.Item(0)
                    Dim dt As Date = dr.Item(1)



                    lst.Add(New BarInformation(i.Text, New Date(df.Year, df.Month, df.Day, 6, 0, 0), New Date(dt.Year, dt.Month, dt.Day, 21, 0, 0), Color.Aqua, Color.Khaki, j))

                    Dim lvi As ListViewItem = LV_List.Items.Add(i.Text)
                    lvi.SubItems.Add(prenom)
                    lvi.SubItems.Add(dr.Item(0))
                    lvi.SubItems.Add(dr.Item(1))
                    lvi.SubItems.Add(dr.Item(2))
                    lvi.SubItems.Add(dr.Item(3))
                    lvi.SubItems.Add(dr.Item(4))
                End While
                If b Then j += 1
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next
        GanttChart1.FromDate = d
       
        For Each bar As BarInformation In lst
            If bar.FromTime > GanttChart1.ToDate Or _
               bar.ToTime < GanttChart1.FromDate Then
            Else
                GanttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index)
                GanttChart1.Refresh()
            End If
        Next
    End Sub



    Private Sub GanttChart1_MouseWheel(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel1.MouseWheel
        LBL_DATE.Text = e.Delta / 120

        ' Exit Sub
        Dim d As Date = GanttChart1.FromDate
        d = DateAdd(DateInterval.Month, e.Delta / 120, d)
        GanttChart1.FromDate = New Date(d.Year, d.Month, 1, 0, 0, 0)
        d = DateAdd(DateInterval.Month, NUD_Mo.Value, d)
        GanttChart1.ToDate = New Date(d.Year, d.Month, 1, 0, 0, 0)
        GanttChart1.Refresh()
        LBL_DATE.Text = GanttChart1.FromDate.Month & "/" & GanttChart1.FromDate.Year
        LBL_DATE.Text &= "->" & GanttChart1.ToDate.Month & "/" & GanttChart1.ToDate.Year
        GanttChart1.RemoveBars()
        For Each bar As BarInformation In lst
            If bar.FromTime > GanttChart1.ToDate Or _
                bar.ToTime < GanttChart1.FromDate Then
            Else
                GanttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index)
                GanttChart1.Refresh()
            End If


            
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GanttChart1.RemoveBars()
    End Sub

    Private Sub LV_List_ItemActivate(sender As Object, e As EventArgs) Handles LV_List.ItemActivate
        Dim a As New MDI_UpdateLeave
        a.DisplayLeave(LV_List.SelectedItems(0).SubItems(6).Text)
        a.Visible = True
    End Sub

   
    'Private Sub GanttChart1_MouseMove(sender As Object, e As MouseEventArgs) Handles GanttChart1.MouseMove
    '    With GanttChart1
    '        Dim toolTipText As New List(Of String)

    '        If .MouseOverRowText.Length > 0 Then
    '            Dim val As BarInformation = CType(.MouseOverRowValue, BarInformation)
    '            toolTipText.Add("[b]Time:")
    '            toolTipText.Add("From " & val.FromTime.ToString("HH:mm"))
    '            toolTipText.Add("To " & val.ToTime.ToString("HH:mm"))
    '        Else
    '            toolTipText.Add("")
    '        End If

    '        .ToolTipTextTitle = .MouseOverRowText
    '        .ToolTipText = toolTipText

    '    End With
    'End Sub

    Private Sub DT_FROM_ValueChanged(sender As Object, e As EventArgs) Handles DT_FROM.ValueChanged, NUD_Mo.ValueChanged
        Dim d As Date = GanttChart1.FromDate

        GanttChart1.FromDate = New Date(DT_FROM.Value.Year, DT_FROM.Value.Month, 1)

        GanttChart1.ToDate = DateAdd(DateInterval.Month, NUD_Mo.Value, DT_FROM.Value)
        GanttChart1.Refresh()
        LBL_DATE.Text = GanttChart1.FromDate.Month & "/" & GanttChart1.FromDate.Year
        LBL_DATE.Text &= "->" & GanttChart1.ToDate.Month & "/" & GanttChart1.ToDate.Year
        GanttChart1.RemoveBars()
        For Each bar As BarInformation In lst
            If bar.FromTime > GanttChart1.ToDate Or _
                bar.ToTime < GanttChart1.FromDate Then
            Else
                GanttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index)
                GanttChart1.Refresh()
            End If



        Next
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            GanttChart1.SaveImage(SFD.FileName)

        End If

    End Sub
End Class