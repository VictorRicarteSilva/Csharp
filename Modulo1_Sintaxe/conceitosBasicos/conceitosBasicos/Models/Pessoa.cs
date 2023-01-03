namespace conceitosBasicos.Models
{ 
    public class Pessoa
    {
        // atributos
        public string Nome { get; set; }
        public byte Idade { get; set; }

        //metodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}