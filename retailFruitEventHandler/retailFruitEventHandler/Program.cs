using System;

namespace retailFruitEventHandler
{
    class Program
    {// event handlers
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            fruit.NewEvent += new EventHandler(newKind);// create new event and launch method 'newKind'
            fruit.Kind = "Apple";
            fruit.Kind = "Banana";
            fruit.Kind = "Orange";
            fruit.Kind = "Cherry";
        }
        static void newKind(object newk, EventArgs e)
        {
            Fruit fruit = (Fruit)newk;
            Console.WriteLine("Fruit changed to {0}", fruit.Kind);
        }
        class Fruit
        {
            public event EventHandler NewEvent;
            private string kind;
            public string Kind
            {
                get { return kind; }
                set 
                {
                    kind = value;
                    NewEvent(this, EventArgs.Empty);
                }
            }
        }
    }
}
