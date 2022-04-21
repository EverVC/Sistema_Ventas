using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Ventas;

namespace Sistema_de_Ventas.Logica
{
    public class ListaUsuarios<User>//Lista de Usuarios
    {
        List<User> UsersList = new List<User>();//Hacemos la instancia de la lista

        //---Bloque para agregar un nuevo usuario a la lista
        public void AddUser(User newUser)
        {
            UsersList.Add(newUser);//Linea para agregar el usuario nuevo
        }

        //---Bloque para mostrar el listado completo de los usuarios
        public User[] ShowUsers()
        {
            User[] users = UsersList.ToArray();
            //return UsersList.ToArray();
            return users;
        }
        //---Bloque para buscar un elemento dentro de la lista, con parámetro el índice o posición a eliminar
        public User BuscarUsuario(int indice)
        {
            User usuarioBuscado = default(User);
            if(UsersList.Count !=0)
            {
                usuarioBuscado=UsersList[indice];
            }
            return usuarioBuscado;
        }
    }
}
