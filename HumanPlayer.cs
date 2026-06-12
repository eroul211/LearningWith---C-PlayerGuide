using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    internal class HumanPlayer : Player
    {
        public override Action GetAction(Character character)
        {
            Console.WriteLine($"1 - Standard Attack ({character.StandardAttack.SkillName})");
            Console.WriteLine($"2 - Do Nothing ");
            Console.Write("What do you want to do? ");
            string userInput = Console.ReadLine()!;
            Console.WriteLine();
            if(userInput == "1")
            {
                return character switch
                {
                    Skeleton          => new Bone(),
                    TheTrueProgrammer => new Punch(),
                    TheUncodedOne     => new UnravelingAttack(),
                    VinFletcher       => new QuickShot()
                };
            }
            else
            {
                return new DoNothing();
            }
        }
        public override Character GetEnemy()
        {
            int count = 0;
            Console.Write("Choose enemy");
            foreach (Character enemy in Enemies)
            {
                Console.Write($" - {count}) {enemy}");
                count++;
            }
            Console.Write("\nPick one enemy: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value >= Enemies.Count)
                return Enemies[0];
            else
                return Enemies[value];
                
        }
    }
}
