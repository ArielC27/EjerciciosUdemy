using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPractica1
{
    public class Ticket
    {
        private int tipo;
        private string color;
        private double tamaño;
        private int cantidad;

        public int GetTipo()
        {
            return tipo;
        }
        public void SetTipo(int tipo)
        {
            if (tipo == 1 || tipo == 2 || tipo == 3)
            {
                this.tipo = tipo;
            }
            else
            {
                this.tipo = 0;
            }
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public double GetTamaño()
        {
            return this.tamaño;
        }
        public void SetTamaño(double tamaño)
        {
            if (tamaño > 0)
            {
                this.tamaño = tamaño;
            }
            else
            {
                Console.WriteLine("VALOR INCORRECTO");
                this.tamaño = 0;
            }
        }
        public int GetCantidad()
        {
            return this.cantidad;
        }
        public void SetCantidad(int cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad = cantidad;
            }
            else
            {
                Console.WriteLine("VALOR INCORRECTO");
                this.cantidad = 0;
            }
        }
        public double Precio()
        {
            int tipo = this.tipo;
            switch (tipo)
            {
                case 1: return 5.00;
                case 2: return 8.00;
                case 3: return 12.00;
                default: return 0;

            }
        }
        public double Total()
        {
            double total = 0;
            double precio = Precio();
            return total = cantidad * precio;
        }

    }
}
