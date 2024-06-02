namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp) 
        {
            Console.WriteLine($"Instalando {nomeApp} no seu celular Iphone");
            Console.WriteLine($"Dados do celular: \nNumero: {Numero}\nModelo: {Modelo}\nImei: {IMEI}\nMemoria: {Memoria}GB");
        }
    }
}