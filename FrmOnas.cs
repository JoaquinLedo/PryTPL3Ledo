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
    public partial class FrmOnas : Form
    {
        public FrmOnas()
        {
            InitializeComponent();
        }

        private void FrmOnas_Load(object sender, EventArgs e)
        {

        }

        private void BtnQuenake_Click(object sender, EventArgs e)
        {
            FrmQuenaken frmQuenaken = new FrmQuenaken();
            frmQuenaken.Show();
            this.Close();
        }

        private void BtnTobas_Click(object sender, EventArgs e)
        {
            FrmTobas freTobas = new FrmTobas();
            freTobas.Show();
            this.Close();
        }
    }
}
