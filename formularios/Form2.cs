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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form frmmenu = new frmmenu();
            frmmenu.ShowDialog();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double ladoa = double.Parse(txtladoa.Text);
            double ladob = double.Parse(txtladob.Text);

            double resultado = ladoa * ladob;

            lblresultado.Visible = true;
            lblresultado.Text = resultado.ToString();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lblresultado.Visible = false;
            txtladoa.Text = String.Empty; 
            txtladob.Text = String.Empty;
        }
    }
}
