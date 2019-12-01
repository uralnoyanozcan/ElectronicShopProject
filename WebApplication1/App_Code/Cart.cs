namespace WebApplication1.App_Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("Cart")]
    public partial class Cart
    {
        public int ID { get; set; }

        public int ClientID { get; set; }

        public int ProductID { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }

        public bool IsInCart { get; set; }

        public virtual Products Product { get; set; }
    }
}
