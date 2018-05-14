using AlmirVjezbaContext1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirVjezbaContext1.Model
{
    public class Meter : IEntity
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public DateTime DateOfInstallation { get; set; }
        public MeterType MeterType { get; set; }
        public long MeterTypeId { get; set; }
        public MeterManufacturer MeterManufacturer { get; set; }
        public long MeterManufacturerId { get; set; }

    }
}
