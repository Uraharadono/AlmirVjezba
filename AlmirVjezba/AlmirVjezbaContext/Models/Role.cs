﻿using AlmirVjezbaContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AlmirVjezbaContext.Models
{
    public class Role : IEntity
    {
        [Key]
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
    }
}
