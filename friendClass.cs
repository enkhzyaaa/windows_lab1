using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gereltsetseg
{
    namespace Lab1
    {
        class Employee
        {
            private int id;
            public int subid { get { return id; } set { id = value; } }
            private String name;
            public String subname { get { return name; } set { this.name = value; } }
            private int age;
            public int subage { get { return age; } set { this.age = value; } }
            private String rank;
            public String subrank { get { return rank; } set { this.rank = value; } }
        }
    }
}
