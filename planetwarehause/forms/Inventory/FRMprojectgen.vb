Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FRMprojectgen
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim sql As New sql
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Private Sub FRMprojectgen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        AddHandler bgw.DoWork, AddressOf bgw_DoWork

        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        gv.DataSource = bs
        loadprojects()
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "GETDATA"
                getdata(projectlabel)
                bgw.ReportProgress(0)
        End Select
    End Sub
    Private Sub loadprojects()
        Try
            Dim dset As New DataSet
            dset.Clear()
            Dim str As String = " select distinct project_label from addendum_to_contract_tb"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()

                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(dset, "addendum_to_contract_tb")
                    End Using
                    Dim dds As New BindingSource
                    dds.DataSource = dset
                    dds.DataMember = "addendum_to_contract_tb"
                    ComboBox1.DataSource = dds
                    ComboBox1.DisplayMember = "project_label"
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "GETDATA"
                bs.DataSource = ds
                bs.DataMember = "addendum_to_contract_tb"
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "GETDATA"
                LoadingPBOX.Visible = False
        End Select
    End Sub
    Private Sub getdata(ByVal projectlabel As String)
        Try
            ds = New DataSet
            ds.Clear()
            Dim str As String = " select distinct project_label,fulladd from addendum_to_contract_tb where project_label like  '%'+@projectlabel+'%'"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    With sqlcmd
                        .Parameters.AddWithValue("@projectlabel", projectlabel)
                    End With
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "addendum_to_contract_tb")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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
    Dim projectlabel As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        projectlabel = ComboBox1.Text
        starter("GETDATA")
    End Sub



    Private Sub gv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gv.CellDoubleClick
        If e.RowIndex >= 0 And gv.RowCount >= 0 Then
            Dim row As DataGridViewRow = gv.Rows(e.RowIndex)
            With FRMaddedit
                .projecttxt.Text = row.Cells("project_label").Value.ToString()
                .addresstxt.Text = row.Cells("fulladd").Value.ToString()
            End With
            Me.Close()
        End If
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

    Private Sub FRMprojectgen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class