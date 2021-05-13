using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Реализация устанавливает интерфейс для всех классов реализации. Он не
    // должен соответствовать интерфейсу Абстракции. На практике оба интерфейса
    // могут быть совершенно разными. Как правило, интерфейс Реализации
    // предоставляет только примитивные операции, в то время как Абстракция
    // определяет операции более высокого уровня, основанные на этих примитивах.
    public interface IImplementation
    {
        string OperationImplementation();
    }
}
