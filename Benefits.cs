using System;
using System.Collections.Generic;
using System.Text;

namespace People_Credits
{
    class Benefits : Clients
    {
        public override EType Type => EType.Benefits;

        public Benefits(string name, int age) : base(name, age) { }
        public override string ShowCreditAmountAndProcent()
        {

            double amount = 6000000;
            double credit_time = 36;
            double CreditAmountAndProcent = 0.05;
            double MonthPay = amount * (CreditAmountAndProcent + 
                (CreditAmountAndProcent / (Math.Pow((1 + CreditAmountAndProcent), credit_time))));
            Console.WriteLine($"Клиент {this.Name} может рассчитывать на сумму {amount} " +
                $"сроком на {credit_time} месяцев" +
                $" c процентной ставкой {CreditAmountAndProcent * 100} % годовых" +
                $"\n ежемесячный платеж составит {Math.Round(MonthPay/10)} рублей");
            return string.Empty;
        }
    }
}
