using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Client
    {
        // За исключением этапа инициализации, когда объект Абстракции
        // связывается с определённым объектом Реализации, клиентский код должен
        // зависеть только от класса Абстракции. Таким образом, клиентский код
        // может поддерживать любую комбинацию абстракции и реализации.
        public void ClientCode(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Operation());
        }
    }
}
