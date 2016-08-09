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
    public partial class ListSelectionForm : Form
    {
        public delegate void StatusUpdateHandler(object sender, EventArgs e);
        public event StatusUpdateHandler OnUpdateStatus;

        public ListSelectionForm()
        {
            InitializeComponent();
            this.Load += ListSelectionForm_Load;
        }

        private void ListSelectionForm_Load(object sender, EventArgs e)
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
                    Id = "1",
                    Name = "Name 1",
                    Description = "Description 1"
                },
                new Row
                {
                    Id = "1",
                    Name = "Name 1",
                    Description = "Description 1"
                }
            };
            this.dataGridView1.DataSource = new BindingList<Row>(dataList);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var row = this.dataGridView1.SelectedRows[0];
            var args = new UpdateEventArgs();
            args.Name = row.Cells[1].Value as string;
            OnUpdateStatus(this, args);
            this.Close();
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

    class UpdateEventArgs: EventArgs
    {
        public string Name { get; set; }
    }
}
