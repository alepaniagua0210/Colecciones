using Modelo;

Stack<Punto> puntos = new Stack<Punto>();

puntos.Push(new Punto(3, 4));
puntos.Push(new Punto(2, 5));
puntos.Push(new Punto(7, 12));
puntos.Push(new Punto(4, 8));
puntos.Push(new Punto(12, 6));

Imprimir(puntos);

Console.WriteLine("Pop {0}", puntos.Pop());

Imprimir(puntos);

Console.WriteLine("Peek {0}", puntos.Peek());

Imprimir(puntos);

void Imprimir(Stack<Punto> collection)
{
    foreach (var item in collection) 
    {

        Console.WriteLine($"{item} ");

    }
    Console.WriteLine();
}