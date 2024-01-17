using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaRestauranteRazor.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        /*        [MaxLength(2)]
                [Range(0, 100)]*/
        public string? Name { get; set; }

        [DisplayName("Valor da conta")]
        public double? Value { get; set; }
    }
}
