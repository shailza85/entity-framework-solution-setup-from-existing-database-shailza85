using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExistingDBPractice.Models
{
    [Table("phonenumber")]
    public partial class Phonenumber
    {
        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "char(12)")]
        public string Number { get; set; }
        [Column("PersonID", TypeName = "int(10)")]
        public int PersonId { get; set; }

        [ForeignKey(nameof(PersonId))]
        [InverseProperty("Phonenumber")]
        public virtual Person Person { get; set; }
    }
}
