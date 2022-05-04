using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopapirollo
{
    internal class Program
    {
        class koPapirOllo
        {
            // osztályváltozók
            private int tipp1;
            
            //konstruktor

            public koPapirOllo() { }

            public void setTipp1()
            {
                Console.WriteLine("Kő, Papír, vagy Olló? (Kő = 1, Papír = 2, Ollo = 3)");
                this.tipp1 = Convert.ToInt32(Console.ReadLine());
            }

            public int getTipp1() { return this.tipp1; }
 
        public void kiszamol(int tipp1 = 1, int tipp2 = 2, int tipp3 = 3)
            {
                Random rnd = new Random();
                int gepTipp = rnd.Next(1,4);
                
                if (gepTipp == tipp1 && this.tipp1 == tipp3 || gepTipp == tipp2 && this.tipp1 == tipp1 || gepTipp == tipp3 && this.tipp1 == tipp2)
                {
                    Console.WriteLine("A gép nyert. Tippje: {0} az én tippem {1}", gepTipp, this.tipp1);
                } else if(this.tipp1 == tipp1 && gepTipp == tipp3 || this.tipp1 == tipp2 && gepTipp == tipp1 || this.tipp1 == tipp3 && gepTipp == tipp2)
                    {
                    Console.WriteLine("Én nyertem. Tippem: {0}, a gép tippje: {1}", this.tipp1, gepTipp);
                }
                else 
                { 
                    Console.WriteLine("Döntetlen! Tippek: {0} {1}", gepTipp, this.tipp1); 
                }

            }   
        }
        static void Main(string[] args)
        {
            koPapirOllo kpo = new koPapirOllo();
            kpo.setTipp1();
            kpo.kiszamol();

            Console.ReadKey();
        }
    }
}
