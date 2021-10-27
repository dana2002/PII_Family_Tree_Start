using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Dana", 19);
            Node n2 = new Node("Maxi", 30);
            Node n3 = new Node("Rafa", 19);
            Node n4 = new Node("Marce", 20);
            Node n5 = new Node("Belen", 23);
            Node n6 = new Node("Joaquin", 19);
            Node n7 = new Node("Juan", 19);
            Node n8 = new Node("Fede", 18);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
        }
    }
}
