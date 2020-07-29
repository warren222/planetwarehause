Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FRMchangepassword
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim bs As New BindingSource
    Dim ds As New DataSet
    Dim sql As New sql
    Dim condition As String
    Private Sub FRMchangepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        newusername.Text = user_username
    End Sub
    Dim _newusernametxt As String
    Dim _newpasswordtxt As String
    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "changeuseraccount"
                changeuseraccount()
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub changeuseraccount()
        Dim str As String = "update [WAREHOUSEaccounttb] set username = '" & _newusernametxt & "',password = '" & _newpasswordtxt & "' where id = '" & user_id & "'"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "changeuseraccount"
                LoadingPBOX.Visible = False
                'Dim formNames As List(Of String)

                'For Each currentForm As Form In Application.OpenForms
                '    If currentForm.Name <> "loginFRM" Then
                '        formNames.Add(currentForm.Name)
                '    End If
                'Next
                'For Each currentFormName As String In formNames
                '    Application.OpenForms(currentFormName).Close()
                'Next
                Me.Close()
                'For Each Form As Form In My.Application.OpenForms
                '    If Not Form.Name = "loginFRM" Then
                '        Form.Close()
                '    End If
                'Next
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "changeuseraccount"

        End Select
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
    Dim isvalid As Boolean
    Private Sub BTNsave_Click(sender As Object, e As EventArgs) Handles BTNsave.Click
        If Not newpassword.Text = "" And Not newusername.Text = "" Then
            If checkduplicate() = False Then
                LBLusernameerror.Text = "username not available!"
                Exit Sub
            Else
                LBLusernameerror.Text = ""
                If Not newpassword.Text = retypepassword.Text Then
                    LBLretypeerror.Text = "password did not match!"
                    Exit Sub
                Else
                    LBLretypeerror.Text = ""
                    If Not oldpassword.Text = user_password Then
                        LBLolpassworderror.Text = "incorrect password!"
                        Exit Sub
                    Else
                        LBLolpassworderror.Text = ""
                        _newpasswordtxt = newpassword.Text
                        _newusernametxt = newusername.Text
                        starter("changeuseraccount")
                    End If
                End If
            End If
        Else
            MessageBox.Show("username and password is required!")
        End If



    End Sub
    Private Function checkduplicate()
        Dim str As String = "select * from [WAREHOUSEaccounttb] where username = '" & newusername.Text & "' and not id = '" & user_id & "'"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Dim dr As SqlDataReader = sqlcmd.ExecuteReader
                    If dr.HasRows Then
                        isvalid = False
                    Else
                        isvalid = True
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Return isvalid

            End Using
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class