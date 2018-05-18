using AlmirVjezbaContext.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirVjezbaContext.Models
{
    public class Address : IEntity
    {
        [Key]
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Addition { get; set; }
        public string ZipCode { get; set; }
    }
}
