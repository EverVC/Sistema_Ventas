using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Sistema_de_Ventas.Logica;

namespace Sistema_de_Ventas
{
    public partial class Form1 : Form
    {
        public Form Home;//Ayudará para abrir éste formulario desde otro
        
        public Form1()
        {
            InitializeComponent();//Inicializa los componentes
            txtBoxPass.PasswordChar= '*';//Inicializa la forma de el cuadro de texto donde se almacenará la contraseña con "*"
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//Solo maximice al area de trabajo y no a la pantalla completa
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cierra la aplicacion
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)//Si la ventana de windows está normal
            {
                this.WindowState = FormWindowState.Maximized;//Entonces la maximizamos
            }
            else if(this.WindowState == FormWindowState.Maximized)//Si la ventana está maximizada
            {
                this.WindowState= FormWindowState.Normal;//Entonces la ponemos normal
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimizamos
        }

        private void btnVerPass_Click(object sender, EventArgs e)
        {
            if(txtBoxPass.PasswordChar == '\0')//Si el cuado de texto tiene elementos que son visibles y se preciona el botón de NO VER
            {
                btnNoVerPass.BringToFront();//Muestra la imagen de "NoVerPass" que indica que no estará viendo la contraseña
                txtBoxPass.PasswordChar='*';//Y muestra la contraseña con el formato de "*"
            }
        }

        private void btnNoVerPass_Click(object sender, EventArgs e)
        {
            if (txtBoxPass.PasswordChar == '*')//Si la contraseña se ve con "*"
            {
                btnVerPass.BringToFront();//Al darle click se mostrará la otra imagen "VerPass" que indica que estará viendo la contraseña
                txtBoxPass.PasswordChar='\0';//Y mostrará la contraseña con formato alfanumerico.
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //StreamWriter escribirArchivo = File.AppendText("C:\\Users\\PC\\Documents\\PRACTICAS\\C#\\Sistema_de_Ventas\\Sistema_de_Ventas\\DB\\DataColection.txt");
            //escribirArchivo.Close();
            string linea;//Permitirá leer la linea del archivo de texto en donde esta el correo y contraseña
            string nombre;//Almacenará los nombres del usuario (los cuales serán extraidos del archivo por medio de la linea2)
            bool except=true;//Ayudará a saber si el usuario ya está registrado o no
            Usuario usuario = new Usuario();//Almacenará los datos del usuario que ingresa
            ListaUsuarios<Usuario> usuarioRegistrado = new ListaUsuarios<Usuario>();
            StreamReader leerArchivo = new StreamReader("C:\\Users\\PC\\Documents\\PRACTICAS\\C#\\Sistema_de_Ventas\\Sistema_de_Ventas\\DB\\DataColection.txt");//Abre el archi de correo y contraseña
            linea = leerArchivo.ReadLine();//Lee la linea 1
            while (linea != null)//Mientras la linea 1 del archivo no esté vacía
            {
                
                if(txtBoxNameUser.Text+","+txtBoxPass.Text == linea.Substring(0,linea.IndexOf(":")))//Si el nombre de usuario y contraseña que fueron ingresados, es igual a el nombre de usuario y contraseña que esté en el archivo
                {
                    //nombre = linea.Substring(posicion1,posicion2);//Almacenará en "nombre" todo lo que haya en la "linea2" hasta que llegue a la "posicion" que es el lugar donde está la coma
                    //IndexOf() extrae la posicion de un elemento indicado en una cadena de texto
                    nombre = linea.Substring((linea.IndexOf(":")+1),(linea.IndexOf(".")-linea.IndexOf(":")));

                    //usuario.setUserName(txtBoxNameUser.Text);
                    //usuario.setPassword(txtBoxPass.Text);
                    //usuario.setNames(linea.Substring(linea.IndexOf(":")+1, linea.IndexOf(".")-linea.IndexOf(":")));
                    //usuario.setSurnames(linea.Substring(linea.IndexOf(".")+1,linea.IndexOf(";") - linea.IndexOf(".")-1));
                    usuario.IngresarDatos(linea.Substring(linea.IndexOf(":")+1, linea.IndexOf(".")-linea.IndexOf(":")), linea.Substring(linea.IndexOf(".")+1, linea.IndexOf(";") - linea.IndexOf(".")-1), txtBoxNameUser.Text,linea.Substring(linea.IndexOf(";")+1,linea.IndexOf("*")-linea.IndexOf(";")-1), txtBoxPass.Text);
                    
                    usuarioRegistrado.AddUser(usuario);
                    if(linea.Substring(linea.IndexOf(";")+1, linea.IndexOf("*")-linea.IndexOf(";")-1) == "Masculino")
                    {
                        MessageBox.Show("Bienvenido de nuevo "+txtBoxNameUser.Text+"!");//Da la bienvenida, concatena el nombre de usuario y los nombres ingresados a la hhora del registro
                    }
                    else
                    {
                        MessageBox.Show("Bienvenida de nuevo "+txtBoxNameUser.Text+"!");//Da la bienvenida, concatena el nombre de usuario y los nombres ingresados a la hhora del registro
                    }
                    
                    
                    PMenu secundario = new PMenu();
                    secundario.Sexo = linea.Substring(linea.IndexOf(";")+1, linea.IndexOf("*")-linea.IndexOf(";")-1);
                    secundario.lblNameUserMenu.Text = txtBoxNameUser.Text;
                    this.Hide();
                    secundario.IrMenu = this;
                    secundario.Show();
                    
                    
                    except = false;//Se pone en falso cuando el usuario sí fue encontrado
                }
                linea = leerArchivo.ReadLine();//Lee la siguiente linea si el usuario aún no ha sido encontrado

            }
            leerArchivo.Close();//Cierra el archivo de texto
            if (except)//Si la variable contiene un valor verdadero es porque el usuario no fué encontrado
            {
                MessageBox.Show("OCURRIO UN ERROR AL BUSCAR SU CUENTA, FAVOR INTENTELO DE NUEVO O ASEGURESE DE TENER UNA.", "ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro secundarioRegistro = new Registro();//Crea un objeto de el formulario de registro
            this.Hide();//Oculta éste formulario Principal
            secundarioRegistro.Registrarse = this;//Al objeto se le asigna el valor de formulario de registro
            secundarioRegistro.Show();//Se muestra el formulario de registro
        }
    }
}
