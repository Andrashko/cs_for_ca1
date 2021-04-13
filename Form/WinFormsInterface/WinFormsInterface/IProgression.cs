using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInterface
{
    /*
     * Створити інтерфейс, що містить опис методів для знаходження
        n -го члена та суми перших n членів прогресії.
     */
    interface IProgression
    {
        double NthElement(int n);
        double SumOfFirstNthElements(int n);
    }
}
