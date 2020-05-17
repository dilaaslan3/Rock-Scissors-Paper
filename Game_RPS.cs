using System;
using System.Collections.Generic;
namespace Rock_Paper_Scissors_OOP
{
    public class Game_RPS
    {
        private int scoreTie = 0;
        private int scoreA = 0;
        private int scoreB = 0;

        int i=0;

        public void startGame()
        {
            while(i<100){

            var list = new List<string>{"Paper","Scissors","Rock"};
            Random random = new Random();
            int index = random.Next(list.Count);
            string PlayerB_Random_Hand = list[index];
            i++;

            
                if(PlayerB_Random_Hand== "Paper"){
                    scoreTie++;
                    /**
                    Console.WriteLine("Player B chooses: "+ PlayerB_Random_Hand +"\nBoth players choose the same, the round is counted as a tie.");
                    Console.WriteLine("scoreTie = " + scoreTie); 
                    **/
                }
            
                else if(PlayerB_Random_Hand == "Scissors"){
                    scoreB++;
                    /**
                    Console.WriteLine("Player B chooses: " + PlayerB_Random_Hand + "\n"+ PlayerB_Random_Hand+ " beats Paper. Player B wins.");
                    Console.WriteLine("scoreB = " + scoreB);
                    **/
                }

                else if(PlayerB_Random_Hand == "Rock") {
                    scoreA++;
                    /**
                    Console.WriteLine("Player B chooses: " + PlayerB_Random_Hand + "\nPaper beats "+ PlayerB_Random_Hand + " Player A wins.");
                    Console.WriteLine("scoreA = " + scoreA);
                    **/
                }
             }
            Console.WriteLine("Player A wins " + scoreA + " of 100 games\n" +
                    "Player B wins " + scoreB + " of 100 games\n" +
                    "Tie: " +  scoreTie +  " of 100 games") ;
        }
    }
}