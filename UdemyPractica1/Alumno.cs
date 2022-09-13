using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPractica1
{
    public class Alumno
    {
        double suma = 0;
        public string NombreAlumno { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }
        
        public double Prom12 (double prom12)
        {
            suma = Nota1 + Nota2;
            prom12 = suma / 2.0;
            return prom12;
        }
        public double Prom34(double prom34)
        {
            suma = Nota3 + Nota4;
            prom34 = suma / 2.0;
            return prom34;
        }
        public double Prom(double prom)
        {
            suma = Nota1 + Nota2 + Nota3 + Nota4;
            prom = suma / 4.0;
            return prom;
        }
    }
}
