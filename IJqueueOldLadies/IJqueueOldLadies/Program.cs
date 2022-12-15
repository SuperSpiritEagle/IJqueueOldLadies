using System;

namespace IJqueueOldLadies
{
    class Program
    {
        static void Main(string[] args)
        {
            const int receptionTime = 10;
            int countPeople;
            Console.WriteLine("Введите количество человек в очереди");
            countPeople = Convert.ToInt32(Console.ReadLine());
            countPeople *= receptionTime;
            var queueTime = TimeSpan.FromMinutes(countPeople);
            Console.WriteLine($"Вы должны отстоять в очереди {queueTime}");
        }
    }
}
