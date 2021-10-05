using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ConcessionariaBelfiore.Shared.Models
{
    [Table("Automobile")]
    public partial class Automobile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Modello { get; set; }
        [Required]
        [StringLength(50)]
        public string Marca { get; set; }
        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }
    }
}
