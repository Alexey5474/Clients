using System;
using System.Collections.Generic;
using System.Text;

namespace People_Credits
{
    class Bad: Clients
    {
        public override EType Type => EType.Bad;

        public Bad(string name, int age) : base(name, age) { }
        public override string ShowCreditAmountAndProcent()
        {

            Console.WriteLine($"Клиент {this.Name} не может рассчитывать на получение кредита");
            return string.Empty;
        }
    }
}
