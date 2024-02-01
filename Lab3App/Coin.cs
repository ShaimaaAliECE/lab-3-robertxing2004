using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value; 

        public Coin(string desc, int score, int value) {
            Description = desc;
            Score = score;
            Value = value;
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
    }
}
