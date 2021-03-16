using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Створити клас Emploeer, який представляє працівника (паспортні дані, дата
прийняття на роботу, дата вступу на поточну посаду) і містить методи знаходження
стажу, авансу та заробітної плати. На основі цього класу створити класи, для
представлення директорів (назва відділення, кількість менеджерів та працівників,
що є у підпорядкуванні), менеджерів та операторів заводу. Якщо стаж 5 (10) років,
то розмір заробітної плати збільшується на 10% (25%). Визначити розміри заробітної
плати працівників, дані яких згенеровано випадковим чином, якщо оклад директора
3000 грн., менеджера –2500 грн., оператора – 1800 грн. Вивести на екран дані тих

працівників, які отримують заробітну плату, вищу ніж середня заробітна плата на
заводі.
 */
namespace Class1
{
    class Emploeer
    {
        public string FullName { get; }
        public DateTime StartWork { get; }
        public DateTime StartPost { get; }

        public string Post { get; set; } = "Парцівник";

        protected double Salary = 0;

        public Emploeer(string FullName, DateTime StartWork, DateTime StartPost)
        {
            this.FullName = FullName;
            this.StartWork = StartWork;
            this.StartPost = StartPost;
        }
        public int GetExperience()
        {
            return (int)((DateTime.Now - this.StartWork).Days / 365);
        }

        public double Prepayment
        {
            get
            {
                return this.Salary * 0.5;
            }
        }

        public double Remuneration
        {
            get
            {
                return this.Salary*this.Increase - this.Prepayment;
            }
        }

        public double Increase
        {
            get //Якщо стаж 5 (10) років, то розмір заробітної плати збільшується на 10% (25%).
            {
                if (this.GetExperience() >= 10)
                    return 1.25;
                if (this.GetExperience() >= 5)
                    return 1.10;
                return 1.0;
            }
        }


        
    }
}
