using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlmirVjezbaContext1.Helper;
namespace AlmirVjezbaContext1.Model
{
    public class User : IEntity
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }

    }
}
