using Entities.concrete;

namespace WorkSpace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            //Variable();
            People people = new People();
           
           
            Console.ReadLine();
        }

        private static void Variable()
        {
            string message = "WorkSpace";
            Console.WriteLine(message);

            double money = 100000;
            Console.WriteLine(money * 1.92);

            bool isLogin = true;
            bool isCompleted = false;

            string name = "Cigdem";
            string surname = "Ay";
            int birthYear = 1988;
            long TCNumber = 1235;
        }

        Person person = new Person();

        public class People
        {
           //public string name = "Cigdem";
           //public string surname = "Ay";
           //public int birthYear = 1988;
           //public long TCNumber = 1235;

            public string  FirstName { get; set; }
            public string LastName { get; set; } 

            public int DateOfBirthYear { get; set; }

            public long NationalIdentity{ get; set; }


 


        }
    }
}