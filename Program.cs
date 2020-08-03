using System;

namespace hello_console
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = BuildMessage("Friend");
            Console.WriteLine(message);
        }

        static String BuildMessage(String Name)
        {
            return ("Hello " + Name + "!");
        }
    }
}
