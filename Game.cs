using TheFinalBattle;

class Game
{
    private Player? player1;
    private Player? player2;
    private List<Character> _heroesParty;
    private List<Character> _monsterParty1;
    private List<Character> _monsterParty2;
    private List<Character> _monsterParty3;

    private FinalBattle _battle1;
    private FinalBattle _battle2;
    private FinalBattle _battle3;
    public Game()
    {
        ChooseGameMode();
        _heroesParty = new() { new TheTrueProgrammer(player1.NameTheTrueProgrammer()), new VinFletcher() };
        _monsterParty1 = new() { new Skeleton() };
        _monsterParty2 = new() { new Skeleton(), new Skeleton() };
        _monsterParty3 = new() { new Skeleton(), new Skeleton(), new TheUncodedOne() };
        _battle1 = new FinalBattle(player1, player2, _heroesParty, _monsterParty1); 
        _battle2 = new FinalBattle(player1, player2, _heroesParty, _monsterParty2);
        _battle3 = new FinalBattle(player1, player2, _heroesParty, _monsterParty3);
    }
    
    public void StartGame()
    {
        if (_battle1.RunBattle() && _battle2.RunBattle() && _battle3.RunBattle())
        {
            Console.WriteLine("The heroes won, and the Uncoded One was defeated.");
        }
        else
        {
            Console.WriteLine("The heroes lost and the Uncoded One’s forces have prevailed. ");
        }
    }

    private void ChooseGameMode()
    {
        while (true)
        {
            Console.WriteLine("What gameplay do you choose");
            Console.Write("1)Human vs Computer, 2)Computer vs Computer, 3) Human vs Human: ");
            string userInput = Console.ReadLine()!;
            switch (userInput)
            {
                case "1":
                    player1 = new HumanPlayer();
                    player2 = new ComputerPlayer();
                    break;
                case "2":
                    player1 = new ComputerPlayer();
                    player2 = new ComputerPlayer();
                    break;
                case "3":
                    player1 = new HumanPlayer();
                    player2 = new HumanPlayer();
                    break;
                default:
                    Console.WriteLine("Input the numbers 1,2 or 3\n");
                    continue;
            }
            break;
        }
    }
}

