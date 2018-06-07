using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopCore.Models
{
    public class Request
    {
        [Key]
        [Column(Order = 1)]
        public Guid Id { get; set; }

        [StringLength(64)]
        public string FirstName { get; set; }

        [StringLength(64)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string Email { get; set; }

        [StringLength(2048)]
        public string Comment { get; set; }

        [StringLength(32)]
        public string FilePath { get; set; }
    }
}
