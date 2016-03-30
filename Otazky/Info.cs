using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otazky
{
    class Info
    {
        public String firstQestion { set; get; }

        public String getfirstQestion()
        {
            return firstQestion;
        }
        public Info()
        {
            firstQestion = "ARPANET";
        }
        
    }
}
