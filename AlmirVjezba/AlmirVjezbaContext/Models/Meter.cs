﻿using AlmirVjezbaContext.Interfaces;
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
        public List<MeterType> MeterType { get; set; }
        [ForeignKey("MeterTypeId")]
        public long MeterTypeId { get; set; }
        public List<MeterManufacturer> MeterManufacturer { get; set; }
        [ForeignKey("MeterManufacturerId")]
        public long MeterManufacturerId { get; set; }
        public User User { get; set; }
        [ForeignKey("UserId")]
        public long UserId { get; set; }
    }
}
