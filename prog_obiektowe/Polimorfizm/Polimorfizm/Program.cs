namespace Polimorfizm
{
    internal class Program
    {
        class Figura
        {
            protected string nazwa;
            public Figura(string nazwa)
            {
                this.nazwa = nazwa;
            }
            public virtual void Wyswietl()
            {
                Console.WriteLine($"Figura geometryczna: {nazwa}");
            }
        }

        class Kolo : Figura
        {
            double promien;
            public Kolo(string nazwa, double promien): base(nazwa)
            { 
                this.promien = promien;
            }
            public double Pole() 
            {
                return Math.PI * Math.Pow(promien, 2);
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.WriteLine($"Pole figury: {Pole()}");
            }
        }

        class Kula : Kolo
        {
            double promien;
            public Kula(string nazwa, double promien) : base(nazwa, promien)
            {
                this.promien = promien;
            }
            public double Objetosc() 
            {
                return (4 / 3) * Math.PI * Math.Pow(promien, 3); 
            }
            public double Pole() 
            { 
                return 4 * Math.PI * Math.Pow(this.promien, 2);
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.WriteLine($"Objętość: {Objetosc()}");  
            }
        }

        class Stozek : Kolo
        {
            double wysokosc, promien;
            public Stozek(double wysokosc, double promien)
            {
                this.wysokosc = wysokosc;
                this.promien = promien;
            }
            public double Objetosc() 
            {
                return (1 / 3) * Math.PI * Math.Pow(promien, 2) * wysokosc;
            }
            public double Pole()
            {
                return Math.PI * promien * (promien + Math.Sqrt(Math.Pow(promien, 2) + Math.Pow(wysokosc, 2)));
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.WriteLine($"Objętość: {Objetosc()}");
            }
        }

        class Walec : Kolo
        {
            double wysokosc, promien;
            public Walec(double wysokosc, double promien) 
            {
                this.wysokosc = wysokosc;
                this.promien = promien;
            }
            public double Objetosc()
            {
                return Math.PI * Math.Pow(promien, 2) * wysokosc;
            }
            public double Pole()
            {
                return 2 * Math.PI * promien * (promien + wysokosc);
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.WriteLine($"Objętość: {Objetosc()}");
            }
        }

        static void Main(string[] args)
        {
            Figura[] obiekty = new Figura[7];
            obiekty[0] = new Figura("");
        }
    }
}
