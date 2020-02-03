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
    public partial class frmBookString : Form
    {
        public frmBookString()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fullName, fName,lName;
            fullName = txtFullname.Text.Trim();
            if(fullName.Length == 0)
            {
                MessageBox.Show("Please enter Lastname , Firstname");
                txtFullname.Focus();
                return ;
            }

        }
    }
}
