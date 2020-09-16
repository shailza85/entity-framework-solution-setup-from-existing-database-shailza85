using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExistingDBPractice.Models
{
    [Table("person")]
    public partial class Person
    {
        public Person()
        {
            Phonenumber = new HashSet<Phonenumber>();
        }

        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<Phonenumber> Phonenumber { get; set; }
    }
}
