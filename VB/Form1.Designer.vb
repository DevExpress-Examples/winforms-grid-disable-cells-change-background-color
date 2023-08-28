Namespace DisabledCells

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.dataColumn4 = New System.Data.DataColumn()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderItem = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsFreeShipping = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.bindingSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(425, 286)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataMember = "Orders"
            Me.bindingSource1.DataSource = Me.dataSet1
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
            Me.dataTable1.TableName = "Orders"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "OrderItem"
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "ShipCountry"
            ' 
            ' dataColumn4
            ' 
            Me.dataColumn4.ColumnName = "IsFreeShipping"
            Me.dataColumn4.DataType = GetType(Boolean)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderItem, Me.colShipCountry, Me.colIsFreeShipping, Me.gridColumn1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            AddHandler Me.gridView1.RowCellStyle, New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(AddressOf Me.gridView1_RowCellStyle)
            AddHandler Me.gridView1.ShowingEditor, New System.ComponentModel.CancelEventHandler(AddressOf Me.gridView1_ShowingEditor)
            ' 
            ' colOrderItem
            ' 
            Me.colOrderItem.FieldName = "OrderItem"
            Me.colOrderItem.Name = "colOrderItem"
            Me.colOrderItem.Visible = True
            Me.colOrderItem.VisibleIndex = 0
            ' 
            ' colShipCountry
            ' 
            Me.colShipCountry.FieldName = "ShipCountry"
            Me.colShipCountry.Name = "colShipCountry"
            Me.colShipCountry.Visible = True
            Me.colShipCountry.VisibleIndex = 1
            ' 
            ' colIsFreeShipping
            ' 
            Me.colIsFreeShipping.Caption = "RowCellStyle"
            Me.colIsFreeShipping.FieldName = "IsFreeShipping"
            Me.colIsFreeShipping.Name = "colIsFreeShipping"
            Me.colIsFreeShipping.Visible = True
            Me.colIsFreeShipping.VisibleIndex = 2
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "CustomDraw"
            Me.gridColumn1.FieldName = "gridColumn1"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.UnboundExpression = "[IsFreeShipping]"
            Me.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 3
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(425, 286)
            Me.Controls.Add(Me.gridControl1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private bindingSource1 As System.Windows.Forms.BindingSource

        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private dataColumn4 As System.Data.DataColumn

        Private colOrderItem As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn

        Private colIsFreeShipping As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
