using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopCore.Models
{
    public class ProductImage
    {
        [Key]
        [Column(Order = 1)]
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        [StringLength(64)]
        public string FilePath { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
