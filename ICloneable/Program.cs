using System;

namespace ICloneableEjer
{
    class Program
    {
        static void Main(string[] args)
        {
            CAuto Auto1 = new CAuto("Mazda", 340000.00);

            //Aqui pensamos que lo hemos clonado pero solo es otra variable referenciada a la misma instancia

            CAuto Auto2 = Auto1;

            Auto1.CalculaTenencia(0.10);
            Auto2.CalculaTenencia(0.10);

            //Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            //Unicamente para separar informacion
            Console.WriteLine("--------------------------");

            //Realizamos un cambio "En caso de que fuera un clon, unicamente uno deberia de cambiar"
            Auto1.Costo = 60000;

            //Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            //Unicamente para separar informacion
            Console.WriteLine("================================");

            //Ahora si hacemos un clon
            CAuto Auto3 = (CAuto)Auto1.Clone();

            //mostramos informacion para verificar los datos de antes y despues
            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            Console.WriteLine("*****************************");

            //Modificamos uno, el otro no debe de modificarse
            Auto1.Costo = 900000.00;

            //Mostramos de nuevo la ifmormacion para verificar
            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            Console.WriteLine("////////////////////////////////////////////");
        }
    }
}
