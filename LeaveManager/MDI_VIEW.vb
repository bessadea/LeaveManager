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
            upcmd.CommandText = "SELECT startDate,toDate,typeIndex,total,index,PM,AM FROM [ListLeave] where userIndex=" & indexnom & ""
            '                           0         1      2         3     4     5  6  
            Try
                dr = upcmd.ExecuteReader()
                b = False
                While dr.Read()
                    b = True
                    Dim df As Date = dr.Item(0)
                    Dim dt As Date = dr.Item(1)

                    Dim fromh, toh As Integer
                    fromh = 6
                    toh = 21
                   
                    Dim colorday, colormid As Color
                    colormid = Color.Red
                  



                    Select Case dr.Item(2)

                        Case 1 'RTT
                            colorday = Color.Green
                            Exit Select
                        Case 2 'cp
                            colorday = Color.Yellow
                            Exit Select
                        Case 3 'health
                            colorday = Color.Blue
                            Exit Select
                        Case 4 'ss
                            colorday = Color.Orange
                            Exit Select
                        Case 5 'famille
                            colorday = Color.Aqua
                            Exit Select
                        Case Else
                            colorday = Color.Red

                    End Select
                    If (dr.Item(5)) Then
                        fromh = 12
                        colormid = colorday
                        colorday = Color.Red
                    End If
                    If (dr.Item(6)) Then
                        toh = 12
                        colormid = colorday
                        colorday = Color.Red
                    End If
                    lst.Add(New BarInformation(i.Text, New Date(df.Year, df.Month, df.Day, fromh, 0, 0), New Date(dt.Year, dt.Month, dt.Day, toh, 0, 0), colorday, colormid, j))

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

   
    Private Sub GanttChart1_MouseMove(sender As Object, e As MouseEventArgs) Handles GanttChart1.MouseMove
        With GanttChart1
            Dim toolTipText As New List(Of String)

            If .MouseOverRowText.Length > 0 Then
                Dim val As BarInformation = CType(.MouseOverRowValue, BarInformation)
                Select Case val.Color
                 
                    Case Color.Green
                        toolTipText.Add("[b]Type: RTT")
                        Exit Select
                    Case Color.Yellow
                        toolTipText.Add("[b]Type:CP")
                        Exit Select
                    Case Color.Blue
                        toolTipText.Add("[b]Type:Health")
                        Exit Select
                    Case Color.Orange
                        toolTipText.Add("[b]Type:Sans Solde")
                        Exit Select
                    Case Color.Aqua
                        toolTipText.Add("[b]Type:Famille")
                        Exit Select
                    Case Else
                        toolTipText.Add("[b]Type:INCONNU ")

                End Select

                toolTipText.Add("[b]Time:")
                toolTipText.Add("From " & val.FromTime.ToString("dd/MM HH:mm"))
                toolTipText.Add("To " & val.ToTime.ToString("dd/MM HH:mm"))
            Else
                toolTipText.Add("")
            End If

            .ToolTipTextTitle = .MouseOverRowText
            .ToolTipText = toolTipText

        End With
    End Sub

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