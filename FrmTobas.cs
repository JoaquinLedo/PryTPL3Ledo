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
    public partial class FrmTobas : Form
    {
        private string[,] asientosAzul = new string[5, 20]; // Matriz de asientos azules (5 filas x 20 columnas)
        private string[,] asientosVerde = new string[5, 20]; // Matriz de asientos verdes (5 filas x 20 columnas)
        public FrmTobas()
        {
            InitializeComponent();
            InitializeAsientos(); // Inicializa los asientos (por ejemplo, todos como disponibles)
        }

        private void BtnOnas_Click(object sender, EventArgs e)
        {
            FrmOnas frmOnas = new FrmOnas();
            frmOnas.Show();
            this.Close();
        }

        private void BtnQuenake_Click(object sender, EventArgs e)
        {
            FrmQuenaken frmQuenaken = new FrmQuenaken();
            frmQuenaken.Show();
            this.Close();
        }
        private void InitializeAsientos()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    asientosAzul[i, j] = "Disponible"; // Todos los asientos azules están inicialmente disponibles
                    asientosVerde[i, j] = "Disponible"; // Todos los asientos verdes están inicialmente disponibles
                }
            }
        }
        private void BtnReservar_Click(object sender, EventArgs e)
        {
            int fila = Convert.ToInt32(TxtFilaT.Text);
            int asiento = Convert.ToInt32(TxtAsientoT.Text);
            string nombre = TxtNombreT.Text;
            string dni = TxtDniT.Text;

            // Verifica si se seleccionó el sector Azul y si el asiento está disponible en ese sector
            if (chbSectorAzul.Checked && asientosAzul[fila, asiento] == "Disponible")
            {
                asientosAzul[fila, asiento] = $"{nombre} ({dni})"; // Marca el asiento como reservado y guarda el nombre y DNI
                MessageBox.Show($"Asiento Azul - {fila}-{asiento} reservado correctamente para {nombre} (DNI: {dni}).");
            }
            // Verifica si se seleccionó el sector Verde y si el asiento está disponible en ese sector
            else if (chbSectorVerde.Checked && asientosVerde[fila, asiento] == "Disponible")
            {
                asientosVerde[fila, asiento] = $"{nombre} ({dni})"; // Marca el asiento como reservado y guarda el nombre y DNI
                MessageBox.Show($"Asiento Verde - {fila}-{asiento} reservado correctamente para {nombre} (DNI: {dni}).");
            }
            else
            {
                MessageBox.Show($"El asiento seleccionado ya está ocupado o no es válido. Por favor, elige otro asiento o sector.");
            }

            // Limpia los cuadros de texto después de la reserva
            TxtFilaT.Text = "";
            TxtAsientoT.Text = "";
            TxtNombreT.Text = "";
            TxtDniT.Text = "";
        }
    }
}
