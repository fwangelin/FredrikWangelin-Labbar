using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2InherencePolymorphism
{
    public class Mammals : Animals
    {
        public int NumberOfLegs { get; set; }

        public override string IntroductionOfAnimals()
        {

            return String.Format("{0} Number of legs: {1}",
                                base.IntroductionOfAnimals(),
                                NumberOfLegs);
        }
    }
}