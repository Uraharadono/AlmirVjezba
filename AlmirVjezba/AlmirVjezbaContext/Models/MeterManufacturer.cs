using AlmirVjezbaContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirVjezbaContext.Models
{
    public class MeterManufacturer : IEntity
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Number { get; set; }
    }
}
