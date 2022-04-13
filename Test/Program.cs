using MyLogger;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Log.LogWriter("Начало выполнения программы", Log.LogLevel.Debug);
                Console.WriteLine("a = 1 / b");
                Console.WriteLine("Введите число b");
                double b = Convert.ToDouble(Console.ReadLine());
                Log.LogWriter($"Введено число b = {b}", Log.LogLevel.Info);
                if (b == 0) { 
                    Log.LogWriter("Деление double на ноль, результат: бесконечность", Log.LogLevel.Warning);
                    Console.WriteLine("Деление double на ноль, результат: бесконечность");
                    return;
                }
                double a = 1 / b;
                Log.LogWriter($"Формула просчитана успешно, результат: {a}", Log.LogLevel.Info);
                Console.WriteLine("a = " + a);
            }
            catch (Exception ex)
            {
                Log.LogWriter($"{ex.Message}", Log.LogLevel.Error, ex);
                throw;
            }
            finally { Log.LogWriter("Конец выполнения программы", Log.LogLevel.Debug); }
        }
    }
}