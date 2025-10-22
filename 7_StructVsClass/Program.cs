namespace _7_StructVsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // инициализация класса и структуры
            var baseClass = new BaseClass { Value = 1 };
            var baseStruct = new BaseStruct { Value = 1 };

            // применим методы к классу и структуре
            ChangeClassValue(baseClass);
            ChangeStructValue(baseStruct);

            // выведем значения полей класса и структуры
            Console.WriteLine($"Value (class): {baseClass.Value}"); // 100
            Console.WriteLine($"Value (struct): {baseStruct.Value}"); // 1

            // дополнительный пример метода, берущего структуру baseStruct по ссылке
            ChangeStructValue(ref baseStruct);
            Console.WriteLine($"Value (struct) после передачи по ссылке: {baseStruct.Value}");
        }

        static void ChangeClassValue(BaseClass baseClass) // передача по ссылке
        {
            baseClass.Value = 100;
        }

        static void ChangeStructValue(BaseStruct baseStruct) // передача по значению
        {
            baseStruct.Value = 100;
        }

        /*
            Когда мы создаем экземпляр класса BaseClass, переменная baseClass хранит ссылку на объект в управляемой куче.
            При вызове ChangeClassValue(baseClass) мы передаем копию ссылки на тот же объект. 
            Обе ссылки (в Main и в методе) указывают на один и тот же объект.
            Изменение Value внутри метода меняет данные исходного объекта. Поэтому после вызова метода baseClass.Value равно 100.

            Когда мы создаем экземпляр структуры BaseStruct, переменная baseStruct хранит само значение (располагается в стеке).
            При вызове ChangeStructValue(baseStruct) мы передаем полную копию структуры. 
            Метод работает с изолированной копией, а не с исходной структурой.
            Изменения в копии не влияют на исходную структуру => baseStruct.Value остается равным 1.

            Но стоит обратить внимание на то, что структуру все таки можно передать по ссылке, это делается при помощи ключевого слова ref.
            В этом случае создается в стек помещается ссылочный указатель на оригинальную структуру => метод будет работать с ориг. структурой
            через этот указатель. Данный метод находится ниже.

            Но зачем тогда нам классы, если мы можем работать со структурами и передавать их по ссылке (работа рантайма на стеке быстрее, чем в куче)?
            Дело в том, что структуры не могут наследоваться от других структур...
        */

        static void ChangeStructValue(ref BaseStruct baseStruct) // передача структуры по ссылке
        {
            baseStruct.Value = 100; // работа с оригиналом
        }
    }
}
