using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public abstract class Player
    {
        public Random _random = new();
        public List<Character>? Enemies { get; private set; }
        public Character? Enemy { get; set; }
        public virtual Action GetAction(Character character)
        {
            return character switch
            {
                Skeleton          => new Bone(),
                TheTrueProgrammer => new Punch(),
                TheUncodedOne     => new UnravelingAttack(),
                VinFletcher       => new UnravelingAttack(),
                _                 => new DoNothing()
            };
        }

        
        public void PlayTurn(List<Character> characters, List<Character> enemies)
        {
            Enemies = enemies;
            if(characters.Count != 0 & enemies.Count != 0)
            {
                foreach (Character character in characters)
                {
                    if (character.Health != 0)
                    {
                        Console.WriteLine($"It is {character}'s turn... ");
                        Enemy = GetEnemy();
                        character.Action = GetAction(character);
                        character.Action.Run(character, Enemy);

                        Enemy.IsAlive = Enemy.Health == 0 ? false : true;
                        if (Enemy.IsAlive == false)
                        {
                            Console.WriteLine($"{Enemy} DIED!!");
                            Thread.Sleep(1500);
                            enemies.Remove(Enemy);
                            if (enemies.Count == 0)
                                break;
                        }
                        Thread.Sleep(2000);
                    }
                }
            }
        }
        public abstract Character GetEnemy();
        public abstract string GetUserInput();
        public string NameTheTrueProgrammer()
        {
            Console.Write($"Insert a name for TheTrueProgrammer: ");
            return GetUserInput();
        }

    }
}
