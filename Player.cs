using System;

namespace Rock_Paper_Scissors_OOP
{
    public class Player
    {
        private string name;
        private string hand;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string Hand 
        {
            get { return hand; }
            set { hand = value; }
        }

        public Player(string name, string hand)
        {
            this.name = name;
            this.hand = hand;
        }
             
        public void showInfo()
        {
            Console.WriteLine("name: " + name + " hand: " + hand);
        }
    }
}