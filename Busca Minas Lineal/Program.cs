using System;
using System.IO.Pipes;
using System.Linq;
namespace BuscaMinasLineal;
public class Program{
    public static void Main(string [] args){
            Console.Clear();
            Random generador = new();
        while (true){
            Console.WriteLine("1-Modo Normal\n2-Modo de pruebas");
            int opcion = int.Parse(Console.ReadLine());
            string devMode = "";
            Console.Clear();
            Console.WriteLine("Enterrando Mina...");
            int casilla = 0;
            int [] jugadas = new int[10];
            string indices = "| 1 || 2 || 3 || 4 || 5 || 6 || 7 || 8 || 9 || 10 |\n";
            string [] mapa = ["X", "X", "X", "X", "X", "X", "X", "X", "X", "X"];
            int locMina = generador.Next(0,10);
            int puntos = 0;
            string pista = "";

            Console.WriteLine("Listo!\nPresione cualquier tecla para empezar...");
            Console.ReadKey();
            if(opcion == 2)
                devMode = "\nUbicacion de la Mina: "+(locMina+1)+"\n";
            
            while (true){
                Console.Clear();
                string tablero = "";
                for(int genMapa=0; genMapa<mapa.Length; genMapa++){
                    tablero += "| "+mapa[genMapa]+" |";
                }
                Console.Write(indices+tablero+devMode+pista+"\nSeleccione una casilla: ");
                try{
                    casilla = int.Parse(Console.ReadLine());
                    casilla -= 1;
                    if(jugadas[casilla] == 1){
                        Console.Write("Ya elegiste esa casilla anteriormente, presiona cualquier tecla para intentarlo de nuevo");
                        Console.ReadKey();
                        continue;
                    }
                    jugadas[casilla] = 1;
                    if((casilla+1 == locMina) || casilla-1 == locMina) pista = "\nSe acercan cositas";
                        else pista = "\nSe alejan cositas";
                    if(casilla == locMina){
                        Console.Clear();
                        Console.Write(indices);
                        for(int fin=0; fin<mapa.Length; fin++){
                            Console.Write("| ");
                            if(fin == locMina) Console.Write("X");
                                else Console.Write(" ");
                            Console.Write(" |");
                        }
                        Console.WriteLine("\n*******\n**x_x**\n*******\n ....Perdiste....");
                        break;
                    }
                    else{
                        mapa[casilla] = " ";
                        puntos += 100;
                    }
                    if(puntos == 900){
                        Console.WriteLine("======GANASTE======");
                        break;
                    }
                }catch(Exception){
                    Console.WriteLine("Opcion Invalida...Para intentar de nuevo, presione cualquier tecla");
                    Console.ReadKey();
                }
            
            }
            Console.WriteLine("Puntos obtenidos: "+puntos);
            Console.WriteLine("Desea Jugar de nuevo?\n1-Si\n2-No");
            int juegoActivo = int.Parse(Console.ReadLine());
            if(juegoActivo == 2) break;
        }
    }
}