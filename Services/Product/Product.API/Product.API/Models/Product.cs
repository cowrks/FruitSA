using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.API.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        [Column(TypeName = "decimal(19,4)")]
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public Category Category { get; set; }
    }
}
