﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public override void Display()
        {
            Console.WriteLine("MagicWand " + this.Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }
    }
}
