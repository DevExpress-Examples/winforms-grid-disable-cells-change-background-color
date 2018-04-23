using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace DisabledCells {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FillDataSource();
        }

        private void FillDataSource() {
            dataTable1.Rows.Add("Product 1002", "US", true);
            dataTable1.Rows.Add("Product 1001", "Germany", false);
            dataTable1.Rows.Add("Product 1003", "Canada", true);
        }


        private bool IsShipToUSCanada(GridView view, int row) {
            try {
                string val = Convert.ToString(view.GetRowCellValue(row, "ShipCountry"));
                return (val == "US" || val == "Canada");
            }
            catch {
                return false;
            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e) {
            if(gridView1.FocusedColumn.FieldName == "IsFreeShipping"
                && IsShipToUSCanada(gridView1, gridView1.FocusedRowHandle))
                e.Cancel = true;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e) {
            if(e.Column.FieldName == "IsFreeShipping"
                && IsShipToUSCanada(gridView1, e.RowHandle)) {
                e.Appearance.BackColor = Color.LightGray;
            }
        }
    }
}