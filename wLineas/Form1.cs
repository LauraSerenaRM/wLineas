using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Fecha: Marzo 14 de 2023
// Autor: Laura Serena Rivera Mejia
// Descripción: Aplicacion para dibujar una linea.
//




namespace wLineas
{
    public partial class frmDibujarLinea : Form
    {

        
        Graphics dibujo;


        public frmDibujarLinea()
        {
            InitializeComponent();
            dibujo =CreateGraphics();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujarLinea_Click(object sender, EventArgs e)
        {
            //Instrucción que intenta un bloque de código, de no recibir el tipo de dato solicitado, atrapa el error
            //y devuelve un mensaje notificando la instrucción para el proceso correcto.
            try
            {
                double xInicial = double.Parse(txtXInicial.Text);
                double xFinal = double.Parse(txtXFinal.Text);
                double yInicial = double.Parse(txtYInicial.Text);
                double yFinal = double.Parse(txtYFinal.Text);

               clsLinea Linea = new clsLinea(xInicial, xFinal, yInicial, yFinal);

                Pen lapicero = new Pen(Color.Fuchsia);
                dibujo.DrawLine(lapicero, Linea.obtenXInicial(), Linea.obtenXfinal(), Linea.obtenYInicial(), Linea.obtenYFinal());
               txtResultado.Text = Convert.ToString(clsLinea.obtenCuentaDeLinea());
            }
            catch (Exception) 
            {
                //Se retira el throw del catch para que no cierre la aplicación de Windows Forms
                MessageBox.Show("Digite sólo números.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
    }
}
