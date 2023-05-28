using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_1080
{
    internal class Player : Person
    {
        public int Number { get; set; }
        public int Height { get; set; }
        public Player(string name, int age, int number, int height) : base(name, age)
        {
            this.Number = number;
            this.Height = height; 
        }


    }
}
