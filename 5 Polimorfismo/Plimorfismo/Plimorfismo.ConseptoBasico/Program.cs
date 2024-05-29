using Plimorfismo.ConseptoBasico;

Console.WriteLine("Demostracion de conceptos basicos del polimorfismo.\n");

ClaseBase claseBase = new ClaseBase();
ClaseDeribada claseDerivada = new ClaseDeribada();
ClaseBase cbcd = new ClaseDeribada();

claseBase.Metodo1();
claseBase.Metodo2();
claseDerivada.Metodo1();
claseDerivada.Metodo2();
cbcd.Metodo1();
cbcd.Metodo2();