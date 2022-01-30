using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        int player_position = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            int dice = random.Next(1, 7);
            return dice;
        }
    }
}
