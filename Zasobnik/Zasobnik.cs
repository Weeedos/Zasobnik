using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasobnik
{
    internal class Zasobnik<T>
    {
        private Node<T>? head;
        public void Push(T element)
        {
            Node<T> n = new Node<T>(element);
            n.Next = head;
            head = n;
        }

        public T? Pop()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("Konec");
            }
            Node<T> n = head;
            head = n.Next;
            return n.Value;
        }

        public bool IsEmpty
        {
           get { return head == null; }
        }

    }
}
