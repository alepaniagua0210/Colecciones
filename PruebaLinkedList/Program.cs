LinkedList<int> numeros = new LinkedList<int> ();

foreach (var numero in new int[] { 10, 8, 6, 4, 2, 0 }) 
{

    numeros.AddLast(numero);  

}

Display(numeros);

for ( LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
{
    Console.WriteLine(nodo.Value);
}

string[] colores = { "Negro", "Amarillo", "Verde", "Azul", "Violeta", "Plateado" };

string[] colores2 = { "Dorado", "Café", "Azul", "Gris" }; 

LinkedList<string> lista1 = new LinkedList<string> ();

foreach (var color in colores) 
{

    lista1.AddLast (color);

}

Display (lista1);

LinkedList<string> lista2 = new LinkedList<string> ();
foreach (var color1 in colores2) 
{ 

    lista2.AddLast(color1);    

}
Display (lista2);

Concatenar(lista1, lista2);

Display(lista1);

void Concatenar<T>(LinkedList<T> lista1, LinkedList<T> lista2)
{
    foreach (T item in lista2) 
    {
    
        lista1.AddLast(item);
    
    }
}

CadenasMayuscula(lista1);

void CadenasMayuscula(LinkedList<string> lista)
{
    LinkedListNode<string> node = lista.First;

    while (node != null) {

        string color = node.Value;
        node.Value = color.ToUpper();

        node = node.Next; 
    
    }
}

Display(lista1);

EliminarElementos(lista1, "NEGRO", "CAFÉ");

void EliminarElementos(LinkedList<string> lista, string v1, string v2)
{
    LinkedListNode<string> node = lista.Find(v1);

    LinkedListNode<string> node2 = lista.Find(v2);

    while ((node.Next != null) && (node.Next != node2)) 
    {

        lista.Remove(node.Next);
    
    }

}

Display(lista1);

// Tarea: Imprimir la lista al revés

void Display<T>(LinkedList<T> collection)
{
    foreach (var item in collection) 
    {
        Console.Write($"{item}, ");
    }

    Console.WriteLine();
}