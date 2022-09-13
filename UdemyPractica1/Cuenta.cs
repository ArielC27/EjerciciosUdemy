using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPractica1
{
    public class Cuenta
    {
        private string Titular { get; set; }
        private decimal Cantidad { get; set; }
        public string GetTitular()
        {
            return Titular;
        }
        public void SetTitular(string titular)
        {
            this.Titular = titular;
        }
        public decimal GetCantidad()
        {
            return this.Cantidad;
        }
        public decimal SetCantidad(decimal cantidad)
        {
            if (cantidad > 0)
            {
                return this.Cantidad = cantidad;
            }
            else
            {
                return this.Cantidad = 0;
            }
        }
        public decimal Ingresar(decimal cantidad)
        {
            if (cantidad >0)
            {
                Cantidad += cantidad;
                return Cantidad;
            }
            else
            {
                return cantidad = 0;
            }
        }
        public decimal Retirar(decimal cantidad)
        {
            if  (cantidad < Cantidad)
            {
                Cantidad -= cantidad;
                return Cantidad;
            }
            else
            {
                Console.WriteLine("El saldo es insuficiente");
                return Cantidad = 0; 
            }
                
        }
    }
}
