using System;
using System.Collections.Generic;
using System.Text;

namespace nAge
{
    class Run
    {
        public void Runner()
        {
            // Menanyakan user untuk convert ulang atau tidak
            Opening();
            Mainr();
            Console.Write("\nConvert Lagi (y/t)? ");
            bool ulang = false;
            var kunci = Console.ReadKey();
            do
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                switch (kunci.Key)
                {
                    case ConsoleKey.Y:
                        ulang = true;
                        Console.Clear();
                        Runner();
                        break;
                    case ConsoleKey.T:
                        ulang = false;
                        Console.Clear();
                        end();
                        break;
                }


            } while (ulang);
        }

        public void Opening()
        {
            string O1 = "-------------------------------------------------------";
            string O2 = "======================                ~ Program Umur je la ~                ======================\n";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (O1.Length / 2)) + "}", O1));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (O2.Length / 2)) + "}", O2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (O1.Length / 2)) + "}", O1));
        }

        public void end()
        {

            string e1 = "Thanks For Using me~\n[Enter]";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (e1.Length / 2)) + "}", e1));
        }

        public void Mainr()
        {
            int nAge;
            int tLahir;
            int tLahir1;

            Console.Write("Masukan Umur Anda: ");
            nAge = Convert.ToInt32(Console.ReadLine());

            tLahir = 2020 - nAge;
            tLahir1 = 2021 - nAge;


            if ((nAge >= 5) && (nAge <= 12))
            {
                Console.WriteLine("\nAnda di masa anak-anak");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if ((nAge >= 13) && (nAge <= 19))
            {
                Console.WriteLine("\nAnda di masa remaja");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if ((nAge >= 20) && (nAge <= 35))
            {
                Console.WriteLine("\nAnda mulai dewasa");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if ((nAge >= 36) && (nAge <= 45))
            {
                Console.WriteLine("\nAnda sudah dewasa");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if ((nAge >= 46) && (nAge <= 55))
            {
                Console.WriteLine("\nAnda mulai tua");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
            else if (nAge >= 56)
            {
                Console.WriteLine("\nAnda Sepuh");
                Console.WriteLine("Tahun Kelahiran " + tLahir + "/" + tLahir1);
            }
        }
    }
}
