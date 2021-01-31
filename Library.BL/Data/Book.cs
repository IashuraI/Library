using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.BL.Data
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [MaxLength(150)]
        [Required]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Author { get; set; }
        [MaxLength(50)]
        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public long Amount { get; set; }
    }
}
