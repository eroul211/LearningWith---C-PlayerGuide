namespace TheFinalBattle
{
    public class Character
    {
        public int FullHealth { get; private set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public bool IsAlive { get; set; } 
        public Action? StandardAttack { get; private set; }
        public Action? Action { get; set; }

        public Character(int fullHealth, bool isAlive, Action standardAttack)
        {
            this.FullHealth = fullHealth;
            this.Health = FullHealth;
            this.IsAlive = isAlive;
            this.StandardAttack = standardAttack;
        }
       
    }
}
