using System;

namespace task2612h
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Verilmiş yazının sonundaki boşluları silinmiş yeni bir yazı düzəldən proqram yazırsınız
            string str = "    salam  necesen   ";
            string newStr = "";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;

            }
            {
                for (int i = count-1; i >= 0; i--)
                    if (str[i] == ' ')
                        newStr += str[i];
            }

            Console.WriteLine(str);








        }
    }
}

    


    




