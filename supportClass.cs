using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkhzaya
{
    namespace lab1
    {
        class User
        {
            private int id;
            public int supportId  { 
                get { return id; } 
                set { id = value; } 
            }
            private String name;
            public String supportName {
                get { return name; } 
                set { this.name = value; } 
            }
        }
    }
}
