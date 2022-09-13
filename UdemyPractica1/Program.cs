using System;

namespace UdemyPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*** 1) Ejercico de Cuenta

            //Cuenta cuenta1 = new Cuenta();
            // cuenta1.SetTitular("Ariel Gutierrez");
            // cuenta1.SetCantidad(356.12m);
            // cuenta1.Retirar(1000);
            // Console.WriteLine(cuenta1.GetCantidad());

            //*** 2) Ejercicio de Ticket

            //Ticket ticket1 = new Ticket();

            //Console.Write("Ingrese el tipo de pelota: ");
            //ticket1.SetTipo(Convert.ToInt32(Console.ReadLine()));

            //Console.Write("Ingrese color: ");
            //ticket1.SetColor(Console.ReadLine());

            //Console.Write("Ingrese tamaño: ");
            //ticket1.SetTamaño(Convert.ToDouble(Console.ReadLine()));

            //Console.Write("Ingrese cantidad: ");
            //ticket1.SetCantidad(Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("");
            //Console.WriteLine($"Tipo: {ticket1.GetTipo()} " +
            //                  $"\nColor: {ticket1.GetColor()} " +
            //                  $"\nTamaño: {ticket1.GetTamaño()} cm" +
            //                  $"\nPrecio: {ticket1.Precio()}$ " +
            //                  $"\nCantidad: {ticket1.GetCantidad()} unidades" +
            //                  $"\nTotal: {ticket1.Total()}$");

            // 3) Ejercicio Alumnos

            Alumno alumno1 = new Alumno();
            alumno1.NombreAlumno = "Ariel Gutierrez";
            alumno1.Nota1 = 10;
            alumno1.Nota2 = 2;
            alumno1.Nota3 = 8;
            alumno1.Nota4 = 5;

            Console.WriteLine($"El alumno { alumno1.NombreAlumno} tiene las siguientes notas.");
            Console.WriteLine($"El promedio de las notas 1 y 2 es: { alumno1.Prom12(alumno1.Nota1 + alumno1.Nota2)}");
            Console.WriteLine($"El promedio de las notas 3 y 4 es: { alumno1.Prom34(alumno1.Nota3 + alumno1.Nota4)}");
            Console.WriteLine($"El promedio de las notas es: { alumno1.Prom(alumno1.Nota1 + alumno1.Nota2 + alumno1.Nota3 + alumno1.Nota4)}");
   
            Console.ReadLine();

        }
    }
}
