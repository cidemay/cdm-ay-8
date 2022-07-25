using Business.Concrete;
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

            Console.WriteLine("Lütfen Ad bilgisini yazınız");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Lütfen Soyad bilgisini yazınız");
            string LastName = Console.ReadLine();
            Console.WriteLine("Lütfen TCKimlik bilgisini yazınız");
            long NationalIdentity =Convert.ToInt64( Console.ReadLine());
            Console.WriteLine("Lütfen doğum yılı bilgisini giriniz");
            int DateOfBirthYear = Convert.ToInt32(Console.ReadLine());

            Person person1 = new Person();
            person1.FirstName = FirstName;
            person1.LastName= LastName;
            person1.NationalIdentity = NationalIdentity;
            person1.DateOfBirthYear= DateOfBirthYear;

            FirmaManager firmaManager = new FirmaManager(new PersonManager());
            firmaManager.GiveData(person1);



            



           
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