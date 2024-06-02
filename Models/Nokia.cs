namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp) 
        {
            Console.WriteLine($"Instalando {nomeApp} no seu celular Nokia");
            Console.WriteLine($"Dados do celular: \nNumero: {Numero}\nModelo: {Modelo}\nImei: {IMEI}\nMemoria: {Memoria}GB");
        }
    }
}