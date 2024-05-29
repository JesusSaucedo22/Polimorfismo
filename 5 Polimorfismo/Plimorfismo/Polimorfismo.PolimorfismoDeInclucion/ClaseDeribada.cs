namespace Polimorfismo.PolimorfismoDeInclucion
{
    public class ClaseDeribada : ClaseBase
    {
        public override void Metodo1()
        {
            Console.WriteLine("Metodo1() e ClaseDeribada");
        }
        public new void Metodo2()
        {
            Console.WriteLine("Metodo2() e ClaseDeribada");
        }
    }
}
