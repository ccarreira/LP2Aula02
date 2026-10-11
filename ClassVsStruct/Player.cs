using System;

namespace ClassVsStruct
{

    public struct Player
    {
        public int Health { get; set; }
        public int Armor { get; set; }

        public Player(int health, int armor)
        {
            Health = health;
            Armor = armor;
        }

        //CLASS
        //  public class Player
        /*  public Player()
                {
                    Health = 0;
                    Armor = 0;
                }
            public Player(int health, int armor)
                    : this()
                {
                    Health = health;
                    Armor = armor;
                } */
    }

}
