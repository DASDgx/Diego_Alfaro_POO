using System; 
using System.Linq;

namespace RegistroTemperaturas;
public static class Program{
    public static void Main(String [] args){
        Console.Clear();
        
        int [] datosClima = new int [7];
        string [] dias = {"Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado"};
        
        string resultado = "=======RESULTADOS=======\n";
        
        for(int i =0; i<datosClima.Length; i++){
            Console.Write($"Ingrese la temperatura para el dia {dias[i]}: ");
            datosClima[i] = int.Parse(Console.ReadLine());
            resultado += dias[i] + ":" + datosClima[i]+"\n";

        }
        int mayorDia = 0;
        int menorDia = 0;
        int mayorTemp = datosClima[0];
        int menorTemp = mayorTemp;

        for(int determinante = 0; determinante<datosClima.Length; determinante++){  
            if(datosClima[determinante] > mayorTemp){
                mayorDia = determinante;
                mayorTemp = datosClima[determinante];
            }
            if(datosClima[determinante] < menorTemp){
                menorDia = determinante;
                menorTemp = datosClima[determinante];
            }
        }
        Console.WriteLine(resultado+$"\nEl dia mas caluroso fue {dias[mayorDia]} con {mayorTemp}\nEl dia mas frio fue {dias[menorDia]} con {menorTemp}");
    }
}