﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _4Point1_EF.Models
{
    [Table("manufacturer")]
    public partial class Manufacturer
    {
        // Initialize the navigation property.
        public Manufacturer()
        {
            Cars = new HashSet<CodeFirstCar>();
        }

        [Key]
        [Column("id", TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column("name", TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column("year_founded", TypeName = "int(10)")]
        public int? YearFounded { get; set; }

        // This property represents a list of all the related entities which have this entity's primary key as their foreign key. It saves using LINQ to try and filter on the primary key and makes things more readable.
        [InverseProperty(nameof(Models.CodeFirstCar.ManufacturerRed))]
        public virtual ICollection<CodeFirstCar> Cars { get; set; }
    }
}
