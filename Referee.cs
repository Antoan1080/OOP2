using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_1080
{
    internal class Referee : Person
    {
        public Referee(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }
    }
}
