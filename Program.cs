using System;

namespace People_Credits
{
    public class Program
    {
        static void Main(string[] args)
        {
            Clients Alex = ClientsFabric.CreateClient("Александр", 25, Clients.EType.Base);
            Clients Maria = ClientsFabric.CreateClient("Мария", 25, Clients.EType.Inner);
            Clients Oleg = ClientsFabric.CreateClient("Олег", 25, Clients.EType.Bad);
            Clients Daria = ClientsFabric.CreateClient("Дарья", 25, Clients.EType.Benefits);

            Console.WriteLine(Alex.ShowCreditAmountAndProcent());
            Console.WriteLine(Maria.ShowCreditAmountAndProcent());
            Console.WriteLine(Oleg.ShowCreditAmountAndProcent());
            Console.WriteLine(Daria.ShowCreditAmountAndProcent());

            Console.ReadKey();
        }
      
    }
}
