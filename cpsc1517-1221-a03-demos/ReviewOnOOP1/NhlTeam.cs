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
        //define an auto implemented property with a private set for players

        public List<NhlRoster> Players { get; private set; }

        private const int MaxPlayers = 23;
        public void AddPlayer(NhlRoster currentPlayer)
        {
            if (Players.Count >= MaxPlayers)
            {
                throw new ArgumentException("Roster is full. Remove a player first");

            }
            Players.Add(currentPlayer);
        }
        public void RemovePlayer(int playerNo)
        {
            //Remove from the players list the player with the matching playerNo.
            //Throw can Arguement exception if the player number does not exist 
            bool foundPlayer = false;
            int playerindex = -1;
            for (int index = 0; index < Players.Count; index++)
            {
                if (Players[index].playerNumber == playerNo)
                {
                    foundPlayer = true;
                    playerindex = index;
                    index = Players.Count; //stop loop
                }
            }
            if(!foundPlayer)
            {
                throw new ArgumentException($"player {playerNo}not found");
            }
                

            
        }
        public NhlTeam(NhlConference conference, NhlDivision division, string name, string city,List<NhlRoster> players)
        {
            //create a new list of roster if none is provided 
            if(players == null)
            {
                players = new List<NhlRoster>();

            }
            else
            {
                Players = players;
            }
            Conference = conference;
            Division = division;
            Name = name;
            City = city;
        }
         public NhlTeam(NhlConference conference, NhlDivision division, string name, string city)

        {
          
            Players = new List<NhlRoster>();
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
