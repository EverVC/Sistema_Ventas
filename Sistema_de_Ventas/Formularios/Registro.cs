using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Ventas.Logica;

namespace Sistema_de_Ventas
{
    public partial class Registro : Form
    {
        public Form Registrarse;//Ayudará a poder abrir ésta ventana desde otra
        public Registro()
        {
            InitializeComponent();
            txtBoxNombres.Focus();
            txtBoxPass2.PasswordChar= '*';//Inicializa la forma de el cuadro de texto donde se almacenará la contraseña con "*"
            txtBoxConfirmPass.PasswordChar= '*';//Inicializa la forma de el cuadro de texto donde se almacenará la contraseña con "*"
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//Solo maximice al area de trabajo y no a la pantalla completa 
        }

        private void Minimizar3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimizamos
        }

        private void Maximizar3_Click(object sender, EventArgs e)
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

        private void btnCerrar3_Click(object sender, EventArgs e)
        {
            Form1 copia = new Form1();//Crea una copia del formulario de inicio
            copia.Home = this;//Al objeto creado se le asigna el valor del formulario principal
            this.Close();//CIERRA ESTE FORMULARIO
            copia.Show();//ABRE FORMULARIO PRINCIPAL
        }

        private void btnNoVerPass2_Click(object sender, EventArgs e)
        {
            if (txtBoxPass2.PasswordChar == '*')//Si la contraseña se ve con "*"
            {
                btnVerPass2.BringToFront();//Al darle click se mostrará la otra imagen "VerPass" que indica que estará viendo la contraseña
                txtBoxPass2.PasswordChar='\0';//Y mostrará la contraseña con formato alfanumerico.
            }
        }

        private void btnVerPass2_Click(object sender, EventArgs e)
        {
            if (txtBoxPass2.PasswordChar == '\0')//Si el cuado de texto tiene elementos que son visibles y se preciona el botón de NO VER
            {
                btnNoVerPass2.BringToFront();//Muestra la imagen de "NoVerPass" que indica que no estará viendo la contraseña
                txtBoxPass2.PasswordChar='*';//Y muestra la contraseña con el formato de "*"
            }
        }

