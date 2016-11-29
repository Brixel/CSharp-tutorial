using System;
using System.Globalization;
using Tutorial.Helper;

namespace FirstConsoleApplication.Model
{
    public abstract class Human : IBirthdayMessage
    {
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

        public string FullBirthDate => string.Format(BirthDate.Day + " " +
                                                     CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(BirthDate.Month) + " " +
                                                     BirthDate.Year);

        public int Age => CalculateAge();
        protected abstract int CalculateAge();

        public abstract void SayBirthDayMessage();
    }

    public interface IBirthdayMessage
    {
        void SayBirthDayMessage();
    }


    public class Female : Human
    {
        protected override int CalculateAge()
        {
            var age = Calculator.GetAge(BirthDate);
            return --age;
        }

        public override void SayBirthDayMessage()
        {
            if (BirthDate == DateTime.Now)
            {
                Console.WriteLine($"Happy birthday {Name}");
            }
            else
            {
                var daysLeft = Calculator.GetDaysLeft(BirthDate);
                Console.WriteLine($"Sorry {Name}, you'll have to wait {daysLeft} day(s)");
            }
        }
    }

    public class Male : Human
    {
        protected override int CalculateAge()
        {
            var age = Calculator.GetAge(BirthDate);
            return age;
        }

        public override void SayBirthDayMessage()
        {
            Console.WriteLine("It's yer birthday!");
        }
    }
}