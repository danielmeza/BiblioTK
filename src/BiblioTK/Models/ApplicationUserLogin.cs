using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTK.Models
{
    /// <summary>
    /// Clase que nos permite personalizar la entidad de user login, 
    /// se puede agregar mas propiedas si es necesario
    /// </summary>
    public class ApplicationUserLogin : IdentityUserLogin<string>
    {
        
    }
}
