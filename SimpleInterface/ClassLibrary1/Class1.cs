using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public interface Duck
    {
        void display();
    }
   
    public class MallardDuck: Duck
    {
        public void display() {Console.WriteLine("I am a mallard"); }
        public void fly() { }
        public void quack() { }
 
    }
    public class RedheadDuck: Duck
    {
        public void display(){ Console.WriteLine("I am a redhead"); }
        public void fly() { }
        public void quack() { }
    }
    public class RubberDuck: Duck
    {
        public void display() { Console.WriteLine("I am a rubber duck"); }
        public void quack() { }
    }
    public class DecoyDuck: Duck 
    {
        public void display() { Console.WriteLine("I am a decoy duck"); }
    }
}
