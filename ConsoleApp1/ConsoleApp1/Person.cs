﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string Name;
        public int mark1;
        public int mark2;
        public int Total()
        {
            return mark1 + mark2;
        }
    }
}
