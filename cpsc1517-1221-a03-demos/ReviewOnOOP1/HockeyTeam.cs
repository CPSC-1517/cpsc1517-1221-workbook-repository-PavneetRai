using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOnOOP1
{
    public class HockeyTeam
    {
        public enum HockeyConference { Eastern, Western}

        public enum HockeyDivision { Metropolitan, Alantic, Centeral, Pacific}

        //defing data feilds for storing data 
        private HockeyConference _conference; 
        private HockeyDivision _division;

        //define fully-implmented properites for the data feilds 
        public HockeyConference Conferecce
        {
            get { return _conference; }
        }
        public HockeyDivision Division
        {
            get { return _division; }
            set { _division = value; }
        }
    }
}
