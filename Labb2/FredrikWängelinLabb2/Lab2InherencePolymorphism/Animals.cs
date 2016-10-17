using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2InherencePolymorphism
{
    public abstract class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Sound { get; set; }
        public string Movement { get; set; }
        

        public virtual string IntroductionOfAnimals()
        {
           return String.Format("Name: {0}, Age: {1}, Weight: {2} kgs, Sound: {3}, Movement: {4}",
                          Name,
                          Age,
                          Weight,
                          Sound,
                          Movement);
        }
    }
}