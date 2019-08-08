using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void selectionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ss selection = new frm_ss();
            selection.MdiParent = this;
            selection.Show();
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bs bubble = new frm_bs();
            bubble.MdiParent = this;
            bubble.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_qs quick = new frm_qs();
            quick.MdiParent = this;
            quick.Show();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about about = new frm_about();
            about.MdiParent = this;
            about.Show();
        }

        private void selectionSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_is insertion = new frm_is();
            insertion.MdiParent = this;
            insertion.Show();
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ms merge = new frm_ms();
            merge.MdiParent = this;
            merge.Show();
        }

        private void linearSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_linear linear = new frm_linear();
            linear.MdiParent = this;
            linear.Show();
        }

        private void binarySearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_binary binary = new frm_binary();
            binary.MdiParent = this;
            binary.Show();
        }

        private void jumpSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_jump jump = new frm_jump();
            jump.MdiParent = this;
            jump.Show();
        }
    }
}
