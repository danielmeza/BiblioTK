using BiblioTK.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BiblioTK.Models
{
    /// <summary>
    /// Clase personalizada que hereda de IdentityUser, 
    /// nos permite agregar los campos de Nombres , Nivel y Fecha de enrolamiento.
    /// </summary>
    [Table("Usuarios")]
    public class ApplicationUser : IdentityUser<string, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        [Key]
          // TODO: Colcoar esto en el migrations para que se modifique la columna id y se coloque está funcion como defualt value[DefaultValue("NEWSEQUENTIALID()")] // Por razones de performance se utiliza esta funcion en vez de NEWID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // para que se genere desde la función por default
        public override string Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public byte Level { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }

        [Required]
        [MaxLength(100)]
        public String Website { get; set; }

        [Column("PaisNacimientoID")]
        public int CountryOfBirthID { set; get; }

        [Column("PaisResidenciaID")]
        public int CountryOfResidenceID { set; get; }

        public virtual Country CountryOfBirth { set; get; }

        public virtual Country CountryOfResidence { set; get; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}