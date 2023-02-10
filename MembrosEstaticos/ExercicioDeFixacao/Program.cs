
using ExercicioDeFixacao.Classes;

Console.WriteLine("Qual é a cotação do dólar? ");
double cotacao = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantos dólares você vai comprar? ");
double quantidade = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ConverteDolar(cotacao, quantidade).ToString("F")}");
