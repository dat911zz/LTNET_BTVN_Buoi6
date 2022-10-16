using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001202045_VuNgoDat_SM24_Buoi6
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new B1().Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new B2().Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
