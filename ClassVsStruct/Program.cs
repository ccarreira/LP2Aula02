using System;

namespace ClassVsStruct
{
    public class Program
    {



        private static void Main(string[] args)
        {

            Player player_01;
            Player player_02;

            //player_01 = new Player(health: 130, armor: 10);
            player_01 = new Player
            {
                Health = 130,
                // Armor = 10
            };

            player_02 = player_01;

            Console.WriteLine("Player 01 Health: " + player_01.Health);
            Console.WriteLine("Player 01 Armor: " + player_01.Armor);

            Console.WriteLine("Player 02 Health: " + player_02.Health);
            Console.WriteLine("Player 02 Armor: " + player_02.Armor);

            //ex3
            //player_01.Health = 10;
            //player_01.Armor = 0;
            //4
            //porque e struct nao duplica o original mas sim a copia passada
            DuplicateHealth(player_01);
            //mas se for passado como ref ja passa a referencia
            //DuplicateHealth(ref player_01);

            Console.WriteLine("***********************");
            Console.WriteLine("Player 01 Health: " + player_01.Health);
            Console.WriteLine("Player 01 Armor: " + player_01.Armor);

            Console.WriteLine("Player 02 Health: " + player_02.Health);
            Console.WriteLine("Player 02 Armor: " + player_02.Armor);

            //out / ref
            int a;
            int b = 10;

            AlteraVars(out a, ref b);

            Console.WriteLine(a); // 3
            Console.WriteLine(b); // 17

        }
        public static void AlteraVars(out int x, ref int y)
        {
            x = 3;
            y = 17;
        }

        public static void DuplicateHealth(Player player)
        //versao ref
        //public static void DuplicateHealth(ref Player player)
        {
            player.Health *= 2;
        }

    }
}
