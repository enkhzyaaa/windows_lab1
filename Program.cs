using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gereltsetseg.Lab1;

namespace Enkhzaya
{
    namespace lab1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("hello world");
                User user = new User();
                user.supportId = 1022;
                user.supportName = "Enkzaya";
                Console.WriteLine(user.supportName + " " + user.supportId);
                Employee emp = new Employee();
                emp.subid = user.supportId;
                emp.subname = user.supportName;
                emp.subage = 20;
                emp.subrank = "Student";
                Console.WriteLine(emp.subname + emp.subage);
            }
        }
    }
}
