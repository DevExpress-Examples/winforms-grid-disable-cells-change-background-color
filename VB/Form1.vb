Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace DisabledCells
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			FillDataSource()
		End Sub

		Private Sub FillDataSource()
			dataTable1.Rows.Add("Product 1002", "US", True)
			dataTable1.Rows.Add("Product 1001", "Germany", False)
			dataTable1.Rows.Add("Product 1003", "Canada", True)
		End Sub


		Private Function IsShipToUSCanada(ByVal view As GridView, ByVal row As Integer) As Boolean
			Try
				Dim val As String = Convert.ToString(view.GetRowCellValue(row, "ShipCountry"))
				Return (val = "US" OrElse val = "Canada")
			Catch
				Return False
			End Try
		End Function

		Private Sub gridView1_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs) Handles gridView1.ShowingEditor
			If gridView1.FocusedColumn.FieldName = "IsFreeShipping" AndAlso IsShipToUSCanada(gridView1, gridView1.FocusedRowHandle) Then
				e.Cancel = True
			End If
		End Sub

		Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridView1.RowCellStyle
			If e.Column.FieldName = "IsFreeShipping" AndAlso IsShipToUSCanada(gridView1, e.RowHandle) Then
				e.Appearance.BackColor = Color.LightGray
			End If
		End Sub
	End Class
End Namespace