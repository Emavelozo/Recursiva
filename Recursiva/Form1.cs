using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad.Modelos;


namespace Recursiva
{
    public partial class Form1 : Form
    {
        private string strConsigna;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPersonasRegistradas.Enabled = false;
            txtSociosRacing.Enabled = false;
            btnPunto3.Visible = false;
            btnPunto4.Visible = false;
            btnPunto5.Visible = false;
        }                    
        private void btbObtenerDatos_Click(object sender, EventArgs e)
        {
            strConsigna = "Listado de todas las personas registradas.";
            lblConsigna.Text = strConsigna;
            //Variables 
            int intCantidadRegistros = 0;            
            clsConsultas_1y2 consulta = new clsConsultas_1y2();
            
            dgvRegistros.DataSource = consulta.ObtenerRegistros();
            intCantidadRegistros = dgvRegistros.Rows.Count;
            
            txtPersonasRegistradas.Text = intCantidadRegistros.ToString();
            txtSociosRacing.Text = consulta.PromedioEdadRacing().ToString("N2");

            btnPunto3.Visible = true;
            btnPunto4.Visible = true;
            btnPunto5.Visible = true;
        }
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            strConsigna = "Primeras 100 personas casadas y con estudios Universitarios. De menor a Mayor.";
            lblConsigna.Text = strConsigna;
            clsConsulta3 consulta = new clsConsulta3();
            dgvRegistros.DataSource = consulta.ObtenerRegistros();            

        }
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            strConsigna = "Los cinco nombres mas comunes entre los hinchas de River.";
            lblConsigna.Text = strConsigna;
            clsConsulta4 consulta = new clsConsulta4();
            dgvRegistros.DataSource = consulta.ObtenerRegistros();
        }
        private void btnPunto5_Click(object sender, EventArgs e)
        {
            strConsigna = "Cantidad de socios por equipo, promedio de edad, menor y mayor edad.";
            lblConsigna.Text = strConsigna;
            clsConsulta5 consulta = new clsConsulta5();
            dgvRegistros.DataSource = consulta.ObtenerRegistros();
        }
    }
}
