Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DisabledCells

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddHandler gridView1.CustomDrawCell, AddressOf GridView1_CustomDrawCell
        End Sub

        Private Sub GridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            If Equals(e.Column.FieldName, "gridColumn1") AndAlso IsShipToUSCanada(gridView1, e.RowHandle) Then
                Dim viewInfo As CheckEditViewInfo = TryCast(CType(e.Cell, GridCellInfo).ViewInfo, CheckEditViewInfo)
                viewInfo.CheckInfo.State = DevExpress.Utils.Drawing.ObjectState.Disabled
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
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
                Return Equals(val, "US") OrElse Equals(val, "Canada")
            Catch
                Return False
            End Try
        End Function

        Private Sub gridView1_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs)
            If Equals(gridView1.FocusedColumn.FieldName, "IsFreeShipping") AndAlso IsShipToUSCanada(gridView1, gridView1.FocusedRowHandle) Then e.Cancel = True
        End Sub

        Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
            If Equals(e.Column.FieldName, "IsFreeShipping") AndAlso IsShipToUSCanada(gridView1, e.RowHandle) Then
                e.Appearance.BackColor = Color.LightGray
            End If
        End Sub
    End Class
End Namespace
