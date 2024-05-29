using Polimorfismo.PolimorfismoDeInclucion;

Console.WriteLine("Demostracion del polimorfismo de inclusion (subtipificacion\n)");

ClaseBase claseBase = new ClaseBase();
ClaseDeribada claseDerivada = new ClaseDeribada();
ClaseBase cbcd = new ClaseDeribada();

claseBase.Metodo1();
claseBase.Metodo2();
claseDerivada.Metodo1();
claseDerivada.Metodo2();
cbcd.Metodo1();
cbcd.Metodo2();