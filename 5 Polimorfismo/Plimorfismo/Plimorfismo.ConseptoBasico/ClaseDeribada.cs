using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plimorfismo.ConseptoBasico
{
    public class ClaseDeribada : ClaseBase
    {
        public void metodo1()
        {
            Console.WriteLine("Meodo1() en ClaseDerivada");
        }

        public new void Metodo2()
        {
            Console.WriteLine("Metodo2() en ClaseDerivada");
        }
    }
}
