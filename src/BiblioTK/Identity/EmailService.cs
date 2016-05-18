using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTK.Identity
{
    /// <summary>
    /// Clase que se usa para enviar los email a los clientes o usuarios de la app, implemente IIdentityMessageService
    /// </summary>
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            /// TODO: Implementar servicio de mesanjeria, el em message viene el contenido del email, body, subject y destinatario
            throw new NotImplementedException();
        }
    }
}
