using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK1PA_exercises
{
   internal class Contestant
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public double FinishingTime { get; set; }

        public Contestant(string firstName, string lastName, double finishingTime)
        {
            FirstName = firstName;
            LastName = lastName;    
            FinishingTime = finishingTime;
        }

    }
}
