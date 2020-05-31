using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallculateCahnceOfMark
{
    public class ChanceOf
    {
        private Dictionary<double, Dictionary<double, int>> pairs;

        public Dictionary<double, Dictionary<double,int>> Pairs { get { return this.pairs; } set { this.pairs = value; } }

        public double Chance(double pointsYouNeed = 23 , int numbOfQuestions = 100 , double chancePerQuestin = 1/4)
        {
            double chance = (100 - 23) ;
        }
    }
}
