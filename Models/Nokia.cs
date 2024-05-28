using System.Security.Cryptography;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        private string _modelo { get; set; }
        private string _imei { get; set; }
        private int _memoria { get; set; }
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)

        {
            Console.WriteLine($"O app {nomeApp} foi instalado");

        }
    }
}