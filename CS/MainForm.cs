using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace DisabledCells {
    public partial class MainForm : Form {
        public MainForm() {
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
                string val = Convert.ToString(view.GetListSourceRowCellValue(row, "ShipCountry"));
                return (val == "US" || val == "Canada");
            }
            catch {
                return false;
            }
        }
        private void disabledCellEvents1_ProcessingCell(object sender, DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs e) {
            //Expression specified in the DisabledCellBehavior disables all row cells. Use the following code to enable cells in specific columns
            if(e.FieldName != "Unbound") {
                e.Disabled = false;
            }
            //This code disables cells of the IsFreeShipping column depending on the IsShipToUSCanada condition
            GridView view = e.Source as GridView;
            if(e.FieldName == "IsFreeShipping" && IsShipToUSCanada(view, e.RecordId)) {
                e.Disabled = true;
            }
        }
    }
}