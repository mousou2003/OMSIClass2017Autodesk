using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
       static void DisplayTheDuck(Duck theDuck)
        { 
             theDuck.display();
        }
        static void Main(string[] args)
        {
            DisplayTheDuck(new MallardDuck());
            DisplayTheDuck(new RedheadDuck());
            DisplayTheDuck(new RubberDuck());
            DisplayTheDuck(new DecoyDuck());
            Console.ReadLine();
        }
    }
}
