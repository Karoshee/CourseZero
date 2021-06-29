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
        private class Element<TElement> where TElement: T
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

        public T this[int index]
        {
            get
            {
                Element<T> current = First;
                int i = 0;
                while (current != null)
                {
                    if (i == index)
                        return current.Value;
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

        public void Add(T item)
        {
            First = new()
            {
                Value = item,
                Next = First
            };
            if (First.Next is not null)
                First.Next.Previous = First;
            Count++;
        }

        public bool RemoveAt(int index)
        {
            if (Count < 1)
                return false;
            if (Count == 1)
            {
                if (index == 0)
                {
                    First = null;
                }
                return false;
            }

            Element<T> current = First;

            int i = 0;
            while (current != null)
            {
                if (i == index)
                {
                    if (current.Previous is not null)
                        current.Previous.Next = current.Next;
                    else
                        First = current.Next;

                    if (current.Next is not null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        current.Previous.Next = null;
                    }
                    Count--;
                    current.Next = null;
                    current.Previous = null;
                    return true;
                }
                current = current.Next;
                i++;
            }
            return false;
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
            Element<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", this.Select(x => x.ToString()).ToArray())}]";
        }

        private class StackEnumerator : IEnumerator<T>
        {
            public Element<T> First { get; }


            public Element<T> CurrentElement {get; private set;}

            public StackEnumerator(Element<T> first)
            {
                CurrentElement = First = first;
            }

            public T Current { get => CurrentElement.Value; }

            object IEnumerator.Current { get => Current; }

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

        // Делегаты
        public delegate int Comparer(T value1, T value2);

        public void Sort(Comparer comparer)
        {
            Element<T> maximum, 
                current = First,
                comparable;

            while (current is not null)
            {
                maximum = current;
                comparable = current.Next;
                while(comparable is not null)
                {
                    if (comparer(comparable.Value, maximum.Value) > 0)
                        maximum = comparable;
                    comparable = comparable.Next;
                }
                _PushToTop(maximum);
                current = maximum.Next;
            }
        }

        private void _PushToTop(Element<T> element)
        {
            if (element != First)
            {
                Element<T> current = First;
                int index = 0;
                while (current is not null)
                {
                    if(current == element)
                        break;
                    index++;
                    current = current.Next;
                }

                RemoveAt(index);
                Add(element.Value);
            }
        }

    }

    
}
