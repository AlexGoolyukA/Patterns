namespace Bridge
{
    // Абстракция устанавливает интерфейс для «управляющей» части двух иерархий
    // классов. Она содержит ссылку на объект из иерархии Реализации и
    // делегирует ему всю настоящую работу
    class Abstraction
    {
        protected IImplementation _implementation;
        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }
}
