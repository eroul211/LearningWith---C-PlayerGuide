using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {

        }

        public override string GetUserInput()
        {
            string userInput = Console.ReadLine()!;
            return userInput;
        }
        public override Character GetEnemy() => Enemy = Enemies[_random.Next(Enemies.Count)];
    }
}
