Imports System.ComponentModel
Imports System.Data.SqlClient
Imports ComponentFactory.Krypton.Toolkit
Public Class KMDIprojectFRM
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim bgw As New BackgroundWorker
    Dim action As String = ""
    Dim _rowlimit As String = ""
    Public Shared _nickname As String
    Dim sql As New sql
    Dim bs As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_progresschanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        GV.DataSource = bs
        toprow.SelectedIndex = 0
        nicknamelabel.Text = "Hi! " + _nickname
        starter("LOAD CONTRACTS")
        If _nickname = "Noy" Then
            wait(1)
            starter("NOTI")
        End If
    End Sub
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Function notification() As Integer
        Dim x As Integer
        Dim str As String = "
 declare @wseen as integer =(
select count(WSEEN) from (
select substring(A.SEENBY,charindex('\',A.SEENBY)+1,charindex('\',A.SEENBY,charindex('\',A.SEENBY)+1)-charindex('\',A.SEENBY)-1) as [WSEEN]
			 from NFCREQ as a
where parentjono in (select distinct PARENTJONO from ADDENDUM_TO_CONTRACT_TB)
and a.approved <> '' or a.disapproved <> '') as tb where not WSEEN like '%" & _nickname & "%')

SELECT @wseen"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Using dr As SqlDataReader = sqlcmd.ExecuteReader
                        While dr.Read
                            x = dr(0)
                        End While
                    End Using
                Catch ex As Exception
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
        Return x
    End Function
    Public Sub rowpostpaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles GV.RowPostPaint
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Microsoft Sans Serif", 8.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
    Public Sub starter(ByVal act As String)
        If bgw.IsBusy <> True Then
            action = act
            LoadingPBOX.Visible = True
            If toprow.Text = "MAX" Then
                _rowlimit = ""
            Else
                _rowlimit = " top " & toprow.Text & ""
            End If
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show("i am busy try again later", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "LOAD CONTRACTS"
                LoadingPBOX.Visible = False
                For i As Integer = 0 To GV.RowCount - 1
                    Dim row As DataGridViewRow = GV.Rows(i)
                    If row.Cells("lock").Value.ToString = "1" Then
                        row.DefaultCellStyle.BackColor = Color.DarkGray
                        row.DefaultCellStyle.SelectionBackColor = Color.DarkGray
                    End If
                Next
            Case "NOTI"
                LoadingPBOX.Visible = False
                wait(1)
                starter("NOTI")
        End Select
    End Sub

    Private Sub bgw_progresschanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "LOAD CONTRACTS"
                bs.DataSource = ds
                bs.DataMember = "ADDENDUM_TO_CONTRACT_TB"
            Case "NOTI"
                nfcPNL.Refresh()
                nfcPNL.TileCount = notification()
                If nfcPNL.TileCount = 0 Then
                    With nfcPNL
                        .UseCustomBackColor = True
                        .UseTileImage = True
                    End With
                Else
                    With nfcPNL
                        .UseCustomBackColor = False
                        .UseTileImage = False
                    End With
                End If
        End Select
    End Sub

    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "LOAD CONTRACTS"
                QUERIES("ADDENDUM_TO_CONTRACT_TB", "LOAD CONTRACTS", filterall.Text)
                bgw.ReportProgress(0)
            Case "NOTI"
                notification()
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles searchBTN.Click, nfcPNL.Click, handletile.Click, accountstile.Click
        Select Case sender.name
            Case "searchBTN"
                starter("LOAD CONTRACTS")
            Case "nfcPNL"
                If Application.OpenForms.OfType(Of NFCform).Any Then
                    NFCform.Dispose()
                End If
                NFCform.Show()
            Case "handletile"
                If Application.OpenForms.OfType(Of Form1).Any Then
                    Form1.Dispose()
                End If
                Form1.Show()
            Case "accountstile"
                If Application.OpenForms.OfType(Of FRMaccount).Any Then
                    FRMaccount.Dispose()
                End If
                FRMaccount.Show()
        End Select
    End Sub

    Private Sub filterall_KeyDown(sender As Object, e As KeyEventArgs) Handles filterall.KeyDown
        If e.KeyData = Keys.Enter Then
            searchBTN.PerformClick()
        End If
    End Sub
    Public Sub QUERIES(ByVal tb As String,
                   ByVal command As String,
                   ByVal searchkey As String)
        ds = New DataSet
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                Try
                    sqlcon.Open()
                    sqlcmd.CommandText = "WAREHOUSE_QUERIES"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@command", command)
                    sqlcmd.Parameters.AddWithValue("@searchkey", searchkey)
                    sqlcmd.Parameters.AddWithValue("@rowlimit", _rowlimit)
                    da = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.Fill(ds, tb)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
