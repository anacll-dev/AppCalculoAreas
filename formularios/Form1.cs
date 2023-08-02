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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnchama2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new frm2();
            frm2.ShowDialog();
            
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            double lado = double.Parse(txtladoa.Text);

            double resultado = lado * lado;

            lblresultado.Visible = true;
            lblresultado.Text = resultado.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lblresultado.Visible = false;
            txtladoa.Text = String.Empty;
        }
    }
}
