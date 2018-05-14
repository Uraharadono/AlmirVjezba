using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAL
{
    public class MyContext: DbContext
    {
        public MyContext() :
            base("Name=MojConnectionString")
        {


        }
       

    }
}
