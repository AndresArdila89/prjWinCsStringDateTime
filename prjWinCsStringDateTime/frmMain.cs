using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsStringDateTime
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you shure you want to quit the program", "Cloasing of the program", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            frmBookString fb = new frmBookString();
            fb.MdiParent = this;
            fb.Show();
        }
    }
}
