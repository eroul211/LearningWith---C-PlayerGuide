using TheFinalBattle;

class FinalBattle
{
    private readonly Player _player1 = new ComputerPlayer();
    private readonly Player _player2 = new ComputerPlayer();
    private Player? _currentPlayer;
    private readonly List<Character> _monsters;
    private readonly List<Character> _heroes;
    private static int _count = 1;

    public FinalBattle(Player player1, Player player2, List<Character> heroes, List<Character> monsters)
    {
        _player1 = player1;
        _player2 = player2;
        _heroes = heroes;
        _monsters = monsters;  
    }
    public bool RunBattle()
    {
        Console.Clear();
        Console.WriteLine($"Round {_count}");
        _currentPlayer = _player1;
        while (true)
        {
            BattleStatus();
            if(_currentPlayer == _player1)
                _currentPlayer.PlayerTurn(_heroes, _monsters);
            else
                _currentPlayer.PlayerTurn(_monsters, _heroes);

            Console.Clear();
            _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
            if (_monsters.Count == 0 || _heroes.Count == 0) break;
        }
        _count++;
       return EndBattle();
    }
    
    private bool EndBattle()
    {
        return _heroes.Count != 0 ? true : false;
    }
    private void BattleStatus()
    {
        Console.WriteLine("============================================= BATTLE ============================================");
        foreach (Character hero in _heroes)
        {
            Console.ForegroundColor = _currentPlayer == _player1 ? ConsoleColor.Yellow : ConsoleColor.Gray;
            Console.WriteLine($"{hero} ({hero.Health}/{hero.FullHealth})");
            Console.ResetColor();
        }
        Console.WriteLine("---------------------------------------------- VS -----------------------------------------------");
        foreach (Character monster in _monsters)
        {
            Console.ForegroundColor = _currentPlayer == _player2 ? ConsoleColor.Yellow : ConsoleColor.Gray;
            Console.WriteLine($"                                                                                   {monster} ({monster.Health}/{monster.FullHealth})");
            Console.ResetColor();
        }
        Console.WriteLine("================================================================================================= ");
    }
}

