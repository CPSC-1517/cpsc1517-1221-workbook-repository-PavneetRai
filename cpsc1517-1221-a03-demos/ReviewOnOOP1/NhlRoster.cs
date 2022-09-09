using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOnOOP1
{
    public class NhlRoster
    {
        public NhlConference Conference { get; private set; }
        public NhlDivision Division { get; private set; }
        
        public Playerposition Playerposition { get; private set; }

        private const int Min = 0;
        private const int Max = 98;
        private int number;
        public int playerNumber
        {
            get => number;
            set
            {
                if(value > Min || value > Max)
                {
                    throw new ArgumentOutOfRangeException("Must be more than zero and less than one ");
                }
                number = value;
            }
        }
        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("must have a name");
                }
                _Name = value;
            }
        }
        //private string lastName;
        //public string LastName
        //{
        //    get => lastName;
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            throw new ArgumentNullException("must have a name");
        //        }
        //        lastName = value;
        //    }
        //}
        //private string position;
        //public string Position
        //{
        //    get => position;
        //    set
        //    {
        //        if(string.IsNullOrWhiteSpace(value))
        //                {
        //            throw new ArgumentNullException("must have a position");

        //        }
        //        position = value;
        //    }
        //}
        public NhlRoster( Playerposition playerposition , int playerNumber, string name)
        {
           
            Playerposition = playerposition;
            //Number = playernumber;
            this.playerNumber = playerNumber;
            Name = name;



            //LastName = lastName;


        }
        public override string ToString()
        {
            return$"{playerNumber},{Name},{Playerposition}"; 
                
        }
    }
}
