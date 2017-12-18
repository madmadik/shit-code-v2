using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Game
    {
        public Player player1 = new Player();
        public Player player2 = new Player();
        Random randomize = new Random();
        Karta karta = new Karta();
        public void Init()
        {
            karta.GetAllKarta();
        }
        public List<Duel> randomedKart = new List<Duel>();
        List<int> usedRandoms = new List<int>();

        public void GiveCards()
        {
            for(int i=0;i<karta.kart.Count/2;i++)
            {
                player1.cards.Add(karta.kart.ElementAt(i));
            }
            for(int i=karta.kart.Count/2;i<karta.kart.Count;i++)
            {
                player2.cards.Add(karta.kart.ElementAt(i));
            }
        }

        public void RandomKarts()
        { 
            for(int i=0;i< karta.kart.Count; i++)
            {
                int pos;
                do
                {
                    pos = randomize.Next(0, karta.kart.Count);
                }
                while (usedRandoms.Contains(pos));
                Duel sample = new Duel(); ;
                sample.type = karta.kart.ElementAt(pos).type;
                sample.mast = karta.kart.ElementAt(pos).mast;
                randomedKart.Add(sample);
                usedRandoms.Add(pos);
            }

            karta.kart = null;
            karta.kart=randomedKart;
        }

        public void Fight()
        {
            for(int i=0;i< karta.kart.Count/2; i++)
            {
                if(player1.cards[i].type>player2.cards[i].type)
                {
                    player1.cards.Add(player2.cards[i]);
                }

                else if(player1.cards[i].type == player2.cards[i].type)
                {
                    player1.cards.Add(player2.cards[i]);
                }

                else
                {
                    player2.cards.Add(player1.cards[i]);
                }
            }
            if(player1.cards.Count>player2.cards.Count)
            {
                Console.WriteLine("выиграл игрок 1");
            }
            else
            {
                Console.WriteLine("выиграл игрок 2");
            }
        }

        public void ShowAllCards()
        {
            foreach(var value in karta.kart)
            {
                if (value.type !='в'&&value.type!='к'&&value.type!='д'&&value.type!='т')
                {
                 Console.WriteLine((int)value.type+ "  "+value.mast);
                }
                else
                {
                    Console.WriteLine(value.type + "  " + value.mast);
                }
                
            }
        }
     
    }
}
