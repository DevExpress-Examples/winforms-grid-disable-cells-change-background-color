Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Windows.Forms

Namespace DisabledCells
	Partial Public Class MainForm
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			FillDataSource()
		End Sub
		Private Sub FillDataSource()
			dataTable1.Rows.Add("Product 1002", "US", True)
			dataTable1.Rows.Add("Product 1001", "Germany", False)
			dataTable1.Rows.Add("Product 1003", "Canada", True)
		End Sub
		Private Function IsShipToUSCanada(ByVal view As GridView, ByVal row As Integer) As Boolean
			Try
				Dim val As String = Convert.ToString(view.GetListSourceRowCellValue(row, "ShipCountry"))
				Return (val = "US" OrElse val = "Canada")
			Catch
				Return False
			End Try
		End Function
		Private Sub disabledCellEvents1_ProcessingCell(ByVal sender As Object, ByVal e As DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs) Handles disabledCellEvents1.ProcessingCell
			'Expression specified in the DisabledCellBehavior disables all row cells. Use the following code to enable cells in specific columns
			If e.FieldName <> "Unbound" Then
				e.Disabled = False
			End If
			'This code disables cells of the IsFreeShipping column depending on the IsShipToUSCanada condition
			Dim view As GridView = TryCast(e.Source, GridView)
			If e.FieldName = "IsFreeShipping" AndAlso IsShipToUSCanada(view, e.RecordId) Then
				e.Disabled = True
			End If
		End Sub
	End Class
End Namespace