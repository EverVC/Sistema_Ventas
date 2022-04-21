using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas.Logica
{
    public class Usuario
    {
        //Atributos
        protected string Names;//Nombres
        protected string Surnames;//Apellidos
        protected string UserName;//Nombre de usuario
        protected string Sexo;
        protected string Password;//Contraseña

        //Métodos constructores
        public Usuario()
        {

        }
        public Usuario(string names, string surnames, string userName, string password)//método para usar el polimorfismo
        {
            this.Names = names;
            this.Surnames = surnames;
            this.UserName = userName;
            this.Password = password;
        }

        //Métodos setters y getters
        public void setNames(string names)
        {
            this.Names = names;
        }
        public void setSurnames(string surnames)
        {
            this.Surnames = surnames;
        }
        public void setUserName(string userName)
        {
            this.UserName = userName;
        }
        public void setSexo(string sexo)
        {
            this.Sexo = sexo;
        }
        public void setPassword(string password)
        {
            this.Password = password;
        }

        public string getNames()
        {
            return Names;
        }
        public string getSurnames()
        {
            return Surnames;
        }
        public string getUserName()
        {
            return UserName;
        }
        public string getSexo()
        {
            return Sexo;
        }
        public string getPassword()
        {
            return Password;
        }

        //Método para ingresar los datos de un usuario
        public void IngresarDatos(string names, string surnames, string userName,string sexo, string password)
        {
            this.Names = names;
            this.Surnames = surnames;
            this.UserName = userName;
            this.Sexo = sexo;
            this.Password = password;
        }

    }
}