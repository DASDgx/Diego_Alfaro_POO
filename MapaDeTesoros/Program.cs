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
                    if(mapa[filas,columnas] == 1) contadorTesoros++; //Si genero un tesoro/1, lo cuenta
                }
            }
            //Lectura de Datos
            for(int filasRead=0; filasRead<mapa.GetLength(0); filasRead++){ //Recorrido X
                for(int columnasRead=0; columnasRead<mapa.GetLength(1); columnasRead++){ //Recorrido Y
                    if(mapa[filasRead,columnasRead] == 1) { //Si en el arreglo mapa[X, Y] hay un 1
                        ubicaciones += $"Y:{filasRead}, X:{columnasRead}\n"; //Acumula la coordenada en String dentro de la variable
                        mapaResultado += "| x "; //Acumula en la variable mapa la senalizacion con X de que es un tesoro
                    }else mapaResultado += "|   "; //Sino, Acumula en la variable mapa un espacio vacio, de que no hay tesoro
                }
                mapaResultado+="|\n"; //Cierra la ultima casilla del mapa
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