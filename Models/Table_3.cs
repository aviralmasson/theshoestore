namespace Shoestore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_3
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int footsize { get; set; }

        [Key]
        [StringLength(50)]
        public string Models { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }

        public int quantity { get; set; }
    }
}
