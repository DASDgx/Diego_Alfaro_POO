using System;
using System.Linq;

namespace TresRandom;

public static class Program {
    public static void Main() {
        Random rnd = new Random();
        int total = 100;
        string emooo = "🙋‍♂️";
        int chekeo = 1;

        int valorUno = rnd.Next(0, 101);
        Console.WriteLine($"Valor generado {valorUno}");
        total -= valorUno;

        int valorDos = rnd.Next(0, total);
        Console.WriteLine($"Valor generado {valorDos}");
        total -= valorDos;

        Console.WriteLine($"Valor generado {total}");
        Console.WriteLine($"{valorUno} + {valorDos} + {total} = 100");

        int turno = valorUno;
        Console.WriteLine($"TURNO DE {valorUno}");

        for (int recorrido = 1; chekeo < 4; recorrido++) {

            if (recorrido == turno + 1 && chekeo == 1) {
                Console.WriteLine($"TURNO DE {valorDos}");
                turno = valorDos;
                recorrido = 1;
                emooo = "🤫";
                chekeo++;
            }
            if (recorrido == turno + 1 && chekeo == 2) {
                Console.WriteLine($"TURNO DE {total}");
                turno = total;
                recorrido = 1;
                emooo = "😡";
                chekeo++;
            }
            if (recorrido == turno + 1 && chekeo == 3) break;

            Console.WriteLine($"{recorrido} {emooo}");
        }
    }
}
