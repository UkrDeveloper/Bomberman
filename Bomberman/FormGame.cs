using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
            => MessageBox.Show("About Bomberman...");

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
            => MessageBox.Show("About Author...");

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            => this.Close();
    }
}
