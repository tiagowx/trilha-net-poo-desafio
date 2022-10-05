namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, int memoria) : base (numero, memoria){
            this.SetModelo($"A-{memoria}");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
                public override void InstalarAplicativo(string nomeApp) {
            Console.WriteLine($"Instalando {nomeApp} via APP Store...");
        }
        
        //Sobrecrevendo o método 'ToString' para exibir informações sobre o smartphone
        public override string ToString() {
            string text = "Smartphone IPhone \n";
            text += $"\t Modelo: {Modelo} \n";
            text += $"\t Memoria: {Memoria} GB \n";
            text += $"\t Número: {Numero} \n";
            text += $"\t IMEI: {IMEI} \n";
            return text;
        }
    }
}