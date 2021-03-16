using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Plant
    {
        public List<Emploeer> emploeers = new List<Emploeer>();

        public int Count
        {
            get
            {
                return this.emploeers.Count;
            }
        }

        public void GenerateRandomData(int count)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int depCount = 0;
            this.emploeers.Clear();
            for(int i=0; i<count; i++)
            {
                string fullname = $"Працівник {i}";
                DateTime startWork = new DateTime(rnd.Next(1980, 2020), rnd.Next(1, 12), rnd.Next(1, 28));
                DateTime startPost = new DateTime(rnd.Next(1980, 2020), rnd.Next(1, 12), rnd.Next(1, 28));
                int post = rnd.Next(0, 3);
                if (post == 0)
                {
                    string department = $"Відділеня {depCount++}";
                    int managerCount = rnd.Next(1, 10);
                    int workerCount = rnd.Next(2, 100);
                    this.emploeers.Add(new Director(fullname, startWork, startPost, department, managerCount, workerCount));
                }

                if (post == 1)
                {
                    int workerCount = rnd.Next(2, 100);
                    this.emploeers.Add(new Manager(fullname, startWork, startPost, workerCount));
                }

                if (post == 2)
                {
                    this.emploeers.Add(new Operator(fullname, startWork, startPost));
                }
            }
        }

        public double getAvarageSalary()
        {
            double res = 0;
            foreach (Emploeer emploeer in this.emploeers)
            {
                res += emploeer.Prepayment + emploeer.Remuneration;
            }
            return res / this.Count;
        }

    //    Вивести на екран дані тих працівників, які отримують заробітну плату,
    //    вищу ніж середня заробітна плата на заводі.
        
        public List<Emploeer> getMoreThenAvarageSeleryList()
        {
            double avgSelary = this.getAvarageSalary();
            return this.emploeers.FindAll(
                e => (e.Prepayment+e.Remuneration) > avgSelary
            );
        }
    }
}
