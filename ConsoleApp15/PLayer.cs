using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Player
    {
        public List<Duel> cards = new List<Duel>();

        public void ShowCards()
        {
            foreach(var value in cards)
            {
                if (value.type != 'в' && value.type != 'к' && value.type != 'д' && value.type != 'т')
                {
                    Console.WriteLine((int)value.type + "  " + value.mast);
                }

                else
                {
                    Console.WriteLine(value.type + "  " + value.mast);
                }
            }
        }
    }
}
