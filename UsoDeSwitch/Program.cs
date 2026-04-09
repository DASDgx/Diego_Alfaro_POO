using System;

using System.Linq;

namespace PrimerSwitch;

public static class Program {

    public static void Main() {

        bool menuAc = true;
        bool opcionV = true;

        int valorUno;
        int valorDos;
        int valorTres, mayor, menor, intermedio;

        int resultadoUno = 0;


        double valorUnoD;
        double valorDosD;
        double resultadoD;

        float valorUnoF;
        float resultadoF;

        string proceso = "";
        string continuar = "\n\nPresione cualquier tecla para continuar";

        int opcion;
        while (menuAc) {
            proceso = "";

            Console.WriteLine("1 - Obtener potencia\n2 - Convertir Km a M\n3 - Convertir Pesos a dolar\n4-Convertir °C a °F\n5- Ordenar numeros\n6- FizzBuzz\n7 - Salir");
            try {
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
            } catch (FormatException ex) {
                Console.WriteLine($"Error: {ex.Message}");
                opcion = 8;
            }

            switch (opcion) {
                case 1:
                    while (opcionV) {
                        Console.Write("Ingrese el valor a potrnciar: ");
                        try {
                            valorUno = int.Parse(Console.ReadLine());
                            Console.Write($"Asigne una potencia para {valorUno}: ");
                            valorDos = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Resolviendo {valorUno}^{valorDos} ...");
                            proceso = "" + valorUno;

                            for (int resol = 1; resol < valorDos; resol++) {
                                resultadoUno += valorUno * valorUno;
                                proceso += "x" + valorUno;
                            }
                            proceso += "=" + resultadoUno;
                            Console.WriteLine($"{proceso}\nResuelto{continuar}");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        } catch {
                            Console.WriteLine("Error, iniciando otra vez");
                        }
                    }
                    break;
                case 2:
                    while (opcionV) {
                        Console.Write("Ingrese los Kilometros a convettir: ");
                        try {
                            valorUnoD = double.Parse(Console.ReadLine());
                            resultadoD = valorUnoD * 1000;
                            proceso = $"{valorUnoD}x1000 = {resultadoD} m";
                            Console.WriteLine($"{proceso}\nResuelto{continuar}");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        } catch {
                            Console.WriteLine("Error, iniciando otra vez");
                        }
                    }
                    break;
                case 3:
                    while (opcionV) {
                        Console.Write("Ingrese su dinero en pesos mexicanos: ");
                        try {
                            valorUnoF = float.Parse(Console.ReadLine());
                            resultadoF = valorUnoF / 17.79f;
                            proceso = $"{valorUnoF} ÷ 17.79 = {resultadoF} Dolares";
                            Console.WriteLine($"{proceso}\nResuelto{continuar}");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        } catch {
                            Console.WriteLine("Error, iniciando otra vez");
                        }
                    }
                    break;
                case 4:
                    while (opcionV) {
                        Console.Write("Ingrese grados Centigrados: ");
                        try {
                            valorUnoF = float.Parse(Console.ReadLine());
                            resultadoF = (valorUnoF * 9 / 5) + 32;
                            proceso = $"(({valorUnoF}°C x 9)/ 5) + 32 = {resultadoF}°F";
                            Console.WriteLine($"{proceso}\nResuelto{continuar}");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        } catch {
                            Console.WriteLine("Error, iniciando otra vez");
                        }
                    }
                    break;
                case 5:
                    Console.Write("Ingresa el primer número: ");
                    valorUno = int.Parse(Console.ReadLine());

                    Console.Write("Ingresa el segundo número: ");
                    valorDos = int.Parse(Console.ReadLine());

                    Console.Write("Ingresa el tercer número: ");
                    valorTres = int.Parse(Console.ReadLine());

                    if (valorUno >= valorDos && valorUno >= valorTres) {
                        mayor = valorUno;
                        if (valorDos >= valorTres) {
                            intermedio = valorDos; menor = valorTres;
                        } else {
                            intermedio = valorTres; menor = valorDos;
                        }
                    } else if (valorDos >= valorUno && valorDos >= valorTres) {
                        mayor = valorDos;
                        if (valorUno >= valorTres) {
                            intermedio = valorUno; menor = valorTres;
                        } else {
                            intermedio = valorTres; menor = valorUno;
                        }
                    } else {
                        mayor = valorTres;
                        if (valorUno >= valorDos) { intermedio = valorUno; menor = valorDos; } else { intermedio = valorDos; menor = valorUno; }
                    }

                    Console.WriteLine($"Mayor: {mayor}\nIntermedio: {intermedio}\nMenor: {menor}\n");
                    Console.WriteLine($"Resuelto{continuar}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    for (int i = 0; i <= 100; i++) {
                        if (i % 15 == 0) {
                            Console.WriteLine("Fizzbuz");
                        } else if (i % 5 == 0) {
                            Console.WriteLine("buz");
                        } else if (i % 3 == 0) {
                            Console.WriteLine("Fizz");
                        } else {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine($"Resuelto{continuar}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    menuAc = false;
                    break;

                default:
                    Console.WriteLine("Opcion invalida\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }

        }
    }

}


