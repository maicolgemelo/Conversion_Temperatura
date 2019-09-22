using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Temperatura
{
    
   public class Temperaturas
    {
        private double Gcelsius;


        public void setGCelsius(double valor) {

            this.Gcelsius = valor;
        }

        public double getgCelsius() {

            return this.Gcelsius;
        }

        public double Convertir() {

            return ((this.getgCelsius() * 9 / 5) + 32);
        }

    }
}
