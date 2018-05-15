﻿using AlmirVjezbaContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirVjezbaContext.Models
{
    public class MeterType : IEntity
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
    }
}
