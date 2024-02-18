using ExtensionApp;

namespace ExtenstionApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Person  person = new Person();
            person.Name = "Ugur";
            person.sleep();
            person.eat();
            person.run(30);
        }
    }
}
