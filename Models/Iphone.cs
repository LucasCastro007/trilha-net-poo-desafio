namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"  (Implementado !!!)
    public class Iphone : Smartphone
    {

        public Iphone (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

    // TODO: Sobrescrever o método "InstalarAplicativo"  (Implementado !!!)
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }
      
    }         
      
}