using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public struct Duel
    {
        public string mast;
        public char type;
    }

    public class Karta
    { 
        public List<Duel> kart = new List<Duel>();

        public void GetAllKarta()
        {
           
            string[] mas1 = { "черви", "бубны", "пики", "трефы" };
            for(int j=6;j<10;j++)
            {
                for (int i = 0; i < mas1.Length; i++)
                {
                    Duel sample = new Duel() ;
                    sample.mast = mas1[i];
                    sample.type =Convert.ToChar(j);
                    kart.Add(sample);
                }
            }
           
            char[] mas2 = { 'в', 'д', 'к', 'т' };
            for(int j=0;j< mas1.Length;j++)
            {
                for (int i = 0; i < mas2.Length; i++)
                {
                    Duel sample = new Duel() ;
                    sample.type = mas2[i];
                    sample.mast = mas1[j] ;
                  
                    kart.Add(sample);
                }
            }
           
        }

    }
}
