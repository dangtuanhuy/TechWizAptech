using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkGenerator.Models
{
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Address { get; set; }

      

    }
}
