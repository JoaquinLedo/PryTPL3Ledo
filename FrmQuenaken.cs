using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryTPL3Ledo
{
    public partial class FrmQuenaken : Form
    {
        public FrmQuenaken()
        {
            InitializeComponent();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void LblSector_Click(object sender, EventArgs e)
        {

        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {

        }

        private void BtnTobas_Click(object sender, EventArgs e)
        {
            FrmTobas frmTobas = new FrmTobas();
            frmTobas.Show();
            this.Close();
        }

        private void BtnOnas_Click(object sender, EventArgs e)
        {
            FrmOnas frmOnas = new FrmOnas();
            frmOnas.Show();
            this.Close();
        }
    }
}
