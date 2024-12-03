using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DTO
{
    [Table("products")]
    public partial class Product
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            cart_items = new HashSet<CartItems>();
            comments = new HashSet<comment>();
            order_items = new HashSet<OrderItems>();
            ratings = new HashSet<Rating>();
        }

        [Key]
        public int product_id { get; set; }

        [StringLength(255)]
        public string product_name { get; set; }

        public decimal? price { get; set; }

        public int? stock { get; set; }

        public string description { get; set; }

        [StringLength(int.MaxValue)]
        public string product_image { get; set; }

        public int? category_id { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public int? sold { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItems> cart_items { get; set; }

        public virtual Category category { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> order_items { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> ratings { get; set; }
    }
}
