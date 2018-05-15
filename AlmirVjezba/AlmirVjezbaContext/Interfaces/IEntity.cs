using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirVjezbaContext.Interfaces
{
    public class IEntity
    {
        long Id { get; set; }
        bool IsDeleted { get; set; }
    }
}
