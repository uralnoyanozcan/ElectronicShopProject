namespace WebApplication1.App_Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Cart = new HashSet<Cart>();
        }

        public int ID { get; set; }

        public int TypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
