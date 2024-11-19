
using PilaresPOO.Classes.Aprendizagem;

namespace PilaresPOO.Classes
{
    public class PowerGeneric : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O personagem está atacando!");
            
        }
        // não tem o método Atacar , ele usar o método do pai
    }
}