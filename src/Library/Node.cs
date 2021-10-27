using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        //private int number;
        private Persona persona;

        public Persona Persona{get;}

        private List<Node> children = new List<Node>();

       /* public int Number {
            get
            {
                return this.number;
            }
        }*/

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string nombre, int edad)
        {
            Persona person = new Persona(nombre, edad);
            this.Persona = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
