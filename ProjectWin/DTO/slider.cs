using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("slider")]
    public partial class Slider
    {
        [Key]
        public int slider_id { get; set; }

        public string slider_img { get; set; }

        public int? position { get; set; }
    }
}
