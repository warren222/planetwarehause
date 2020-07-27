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
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "getdata"
                bs.DataSource = ds
                bs.DataMember = "WAREHOUSEaccounttb"
            Case "addnew"
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "getdata"
                LoadingPBOX.Visible = False
            Case "addnew"
                starter("getdata")
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
                                 insert into WAREHOUSEaccounttb (id,accttype,firstname,surname)VALUES(@id,'" & _acctypetxt & "','" & _firstnametxt & "','" & _surnametxt & "')"
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
                End If

        End Select
    End Sub
    Dim _acctypetxt As String
    Dim _firstnametxt As String
    Dim _surnametxt As String

    Private Sub initializedstring()
        _acctypetxt = acctype.Text
        _firstnametxt = firstname.Text
        _surnametxt = surename.Text
    End Sub
End Class