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
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            var grid = (sender as MainView).dataGrid;
            var bindingSource = new BindingList<DataRow>(
                new List<DataRow>{
                        new DataRow { Name = "John Smith", Title = "Mr.", Age = 34 },
                        new DataRow { Name = "Maria Smith", Title = "Mrs.", Age = 45 },
                        new DataRow { Name = "Tyler Smith", Title = "", Age = 19 },
                }
            );
            grid.DataSource = bindingSource;
            grid.Rows.Cast<DataGridViewRow>()
                .ToList()
                .ForEach(x => x.ContextMenuStrip = customContextMenu);
        }

        private void dataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var grid = sender as DataGridView;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    break;
                case MouseButtons.Left:
                    break;
                default:
                    break;
            }
        }
    }
}
