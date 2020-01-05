using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] buffer = new char[32];
               buffer[0] = 'd';
               buffer[29] = '7'  ;
               buffer[4] = 'r'  ;
               buffer[2] = '5'  ;
               buffer[23] = 'r'  ;
               buffer[3] = 'c'  ;
               buffer[17] = '4'  ;
               buffer[1] = '3'  ;
               buffer[7] = 'b'  ;
               buffer[10] = '_'  ;
               buffer[5] = '4'  ;
               buffer[9] = '3'  ;
               buffer[11] = 't'  ;
               buffer[15] = 'c'  ;
               buffer[8] = 'l'  ;
               buffer[12] = 'H'  ;
               buffer[20] = 'c'  ;
               buffer[14] = '_'  ;
               buffer[6] = 'm'  ;
               buffer[24] = '5'  ;
               buffer[18] = 'r'  ;
               buffer[13] = '3'  ;
               buffer[19] = '4'  ;
               buffer[21] = 'T'  ;
               buffer[16] = 'H'  ;
               buffer[27] = '1'  ;
               buffer[30] = 'f'  ;
               buffer[25] = '_'  ;
               buffer[22] = '3'  ;
               buffer[28] = 'e'  ;
               buffer[26] = '5'  ;
               buffer[31] = 'd';
            string s = new string(buffer);
            string d = "picoCTF{";
            string f = "}";
            Console.WriteLine("Code is : {0}{1}{2} ", d,s,f);
            Console.WriteLine("Press Enter to quit");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
