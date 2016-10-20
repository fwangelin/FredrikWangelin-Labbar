using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FredrikWängelin_Labb2
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public virtual string Move()
        {
            return "The animal moves around";
        }
    }
}