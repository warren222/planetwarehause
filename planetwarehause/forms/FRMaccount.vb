Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FRMaccount
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim bs As New BindingSource
    Dim ds As New DataSet
    Dim sql As New sql
    Dim condition As String
    Private Sub FRMaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        GV.DataSource = bs
        starter("getdata")
    End Sub
    Private Sub starter(act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "getdata"
                getdata()
                bgw.ReportProgress(0)
            Case "addnew"
                addnew()
                bgw.ReportProgress(0)
            Case "delete"
                For i As Integer = 0 To idlist.Count - 1
                    delete(idlist(i).ToString)
                Next
                bgw.ReportProgress(0)
            Case "save"
                save()
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "getdata"
                GV.Columns.Clear()
                bs.DataSource = ds
                bs.DataMember = "WAREHOUSEaccounttb"
                Dim btn As New DataGridViewButtonColumn
                With btn
                    .Name = "btn"
                    .Text = "edit"
                    .HeaderText = ""
                    .UseColumnTextForButtonValue = True
                    .Width = 100
                End With
                GV.Columns.Insert(0, btn)
            Case "addnew"
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "getdata"
                LoadingPBOX.Visible = False
                With GV

                    .Columns("username").Visible = False
                    .Columns("password").Visible = False
                End With
            Case "addnew"
                starter("getdata")
            Case "delete"
                starter("getdata")
            Case "save"
                starter("getdata")
                BTNcancel.PerformClick()
        End Select
    End Sub
    Private Sub getdata()
        Try
            ds = New DataSet
            ds.Clear()
            Dim str As String = "select * from WAREHOUSEaccounttb"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "WAREHOUSEaccounttb")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub addnew()
        Try
            Dim str As String = "declare @id as integer = (select isnull(max(isnull(id,0)),0)+1 from WAREHOUSEaccounttb)
                                 insert into WAREHOUSEaccounttb (id,accttype,firstname,surname,username,password)VALUES(@id,'" & _acctypetxt & "','" & _firstnametxt & "','" & _surnametxt & "',@id,@id)"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub delete(ByVal id As String)
        Try
            Dim str As String = "delete from WAREHOUSEaccounttb where id = '" & id & "'"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub save()
        Try
            Dim str As String = "update WAREHOUSEaccounttb set accttype='" & _acctypetxt & "',firstname='" & _firstnametxt & "',surname='" & _surnametxt & "' where id = '" & _id & "'"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BTNreload_Click(sender As Object, e As EventArgs) Handles BTNreload.Click, BTNsave.Click, BTNcancel.Click, BTNdelete.Click
        Select Case sender.name
            Case "BTNreload"
                starter("getdata")
            Case "BTNsave"
                If BTNsave.Text = "add" Then
                    initializedstring()
                    starter("addnew")
                ElseIf BTNsave.Text = "save" Then
                    initializedstring()
                    starter("save")
                End If
            Case "BTNcancel"
                BTNcancel.Visible = False
                BTNsave.Text = "add"
                GV.Enabled = True
            Case "BTNdelete"
                If MessageBox.Show("delete this account?", "continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
                starter("delete")
        End Select
    End Sub
    Dim _acctypetxt As String
    Dim _firstnametxt As String
    Dim _surnametxt As String
    Dim _id As String
    Private Sub initializedstring()
        _acctypetxt = acctype.Text
        _firstnametxt = firstname.Text
        _surnametxt = surname.Text
    End Sub
    Dim idlist As ArrayList
    Sub GV_SelectionChanged(sender As Object, e As EventArgs) Handles GV.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = GV.SelectedRows
        idlist = New ArrayList(rows.Count)
        For Each row As DataGridViewRow In rows
            idlist.Add(row.Cells("id").Value.ToString)
            _id = row.Cells("id").Value.ToString
        Next
    End Sub

    Private Sub GV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellClick
        If e.RowIndex >= 0 And GV.RowCount >= 0 Then
            Dim row As DataGridViewRow = GV.Rows(e.RowIndex)
            If e.ColumnIndex = 0 Then
                BTNsave.Text = "save"
                BTNcancel.Visible = True
                GV.Enabled = False
                acctype.Text = row.Cells("accttype").Value.ToString
                firstname.Text = row.Cells("firstname").Value.ToString
                surname.Text = row.Cells("surname").Value.ToString
            End If
        End If
    End Sub
End Class