﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entities
{
    public class Usuario
    {
        [Key]
        public Guid id { get; set; }

        public Guid idPais { get; set; }
        [Required]
        public string email { get; set; }

        public DateTime? fechaNacimiento { get; set; }

        [Required]
        public string password { get; set; }
    }
}