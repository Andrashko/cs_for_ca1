using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Operator:Emploeer
    {
        public Operator(string FullName, DateTime StartWork, DateTime StartPost)
            : base(FullName, StartWork, StartPost)
        {
            this.Salary = 1800;
            this.Post = "Оператор";
        }
    }
}
