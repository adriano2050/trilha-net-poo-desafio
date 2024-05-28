namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private object value;

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string _modelo { get; set; }
        private string _imei { get; set; }
        private int _memoria { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;

        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        protected Smartphone(string numero, object value)
        {
            Numero = numero;
            this.value = value;
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
    }
}