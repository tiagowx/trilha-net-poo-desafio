using DesafioPOO.Utils;
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo {get; private set; }
        public string IMEI {get; private set; }
        public int Memoria {get; private set; }

        public Smartphone(string numero, int memoria)
        {
            this.Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            // Gera um IMEI aleatório de acordo com o padrão estabelicido no método
            this.IMEI = Utils.IMEI.NovoIMEI();
            this.Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void SetModelo(string modelo) {
            this.Modelo = modelo;
        }

        public void SetMemoria (int memoria) {
            this.Memoria = memoria;
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}