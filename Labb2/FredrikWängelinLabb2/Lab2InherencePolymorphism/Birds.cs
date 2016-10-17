using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2InherencePolymorphism
{
    public class Birds : Animals
    {
       
        public string WingSpan { get; set; }

        public override string IntroductionOfAnimals()
        {

            return String.Format("{0} Wing span: {1}",
                                base.IntroductionOfAnimals(),
                                WingSpan);
        }
    }
}