﻿Imports System.Data.OleDb

Module codePool
    Public accessLevel As Integer



    Public openForm As String
    Public MaxRows As Integer 'maxiumum rows
    Public MaxCol As Integer
    Public curRow As Integer = 0 'current row
    Public conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\..\stock-controlDB.accdb")
    Public ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Public da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Public sql As String 'The sql command

    Public MaxRows2 As Integer 'maxiumum rows
    Public MaxCol2 As Integer
    Public curRow2 As Integer = 0 'current row
    Public conn2 As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\..\stock-controlDB.accdb")
    Public ds2 As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Public da2 As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Public sql2 As String 'The sql command

    Sub simpleSQL(ByVal sql As String, ByVal dsName As String) 'this is a subroutine that allows me to create quick and simple queeries, since otherwise alot of code is copied and pasted
        conn.Open()
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, dsName)
        MaxRows = ds.Tables(dsName).Rows.Count
        conn.Close()
    End Sub

    Sub simpleSQL2(ByVal sql As String, ByVal dsName As String) 'seperate connection for when visual basic decides itd be funny to not work :)
        conn2.Open()
        da2 = New OleDb.OleDbDataAdapter(sql, conn)
        da2.Fill(ds2, dsName)
        MaxRows2 = ds2.Tables(dsName).Rows.Count
        conn2.Close()
    End Sub

    Function presenceCheck(ByVal textbox As String) 'the value textbox is used which will be passed into by (name of textbox).Text when used for presence checking
        If textbox = "" Then 'if the text box is empty return false, meaning validation has failed.
            Return False
        Else
            Return True 'if text box has text, return true, meaning validation succeeded. o/
        End If
    End Function

    'Function profilePicLookup(ByVal userOrAdmin As Boolean) 'this finds out the users profile picture, then creates the appropriate return based on its file path so that the picture boxes on each page correctly use the correct profile picture innit :thumbs_up:

    'Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    'Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    'Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    'Dim sql As String 'The sql command

    'conn.Open()

    'If userOrAdmin = True Then 'this gets the correct PfP for a user

    '    sql = "SELECT UserID, PfP FROM Users WHERE UserID='" & UserLoggedIn & "'"
    '    da = New OleDb.OleDbDataAdapter(sql, conn)
    '    da.Fill(ds, "DSUsers")

    '    If ds.Tables("DSUsers").Rows(0).Item(1).ToString() = "" Then 'if there is no profile picture, use the default profile picture
    '        Return "..\pfps\default.png"
    '    Else
    '        Return "..\pfps\" & ds.Tables("DSUsers").Rows(0).Item(1).ToString()
    '    End If
    'End If

    'If userOrAdmin = False Then 'this gets the correct PfP for an admin

    '    sql = "SELECT EmployeeID, PfP FROM Employee WHERE EmployeeID='" & UserLoggedIn & "'"
    '    da = New OleDb.OleDbDataAdapter(sql, conn)
    '    da.Fill(ds, "DSEmployee")

    '    If ds.Tables("DSEmployee").Rows(0).Item(1).ToString() = "" Then 'if there is no profile picture, use the default profile picture
    '        Return "..\pfps\default.png"
    '    Else
    '        Return "..\pfps\" & ds.Tables("DSEmployee").Rows(0).Item(1).ToString()
    '    End If
    'End If



    'End Function


End Module
