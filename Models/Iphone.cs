namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string nome, int numero) : base(nome, "Iphone", "IOS", numero)
        {

        }
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando aplicativo {nomeAplicativo} no Iphone...");
        }
    }
}