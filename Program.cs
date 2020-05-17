using System;

namespace Rock_Paper_Scissors_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Player PlayerA = new Player("PlayerA", "Paper");
            Game_RPS game_RPS = new Game_RPS();
            game_RPS.startGame();
        }
    }
}
