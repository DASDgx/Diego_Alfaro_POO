using System;
using System.Linq;

namespace DiagnosticoCambioProfe;

public static class Program {
    public static void Main() {
        Console.Clear();
        while (true) {
            string errorDeDatos = "";
            bool concluido = false;
            //Solicitud de Nombre
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            if (nombre == "") {
                Console.WriteLine("La cadena no puede estar vacia\nPresione Enter para intentar de nuevo");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            //Conversiones
            Console.WriteLine("Su primer caracter es " + nombre[0]);
            int primeraLetra = nombre[0];
            Console.WriteLine("Su valor en ASCII es " + primeraLetra);

            //Definicion de variables
            int valor;
            int comparacionMayor = 0;
            int comparacionMenor = 0;

            int contadorGeneral = 0;
            int sumaGeneral = 0;

            int contadorPar = 0;
            int contadorImpar = 0;

            //Procesamiento de valores Enteros
            while (true) {
                try {
                    //Entrada de datos
                    Console.WriteLine("-Ingrese un valor entero positivo\n-Cualquier texto para finalizar");
                    try{
                        valor = int.Parse(Console.ReadLine());
                        if(valor<0){
                            Console.WriteLine("entroooo");
                            errorDeDatos = "Solo puedes ingresar numeros enteros positivos, iguales o mayores a 0";
                            concluido = false;
                            throw new();
                            }
                        concluido = true;
                    }catch(Exception){
                        Console.WriteLine(errorDeDatos);
                        
                        break;
                    }
                    //Mayor y Menor
                    if (valor <= comparacionMenor || comparacionMenor == 0) {
                        comparacionMenor = valor;
                    }
                    if (valor >= comparacionMayor) {
                        comparacionMayor = valor;
                    }
                    //Par e impar
                    if ((valor % 2) == 0) contadorPar++; else contadorImpar++;
                    
                    //Conteo de valores ingresados y suma de los mismos
                    contadorGeneral++;
                    sumaGeneral += valor;
                } catch (Exception) {
                    break;
                }
            }
            //Resultados
            if(concluido){
                int promedio = sumaGeneral/contadorGeneral;
                Console.WriteLine($"\nRESULTADOS\nValor mayor entre todos {comparacionMayor}\nValor menor entre todos {comparacionMenor}"); //Mayor y menor
                Console.WriteLine($"Haz ingresado {contadorGeneral} valores\nLa suma de todos sus valores es {sumaGeneral}"); //Contador y suma general de valores
                Console.Write($"El promedio entre sus valores es de {promedio}, el cual es "); //Promedio de valores ingresados
                if(promedio>50) Console.WriteLine("mayor a 50"); else if(promedio == 50) Console.WriteLine("igual a 50 ");
            }
            Console.WriteLine("-Enter para iniciar de nuevo\n-Cualquier otra tecla para finalizar"); //FInalizacion o continuidad del programa completo
            string decision = Console.ReadLine();
            if(decision != "") break;
        }
    }
}