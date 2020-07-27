Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class loginFRM
    Dim sql As New sql
    Dim _user, _pass As String


    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        _user = username.Text
        _pass = password.Text

        If RadioButton1.Checked Then
            KMDISystemsConnectionType = "192.168.1.21,49107"
        ElseIf RadioButton2.Checked Then
            KMDISystemsConnectionType = "121.58.229.248,49107"
        End If

        Select Case login()
                Case "1"
                    If Application.OpenForms.OfType(Of KMDIprojectFRM).Any Then
                        KMDIprojectFRM.Dispose()
                    End If
                    KMDIprojectFRM.Show()
                Case Else
                    MessageBox.Show("Invalid login")
            End Select

    End Sub
    Private Function login() As String
        Dim rc As String = "0"
        Dim str As String = "select count(id),NICKNAME from account_tb where username = '" & _user & "' and password = '" & _pass & "' group by nickname"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr2)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Dim rd As SqlDataReader = sqlcmd.ExecuteReader
                    While rd.Read
                        rc = rd(0).ToString
                        KMDIprojectFRM._nickname = rd(1).ToString
                    End While
                    rd.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
        Return rc
    End Function
    Public Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    Private Sub loginFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
End Class