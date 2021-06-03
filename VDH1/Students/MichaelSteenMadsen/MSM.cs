using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDH1.Students.MichaelSteenMadsen
{
    class MSM
    {
        //  Property
        public string FullName { get; set; }

        //  Constructor
        public MSM(string fullname)
        {
            this.FullName = fullname;
        }

        //  Override
        public override string ToString()
        {
            return $"Michael Steen Madsen";
        }
    }
}
