using System;

namespace Day0ne
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("input.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line;
            while(!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string first.substring(0,1);
                string second.substring(line.Lenght);
                int output = Convert.ToInt32(first + last);
                total += output;
            }
        }
    }
}
```