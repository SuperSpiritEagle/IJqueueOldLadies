using System;

namespace IJqueueOldLadies
{
    class Program
    {
        static void Main(string[] args)
        {
            int receptionTime = 10;
            int minutesHour = 60;
            int countPeople;
            int hoursLine;
            int minutesLine;
            Console.WriteLine("Введите количество человек в очереди");
            countPeople = Convert.ToInt32(Console.ReadLine());
            receptionTime *= countPeople;
            hoursLine = receptionTime / minutesHour;
            minutesLine = receptionTime % minutesHour;
            Console.WriteLine($"Вы должны отстоять в очереди {hoursLine} часа : {minutesLine} минут");
        }
    }
}
