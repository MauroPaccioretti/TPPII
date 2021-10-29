using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Datos
{
    class UsuariosDao : IUsuarios
    {
        HelperDAO helper = HelperDAO.GetInstance();

        public bool CreateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            
            if (helper.Login(username, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RecoverPassword(string userRequesting)
        {
            return helper.RecoverPassword(userRequesting);
        }
    }
}
