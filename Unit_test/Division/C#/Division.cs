using System;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестировать функции деления двух чисел используя оператор исключения.");
            Console.WriteLine("Справка: при делении на ноль типов с плавающей точкой никогда не генерируется исключение,");
            Console.WriteLine("вместо этого всегда возращается значение, по умолчанию описанное в стандарте, то есть infinity.");
            try
            {
                Console.WriteLine("Введите делимое");               
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите делитель");
                int b = int.Parse(Console.ReadLine());
                double s = a / b;
                Console.WriteLine(s);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка. На ноль делить нельзя!");
            }
            catch 
            {
                Console.WriteLine("Ошибка");
            }
            finally
            {
                Console.WriteLine("Размер типа данных int равен " + sizeof(int) + " bytes");
                Console.WriteLine("Размер типа данных float равен " + sizeof(float) + " bytes");
                Console.WriteLine("Конец программы");
            }
        }
    }
}
