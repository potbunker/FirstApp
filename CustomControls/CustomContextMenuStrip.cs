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
        public DataGridView Grid { get; set; }
        public CustomContextMenuStrip() : base()
        {

        }
    }

    public class CustomToolStripMenuItem: ToolStripMenuItem
    {

    }
}
