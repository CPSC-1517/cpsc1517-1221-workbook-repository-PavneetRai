using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystem
{
    public class Team
    {
        //define a read only property for the coach 
        //the coach is another custom class 
        //The coach property is known as aggregation/composition, when the field is an object
        //ex the team consists of a coach
        public Coach Coach { get; private set; } = null!;

        //define a auto impleneted readonly property for players. dont want anyone to change the list 
        public List<Player> Players { get; } = new List<Player>();

        //define a method used to add a new Player to the team 

        public void AddPlayer(Player newPlayer)
        {
            //validate that the newPlayer is not null
            //create a method to add players 
            if(newPlayer == null)
            {
                throw new ArgumentNullException("Player is required");
            }
            //validate that the team size (23 players) is not full 
            if(Players.Count >= 3)
            {
                throw new ArgumentException("Team is full. cannot add anymore players");
            }
            //validate that the new player PrimaryNo is not already in use
            //this is a sequential search
            //bool primaryNoFound = false;

            //foreach(Player currentPlayer in Players )
            //{
            //    if(currentPlayer.PrimaryNo == newPlayer.PrimaryNo)
            //    {
            //        primaryNoFound = true;
            //        break; //exit foreach statement
            //    }
            //}
            //if(primaryNoFound)
            //{
            //    throw new ArgumentException("PrimaryNo is already in use by another player");
            //}
            ////add the new player to the team 
            //Players.Add(newPlayer);

            //validate that the new player PrimaryNo is not already in use using linQ 
            bool primaryNoFound = Players.Any(currentPlayer => currentPlayer.PrimaryNo == newPlayer.PrimaryNo);
            if(primaryNoFound)
            {
                throw new ArgumentException("Primary NO is already in use");
            }

        }

        //define a computed-property to return the total of Points of all players 
        //public int TotalPlayerPoints
        //{
        //    get
        //    {
        //        int totalPoints = 0; 
        //        foreach(Player currentPlayer in Players)
        //        {
        //            totalPoints += currentPlayer.Points;
        //        }
        //        return totalPoints;
        //    }

        //}
        //define a computed-property to return the total of Points of all players using linQ funtion for each 
        public int TotalPlayerPoints
        {
            get
            {
                //two ways to write 
                return Players
                    .Select(player => player.Points)
                    .Sum();
                return Players
                    .Sum(currentPlayer => currentPlayer.Points);
            }
        }
        

        //define a full implemented property with a backing feild for a teamname 
        private string _teamName = string.Empty;
        public string TeamName
        {
            get
            {
                return _teamName;

            }
            set
            {
                //validate the new value is not null, an empty string, or only whitespaces 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Team Name is required");
                }
                //validate the new value contains at least 5 or more characters
                if(value.Trim().Length < 5)
                {
                    throw new ArgumentException("Team Name must contain 5 or more characters");
                }
                _teamName = value;  
            }
        }

        public Team(string teamName, Coach coach  )
        {
            if(coach == null)
            {
                throw new ArgumentNullException("A team requires a coach.");
            }
            Coach = coach;         
            TeamName = teamName;
            
        }
        public override string ToString()
        {
            return $"{TeamName},{Coach}";
        }
    }
}
