using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class ListSelectionForm : Form
    {
        public event EventHandler<UpdateEventArgs> OnUpdateStatus;

        private Func<IList<Row>> GetObjects;
        private Row selectedRow;

        public ListSelectionForm(Row selectedRow)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            this.Load += ListSelectionForm_Load;
        }

        private void ListSelectionForm_Load(object sender, EventArgs e)
        {
            GetObjects = () =>
            {
                var dataList = new List<Row>
                {
                    new Row
                    {
                        Id = "1",
                        Name = "Name 1",
                        Description = "Description 1"
                    },
                    new Row
                    {
                        Id = "2",
                        Name = "Name 2",
                        Description = "Description 2"
                    },
                    new Row
                    {
                        Id = "3",
                        Name = "Name 3",
                        Description = "Description 3"
                    }
                };

                return dataList;
            };

            Action<DataGridViewRow> ClearRow = r =>
            {
                r.Selected = false;
            };
            var t = Task<IList<Row>>.Run(GetObjects);
            this.dataGridView.DataSource = new BindingList<Row>(t.Result);

            try
            {
                var selected = dataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .First(x => selectedRow.Id.Equals(x.Cells[0].Value));
                dataGridView.Rows[0].Selected = false;
                dataGridView.CurrentCell = selected.Cells[0];
                selected.Selected = true;
            }
            catch (Exception exp)
            {
                dataGridView.Rows[0].Selected = true;
            }
        }

        private void ProcessSelectedRow(DataGridViewRow row)
        {
            OnUpdateStatus(this, new UpdateEventArgs
                {
                    SelectedRow = row.DataBoundItem as Row
                });
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                var row = (sender as DataGridView).Rows[e.RowIndex];
                ProcessSelectedRow(row);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var row = this.dataGridView.SelectedRows[0];
            ProcessSelectedRow(row);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                var row = this.dataGridView.SelectedRows[0];
                ProcessSelectedRow(row);
                e.SuppressKeyPress = true;
            }
        }
    }

    public class Row
    {
        public string Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public bool Primary
        {
            get; set;
        }

    }

    public class UpdateEventArgs: EventArgs
    {
        public Row SelectedRow { get; set; }
    }
}
