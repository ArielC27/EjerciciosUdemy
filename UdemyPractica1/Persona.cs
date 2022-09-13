using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPractica1
{
    public class Persona
    {
        private string nombre { get; set; }
        private string apPaterno { get; set; }
        private string apMaterno { get; set; }
        private int edad { get; set; }
        private double sueldo { get; set; }

        public string GetNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetApPaterno()
        {
            return apPaterno;
        }
        public void setApPaterno(string apPaterno)
        {
            this.apPaterno = apPaterno;
        }
        public string getApMaterno()
        {
            return apMaterno;
        }
        public void setApMaterno(string apMaterno)
        {
            this.apMaterno = apMaterno;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            if (edad > 0)
            {
                this.edad = edad;
            }
            else
            {
                Console.WriteLine("VALOR INGRESADO INCORRECTO");
                this.edad = 0;
            }
        }
        public double GetSueldo()
        {
            return sueldo;
        }
        public void SetSueldo(double sueldo)
        {
            if (sueldo > 0)
            {
                this.sueldo = sueldo;
            }
            else
            {
                Console.WriteLine("VALOR INGRESADO INCORRECTO");
                this.sueldo = 0;
            }
        }

    }
}
