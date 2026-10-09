using System;

namespace ClassVsStruct
{
/*     public class Player
    {
        public int Health { get; set; }
        public int Armor { get; set; }

        public Player()
        {
        }
        public Player(int health, int armor)
         : this()
        {
            Health = health;
            Armor = armor;
        }

    } */

    //STRUCT VERSION
        public struct Player
        {
            public int Health { get; set; }
            public int Armor { get; set; }
        }
}
