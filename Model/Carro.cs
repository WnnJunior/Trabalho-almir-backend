using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TrabalhoCarros.Model
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required]
        public int Ano { get; set; }

        [Required]
        [StringLength(20)]
        public string Cor { get; set; }

        [Required]
        [StringLength(50)]
        public string Motor { get; set; }

        [Required]
        [StringLength(20)]
        public string Combustivel { get; set; }
    }
}
