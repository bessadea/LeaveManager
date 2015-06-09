Imports System.IO

Public Class MDI_UpdateLeave

    Public leaveID As Integer
    Public Sub DisplayLeave(id As Integer)

        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim userIndex As Integer
        Dim typeIndex As Integer
        leaveID = id
        upcmd.Connection = connection
        upcmd.CommandText = "SELECT userIndex,startDate,amstart,pmstart,toDate,amto,pmto,total,typeIndex,Comment,data FROM [ListLeave] where index =" & id
        ' upcmd.CommandText = "SELECT userIndex  FROM [ListLeave] WHERE index =" & id & " "

        Try
            dr = upcmd.ExecuteReader()
            dr.Read()
            userIndex = dr.Item(0)
            typeIndex = dr.Item(8)
            DTP_from.Value = dr.Item(1)
            CHK_AMfrom.Checked = dr.Item(2)
            CHK_PMfrom.Checked = dr.Item(3)

            DTP_To.Value = dr.Item(4)
            CHK_AMto.Checked = dr.Item(5)
            CHK_PMTo.Checked = dr.Item(6)

            TXT_Len.Text = dr.Item(7)
            TXT_Comment.Text = dr.Item(9)

            Dim b() As Byte = dr.Item(10)
            Dim FileStreamObject As New System.IO.FileStream(Directory.GetCurrentDirectory + "\temp.pdf", IO.FileMode.Create, IO.FileAccess.Write)
            FileStreamObject.Write(b, 0, b.Length)
            FileStreamObject.Close()
            WB_Data.Navigate(Directory.GetCurrentDirectory + "\temp.pdf")

        Catch ex As Exception
            MsgBox(ex.Message)
            'Me.Dispose()
        End Try
        upcmd = New OleDbCommand
        upcmd.Connection = connection



        upcmd.CommandText = "SELECT TypeName FROM [LeaveType] where index = " & typeIndex
        Try
            dr = upcmd.ExecuteReader()
            dr.Read()
            CBX_Type.Text = (dr.Item(0))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        upcmd = New OleDbCommand
        upcmd.Connection = connection



        upcmd.CommandText = "SELECT Nom,Prenom FROM [User] where index = " & userIndex
        Try
            dr = upcmd.ExecuteReader()
            dr.Read()

            TXT_Nom.Text = dr.Item(0) & " " & dr.Item(1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
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

        
        'CBX_Prenom.AutoCompleteCustomSource.Clear()

        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader

       
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


        If CBX_Type.Text = "" Then Exit Sub
        If TXT_Len.Text = "" Then Exit Sub



        'userIndex,from,to,number,typeIndex,Comment,DATA
        Dim indexUser, indexLType As Integer

        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        upcmd.Connection = connection


        Try
            If upcmd.Connection.State <> ConnectionState.Open Then upcmd.Connection.Open()

            upcmd.CommandText = "Select index from [LeaveType] where typename='" & CBX_Type.Text + "'"
            dr = upcmd.ExecuteReader()
            dr.Read()
            indexLType = dr.Item(0)





            upcmd = New OleDbCommand
            upcmd.Connection = connection



            upcmd.CommandText = "UPDATE  [ListLeave]  SET " & _
                                "startDate = '" & DTP_from.Text & "'" & _
                                ",amstart = " & CHK_AMfrom.Checked & _
                                ",pmstart = " & CHK_PMfrom.Checked & _
                                ",toDate = '" & DTP_To.Text & "'" & _
                                ",amto = " & CHK_AMto.Checked & _
                                ",pmto = " & CHK_PMTo.Checked & _
                                ",total = '" & TXT_Len.Text & "'" & _
                                ",typeIndex = " & indexLType & _
                                ",Comment = '" & TXT_Comment.Text & "'" & _
                                "WHERE index = " & leaveID

            If upcmd.Connection.State <> ConnectionState.Open Then upcmd.Connection.Open()


            upcmd.ExecuteNonQuery()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
       

    End Sub

  

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Dispose()

    End Sub
End Class