
Imports System.Data.SqlClient

Public Class sql



    Dim DBName As String = "kmdidata"
    Dim sqlconnString As String = "Data Source='" & KMDISystemsConnectionType & "';Network Library=DBMSSOCN;Initial Catalog='" & DBName & "';User ID='kmdiadmin';Password='kmdiadmin';"
    Public sqlcon As New SqlConnection With {.ConnectionString = sqlconnString}
    'Public sqlconstr As String = sqlcon.ConnectionString.ToString

    Dim finaldb As String = "finaltrans"
    Dim finaldbcon As String = "Data Source='" & KMDISystemsConnectionType & "';Network Library=DBMSSOCN;Initial Catalog='" & finaldb & "';User ID='kmdiadmin';Password='kmdiadmin';"
    Public sqlcon2 As New SqlConnection With {.ConnectionString = finaldbcon}
    'Public sqlconstr2 As String = sqlcon2.ConnectionString.ToString



    Public Property sqlconstr() As String
        Get
            Return "Data Source='" & KMDISystemsConnectionType & "';Network Library=DBMSSOCN;Initial Catalog='" & DBName & "';User ID='kmdiadmin';Password='kmdiadmin';"
        End Get
        Private Set(ByVal value As String)
            sqlconnString = value
        End Set
    End Property
    Public Property sqlconstr2() As String
        Get
            Return "Data Source='" & KMDISystemsConnectionType & "';Network Library=DBMSSOCN;Initial Catalog='" & finaldb & "';User ID='kmdiadmin';Password='kmdiadmin';"
        End Get
        Private Set(ByVal value As String)
            finaldbcon = value
        End Set
    End Property
End Class
