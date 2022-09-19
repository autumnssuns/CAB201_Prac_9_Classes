using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Letter ordinaryLetter = new Letter("Lawrence", new MyDate(19, 9, 2022));
            Console.WriteLine($"This is an ordinary letter to {ordinaryLetter.Name}, " +
                $"sent on {ordinaryLetter.Date.Day}/{ordinaryLetter.Date.Month}" +
                $"/{ordinaryLetter.Date.Year}.");
            CertifiedLetter certifiedLetter = new CertifiedLetter("Lawrence", new MyDate(19, 9, 2022), 42);
            Console.WriteLine($"This is a certified letter to {certifiedLetter.Name}, " +
                $"sent on {certifiedLetter.Date.Day}/{certifiedLetter.Date.Month}" +
                $"/{certifiedLetter.Date.Year}. The tracking number is {certifiedLetter.TrackingNumber}");
        }
    }
}