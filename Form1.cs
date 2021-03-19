using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";

            cotizacion = "Cotizacion de auto para " + txtName.Text + "\r\n";
            cotizacion += "----------------------------------------------\r\n";

            try
            {
                costo = Convert.ToDouble(txtCosto.Text);
                if (btnBasico.Checked == true)
                {
                    costo += 500.0;
                    cotizacion += "Lleva seguro basico de $500 \r\n";
                }
                if (btnTerceros.Checked == true)
                {
                    costo += 700.0;
                    cotizacion += "Lleva seguro a Terceros de $700 \r\n";
                }
                if (btnTotal.Checked == true)
                {
                    costo += 1000.0;
                    cotizacion += "Lleva seguro Total de $1000 \r\n";
                }
                if (chkAire.Checked == true)
                {
                    costo += 500.0;
                    cotizacion += "Con Aire acondicionado de $500 \r\n";
                }
                if (chkAudio.Checked == true)
                {
                    costo += 700.0;
                    cotizacion += "Con sistema de audio de $700 \r\n";
                }
                cotizacion += "\r\nEl total a pagar es de $" + costo.ToString();
                cotizacion += "\r\n----------------------------------------------\r\n";
                cotizacion += "Gracias por su cotización";
                txtCotizacion.Text = cotizacion;
            }
            catch(Exception ex)
            {
                alert.Text = ($"Error: {ex}");
            }
        }
    }
}
