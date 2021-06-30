using System.ComponentModel.DataAnnotations;
using Products.Domain.Models.Abstract;

namespace Products.Domain.Models
{
    public class Product : IProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description {get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage ="Price value needs to be above 1")]
        public int Price { get; set; }
    }
}
