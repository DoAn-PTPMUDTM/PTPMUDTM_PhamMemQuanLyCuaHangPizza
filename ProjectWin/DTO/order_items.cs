using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("order_items")]
    public partial class OrderItems
    {
        [Key]
        public int order_item_id { get; set; }

        public int? order_id { get; set; }

        public int? product_id { get; set; }

        public int? quantity { get; set; }

        public decimal? total_price { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public virtual Order order { get; set; }

        public virtual Product product { get; set; }
    }
}
