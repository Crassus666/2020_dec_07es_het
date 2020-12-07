using System;
using System.IO;

namespace _2020_12_06_4
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
                if (szamok[0][k] != '~')
                    Console.Write("{0} ", szamok[0][k]);
                //Console.Write(betu);
                betu = szamok[0][k];
                k += 1;
            }
            rs.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
