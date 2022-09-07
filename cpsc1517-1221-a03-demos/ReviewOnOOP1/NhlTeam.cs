using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOnOOP1
{
    public class NhlTeam
    {

        public NhlConference Conference { get; private set; }
        public NhlDivision Division { get; private set; }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name must contain text");

                }
                _name = value.Trim();
            }
        }
        private string _city;
        public string City
        {
            get => _city;
            private set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("city must contain text");

                }
                _city = value.Trim();
            }
        }
        private int _gamesplayed;
        public int Gamesplayed
        {
            get=> _gamesplayed;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("must be more than one ");

                }
                _gamesplayed = value;
            }
        }
        private int _wins;
        public int Wins 
        { 
            get => _wins; 
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("must be more than one");
                }
                _wins = value;
            }
                     
        }
        private int _losses;
        public int Lossess
        {
            get => _losses;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("must be more than one ");
                }
                _losses = value;
            }

        }
        private int _overtimelosses;
        public int Overtimelosses
        {
            get => _overtimelosses;
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("must be more than one ");
                }
                _overtimelosses = value;
            } 

        }
        
        public int Points
        {
            get => (Wins * 2) + Overtimelosses;

        }
         public NhlTeam(NhlConference conference, NhlDivision division, string name, string city)
        {
            Conference = conference;
            Division = division;    
            Name = name;
            this.City = city;

            Gamesplayed = 0;
            Wins = 0;
            Lossess = 0;
            Overtimelosses =0;


        }
        public override string ToString()
        {
           // return base.ToString();
           return $"{Conference},{Division},{Name}, {City}, {Gamesplayed},{Wins},{Lossess},{Overtimelosses}";
        }

        ////defing data feilds for storing data 
        //private HockeyConference _conference; 
        //private HockeyDivision _division;

        ////define fully-implmented properites for the data feilds 
        //public HockeyConference Conferecce
        //{
        //    get { return _conference; }
        //}
        //public HockeyDivision Division
        //{
        //    get { return _division; }
        //    set { _division = value; }
        //}
    }
}
