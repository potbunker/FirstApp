using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class ListSelectionForm : Form
    {
        public delegate void EventHandler(object sender, UpdateEventArgs e);
        public event EventHandler<UpdateEventArgs> OnUpdateStatus;

        public ListSelectionForm()
        {
            InitializeComponent();
            this.Load += ListSelectionForm_Load;
        }

        private void ListSelectionForm_Load(object sender, EventArgs e)
        {
            var t = Task<IList<Row>>.Run(() => 
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

                Thread.Sleep(2000);
                return dataList;
            });
            this.dataGridView1.DataSource = new BindingList<Row>(t.Result);
        }

        private void ProcessSelectedRow(DataGridViewRow row)
        {
            OnUpdateStatus(this, new UpdateEventArgs
            {
                Name = row.Cells[1].Value as string
            }
            );
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
            var row = this.dataGridView1.SelectedRows[0];
            ProcessSelectedRow(row);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class Row
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

    }

    public class UpdateEventArgs: EventArgs
    {
        public string Name { get; set; }
    }
}
