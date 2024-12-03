using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("cart_items")]
    public partial class CartItems
    {
        [Key]
        public int cart_item_id { get; set; }

        public int? cart_id { get; set; }

        public int? product_id { get; set; }

        public int? quantity { get; set; }

        public decimal? total_price { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public virtual Cart cart { get; set; }

        public virtual Product product { get; set; }
    }
}
