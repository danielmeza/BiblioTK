using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTK.Models
{
    /// <summary>
    /// Nos permite personalizar los user claims, se pueden agregar mas propiedades
    /// </summary>
    public class ApplicationUserClaim : IdentityUserClaim<string>
    {

    }
}
