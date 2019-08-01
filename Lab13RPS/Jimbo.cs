using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class Jimbo : Player
    {

        
        public override Roshambo GenerateRoshambo()
        {
            string result = Enum.GetName(typeof(Roshambo), RandomNum());
            Enum.TryParse(result, out Roshambo roshambo );
            return roshambo; 
        }
        public static int RandomNum()
        {
            Random random = new Random();
            int r = random.Next(1, 4);
            return r;
        }
    }
}
