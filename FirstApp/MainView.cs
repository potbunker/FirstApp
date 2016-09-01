using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            Load += (sender, e) =>
            {
                var bindingSource = new BindingList<DataRow>(
                    new List<DataRow>{
                        new DataRow { Name = "Jaewan Kim", Title = "Dr.", Age = 52 },
                        new DataRow { Name = "Mirim Lee", Title = "Dr.", Age = 52 },
                        new DataRow { Name = "Wooyoung Kim", Title = "Dr.", Age = 19 },
                    }
                );
                dataGrid.DataSource = bindingSource;
            };
        }

        private void dataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            var gridView = sender as DataGridView;
            switch (e.Button)
            {
                case MouseButtons.Right:
                    var hitTest = gridView.HitTest(e.X, e.Y);
                    var selectedRow = gridView.Rows[hitTest.RowIndex];
                    gridView.CurrentCell = selectedRow.Cells[hitTest.ColumnIndex];
                    selectedRow.Selected = true;
                    customContextMenu.Show(gridView, e.Location);
                    break;
                case MouseButtons.Left:

                    MessageBox.Show("index is " + gridView.CurrentRow.Index);
                    break;
                default:
                    break;
            }
        }
    }
}
