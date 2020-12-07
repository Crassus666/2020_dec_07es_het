using System;
using System.IO;

namespace _2020_12_06_06
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("forras68.txt", FileMode.Open);
            StreamReader rs = new StreamReader(fs);
            char betu = 'a';
            int k = 0;
            string s = rs.ReadLine();

            int db = Convert.ToInt32(s);
            string[] szamok = new string[db];
            s = rs.ReadLine();
            szamok[0] = s;
            //s = rs.ReadLine();
            szamok[0] += '~';

            while (betu != '~')
            {
                if (szamok[0][k] != 'a' && szamok[0][k] != '~')
                    Console.Write(" {0}", szamok[0][k]);
                //if (szamok[0][k] != '~')
                betu = szamok[0][k];
                //Console.Write(betu);

                k += 1;
            }
            rs.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
