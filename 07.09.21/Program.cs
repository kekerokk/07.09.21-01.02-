using System;

namespace _07._09._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = 0;
            int kolichestvoPovroreniy = 0;
            string answer;

            for(int i = 0;i<10;i++)
            {
                chislo += 2;
                kolichestvoPovroreniy++;
            }
            answer = chislo.ToString();
            Console.WriteLine(answer);
        }
    }
}
