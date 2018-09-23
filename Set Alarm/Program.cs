using System;

namespace Set_Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            //explain program
            Console.WriteLine("Set an alarm!");

            //ask user for what time it is, specify format
            Console.Write("What time is it? (ex. 1:38 pm) ");

            //convert to datetime, assign variable
            DateTime currentTime = DateTime.Parse(Console.ReadLine());

            //print to console as military time
            Console.WriteLine($"Current time per 24 hour clock: {currentTime:HH:mm}");

            //prompt for how many hours from now they want the alarm to go off
            Console.Write("How many hours from now would you like to set an alarm for? ");

            //convert to int and assign variable
            int hours = int.Parse(Console.ReadLine());


            //take method and convert to datetime variable so it can be formatted when printing to console
            DateTime alarm = AlarmSet(currentTime, hours);

            Console.WriteLine($"Your alarm is set for: {alarm:M/dd/yyyy HH:mm:ss}");

            Console.ReadLine();

        }

        /// <summary>
        /// adds number of hours to time entered
        /// </summary>
        /// <param name="currentTime"></param>
        /// <param name="hours"></param>
        /// <returns>time it will be in number of hours user entered</returns>
        private static DateTime AlarmSet(DateTime currentTime, int hours)
        {
            return currentTime.AddHours(hours);
        }
        


    }
}
