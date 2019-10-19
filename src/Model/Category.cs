using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public int Posts { get; set; }
    }
}
