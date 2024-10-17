using System.Runtime.CompilerServices;

namespace Klasy_abstrakcyjne
{
    internal class Program
    {
        abstract class Animal
        {
            public abstract void animalSound();
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        class Pig : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("wee wee");
            }
        }

        interface IAnimal
        {
            void animalSound();
        }

        class Pig2 : IAnimal
        {
            public void animalSound()
            {
                Console.WriteLine("Wee wee");
            }
        }

        interface IAddress
        {
            string Country { get; set; }
            string City { get; set; }
            string Street { get; set; }
            string Number { get; set; }
        }

        interface IUser
        {
            string Name { get; set; }
            string Surname { get; set; }
            string Phone { get; set; }
            string Email { get; set; }
            IAddress Address { get; set; }
            void DisplayData();
        }

        class Address : IAddress
        {
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string Number { get; set; }
            public Address(string[] data)
            {
                Country = data[0];
                City = data[1];
                Street = data[2];
                Number = data[3];
            }
        }

        class User : IUser
        {
            private string _name;
            public string Name
            {
                get => _name;
                set => _name = value;
            }

            private string _surname;
            public string Surname
            {
                get => _surname;
                set => _surname = value;
            }

            private string _phone;
            public string Phone
            {
                get => _phone;
                set => _phone = value;
            }

            private string _email;
            public string Email
            {
                get => _email;
                set => _email = value;
            }

            private IAddress _address;
            public IAddress Address
            {
                get => _address;
                set => _address = value;
            }

            public User(string name, string surname, string phone, string email, IAddress adress)
            {
                _name = name;
                _surname = surname; 
                _phone = phone;
                _email = email;
                _address = adress;
            }

            public void DisplayData()
            {
                Console.WriteLine($"Witaj {Name} {Surname}\nTwój numer telefonu: {Phone}\nTwój adres e-mail: {Email}\nTwój adres zamieszkania: {Address.Country} => {Address.City} => {Address.Street} => {Address.Number}");
            }
        }

            static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.sleep();
            pig.animalSound();
            Pig2 pig2 = new Pig2();
            pig2.animalSound();

            Console.Write("Wpisz imię: ");
            string name = Console.ReadLine();
            Console.Write("Wpisz nazwisko: ");
            string surname = Console.ReadLine();
            Console.Write("Wpisz numer telefonu: ");
            string phone = Console.ReadLine();
            Console.Write("Wpisz email: ");
            string email = Console.ReadLine();
            Console.Write("Wpisz adres zamieszkania (kraj, miejscowość, ulica, numer) po spacji: ");
            Address address = new(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            User user = new(name, surname, phone, email, address);
            user.DisplayData();
        }
    }
}
