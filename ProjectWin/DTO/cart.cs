using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DTO
{
    [Table("carts")]
    public partial class Cart
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cart()
        {
            cart_items = new HashSet<CartItems>();
        }

        [Key]
        public int cart_id { get; set; }

        public int? user_id { get; set; }

        public decimal? total_price { get; set; }

        public int? total_quantity { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItems> cart_items { get; set; }

        public virtual User user { get; set; }
    }
}
