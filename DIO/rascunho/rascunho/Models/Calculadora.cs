namespace rascunho.Models;


    public class Calculadora
    {
        public void Somar(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void Subtrair(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public void Multiplicar(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        public void Dividir(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        public void Potenciar(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a,b)}");
        }

        public void RaizQuadrada(double a)
        {
            Console.WriteLine($"√{a} = {Math.Sqrt(a)}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }
    }