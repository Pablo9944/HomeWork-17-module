using HomeWork_17_module.choice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17_module
{
    public class Account:IOrdinary,ISalary
    {
       

        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // расчет процентной ставки обычного аккаунта по правилам банка
        void IOrdinary.CalculateInterest()
        {

           Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

        }
        void ISalary.CalculateInterest()
        {
           Interest = Balance * 0.5;
        }
    }
    
}
