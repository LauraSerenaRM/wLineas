using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wLineas
{
    internal class clsLinea
    {
        //Declaración de las variables
        private int xInicial;
        private int xFinal;
        private int yInicial;
        private int yFinal;

        private static int contar = 0;

        //Se inicializan las variables con el método constructor, este lleva el mismo
        //nombre de la clase.
        public clsLinea()
        {
            xInicial = 0;
            xFinal = 0;
            yInicial = 0;
            yFinal = 0;
        }
        //Sobrecarga de métodos.
        public clsLinea(int xInicial, int xFinal, int yInicial, int yFinal)
        {
            this.xInicial = xInicial;
            this.xFinal = xFinal;
            this.yInicial = yInicial;
            this.yFinal = yFinal;
        }   

        public clsLinea(double xInicial, double xFinal, double yInicial, double yFinal) 
        {

            this.xInicial = (int)xInicial;
            this.xFinal = (int)xFinal;
            this.yInicial =(int)yInicial;
            this.yFinal = (int) yFinal;


        }
        //Obtiene el valor de xInicial
        public int obtenXInicial()
        {
            return xInicial;
        }
        
        //Obtiene el valor de xFinal
        public int obtenXfinal()
        {
            return xFinal;
        }

        //Obtiene el valor de yInicial
        public int obtenYInicial()
        {
            return yInicial;
        }
        //Obtiene el valor de yFinal
        public int obtenYFinal()
        {
            return yFinal;
        }

        public void cambiarXInicial(int xInicial)
        {
            this.xInicial = xInicial;
        }
        public void cambiarXFinal(int xFinal)
        {
            this.xFinal = xFinal;
        }
        public void cambiarYInicial (int yInicial)
        {
            this.yInicial = yInicial;
        }

        public void cambiarYFinal(int yFinal)
        {
            this.yFinal = yFinal;
        }
        //Método para contar la cantidad de lineas en dibujadas con una variable
        //contador que incrementa su valor de uno en uno
        public static int obtenCuentaDeLinea()
        {
            
            contar += 1;
            return contar;
        }






    }
}
