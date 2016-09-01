using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class ListSelectionForm<TRow> : Form
    {
        ILog log = LogManager.GetLogger(typeof(ListSelectionForm<TRow>));
        public event EventHandler<UpdateEventArgs> OnUpdateStatus;

        private Func<IList<TRow>> GetObjects = () => new List<TRow>();
        private TRow initialRow;

        public ListSelectionForm(TRow selectedRow)
        {
            InitializeComponent();
            this.initialRow = selectedRow;
            this.Load += ListSelectionForm_Load;
        }

        private void ListSelectionForm_Load(object sender, EventArgs e)
        {
            var t = Task<IList<Row>>.Run(GetObjects);
            this.dataGridView.DataSource = new BindingList<TRow>(t.Result);

            try
            {
                var selected = dataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .First(x => x.Equals(initialRow));
                dataGridView.Rows[0].Selected = false;
                dataGridView.CurrentCell = selected.Cells[0];

                selected.Selected = true;
            }
            catch (Exception exp)
            {
                log.Error(exp.Message, exp);
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

        public override bool Equals(object obj)
        {
            return this.Id.Equals((obj as Row).Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class UpdateEventArgs: EventArgs
    {
        public Row SelectedRow { get; set; }
    }
}
