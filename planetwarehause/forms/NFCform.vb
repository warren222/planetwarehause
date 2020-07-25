Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework

Public Class NFCform
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim sql As New sql
    Dim bs As New BindingSource
    Dim approvedbs As New BindingSource
    Dim disapprovedbs As New BindingSource
    Dim ds As New DataSet
    Dim projectnametxt As String
    Dim addcon As String = ""
    Dim nickname As String = KMDIprojectFRM._nickname
    Private Sub NFCform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        approvedGV.DataSource = approvedbs
        disapprovedGV.DataSource = disapprovedbs
        searchBTN.PerformClick()
    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            If action = "LOAD DISAPPROVED" Or action = "LOAD APPROVED" Then
                projectnametxt = projectname.Text
            End If
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MetroMessageBox.Show(Me, "Busy please try again later.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Dim fload As Boolean = True
    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "LOAD DISAPPROVED"
                LoadingPBOX.Visible = False
                With disapprovedGV
                    .Columns("ID").Visible = False
                    .Columns("REASON").Visible = False
                    .Columns("ENGRSEEN").Visible = False
                    .Columns("SALESSEEN").Visible = False
                    .Columns("SCREENSEEN").Visible = False
                    .Columns("WSEEN").Visible = False
                End With
                For i As Integer = 0 To disapprovedGV.ColumnCount - 1
                    With disapprovedGV
                        If i = 6 Then
                            .Columns(i).Width = 100
                        Else
                            .Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End If
                    End With
                Next
                Dim x As Integer = 0
                Select Case nickname
                    Case "Noy"
                        For i As Integer = 0 To disapprovedGV.RowCount - 1
                            Dim row As DataGridViewRow = disapprovedGV.Rows(i)
                            If Not row.Cells("wseen").Value.ToString.Contains(nickname) Then
                                newrec(row)
                                x += 1
                            End If
                        Next
                End Select
                If x = 0 Then
                    TabPage3.Text = "Dispproved"
                Else
                    TabPage3.Text = "(" + x.ToString + ") Dispproved"
                End If
                If fload = True Then
                    TabControl1.SelectedIndex = 1
                End If
            Case "LOAD APPROVED"
                LoadingPBOX.Visible = False
                With approvedGV
                    .Columns("ID").Visible = False
                    .Columns("ENGRSEEN").Visible = False
                    .Columns("SALESSEEN").Visible = False
                    .Columns("SCREENSEEN").Visible = False
                    .Columns("WSEEN").Visible = False
                End With
                For i As Integer = 0 To approvedGV.ColumnCount - 1
                    With approvedGV
                        .Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    End With
                Next
                Dim x As Integer = 0
                Select Case nickname
                    Case "Noy"
                        For i As Integer = 0 To approvedGV.RowCount - 1
                            Dim row As DataGridViewRow = approvedGV.Rows(i)
                            If Not row.Cells("wseen").Value.ToString.Contains(nickname) Then
                                newrec(row)
                                x += 1
                            End If
                        Next
                End Select
                If x = 0 Then
                    TabPage4.Text = "Approved"
                Else
                    TabPage4.Text = "(" + x.ToString + ") Approved"
                End If
                If fload = True Then
                    fload = False
                    TabControl1.SelectedIndex = 0
                End If
            Case "SEEN"
                Select Case TabControl1.SelectedIndex
                    Case 0
                        starter("LOAD DISAPPROVED")
                    Case 1
                        starter("LOAD APPROVED")
                End Select
        End Select
    End Sub
    Private Sub newrec(ByVal row As DataGridViewRow)
        row.DefaultCellStyle.BackColor = Color.Orange
        row.DefaultCellStyle.SelectionBackColor = Color.Orange
    End Sub
    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "LOAD APPROVED"
                approvedGV.Columns.Clear()
                approvedbs.DataSource = ds
                approvedbs.DataMember = "NFCREQ"
            Case "LOAD DISAPPROVED"
                disapprovedGV.Columns.Clear()
                disapprovedbs.DataSource = ds
                disapprovedbs.DataMember = "NFCREQ"
                addbtbn(disapprovedGV)
        End Select
    End Sub
    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "LOAD APPROVED"
                queries(action, "NFCREQ", projectnametxt, vbNull)
                bgw.ReportProgress(0)
            Case "LOAD DISAPPROVED"
                queries(action, "NFCREQ", projectnametxt, vbNull)
                bgw.ReportProgress(0)
            Case "SEEN"
                queries(action, "NFCREQ", _idtxt, _SEEN)
        End Select
    End Sub
    Private Sub addbtbn(ByVal gv As Object)
        Select Case gv.name
            Case "disapprovedGV"
                Dim reasonbtn As New DataGridViewButtonColumn
                With reasonbtn
                    .Name = ""
                    .Text = "reason"
                    .UseColumnTextForButtonValue = True
                    .HeaderText = ""
                End With
                With gv.Columns
                    .Insert(6, reasonbtn)
                End With
        End Select
    End Sub
    Private Sub buttonclick(sender As Object, e As EventArgs) Handles searchBTN.Click
        Select Case sender.name
            Case "searchBTN"
                Select Case TabControl1.SelectedIndex
                    Case 0
                        starter("LOAD DISAPPROVED")
                    Case 1
                        starter("LOAD APPROVED")
                End Select
        End Select
    End Sub
    Private Sub queries(ByVal command As String, ByVal TB As String,
                       ByVal projectname As String, ByVal val As String)
        ds = New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                Try
                    sqlcon.Open()
                    With sqlcmd
                        .CommandText = "[COLLECTION_NFCform]"
                        .CommandType = CommandType.StoredProcedure
                        .CommandTimeout = 30000
                        .Parameters.AddWithValue("@command", command)
                        .Parameters.AddWithValue("@projectname", projectname)
                        .Parameters.AddWithValue("@addcon", addcon)
                        .Parameters.AddWithValue("@val", val)
                    End With
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        With da
                            .SelectCommand = sqlcmd
                            .Fill(ds, TB)
                        End With
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    bgw.CancelAsync()
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                starter("LOAD DISAPPROVED")
            Case 1
                starter("LOAD APPROVED")
        End Select
    End Sub
    Dim _idtxt As String
    Dim _reasontxt As String
    Dim _ENGRSEEN As String
    Dim _SALESSEEN As String
    Dim _SCREENSEEN As String
    Dim _WSEEN As String
    Dim _SEEN As String
    Private Sub GV_SelectionChanged(sender As Object, e As EventArgs) Handles approvedGV.SelectionChanged, disapprovedGV.SelectionChanged
        Select Case sender.name
            Case "disapprovedGV"
                Dim rows As DataGridViewSelectedRowCollection = disapprovedGV.SelectedRows
                For Each row As DataGridViewRow In rows
                    _idtxt = row.Cells("id").Value.ToString
                    _reasontxt = row.Cells("reason").Value.ToString
                    _ENGRSEEN = row.Cells("ENGRSEEN").Value.ToString
                    _SALESSEEN = row.Cells("SALESSEEN").Value.ToString
                    _SCREENSEEN = row.Cells("SCREENSEEN").Value.ToString
                    _WSEEN = row.Cells("WSEEN").Value.ToString
                Next
            Case "approvedGV"
                Dim rows As DataGridViewSelectedRowCollection = approvedGV.SelectedRows
                For Each row As DataGridViewRow In rows
                    _idtxt = row.Cells("id").Value.ToString
                    _ENGRSEEN = row.Cells("ENGRSEEN").Value.ToString
                    _SALESSEEN = row.Cells("SALESSEEN").Value.ToString
                    _SCREENSEEN = row.Cells("SCREENSEEN").Value.ToString
                    _WSEEN = row.Cells("WSEEN").Value.ToString
                Next
        End Select
    End Sub
    Private Sub GV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles disapprovedGV.CellClick, approvedGV.CellClick
        Select Case sender.NAME
            Case "disapprovedGV"
                If disapprovedGV.RowCount >= 0 And e.RowIndex >= 0 Then
                    If nickname = "Noy" Then
                        If _WSEEN.Contains(nickname) Then
                        Else
                            _SEEN = "[" + _ENGRSEEN + "[" + "{" + _SALESSEEN + "{" + "|" + _SCREENSEEN + "|" + "\" + _WSEEN + nickname + "\"
                            starter("SEEN")
                        End If
                    End If
                    Dim row As DataGridViewRow = disapprovedGV.Rows(e.RowIndex)
                    Select Case e.ColumnIndex
                        Case 6
                            MessageBox.Show(_reasontxt, "reason", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Select
                End If
            Case "approvedGV"
                If approvedGV.RowCount >= 0 And e.RowIndex >= 0 Then

                    If nickname = "Noy" Then
                        If _WSEEN.Contains(nickname) Then
                        Else
                            _SEEN = "[" + _ENGRSEEN + "[" + "{" + _SALESSEEN + "{" + "|" + _SCREENSEEN + "|" + "\" + _WSEEN + nickname + "\"
                            starter("SEEN")
                        End If
                    End If
                End If
        End Select
    End Sub
End Class