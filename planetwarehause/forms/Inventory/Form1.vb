Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Form1
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim bs As New BindingSource
    Dim ds As New DataSet
    Dim sql As New sql
    Dim condition As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        AddHandler bgw.DoWork, AddressOf bgw_DoWork

        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        gv.DataSource = bs
        CBXcolumn.SelectedIndex = 1
        condition = CBXcolumn.Text + " like " + "'%" & TBOXkey.Text & "%'"
        starter("SEARCH")



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
            Case "SEARCH"
                queries(action, "")
                bgw.ReportProgress(0)
            Case "DELETE"
                For i As Integer = 0 To idlist.Count - 1
                    queries(action, idlist(i).ToString)
                Next
                bgw.ReportProgress(0)

        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "SEARCH"
                LoadingPBOX.Visible = False
            Case "DELETE"
                LoadingPBOX.Visible = False
                starter("SEARCH")
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "SEARCH"
                bs.DataSource = ds
                bs.DataMember = "HANDLEINVENTORY"
        End Select
    End Sub
    Private Sub buttonclick(sender As Object, e As EventArgs) Handles BTNreload.Click, BTNfind.Click, BTNnew.Click, BTNedit.Click, BTNdelete.Click
        Select Case sender.name
            Case "BTNreload"
                condition = CBXcolumn.Text + " like " + "'%" & TBOXkey.Text & "%'"
                starter("SEARCH")
            Case "BTNfind"
                condition = CBXcolumn.Text + " like " + "'%" & TBOXkey.Text & "%'"
                starter("SEARCH")
            Case "BTNnew"
                suggestioncaller()
                FRMaddedit.colortxt.SelectedIndex = -1
                FRMaddedit.handletypetxt.SelectedIndex = -1
                FRMaddedit.descriptiontxt.SelectedIndex = -1
                FRMaddedit.releasedtxt.SelectedIndex = -1
                FRMaddedit.receivedbytxt.SelectedIndex = -1
                FRMaddedit.BTNsave.Text = "add"
                FRMaddedit.Label1.Text = "Add new Record"
                FRMaddedit.ShowDialog()
            Case "BTNedit"
                suggestioncaller()
                FRMaddedit.editinitializevalues()
                gv.Enabled = False
                FRMaddedit.BTNsave.Text = "save"
                FRMaddedit.Label1.Text = "Edit Record"
                FRMaddedit.ShowDialog()
            Case "BTNdelete"
                If MessageBox.Show(Me, "Delete this record?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
                starter("DELETE")
        End Select
    End Sub
    Private Sub suggestioncaller()
        loadsuggestions("COLOR", FRMaddedit.colortxt)
        loadsuggestions("HANDLETYPE", FRMaddedit.handletypetxt)
        loadsuggestions("DESCRIPTION", FRMaddedit.descriptiontxt)
        loadsuggestions("RELEASED", FRMaddedit.releasedtxt)
        loadsuggestions("RECEIVEDBY", FRMaddedit.receivedbytxt)
    End Sub
    Public Sub queries(ByVal command As String, ByVal val As String)
        ds = New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                Try
                    sqlcon.Open()
                    With sqlcmd
                        .CommandText = "[WAREHOUSE_handleinventoryFRM]"
                        .CommandType = CommandType.StoredProcedure
                        .CommandTimeout = 30000
                        .Parameters.AddWithValue("@command", command)
                        .Parameters.AddWithValue("@val", val)
                        .Parameters.AddWithValue("@condition", condition)
                    End With
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        With da
                            .SelectCommand = sqlcmd
                            .Fill(ds, "HANDLEINVENTORY")
                        End With
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub


    Dim idlist As ArrayList
    Private Sub gv_SelectionChanged(sender As Object, e As EventArgs) Handles gv.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = gv.SelectedRows
        idlist = New ArrayList(rows.Count)

        For Each row As DataGridViewRow In rows
            idlist.Add(row.Cells("ID").Value.ToString)
            With FRMaddedit

                ._id = row.Cells("ID").Value.ToString
                ._date = row.Cells("DATE").Value.ToString
                ._project = row.Cells("PROJECT").Value.ToString
                ._address = row.Cells("ADDRESS").Value.ToString
                ._clno = row.Cells("CL#").Value.ToString
                ._kno = row.Cells("K#").Value.ToString
                ._location = row.Cells("LOCATION").Value.ToString
                ._color = row.Cells("COLOR").Value.ToString
                ._qty = row.Cells("QTY").Value.ToString
                ._handletype = row.Cells("HANDLE TYPE").Value.ToString
                ._additional = row.Cells("ADDITIONAL").Value.ToString
                ._description = row.Cells("DESCRIPTION").Value.ToString
                ._released = row.Cells("RELEASED").Value.ToString
                ._datereleased = row.Cells("DATE RELEASED").Value.ToString
                ._receivedby = row.Cells("RECEIVED BY").Value.ToString
                ._controlno = row.Cells("CTRL#").Value.ToString
            End With
        Next
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub gv_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles gv.RowPostPaint
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


    Private Sub loadsuggestions(ByVal column As String, obj As Object)
        Try
            Dim dds As New DataSet
            Dim bbs As New BindingSource
            dds.Clear()

            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand("select distinct " & column & " from HANDLEINVENTORY", sqlcon)
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(dds, "HANDLEINVENTORY")
                    End Using
                    bbs.DataSource = dds
                    bbs.DataMember = "HANDLEINVENTORY"
                    obj.DataSource = bbs
                    obj.DisplayMember = column
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class