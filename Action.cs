using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class Action
    {
        public Random _random = new();

        public string SkillName { get; private set; }
        private int _damageAction;

        public Action(string skillName, int damageAction)
        {
            SkillName = skillName;
            _damageAction = damageAction;
        }
        public virtual void Run(Character character, Character enemy)
        {
            character.Damage = HitChange();
            Console.WriteLine($"{character} used {SkillName} on {enemy}");
            if (character.Damage == 0) Console.WriteLine($"{character} MISSED!");

            Console.WriteLine($"{SkillName} dealt {character.Damage} damage to {enemy}\n");
            enemy.Health = enemy.Health - character.Damage >= 0 ? enemy.Health - character.Damage : 0;
        }
        private int HitChange()
        {
            if (_random.Next(2) == 0)
            {
                return 0;
            }
            else
                return _damageAction;
        }
    }
}
