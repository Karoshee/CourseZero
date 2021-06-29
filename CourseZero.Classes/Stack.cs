using CourseZero.Classes.SomeClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes
{
    public class Stack<T> : IEnumerable<T>
    {
        private class Element<TElement> where TElement : T
        {
            public Element<TElement> Next { get; set; }

            public Element<TElement> Previous { get; set; }

            public TElement Value { get; set; }

            public override string ToString()
            {
                return $"Value={Value}";
            }
        }

        private Element<T> First { get; set; }

        public int Count { get; private set; }

        public Stack(params T[] items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public void Add(T item)
        {
            First = new Element<T>()
            {
                Value = item,
                Next = First
            };

            if (First.Next is not null)
            {
                First.Next.Previous = First;
            }
            Count++;
        }

        public T this[int index]
        {
            get 
            {
                Element<T> current = First;
                int i = 0;
                while (current is not null)
                {
                    if (i == index)
                    {
                        return current.Value;
                    }
                    current = current.Next;
                    i++;
                }
                return default(T);
            }
            set 
            {
                Element<T> current = First;
                int i = 0;
                while (current != null)
                {
                    if (i == index)
                        current.Value = value;
                    current = current.Next;
                    i++;
                }
            }
        }



        public bool RemoveAt(int index)
        {
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Element<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class StackEnumerator : IEnumerator<T>
        {
            public Element<T> First { get; }

            public Element<T> CurrentElement { get; private set; }

            public StackEnumerator(Element<T> first)
            {
                CurrentElement = First = first;
            }

            public T Current { get { return CurrentElement.Value; }  }

            object IEnumerator.Current { get { return Current; } }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (CurrentElement.Next is null)
                    return false;
                CurrentElement = CurrentElement.Next;
                return true;
            }

            public void Reset()
            {
                CurrentElement = First;
            }
        }
    }

    
}
