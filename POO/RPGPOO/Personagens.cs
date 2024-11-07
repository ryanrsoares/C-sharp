using System.Diagnostics;

namespace RPGPOO.Classes
{
    public class Personagens
    {
        public string nome;
        public int idade;
        public string armadura;
        public string IA;
        public int escolha;

        public void atacar(){
            Console.WriteLine($"O personagem atacou!");
            
        }
        public void defender(){
            Console.WriteLine($"O personagem defendeu!");
            
        }
        public void RestaurarArmadura(){
            Console.WriteLine($"O personagem restaurou a armadura!");
            
        }
    }
}