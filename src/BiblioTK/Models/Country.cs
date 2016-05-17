﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioTK.Models
{
    /// <summary>
    /// Representa el pais
    /// </summary>
    public class Country
    {
        [Key]
        public int Id { set; get; }

        [Required]
        [MaxLength(70)]
        [Index("ixu_pais_nombre", IsUnique = true, IsClustered = false)]
        public string Name { set; get; }

        public virtual ICollection<ApplicationUser> ApplicationUsersByCountryOfBirth { set; get; }

        public virtual ICollection<ApplicationUser> ApplicationUsersByCountryOfResidence { set; get; }
    }
}