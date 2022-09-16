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
        //define auto-implentemedt props for posistion, goalsm assists, primaryNO

        public Position Position {get; set;}
        public int primaryNumber { get; set; }
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
        public Player(string fullName,Position position, int Primarynumber, int goals, int assists) : base(fullName)
        {
            Position = position;
            primaryNumber = Primarynumber;
            Goals = goals;
            Assists = assists;
        }
    }
}
