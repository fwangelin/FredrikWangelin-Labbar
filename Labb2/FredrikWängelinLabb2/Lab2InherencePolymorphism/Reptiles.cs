using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2InherencePolymorphism
{
    public class Reptiles : Animals
    {
        public string ColdBlooded { get; set; }

        public override string IntroductionOfAnimals()
        {

            return String.Format("{0} Cold blooded: {1}",
                                base.IntroductionOfAnimals(),
                                ColdBlooded);
        }

    }
}