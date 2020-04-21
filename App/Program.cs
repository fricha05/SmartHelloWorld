using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHelloWorld hello = new IWriteHelloWorld("Florian");
            hello.writeFullHelloWorl();
        }
    }
}
