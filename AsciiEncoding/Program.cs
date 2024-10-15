using System;
using System.Collections.Generic;

namespace AsciiEncoding
{
     class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            byte b = (byte)ch;
            Console.WriteLine(b);//65
            char ch2 = (char)b;
            Console.WriteLine(ch2);

            byte[] bytes = new byte[128];
            for(byte i = 0; i < 128; i++)
            {
                bytes[i] = i;
            }
            string s=System.Text.Encoding.ASCII.GetString(bytes);
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
