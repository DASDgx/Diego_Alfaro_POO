using System;
using System.Linq;
namespace MapaDeTesoros;
public class Program{
    public static void Main(String [] args){
        Random generador = new();
        while (true){ //Inicia el ciclo del Generador de Mapas
            Console.Clear();
            int contadorTesoros = 0;
            string mapaResultado ="===== MAPA =====\n";
            string ubicaciones = "Locaciones de Tesoros\n";
            int [,] mapa = new int [3,4]; //Iniciar arreglo de 2 dimensiones, X=3 Y=4
            Console.WriteLine($"Generando Mapa de Tesoros de {mapa.GetLength(0)}x{mapa.GetLength(1)}...");
             //Asignacion de datos
            for (int filas=0; filas<mapa.GetLength(0); filas++){ //Recorrido X
                for(int columnas=0; columnas<mapa.GetLength(1); columnas++){ //Recorrido Y
                    mapa[filas,columnas] = generador.Next(0,2); //Generador de 0 y 1
                    if(mapa[filas,columnas] == 1){
                        contadorTesoros++; //Si genero un tesoro/1, lo cuenta
                        ubicaciones += $"{contadorTesoros}-[{filas},{columnas}]\n"; //Acumula la coordenada en String dentro de la variable
                        mapaResultado += "| x "; //Acumula la casilla con el Tesoro representado en X
                    }else mapaResultado += "|   "; //Acumula la casilla vacia / sin tesoro
                }
                mapaResultado+="|\n"; //Cierra la ultima casilla de la fila
            }
            Console.WriteLine(mapaResultado); //Imprime el mapa (|  | x |  |...)
            Console.WriteLine("Numero de Tesoros: "+contadorTesoros); //Imprime conteo de Tesoros
            Console.WriteLine(ubicaciones); //Imprime coordenadas acumuladas
            Console.WriteLine("\n-Enter para generar un nuevo mapa\n-Cualquier otro valor para salir"); //indicaciones para el usuario
            string decision = Console.ReadLine(); //Lee Respuesta del usuario
            if(!(decision == "")) break; //Si presiono Enter, rompe el ciclo
        }//Termina Ciclo Generador de Mapas


    



    }
}