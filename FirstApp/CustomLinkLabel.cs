using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public class CustomLinkLabel: LinkLabel
    {
        private Row row;

        public CustomLinkLabel() : base()
        {
            this.HandleCreated += CustomLinkLabel_HandleCreated;
            this.LinkClicked += CustomLinkLabel_LinkClicked;
        }

        private void CustomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ListSelectionForm<Row>(row);
            form.OnUpdateStatus += Form_OnUpdateStatus;
            form.ShowDialog();
        }

        private void Form_OnUpdateStatus(object sender, EventArgs e)
        {
            var selected = (e as UpdateEventArgs).SelectedRow;
            this.row = selected;
            this.UpdateLabelText();
        }

        private void CustomLinkLabel_HandleCreated(object sender, EventArgs e)
        {
            this.UpdateLabelText();
        }

        private void UpdateLabelText()
        {
            if (row == null)
            {
                this.Text = "Add value";
            }
            else
            {
                this.Text = string.Format("Value is {0}", row.Name);
            }
        }
    }
}
