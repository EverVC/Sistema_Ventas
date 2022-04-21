using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Ventas.Logica;

namespace Sistema_de_Ventas
{
    public partial class PMenu : Form
    {
        public Form IrMenu;
        public string Sexo;
        public PMenu()
        {
            InitializeComponent();
        }
        private void PMenu_Load(object sender, EventArgs e)
        {
            if(Sexo == "Masculino")
            {
                imgUserMasculino.BringToFront();
            }
            else
            {
                imgUserFemenino.BringToFront();
            }
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            //Pregunta al usuario si desea cerrar sesión, si la respuesta es "Si"
            if(MessageBox.Show("¿DESEA CERRAR SESION?","ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Vuelve al incio
                Form1 copia = new Form1();//Crea una copia del formulario de inicio
                copia.Home = this;//Al objeto creado se le asigna el valor del formulario principal
                this.Close();//CIERRA ESTE FORMULARIO
                copia.Show();//ABRE FORMULARIO PRINCIPAL
            }
            else
            {
                //Sino muestra un mensaje y se queda en el menú
                MessageBox.Show("LA SESION SIGUE");
            }
            
        }

        private void MaximizarMenu_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)//Si la ventana de windows está normal
            {
                this.WindowState = FormWindowState.Maximized;//Entonces la maximizamos
            }
            else if (this.WindowState == FormWindowState.Maximized)//Si la ventana está maximizada
            {
                this.WindowState= FormWindowState.Normal;//Entonces la ponemos normal
            }
        }

        private void MinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimizamos
        }
        
    }
}
