Imports System.IO

Public Class MDI_NewLeave
    Public path As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            WB_Data.Navigate(OFD.FileName)
            path = OFD.FileName
        End If
    End Sub

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        CBX_Nom.AutoCompleteCustomSource.Clear()
        CBX_Nom.Items.Clear()
        'CBX_Prenom.AutoCompleteCustomSource.Clear()

        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        upcmd.Connection = connection
        upcmd.CommandText = "SELECT Nom FROM [User]"
        Try
            dr = upcmd.ExecuteReader()
            While dr.Read()
                CBX_Nom.AutoCompleteCustomSource.Add(dr.Item(0))
                CBX_Nom.Items.Add(dr.Item(0))

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        upcmd = New OleDbCommand
        upcmd.Connection = connection


        CBX_Type.AutoCompleteCustomSource.Clear()
        CBX_Type.Items.Clear()

        upcmd.CommandText = "SELECT TypeName FROM [LeaveType]"
        Try
            dr = upcmd.ExecuteReader()
            While dr.Read()
                CBX_Type.AutoCompleteCustomSource.Add(dr.Item(0))
                CBX_Type.Items.Add(dr.Item(0))

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub GOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GOToolStripMenuItem.Click

        If CBX_Nom.Text = "" Then Exit Sub
        If CBX_Type.Text = "" Then Exit Sub
        If TXT_Len.Text = "" Then Exit Sub



        'userIndex,from,to,number,typeIndex,Comment,DATA
        Dim indexUser, indexLType As Integer

        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        upcmd.Connection = connection

        upcmd.CommandText = "Select index from [user] where nom='" & CBX_Nom.Text + "'"
        Try
            If upcmd.Connection.State <> ConnectionState.Open Then upcmd.Connection.Open()
            dr = upcmd.ExecuteReader()
            dr.Read()
            indexUser = dr.Item(0)

            upcmd = New OleDbCommand
            upcmd.Connection = connection
            upcmd.CommandText = "Select index from [LeaveType] where typename='" & CBX_Type.Text + "'"
            dr = upcmd.ExecuteReader()
            dr.Read()
            indexLType = dr.Item(0)





            upcmd = New OleDbCommand
            upcmd.Connection = connection



            upcmd.CommandText = "INSERT INTO [ListLeave] (userIndex,startDate,amstart,pmstart,toDate,amto,pmto,total,typeIndex,Comment" & IIf(path <> "", ",data", "") & ")" & _
                "VALUES(" & indexUser & "," _
                & " '" & DTP_from.Text & "'," _
                & " " & CHK_AMfrom.Checked & "," _
                & " " & CHK_PMfrom.Checked & "," _
                & " '" & DTP_To.Text & "'," _
                & " " & CHK_AMto.Checked & "," _
                & " " & CHK_PMTo.Checked & "," _
                & " " & TXT_Len.Text & "," _
                & " " & indexLType & "," _
                & " '" & TXT_Comment.Text & " '" _
                & ",@file)"

            If path <> "" Then
                Dim fs As New FileStream(path, FileMode.Open, FileAccess.Read)
                Dim byteArr(CInt(fs.Length)) As Byte
                fs.Read(byteArr, 0, fs.Length)
                fs.Close()

                upcmd.Parameters.AddWithValue("@file", byteArr)
            End If
            'upcmd.CommandText = "INSERT INTO [ListLeave] (userIndex,startdate,todate,total) VALUES( 1," & "'" & DTP_from.Text & "', '" & DTP_To.Text & "',1)"

            If upcmd.Connection.State <> ConnectionState.Open Then upcmd.Connection.Open()


            upcmd.ExecuteNonQuery()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        If MsgBox("New one ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TXT_Comment.Text = ""
            TXT_Len.Text = ""
            DTP_from.Value = Date.Now
            CHK_AMfrom.Checked = False
            CHK_PMfrom.Checked = False
            DTP_To.Value = Date.Now
            CHK_AMto.Checked = False
            CHK_PMTo.Checked = False
            CBX_Nom.Text = ""
            CBX_Type.Text = ""
        Else
            Me.Dispose()
        End If

    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim a As String
        Try
            upcmd = New OleDbCommand
            upcmd.Connection = connection
            upcmd.CommandText = "SELECT startdate FROM [ListLeave] " 'WHERE Index=3"
            dr = upcmd.ExecuteReader()
            dr.Read()

            a = dr.GetDateTime(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        MsgBox(a)
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Dispose()

    End Sub
End Class