using AlmirVjezbaContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AlmirVjezbaContext.Models
{
    public class Meter : IEntity
    {
        [Key]
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public DateTime DateOfInstallation { get; set; }
        public long MeterTypeId { get; set; }
        [ForeignKey("MeterTypeId")]
        public MeterType MeterType { get; set; }
        public long MeterManufacturerId { get; set; }
        [ForeignKey("MeterManufacturerId")]
        public MeterManufacturer MeterManufacturer { get; set; }
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
