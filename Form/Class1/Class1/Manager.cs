using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Manager: Emploeer
    {
        public int WorkerCount { get; }
        public Manager(string FullName, DateTime StartWork, DateTime StartPost, int WokerCount) 
            : base(FullName, StartWork, StartPost)
        {
            this.WorkerCount = WorkerCount;
            this.Salary = 2500;
            this.Post = "Менеджер";
        }

        
    }
}
