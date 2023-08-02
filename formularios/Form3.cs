using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btnquadrado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new frm1();
            frm1.ShowDialog();
        }

        private void btnretangulo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new frm2();
            frm2.ShowDialog();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
