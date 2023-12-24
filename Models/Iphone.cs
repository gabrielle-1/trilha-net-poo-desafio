namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            var nomeAppValido = verificaSeNomeAppValido(nomeApp);

            if (!nomeAppValido)
            {
                throw new ArgumentException("O nome do aplicativo não pode ser nulo ou vazio. Tente novamente.");
            }
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}