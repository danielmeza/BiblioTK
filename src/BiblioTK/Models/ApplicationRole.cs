using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioTK.Models
{
    [Table("Roles")]
    public class ApplicationRole : IdentityRole<string,ApplicationUserRole>
    {

        /// <summary>
        /// Descripcion en pocas palabras del rol y su uso.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Description { set; get; }

    }
}