using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BiblioTK.Models
{
    /// <summary>
    /// Clase personalizada que hereda de IdentityUser, nos permite agregar los campos de Nombres , Nivel y Fecha de enrolamiento.
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
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

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Aca podemos agregar el codigo para personalizar el claims del usuario.
            return userIdentity;
        }
    }
}