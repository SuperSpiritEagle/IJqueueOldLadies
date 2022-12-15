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
            int hours;
            int minutes;
            Console.WriteLine("Введите количество человек в очереди");
            countPeople = Convert.ToInt32(Console.ReadLine());
            countPeople *= receptionTime;
            minutes = countPeople;
            countPeople /= minutesHour;
            hours = countPeople;
            countPeople *= minutesHour;
            minutes -= countPeople;
            Console.WriteLine($"Вы должны отстоять в очереди {hours} часа : {minutes} минут");
        }
    }
}
