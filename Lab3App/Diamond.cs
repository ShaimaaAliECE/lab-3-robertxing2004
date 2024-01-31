using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(string desc, int score) {
            Description = desc;
            Score = score;
        }

        public override void Display()
        {
            Console.WriteLine("Diamond" + Description + " is displayed");
        }
    }
}
