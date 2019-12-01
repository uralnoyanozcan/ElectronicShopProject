namespace WebApplication1.App_Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTable")]
    public partial class UserTable
    {
        [Key]
        public int userID { get; set; }

        [Required]
        [StringLength(50)]
        public string userName { get; set; }

        [Required]
        [StringLength(10)]
        public string password { get; set; }
    }
}
