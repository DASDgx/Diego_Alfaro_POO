using System;
using System.Linq;

namespace RegistroCalificaciones;

public class Program
{
    public static void Main(String [] args){
        Console.Clear();
        double [] calificaciones = new double [5];
        for(int i=0; i<calificaciones.Length; i++){
            Console.Write($"Ingrese la calificacion {i+1}: ");
            calificaciones[i] = double.Parse(Console.ReadLine());
        }

        double mayor = calificaciones[0];
        double menor = mayor;

        for(int i=0; i<calificaciones.Length; i++)
        {
            if(calificaciones[i] > mayor) mayor = calificaciones[i];
            if(calificaciones[i] < menor) menor = calificaciones[i];
        }
        Console.WriteLine($"La calificacion mayor fue {mayor}\nLa calificacion menor fue {menor}");
    }
}


