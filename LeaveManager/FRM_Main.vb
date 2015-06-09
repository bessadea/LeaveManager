Public Class FRM_Main


    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        If IO.File.Exists(My.Settings.RSS_PATH_DB) = False Then
            OFD.Filter = "Access DataBase |*.mdb"
            OFD.FileName = "*.mdb"
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Settings.RSS_PATH_DB = OFD.FileName
            Else
                End
            End If
        End If
        'Provider = Microsoft
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" & _
                                                      My.Settings.RSS_PATH_DB)

        connection.Open()
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim a_MDI_NEW As MDI_USER

        For Each frm In Me.MdiChildren
            If frm.GetType = MDI_USER.GetType Then
                frm.Focus()
                Exit Sub
            End If
        Next

        a_MDI_NEW = New MDI_USER
        a_MDI_NEW.MdiParent = Me



        a_MDI_NEW.WindowState = FormWindowState.Maximized
        a_MDI_NEW.Show()
    End Sub

    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        Dim a_MDI_NEW As MDI_NewLeave

        For Each frm In Me.MdiChildren
            If frm.GetType = MDI_NewLeave.GetType Then
                frm.Focus()
                Exit Sub
            End If
        Next

        a_MDI_NEW = New MDI_NewLeave
        a_MDI_NEW.MdiParent = Me



        a_MDI_NEW.WindowState = FormWindowState.Maximized
        a_MDI_NEW.Show()
    End Sub

    Private Sub CalendarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalendarToolStripMenuItem.Click
        Dim a_MDI_NEW As MDI_VIEW

        For Each frm In Me.MdiChildren
            If frm.GetType = MDI_VIEW.GetType Then
                frm.Focus()
                Exit Sub
            End If
        Next

        a_MDI_NEW = New MDI_VIEW
        a_MDI_NEW.MdiParent = Me



        a_MDI_NEW.WindowState = FormWindowState.Maximized
        a_MDI_NEW.Show()
    End Sub
End Class