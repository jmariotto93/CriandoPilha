//Declarando a fila
Stack<int> pilha = new Stack<int>();

//Adicionando elementos na pilha
pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

//Removendo o numero 10 da pilha usando o Pop
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

//Adicionando o elemento 20 que vai ser o primeiro da pilha LIFO
pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}