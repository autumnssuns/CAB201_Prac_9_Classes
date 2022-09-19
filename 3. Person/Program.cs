using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        public static void Main(string[] args)
        {
            Worker tutor = new Worker("Dan", 0.5, "Nothing");
            Console.WriteLine(tutor.IntroduceWorker());
            CEOWorker superTutor = new CEOWorker("Timothy", 250, "Spaghetti");
            Console.WriteLine(superTutor.IntroduceWorker());
        }
    }
}
