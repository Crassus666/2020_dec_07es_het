using System;
using System.IO;

namespace _2020_12_06_07
{
    class Program
    {
        static int NotMain(string p_szo)
        {
            char betu = 'a';
            int k = 0;
            p_szo += '~';
            while (betu != '~')
            {

                //if (p_szo[k] != '~')
                    //Console.Write( p_szo[k]);
                
                betu = p_szo[k];
                k += 1;

            }



            return k-1;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("forras68.txt", FileMode.Open);
            StreamReader rs = new StreamReader(fs);
            int eredmeny = 0;
            string vege = " ";
            string masikvege = " ";
            int legkisebb = 100000;
            
            int k = 0;
            string s = rs.ReadLine();

            int db = Convert.ToInt32(s);
            string[] szamok = new string[db];

            for (int i = 0; i < db; i++)
            {
                s = rs.ReadLine();
                if (eredmeny < NotMain(s))
                {
                    eredmeny = NotMain(s);
                    vege = s;
                }
                if (legkisebb > NotMain(s))
                {
                    legkisebb = NotMain(s);
                    masikvege = s;
                }
            }
            
            Console.Write(vege);
            Console.Write(masikvege);
            rs.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
