using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string imei;
        private string Modelo { get; set; }
        private string IMEI 
        { 
            get => imei;
            set {
                // 000000-00-000000-0.
                var padraoIMEI = new Regex("[0-9]{6}-[0-9]{2}-[0-9]{6}-[0-9]{1}");  
                
                if (padraoIMEI.IsMatch(value))
                {
                    imei = value;
                }
                else 
                {
                    throw new ArgumentException("IMEI fora do padrão. Por favor verifique os valores do Smartphone e tente novamente.");
                }
            }
        }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public bool verificaSeNomeAppValido (string nomeApp) {
            bool nomeAppIsInvalid = string.IsNullOrEmpty(nomeApp);

            if (nomeAppIsInvalid) return false;            
            return true;
        }

    }
}