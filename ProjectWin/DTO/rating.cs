using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("rating")]
    public partial class Rating
    {
        [Key]
        public int rate_id { get; set; }

        public int? user_id { get; set; }

        public int? product_id { get; set; }

        public int? rate { get; set; }

        public virtual Product product { get; set; }

        public virtual User user { get; set; }
    }
}
