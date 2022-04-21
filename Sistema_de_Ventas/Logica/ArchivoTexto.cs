using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Sistema_de_Ventas.Logica
{
    public class ArchivoTexto
    {

        //Método constructor
        public ArchivoTexto()
        {
            
        }

        //Método para crear y/o escribir en el archivo
        public void Registrarse(string nombres, string apellidos,string userName,string sexo, string pass)
        {
            bool except=false;//Variable booleana para saber si ocurrió un error al crear o escribir en el archivo
            try
            {
                //Crear el archivo "Datos"
                StreamWriter escribirArchivo = File.AppendText("C:\\Users\\PC\\Documents\\PRACTICAS\\C#\\Sistema_de_Ventas\\Sistema_de_Ventas\\DB\\DataColection.txt");
                escribirArchivo.WriteLine(userName+","+pass+":"+nombres+"."+apellidos+";"+sexo+"*");//En el archivo "Datos" escribe el nombre de usuario y la contraseña
                escribirArchivo.Close();//Se cierra el archivo "Datos"
            }
            catch
            {
                except = true;//Si ocurrió un error, almacenamos el valor true en la variable
            }
            finally
            {
                if (except)//Si la variable está en true (Osea que ocurrió una excepción)
                {
                    MessageBox.Show("OCURRIO UN ERROR AL CREAR SU CUENTA, FAVOR INTENTELO DE NUEVO");//Le informamos al usurio que ocurrió un problema
                }
                else//De otro modo (No hubo excepción)
                {
                    MessageBox.Show("EL REGISTRO SE HA HECHO DE MANERA EXITOSA!");//Indicamos que se ha registrado de manera exitosa.
                }
            }
        }

        public void Ingresar()
        {
            
            
        }
    }
}