        private void btnRegistrarseF_Click(object sender, EventArgs e)
        {
            bool excep=false,usuarioExiste=false;//Variable para saber si se pudo crear la cuenta o no
            string linea,userName;
            StreamReader leerArchivo = new StreamReader("C:\\Users\\PC\\Documents\\PRACTICAS\\C#\\Sistema_de_Ventas\\Sistema_de_Ventas\\DB\\DataColection.txt");//Abre el archi de correo y contraseña
            linea = leerArchivo.ReadLine();
            while(linea != null)
            {
                if(linea.Substring(0, linea.IndexOf(",")) == txtBoxNameUser2.Text)
                {
                    MessageBox.Show("EL NOMBRE DE USUARIO YA ESTA EN USO, POR FAVOR INGRESE OTRO", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuarioExiste = true;
                }
                linea = leerArchivo.ReadLine();
            }
            leerArchivo.Close();
            if(usuarioExiste!=true)//Si el nombre de usuario aún no existe en la base de datos
            {
                //Variables que almacenan los datos de registro
                string names = txtBoxNombres.Text;
                string surnames = txtBoxApellidos.Text;
                userName = txtBoxNameUser2.Text;//Debe averiguar si ya hay un usuario con ese nombre y no permitirle el acceso con el mismo
                string password = txtBoxPass2.Text;
                string sexo;

                ArchivoTexto archivoTexto = new ArchivoTexto();//Instancia un objeto para poder crear o escribir en el archivo
                Usuario usuario = new Usuario();//El objeto usuario almacenará los datos del registro
                ListaUsuarios<Usuario> listaUsuarios = new ListaUsuarios<Usuario>();//El usuarió que será registrado será guardado en una lista

                if (rbtnFemenino.Checked)
                {
                    sexo = "Femenino";
                    if (password.Length < 8)//Si la contraseña que ingresó tiene menos de 8 caracteres
                    {
                        MessageBox.Show("LA CONTRASEÑA DEBE CONTENER AL MENOS 8 CARACTERES");//Se le dice que al menos tiene que usar 8
                    }
                    else if (password == txtBoxConfirmPass.Text)//Si la contraseña que digitó es igual a la misma contraseña en el espacio de confirmación
                    {
                        //MessageBox.Show("BIENVENIDO A LA COMUNIDAD!");
                        try
                        {
                            archivoTexto.Registrarse(names, surnames, userName, sexo, password);//Se llama la función para escribir los datos en el archivo .txt
                            usuario.IngresarDatos(names, surnames, userName, sexo, password);//se llama a la función para almacenar los datos de un usuario nuevo
                            listaUsuarios.AddUser(usuario);//Agrega el usuario con sus datos a la lista
                        }
                        catch
                        {
                            excep = true;//Si ocurre un error tendrá el valor true
                        }
                        finally
                        {
                            if (excep)//Si ha ocurrido un error
                            {
                                MessageBox.Show("OCURRIO UN ERROR", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                PMenu secundario = new PMenu();
                                secundario.Sexo = sexo;
                                secundario.lblNameUserMenu.Text = txtBoxNameUser2.Text;
                                this.Hide();
                                secundario.IrMenu = this;
                                secundario.Show();
                            }
                        }
                    }
                    else//De otro modo, si se cumple la primer condicion, pero no así la segunda 
                    {
                        //Significa que la contraseña de confirmacion no es igual a la que se asigno
                        MessageBox.Show("LAS CONTRASEÑAS NO COISIDEN, INTENTELO DE NUEVO");//Se le indica eso al usuario
                    }
                }
                else if (rbtnMasculino.Checked)
                {
                    sexo = "Masculino";
                    if (password.Length < 8)//Si la contraseña que ingresó tiene menos de 8 caracteres
                    {
                        MessageBox.Show("LA CONTRASEÑA DEBE CONTENER AL MENOS 8 CARACTERES");//Se le dice que al menos tiene que usar 8
                    }
                    else if (password == txtBoxConfirmPass.Text)//Si la contraseña que digitó es igual a la misma contraseña en el espacio de confirmación
                    {
                        //MessageBox.Show("BIENVENIDO A LA COMUNIDAD!");
                        try
                        {
                            archivoTexto.Registrarse(names, surnames, userName, sexo, password);//Se llama la función para escribir los datos en el archivo .txt
                            usuario.IngresarDatos(names, surnames, userName, sexo, password);//se llama a la función para almacenar los datos de un usuario nuevo
                            listaUsuarios.AddUser(usuario);//Agrega el usuario con sus datos a la lista

                        }
                        catch
                        {
                            excep = true;//Si ocurre un error tendrá el valor true
                        }
                        finally
                        {
                            if (excep)//Si ha ocurrido un error
                            {
                                MessageBox.Show("OCURRIO UN ERROR", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                PMenu secundario = new PMenu();
                                secundario.Sexo = sexo;
                                secundario.lblNameUserMenu.Text = txtBoxNameUser2.Text;
                                this.Hide();
                                secundario.IrMenu = this;
                                secundario.Show();
                            }
                        }
                    }
                    else//De otro modo, si se cumple la primer condicion, pero no así la segunda 
                    {
                        //Significa que la contraseña de confirmacion no es igual a la que se asigno
                        MessageBox.Show("LAS CONTRASEÑAS NO COISIDEN, INTENTELO DE NUEVO");//Se le indica eso al usuario
                    }
                }
                else
                {
                    MessageBox.Show("POR FAVOR SELECCIONE SU SEXO");
                }
            }
        }

        private void txtBoxPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled=false;
            }
            else if(e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("EL CARACTER NO ESTA PERMITIDO.","ATENCION!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (e.KeyChar == ':')
            {
                e.Handled = true;
                MessageBox.Show("EL CARACTER NO ESTA PERMITIDO.", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = true;
                MessageBox.Show("EL CARACTER NO ESTA PERMITIDO.", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar == ';')
            {
                e.Handled = true;
                MessageBox.Show("EL CARACTER NO ESTA PERMITIDO.", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = true;
                MessageBox.Show("EL CARACTER NO ESTA PERMITIDO.", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
                MessageBox.Show("LA CONTRASEÑA NO PUEDE CONTENER ESPACIOS.", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
