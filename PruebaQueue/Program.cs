using Modelo;

Queue<Punto> puntos = new Queue<Punto>();

puntos.Enqueue(new Punto(3,7));
puntos.Enqueue(new Punto(4,8));
puntos.Enqueue(new Punto(5,9));
puntos.Enqueue(new Punto(6,10));
puntos.Enqueue(new Punto(7,11));
puntos.Enqueue(new Punto(8,12));

Imprimir(puntos);

Console.WriteLine("Dequeue {0} ",puntos.Dequeue());
Console.WriteLine("Dequeue {0} ",puntos.Dequeue());

Imprimir(puntos);

Console.WriteLine("Peek {0}", puntos.Peek());

Imprimir(puntos);

Console.WriteLine(puntos.Count);

Punto p = new Punto(10, 7);

Console.WriteLine(puntos.Contains(p));

Console.WriteLine();

void Imprimir<T>(Queue<T> collection)
{
    foreach (T item in collection)
    {
        Console.WriteLine($"{item} ");
    }

    Console.WriteLine();
}