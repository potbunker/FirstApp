using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp.CustomControls
{
    public class CustomContextMenuStrip: ContextMenuStrip
    {
        public CustomContextMenuStrip() : base()
        {
            Opening += (sender, e) =>
            {
                var grid = (sender as ContextMenuStrip).SourceControl as DataGridView;
                Items.OfType<CustomToolStripMenuItem>()
                .ToList()
                .ForEach(item => item.Enabled = item.Enabler(grid));
            };

        }
    }

    public class CustomToolStripMenuItem: ToolStripMenuItem
    {
        public Func<DataGridView, bool> Enabler { get; set; }

        public CustomToolStripMenuItem() : base ()
        {
        }

    }
}
