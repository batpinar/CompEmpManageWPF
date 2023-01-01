using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompEmpManageWPF
{
    public partial class frmCompEmpMenu : Form
    {
        public frmCompEmpMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new frmCompany();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new frmEmployee();
            myForm.Show();
        }
    }
}
