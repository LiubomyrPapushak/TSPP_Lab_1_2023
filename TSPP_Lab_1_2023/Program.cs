using System;

namespace TSPP_Lab_1_2023
{
    public class Program
    {
        public static uint hours, minutes, seconds;
        public static uint TimeConvH(uint S)
        {
            hours = S / 3600;
            return hours;
        }
        public static uint TimeConvM(uint S)
        {
            minutes = (S - hours * 3600) / 60;
            return minutes;
        }
        public static uint TimeConvS(uint S)
        {
            seconds = S - hours * 3600 - minutes * 60;
            return seconds;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Введiть кiлькiсть секунд вiд початку доби");
            string T = Console.ReadLine();
            uint S = uint.Parse(T);
            uint hh = TimeConvH(S);
            uint mm = TimeConvM(S);
            uint ss = TimeConvS(S);
            Console.Clear();
            Console.WriteLine("\n Ви стверджуєте, що вiд початку доби минуло - " + S.ToString() + " секунд! \n");
            Console.WriteLine();
            Console.WriteLine(" Вiдповiдно, вiд початку доби минуло:\n" +
                    "\t\t\t\t\t годин -  " + hh.ToString() + ";\n" +
                    "\t\t\t\t\t хвилин - " + mm.ToString() + ";\n" +
                    "\t\t\t\t\t секунд - " + ss.ToString() + ".");

            Console.ReadLine();
        }
    }
}
