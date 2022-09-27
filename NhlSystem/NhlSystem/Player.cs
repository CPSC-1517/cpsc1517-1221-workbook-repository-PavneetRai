using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystem
{
    //define a class name player that inherits from the person base class 
    public class Player : Person
    {
        //define an fully-implemented property with a backing feild 
   private int _primaryNo;
        public int PrimaryNo
        {
            get
            {
                return _primaryNo;  
            }
            set
            {
                //validate the new value is between 0 and 98 
                if (value <0 || value >98 )
                {
                    throw new ArgumentOutOfRangeException("PrimaryNo must between 0 and 98");
                }
                _primaryNo = value;
            }
        }

        //define auto-implentemedt props for posistion, goalsm assists, primaryNO

        public Position Position {get; set;}
        //public int primaryNumber { get; set; }
        public int Goals { get; set; }  
        public int Assists { get; set; }

     

       
        //define a read-only computed property for points 
        public int Points
        {
            get
            {

                return Goals + Assists;
            }
        }
        //define acontructor that passes fullName to base class 
        public Player(string fullName, Position position, int primaryNo) : base(fullName)
        {
            Position = position;
            PrimaryNo = primaryNo;
            Goals = 0;
            Assists = 0;
        }
        public Player(string fullName,Position position, int Primarynumber, int goals, int assists) : base(fullName)
        {
            Position = position;
            PrimaryNo = Primarynumber;
            Goals = goals;
            Assists = assists;
        }
        public override string ToString()
        {
            return $"{Position}, {PrimaryNo}, {Goals}, {Assists},{Points}";
        }
        public static Player ParseCsv(string line)
        {
            //define a constant for the Delimiiter character 
            const char Delimiter = ',';
            //Split the line into an array where each value is seperated by a Delimiter 
            string[] tokens = line.Split(Delimiter);
            /*The columns int he lines are in this order: 
             * 0) Name 
             * 1) Number
             * 2) Position 
             * 3) Goals
             * 4) Assist
             * 5) Points
            */
            //verify that there are 6 elements in the array 
            if (tokens.Length != 6)
            {
                throw new FormatException($"CSV line must contain exactly 6 values {line}");
            }
            string playerName = tokens[0];
            int playerNumber = int.Parse(tokens[1]);
            Position position = (Position)Enum.Parse(typeof(Position), tokens[2]); //to parse an enum //Type casting to transform one to another 
            int goals = int.Parse(tokens[3]);
            int assists = int.Parse(tokens[4]);
            //
            return new Player
                (
                    fullName: playerName,
                    primaryNo: playerNumber,
                    position: position,
                    goals: goals,
                    assists: assists
                );

        }
        public static bool TryParse(string line, out Player player)// when you call method and use "out" it does not make a copy 
        {
            bool success = false;
            try
            {
                player = ParseCsv(line);
                success = true;
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception($"Player Tryparse exception {ex.Message}");
            }
            return success;
        }

    }
}
