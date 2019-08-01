using System;
using System.Collections.Generic;
using System.Text;


namespace Lab13RPS
{
    enum Roshambo
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo ValueOfRo {get; set;}
        
        public Player()
        {

        }

        public abstract Roshambo GenerateRoshambo();           
        
    }
}
