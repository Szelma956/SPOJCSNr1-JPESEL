using System;

namespace JPESEL
{

    class Pesel
    {

        public int[] cyfry;


        public bool IsValid()
        {
            int[] wagi = new int[]
            {
                1,3,7,9,1,3,7,9,1,3,1
            };

            int suma = 0;

            for (int i = 0; i < 11; i++)
            {

                suma += cyfry[i] * wagi[i];

            }

            return suma % 10 == 0;

        }


        public static Pesel Parse(string str)
        {
            int[] cyfry = new int[11];

            for (int i = 0; i < 11; i++)
            {

                char znak = str[i];
                int cyfra = znak - '0';
                cyfry[i] = cyfra;

            }

            Pesel pesel = new Pesel();
            pesel.cyfry = cyfry;


            return pesel;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string linia = Console.ReadLine();
            int liczbaPrzypadkow = int.Parse(linia);

            for (int i = 0; i < liczbaPrzypadkow; i++)
            {

                string peselstr = Console.ReadLine();
                Pesel pesel = Pesel.Parse(peselstr);
                if (pesel.IsValid())
                {

                    Console.WriteLine('D');

                }
                else {

                    Console.WriteLine('N');
                
                }



            }
        }
    }
}
