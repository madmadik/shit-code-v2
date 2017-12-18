using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Game game = new Game();
            game.Init();
            game.RandomKarts();
            game.GiveCards();
            Console.WriteLine("карты первого игрока!");
            game.player1.ShowCards();
            Console.WriteLine("карты второго игрока!");
            game.player2.ShowCards();
            game.Fight();
            Console.ReadLine();
        }
    }
}
