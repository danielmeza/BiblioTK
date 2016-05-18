using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace BiblioTK.Models
{
    /// <summary>
    /// Clase que representa la tabla que rompe la relación entre ApplicationUser y ApplicationRole se pueden agregar mas propiedades
    /// </summary>
    public class ApplicationUserRole : IdentityUserRole<string>
    {
       
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}