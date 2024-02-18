namespace ExtensionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Int32 num = 5;
            Console.WriteLine(num.ToString());

            Person r = new Person();
            r.Name = "Rustam";
            r.Surname = "Cebrayilov";
            r.DOB = new DateTime(2005,4,19);

            Console.WriteLine(r.ToString()) ;
            Person n = new Person();
            n.Name = "Nermin";
            n.Surname = "Abbaszade";
            n.DOB = new DateTime(2004, 2, 14);
            Console.WriteLine(n.ToString());

            Person e = new Person("Ekber");          
            e.Surname = "Zeynalli";
            e.DOB = new DateTime(2005, 8, 18);
            Console.WriteLine(e.ToString());

            Console.WriteLine(Person.Count);



           



        }

      
    }
}
