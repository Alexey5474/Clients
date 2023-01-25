using System;
using System.Collections.Generic;
using System.Text;

namespace People_Credits
{
    public class ClientsFabric
    {
        public static Clients CreateClient(string name, int age, Clients.EType type)
        {
            Clients result = null;

            if (type == Clients.EType.Base)
                result = new Base(name, age);
            if (type == Clients.EType.Bad)
                result = new Bad(name, age);
            if (type == Clients.EType.Inner)
                result = new Inner(name, age);
            if (type == Clients.EType.Benefits)
                result = new Benefits(name, age);

            return result;
        }
    }
}
