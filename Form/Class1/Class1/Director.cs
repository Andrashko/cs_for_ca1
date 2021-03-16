using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    /* На основі класу Emploeer створити класи, для
представлення директорів (назва відділення, кількість менеджерів та працівників,
що є у підпорядкуванні)
    */
    class Director : Emploeer
    {
        public String Department { get; }
        public int ManagerCount { get;  }

        public int WorkerCount { get;  }

        public Director(string FullName, DateTime StartWork, DateTime StartPost, string Deprtment, 
            int ManagerCount, int WokerCount) : base(FullName, StartWork, StartPost) 
        {
            this.Department = Department;
            this.ManagerCount = ManagerCount;
            this.WorkerCount = WorkerCount;
            this.Salary = 3000;
            this.Post = "Директор";
        }

      
    }
}
