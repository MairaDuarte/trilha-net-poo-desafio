using System.Reflection.Emit;

namespace DesafioPOO.Models
{
    // Implementado: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // Implementado: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            
            bool duvida = true;
            while (duvida)
            {
                Console.WriteLine($"É esse aplicativo que você quer instalar: {nomeApp}? (Escreva S para sim ou N para não)");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso!!");
                    duvida = false;
                }
                else if (resposta == "N")
                {
                    Console.WriteLine("Reescreva, por favor, o nome do aplicativo que você deseja instalar.");
                    nomeApp = Console.ReadLine();
                
                }
                else
                {
                    throw new ArgumentException("ERRO, você escreveu algo que não era S para sim ou N não");
                }
            }
        }
    }
}