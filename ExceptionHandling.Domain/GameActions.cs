using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Domain
{
    public class GameActions
    {

        public static void Battle(Character attacker, Character defender)
        {
            if (attacker.HitPoints <= 0)
                throw new ArgumentOutOfRangeException("Attacker is already dead.");
            if (defender.HitPoints <= 0)
                throw new ArgumentOutOfRangeException("Defender is already dead.");


            Random random = new Random();
            int attackValue = random.Next(100);

            defender.HitPoints -= attackValue;

        }




    }
}
