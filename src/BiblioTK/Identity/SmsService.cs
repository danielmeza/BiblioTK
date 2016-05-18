using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTK.Identity
{
    /// <summary>
    /// Clase que se usa para enviar los mensajes a los celulares, implemente IIdentityMessageService
    /// </summary>
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            //TODO: Implementar codigo para enviar mensajes a telefonos
            throw new NotImplementedException();
        }
    }
}
