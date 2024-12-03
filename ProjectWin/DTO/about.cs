using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("about")]
    public partial class About
    {
        [Key]
        public int about_id { get; set; }

        public string content { get; set; }
    }
}
