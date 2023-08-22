using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    public enum Color
    {
        Black,
        White,
        Brown
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Color Color { get; set; }
    }

}

