using System;
using System.Collections.Generic;
using System.Text;

namespace People_Credits
{
    public class Base: Clients
    {
        public override EType Type => EType.Base;

        public Base(string name, int age) : base(name, age) { }
        public override string ShowCreditAmountAndProcent()
        {

            double amount = 3000000;
            double credit_time = 24;
            double CreditAmountAndProcent = 0.12;
            double MonthPay = amount * (CreditAmountAndProcent + (CreditAmountAndProcent 
                / (Math.Pow((1 + CreditAmountAndProcent), credit_time))));
            Console.WriteLine($"Клиент {this.Name} может рассчитывать на сумму {amount} " +
                $"сроком на {credit_time} месяцев c процентной ставкой {CreditAmountAndProcent * 100}" +
                $" % годовых\n ежемесячный платеж составит {Math.Round(MonthPay/10)} рублей");
            return string.Empty;
        }

        public override double MonthPayTest()
        {
            double amount = 3000000;
            double credit_time = 24;
            double CreditAmountAndProcent = 0.12;
            double Result = (amount * (CreditAmountAndProcent + (CreditAmountAndProcent / 
                (Math.Pow((1 + CreditAmountAndProcent), credit_time)))))/10;
            return Math.Round(Result);
        }
    }
}
