using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopCore.Models
{
    public class Product
    {
        [Key]
        [Column(Order = 1)]
        public Guid Id { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(2048)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public List<ProductImage> ProductImage { get; set; }
    }
}
