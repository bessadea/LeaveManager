Public Class MDI_USER
    Public MyBindingSource As BindingSource
    Public MyBindingSource2 As BindingSource
    Dim myDataSet As DataSet
    Dim myDataSet2 As DataSet
    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        upcmd.Connection = connection
        upcmd.CommandText = "INSERT INTO [User] (Nom, Prenom, Mail, Tel, NombreCP, NombreRTT) " & _
           "VALUES('" & CBX_Nom.Text + "'," _
            & " '" & CBX_Prenom.Text & "'," _
            & " '" & TXT_Mail.Text & "'," _
           & " '" & TXT_Tel.Text & "'," _
           & " '" & TXT_CP.Text & "'," _
           & " '" & TXT_Rtt.Text & "'" _
           & " )"

       
        If upcmd.Connection.State <> ConnectionState.Open Then upcmd.Connection.Open()

        Try
            upcmd.ExecuteNonQuery()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        Connection_to_base()
    End Sub
    Public Sub Connection_to_base()
       
        Try

            Dim oCommand As OleDbCommand = New OleDbCommand("SELECT        Nom, Prenom, Mail, Tel, NombreCP, NombreRTT FROM [User]", connection)

            Dim oAdapter As OleDbDataAdapter = New OleDbDataAdapter(oCommand)

            myDataSet = New DataSet()

            oAdapter.Fill(myDataSet)
            MyBindingSource = New BindingSource()

            MyBindingSource.DataSource = myDataSet

            MyBindingSource.DataMember = myDataSet.Tables(0).TableName

            DG_USER.DataSource = MyBindingSource



            ' DG_USER.DataSource = MyBindingSource2

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        


        DG_USER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DG_USER.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DG_USER.AutoSize = True
        DG_USER.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize


        CBX_Nom.AutoCompleteCustomSource.Clear()
        CBX_Prenom.AutoCompleteCustomSource.Clear()

        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        
        upcmd.Connection = connection
        upcmd.CommandText = "SELECT Nom FROM [User]"
        Try
            dr = upcmd.ExecuteReader()
            While dr.Read()
                CBX_Nom.AutoCompleteCustomSource.Add(dr.Item(0))


            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       


    End Sub

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Connection_to_base()



    End Sub


    
    Private Sub CBX_Nom_KeyUp(sender As Object, e As KeyEventArgs) Handles CBX_Nom.KeyUp
        If e.KeyCode = Keys.Enter Then
            maj(CBX_Nom.Text)
        End If
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        If MsgBox("Update user " & CBX_Nom.Text & "? ", vbYesNo) = MsgBoxResult.Yes Then
            Dim upcmd As New OleDbCommand
            Dim dr As OleDbDataReader
            upcmd.Connection = connection
            upcmd.CommandText = "UPDATE  Nom, Prenom, Mail, Tel, NombreCP, NombreRTT FROM [User] WHERE Nom = '" & CBX_Nom.Text & "'"
            upcmd.CommandText = "UPDATE [User]  SET "

            upcmd.CommandText += "Prenom =  '" & CBX_Prenom.Text & "',"
            upcmd.CommandText += "Mail =  '" & TXT_Mail.Text & "',"
            upcmd.CommandText += "Tel =  '" & TXT_Tel.Text & "',"
            upcmd.CommandText += "NombreCP =  '" & TXT_CP.Text & "',"
            upcmd.CommandText += "NombreRTT =  '" & TXT_Rtt.Text & "'"
            upcmd.CommandText += " WHERE Nom =  '" & CBX_Nom.Text & "'"
            upcmd.ExecuteNonQuery()
            Try
                dr = upcmd.ExecuteReader()
               
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Connection_to_base()
        End If

    End Sub

    Private Sub DG_USER_MouseUp(sender As Object, e As MouseEventArgs) Handles DG_USER.MouseUp
        maj(DG_USER.SelectedCells.Item(0).Value())
        'Name = DG_USER.Se DG_USER.SelectedCells.Item(0).RowIndex
    End Sub
    Public Sub maj(name As String)
        TXT_summury.Text = ""
        Dim upcmd As New OleDbCommand
        Dim dr As OleDbDataReader
        upcmd.Connection = connection
        upcmd.CommandText = "SELECT Nom, Prenom, Mail, Tel, NombreCP, NombreRTT FROM [User] WHERE Nom = '" & name & "'"
        Try
            dr = upcmd.ExecuteReader()
            CBX_Prenom.Text = ""
            TXT_Mail.Text = ""
            TXT_Tel.Text = ""
            TXT_CP.Text = ""
            TXT_Rtt.Text = ""
            While dr.Read()
                CBX_Nom.Text = dr.GetString(0)
                If dr.IsDBNull(1) Then
                    CBX_Prenom.Text = ""
                Else
                    CBX_Prenom.Text = dr.GetString(1)
                End If
                If dr.IsDBNull(2) Then
                    TXT_Mail.Text = ""
                Else
                    TXT_Mail.Text = dr.GetString(2)
                End If
                If dr.IsDBNull(3) Then
                    TXT_Tel.Text = ""
                Else
                    TXT_Tel.Text = dr.GetString(3)
                End If
                If dr.IsDBNull(4) Then
                    TXT_CP.Text = ""
                Else
                    TXT_CP.Text = dr.GetValue(4)
                End If
                If dr.IsDBNull(5) Then
                    TXT_Rtt.Text = ""
                Else
                    TXT_Rtt.Text = dr.GetValue(5)
                End If




            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim indexnom As String
        Dim rtt, cp As Integer
        upcmd = New OleDbCommand
        upcmd.Connection = connection
        upcmd.CommandText = "SELECT Prenom, index,NombreCP, NombreRTT FROM [User]  WHERE Nom = '" & name & "'"
        Try
            dr = upcmd.ExecuteReader()
            While dr.Read()
                'If dr.Item(0) <> vbNull Then CBX_Prenom.AutoCompleteCustomSource.Add(dr.Item(0))
                indexnom = dr.Item(1)
                rtt = dr.Item(3)
                cp = dr.Item(2)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        '2. on retrouve les congés
        Dim b As Boolean
        upcmd = New OleDbCommand
        upcmd.Connection = connection
        upcmd.CommandText = "SELECT startDate,toDate,typeIndex,total,index FROM [ListLeave] where userIndex=" & indexnom
        Try
            dr = upcmd.ExecuteReader()
            b = False
            While dr.Read()
                b = True
                Dim df As Date = dr.Item(0)
                Dim dt As Date = dr.Item(1)



                TXT_summury.Text += " en congé pendant " & dr.Item(3) & "jour(s) du: " & dr.Item(0) & " Au: " & dr.Item(1) & vbCrLf
                If (dr.Item(2) = 1) Then
                    rtt -= dr.Item(3)
                End If
                If (dr.Item(2) = 2) Then
                    cp -= dr.Item(3)
                End If
            End While
            TXT_summury.Text += "*********************************************************************" & vbCrLf
            TXT_summury.Text += "Reste " & cp & " CP & " & rtt & " Rtt"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try











    End Sub

    Private Sub CBX_Nom_TextChanged(sender As Object, e As EventArgs) Handles CBX_Nom.TextChanged
        If CBX_Nom.Text = "" Then
            CBX_Prenom.Text = ""
            TXT_Mail.Text = ""
            TXT_Tel.Text = ""
            TXT_CP.Text = ""
            TXT_Rtt.Text = ""
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        If MsgBox("Delete user " & CBX_Nom.Text & "? ", vbYesNo) = MsgBoxResult.Yes Then
            Dim upcmd As New OleDbCommand
            Dim dr As OleDbDataReader
            upcmd.Connection = connection
            upcmd.CommandText = "DELETE  FROM [User] WHERE Nom = '" & CBX_Nom.Text & "'"
            upcmd.ExecuteNonQuery()
            Try
                dr = upcmd.ExecuteReader()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Connection_to_base()
        End If
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class