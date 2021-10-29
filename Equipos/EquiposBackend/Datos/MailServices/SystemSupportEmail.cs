using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Datos.MailServices
{
    class SystemSupportEmail : MasterMailServices
    {
        public SystemSupportEmail()
        {
            SenderMail = "soportetecnicosoccer@gmail.com";
            Password = "Soccer1234";
            Host = "smtp.gmail.com";
            Port = 587;
            Ssl = true;
            initializeSmtpClient();
        }
    }
}
