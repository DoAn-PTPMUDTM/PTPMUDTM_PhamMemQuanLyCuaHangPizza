using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DTO
{
    [Table("users")]
    public partial class User
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            carts = new HashSet<Cart>();
            comments = new HashSet<comment>();
            orders = new HashSet<Order>();
            ratings = new HashSet<Rating>();
        }

        [Key] public int user_id { get; set; }

        [StringLength(255)] public string email { get; set; }

        [StringLength(255)] public string password { get; set; }

        [StringLength(255)] public string full_name { get; set; }

        [StringLength(50)] public string role { get; set; }

        [StringLength(50)] public string status { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> carts { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> orders { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> ratings { get; set; }
    }
}