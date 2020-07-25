Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FRMaddedit
    Dim bgw As New BackgroundWorker
    Dim action As String

    Dim sql As New sql
    Public id As String
    Public _id As String
    Public _date As String
    Public _project As String
    Public _address As String
    Public _clno As String
    Public _kno As String
    Public _location As String
    Public _color As String
    Public _qty As String
    Public _handletype As String
    Public _additional As String
    Public _description As String
    Public _released As String
    Public _datereleased As String
    Public _receivedby As String
    Public _controlno As String

    Private Sub FRMaddedit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.gv.Enabled = True
        Form1.BTNreload.PerformClick()
        Me.Dispose()
    End Sub

    Private Sub FRMaddedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        AddHandler bgw.DoWork, AddressOf bgw_DoWork

        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
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
    Private Sub buttonclick(sender As Object, e As EventArgs) Handles BTNsave.Click, BTNcancel.Click, BTNclear.Click
        Select Case sender.name
            Case "BTNsave"
                initializedvalues()
                Select Case BTNsave.Text
                    Case "add"
                        starter("ADD")
                    Case "save"
                        starter("SAVE")
                End Select
            Case "BTNcancel"
                Me.Close()
            Case "BTNclear"
                projecttxt.Text = ""
                addresstxt.Text = ""
        End Select
    End Sub
    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "ADD"
                Dim val As String
                val = "@id,'" & _date & "',
                           '" & _project & "',
                           '" & _address & "',
                           '" & _clno & "',
                           '" & _kno & "',
                           '" & _location & "',
                           '" & _color & "',
                           '" & _qty & "',
                           '" & _handletype & "',
                           '" & _additional & "',
                           '" & _description & "',
                           '" & _released & "',
                           '" & _datereleased & "',
                           '" & _receivedby & "',
                           '" & _controlno & "'"
                queries(action, val)
            Case "SAVE"
                Dim val As String
                val = " SET [DATED]= '" & _date & "',
                          [PROJECT]= '" & _project & "',
                          [ADDRESS]= '" & _address & "',
                          [CLNO]= '" & _clno & "',
                          [KNO]= '" & _kno & "',
                          [LOCATION]= '" & _location & "',
                          [COLOR]= '" & _color & "',
                          [QTY]= '" & _qty & "',
                          [HANDLETYPE]= '" & _handletype & "',
                          [ADDITIONAL]= '" & _additional & "',
                          [DESCRIPTION]= '" & _description & "',
                          [RELEASED]= '" & _released & "',
                          [DATERELEASED]= '" & _datereleased & "',
                          [RECEIVEDBY]= '" & _receivedby & "',
                          [CTRLNO]= '" & _controlno & "' where id = '" & _id & "'"
                queries(action, val)
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "ADD"
                LoadingPBOX.Visible = False
                MessageBox.Show("new record added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "SAVE"
                LoadingPBOX.Visible = False
                MessageBox.Show("record updated", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "ADD"

        End Select
    End Sub

    Public Sub initializedvalues()
        With Me
            _id = id
            _date = .datetxt.Text
            _project = .projecttxt.Text
            _address = .addresstxt.Text
            _clno = .clnotxt.Text
            _kno = .knotxt.Text
            _location = .locationtxt.Text
            _color = .colortxt.Text
            _qty = .qtytxt.Text
            _handletype = .handletypetxt.Text
            _additional = .additionaltxt.Text
            _description = .descriptiontxt.Text
            _released = .releasedtxt.Text
            _datereleased = .datereleasetxt.Text
            _receivedby = .receivedbytxt.Text
            _controlno = .controlnotxt.Text
        End With
    End Sub
    Public Sub editinitializevalues()
        With Me
            .id = _id
            .datetxt.Text = _date
            .projecttxt.Text = _project
            .addresstxt.Text = _address
            .clnotxt.Text = _clno
            .knotxt.Text = _kno
            .locationtxt.Text = _location
            .colortxt.Text = _color
            .qtytxt.Text = _qty
            .handletypetxt.Text = _handletype
            .additionaltxt.Text = _additional
            .descriptiontxt.Text = _description
            .releasedtxt.Text = _released
            .datereleasetxt.Text = _datereleased
            .receivedbytxt.Text = _receivedby
            .controlnotxt.Text = _controlno
        End With
    End Sub

    Public Sub queries(ByVal command As String, ByVal val As String)

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
                        .Parameters.AddWithValue("@condition", "")
                    End With
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub MetroDateTime1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroDateTime1.MouseDown
        datetxt.Text = MetroDateTime1.Text
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        datetxt.Text = MetroDateTime1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FRMprojectgen.ShowDialog()
    End Sub

    Private Sub MetroDateTime2_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime2.ValueChanged, MetroDateTime2.MouseDown
        datereleasetxt.Text = MetroDateTime2.Text
    End Sub
End Class