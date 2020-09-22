using System;
using System.Collections.Generic;
using System.Text;

namespace ICloneableEjer
{
    class CAuto : IAutomovil,ICloneable
    {
        private double costo;
        private double tenencia;
        private string modelo;

        //Costructor
        public CAuto(string pModelo, double pCosto)
        {
            //Inicializamos los datos
            costo = pCosto;
            modelo = pModelo;
        }

        public double Costo { get { return costo; } set { costo = value; } }
        public double Tenencia { get { return tenencia; } set { tenencia = value; } }

        //Metodos de interfaz
        public void CalculaTenencia(double imp)
        {
            //Calculamos el impuesto
            tenencia = 5000.0 + costo * imp;
        }

        public void MuestraInformacion()
        {
            //Muestra la informacion necesaria
            Console.WriteLine("Automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con uina tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total {0}", costo + tenencia);
            Console.WriteLine("-----------------------------------------------------");
        }

        //Metodo para implementar ICloneable
        public object Clone()
        {
            CAuto temp = new CAuto(modelo, costo);

            temp.Tenencia = tenencia;

            return temp;
        }
    }
}
