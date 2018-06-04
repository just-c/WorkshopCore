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
        public Guid request_id { get; set; }

        [StringLength(64)]
        public string first_name;

        [StringLength(64)]
        public string last_name;
    }
}
