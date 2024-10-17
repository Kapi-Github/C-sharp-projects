namespace Polimorfizm
{
    internal class Program
    {
        interface IDD
        {
            double Pole();
        }

        interface I3D
        {
            double Objetosc();
        }

        class Figura : IDD, I3D
        {
            private string _nazwa;
            public string Nazwa { get; set; }
            public Figura(string nazwa)
            {
                Nazwa = nazwa;
            }
            public double Pole()
            {
                return 0;
            }
            public double Objetosc()
            {
                return 0;
            }
            public virtual void Wyswietl()
            {
                Console.Write($"Figura geometryczna");
            }
        }

        class Kolo : Figura, IDD
        {
            private double promien;
            public double Promien { get; set; }
            public Kolo(string nazwa, double promien): base(nazwa)
            {
                Promien = promien;
            }
            public double Pole()
            {
                return Math.PI * Math.Pow(promien, 2);
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.Write($" - {nazwa}, pole figury: {Pole()}");
            }
        }

        class Kula : Kolo, IDD, I3D
        {
            public Kula(string nazwa, double promien) : base(nazwa, promien)
            {
                base.promien = promien;
            }
            public double Pole()
            {
                return 4.0 * base.Pole();
            }
            public double Objetosc()
            {
                return (4.0/3.0) * Math.PI * Math.Pow(promien, 3);
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.Write($", objętość: {Objetosc()}");
            }
        }

        class Stozek : Kolo, IDD, I3D
        {
            protected double wysokosc;
            public Stozek(string nazwa, double promien, double wysokosc) : base(nazwa, promien)
            {
                base.promien = promien;
                this.wysokosc = wysokosc;
            }
            public double Objetosc()
            {
                return (1.0 / 3.0) * base.Pole() * wysokosc;
            }
            public double Pole()
            {
                return Math.PI * promien * (promien + (Math.Sqrt(Math.Pow(wysokosc, 2) + Math.Pow(promien, 2))));
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.Write($", objętość: {Objetosc()}");
            }
        }

        class Walec : Kolo, IDD, I3D
        {
            protected double wysokosc;
            public Walec(string nazwa, double promien, double wysokosc) : base(nazwa, promien)
            {
                base.promien = promien;
                this.wysokosc = wysokosc;
            }
            public double Objetosc()
            {
                return base.Pole() * wysokosc;
            }
            public double Pole()
            {
                return 2.0 * Math.PI * promien * (promien + wysokosc);
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.Write($", objętość: {Objetosc()}");
            }
        }

        static void Main(string[] args)
        {
            Figura[] obiekty =
            [
                new Figura(""),
                new Kolo("Moje koło nr 1", 3.56),
                new Kolo("Moje koło nr 2", 6.45),
                new Walec("Mój walec nr 1", 2.34, 5),
                new Walec("Mój walec nr 2", 6, 2),
                new Stozek("Mój stożek nr 1", 3.23, 5),
                new Stozek("Mój stożek nr 2", 5, 3),
            ];

            foreach (Figura figura in obiekty)
            {
                figura.Wyswietl();
                Console.WriteLine();
            }
        }
    }
}
