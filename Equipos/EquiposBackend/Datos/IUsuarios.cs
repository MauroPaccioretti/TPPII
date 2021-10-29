using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Datos
{
    interface IUsuarios
    {
        bool CreateUsuario(Usuario usuario);
        bool Login(string username, string pass);
        string RecoverPassword(string userRequesting);
    }
}
