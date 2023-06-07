using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor_De_Peso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double miligramo;
        double microgramo;
        double gramo;
        double kilogramo;
        double tonelada;
        double MIni; //variable para almcenar la medida inicial
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMedidaI.Text.Length == 0)
            {
                MessageBox.Show("Porfavor escribe una cantidad\ndentro del cuadro de texto\nY selecciona una unidad de peso", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MIni = Convert.ToDouble(txtMedidaI.Text);
                calcular_microgramos();
                convertir_a_miligramo();
                convertir_a_gramos();
                convertir_a_kg();
                convertir_a_toneladas();
                txtMicGramo.Text = Convert.ToString(microgramo);
                txtMilGramo.Text = Convert.ToString(miligramo);
                txtGramo.Text = Convert.ToString(gramo);
                txtKiloGramo.Text = Convert.ToString(kilogramo);
                txtTonelada.Text = Convert.ToString(tonelada);
            }
        }
        private void calcular_microgramos()
        {
            if(cmbMedidas.SelectedIndex==0)
            {
                microgramo = MIni;
            }
            if(cmbMedidas.SelectedIndex==1)
            {
                microgramo = MIni / 0.0010000; //ecuacion para miligramos
            }
            if(cmbMedidas.SelectedIndex==2)
            {
                microgramo = MIni / 0.0000010000; //ecuacion de gr
            }
            if(cmbMedidas.SelectedIndex==3)
            {
                microgramo = MIni / 0.0000000010000; //ecuacion para kg
            }
            if (cmbMedidas.SelectedIndex == 4)
            {
                microgramo = MIni / 0.0000000000010000; //ecuacion en t
            }
        }
        private void convertir_a_miligramo()
        {
            if(cmbMedidas.SelectedIndex==0)
            {
                miligramo = MIni / 1000.0; //mic a miligramo
            }
            if(cmbMedidas.SelectedIndex==1)
            {
                miligramo = MIni;
            }
            if(cmbMedidas.SelectedIndex==2)
            {
                miligramo = MIni / 0.0010000; //gr a mg
            }
            if(cmbMedidas.SelectedIndex==3)
            {
                miligramo = MIni / 0.0000010000; // kg a 
            }
            if (cmbMedidas.SelectedIndex == 4)
            {
                miligramo = MIni / 0.0000000010000;
            }
        }
        private void convertir_a_gramos()
        {
            if(cmbMedidas.SelectedIndex==0)
            {
                gramo = MIni / 1000000;// microg a gr
            }
            if(cmbMedidas.SelectedIndex==1)
            {
                gramo = MIni / 1000.0; // mg a gr
            }
            if(cmbMedidas.SelectedIndex==2)
            {
                gramo = MIni; // gr
            }
            if(cmbMedidas.SelectedIndex==3)
            {
                gramo = MIni / 0.0010000; //kg a gr
            }
            if (cmbMedidas.SelectedIndex == 4)
            {
                gramo = MIni / 0.0000010000; //t a gr
            }
        }
        private void convertir_a_kg()
        {
            if(cmbMedidas.SelectedIndex==0)
            {
                kilogramo = MIni / 1000000000; //micg a kg
            }
            if(cmbMedidas.SelectedIndex==1)
            {
                kilogramo = MIni / 1000000; // mg a kg
            }
            if(cmbMedidas.SelectedIndex==2)
            {
                kilogramo= MIni / 1000.0 ; //gr a kg
            }
            if(cmbMedidas.SelectedIndex==3)
            {
                kilogramo = MIni; //kg
            }
            if (cmbMedidas.SelectedIndex == 4)
            {
                kilogramo = MIni / 0.0010000; //t a kg
            }
        }
        private void convertir_a_toneladas()
        {
            if(cmbMedidas.SelectedIndex==0)
            {
                tonelada = MIni / 1000000000000; //micg a t
            }
            if(cmbMedidas.SelectedIndex==1)
            {
                tonelada = MIni / 1000000000; //mg a t 
            }
            if(cmbMedidas.SelectedIndex==2)
            {
                tonelada = MIni / 1000000; //gr a t
            }
            if(cmbMedidas.SelectedIndex==3)
            {
                tonelada = MIni / 1000.0; //kg a t
            }
            if (cmbMedidas.SelectedIndex == 4)
            {
                tonelada = MIni; // t 
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by: Jonathan J.V\nVersion: 1.0", "Acerca De", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escribe en el cuadro de texto la cantidad y seleccione \nla unidad de medida del lado derecho", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
