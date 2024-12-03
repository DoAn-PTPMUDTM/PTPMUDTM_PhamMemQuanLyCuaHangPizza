using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("policy")]
    public partial class Policy
    {
        [Key]
        public int policy_id { get; set; }

        public string policy_content { get; set; }
    }
}
