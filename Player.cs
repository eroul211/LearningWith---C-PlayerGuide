using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class Player
    {
        private readonly Random _random = new();
        public List<Character>? Enemies { get; private set; }
        private Character? _enemy;
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

        public static string UserInput()
        {
            Console.Write("Enter the True programmers name: ");
            string input = Console.ReadLine()!;
            return input;
        }
        public void PlayerTurn(List<Character> characters, List<Character> enemies)
        {
            Enemies = enemies;
            if(characters.Count != 0 & enemies.Count != 0)
            {
                foreach (Character character in characters)
                {
                    if (character.Health != 0)
                    {
                        Console.WriteLine($"It is {character}'s turn... ");
                        _enemy = GetEnemy();
                        character.Action = GetAction(character);
                        character.Action.Run(character, _enemy);

                        _enemy.IsAlive = _enemy.Health == 0 ? false : true;
                        if (_enemy.IsAlive == false)
                        {
                            Console.WriteLine($"{_enemy} DIED!!");
                            Thread.Sleep(1500);
                            enemies.Remove(_enemy);
                            if (enemies.Count == 0)
                                break;
                        }
                        Thread.Sleep(2000);
                    }
                }
            }
        }
        public virtual Character GetEnemy() => _enemy = Enemies[_random.Next(Enemies.Count)];

    }
}
