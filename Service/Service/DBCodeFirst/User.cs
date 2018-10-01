namespace Service.DBCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(50)]
        public string Specialization { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string UserPassword { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }
    }
}
