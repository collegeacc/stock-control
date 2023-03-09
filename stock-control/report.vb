
Imports System.Linq
Imports System.Globalization
Imports System.Data
Imports System.Data.OleDb

Imports SautinSoft.Document

Namespace Sample
	Friend Class Sample
		Shared Sub Main2(ByVal args() As String)
			MailMergeUsingDatabase()
		End Sub
		''' <summary>
		''' How to generate a Report (Mail Merge) using a DOCX template and Database as a data source.
		''' </summary>
		''' <remarks>
		''' See details at: https://www.sautinsoft.com/products/document/help/net/developer-guide/mail-merge-using-database-net-csharp-vb.php
		''' </remarks>
		Public Shared Sub MailMergeUsingDatabase()
			' Load the DOCX-template document.
			Dim document As DocumentCore = DocumentCore.Load("..\..\reportDoc.docx")

			' Create a data source.
			Dim dataSet As New DataSet()

			' Execute query for retrieving data of stock query.
			Dim stock As DataTable = ExecuteSQL("SELECT tblProducts.ProductID, tblProducts.[Product Name], Count(tblOrderLine.OrderID) AS [Sold Stock], tblProducts.Stock AS [Unsold Stock]
FROM tblProducts INNER JOIN (tblOrder INNER JOIN tblOrderLine ON tblOrder.OrderID = tblOrderLine.OrderID) ON tblProducts.ProductID = tblOrderLine.ProductID
GROUP BY tblProducts.ProductID, tblProducts.[Product Name], tblProducts.Stock;
")
			stock.TableName = "Stock"
			dataSet.Tables.Add(stock)



			' Calculate and fill Total.
			document.MailMerge.Execute(stock, "Stock")




			Dim resultPath As String = "stock.docx"

			' Save the output to file.
			document.Save(resultPath)

			' Open the result for demonstration purposes.
			System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(resultPath) With {.UseShellExecute = True})
		End Sub

		''' <summary>
		''' Utility function that creates a connection, executes the sql-query and
		''' return the result in a DataTable.
		''' </summary>
		Private Shared Function ExecuteSQL(ByVal sqlText As String) As DataTable
			' Open the database connection.

			Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\..\stock-controlDB.accdb")

			conn.Open()

			' Create and execute a command.
			Dim cmd As New OleDbCommand(sqlText, conn)
			Dim da As New OleDbDataAdapter(cmd)
			Dim table As New DataTable()
			da.Fill(table)

			' Close the database.
			conn.Close()

			Return table
		End Function
	End Class
End Namespace