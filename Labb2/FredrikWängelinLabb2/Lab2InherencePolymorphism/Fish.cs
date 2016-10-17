using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2InherencePolymorphism
{
    public class Fish : Animals
    {
        public string CanSwim { get; set; }


        public override string IntroductionOfAnimals()
        {

            return String.Format("{0} Can it swim: {1}",
                                base.IntroductionOfAnimals(),
                                CanSwim);
        }

    }
}