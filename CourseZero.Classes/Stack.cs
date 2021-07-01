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
        private class Element
        {
            public Element Next { get; set; }

            public Element Previous { get; set; }

            public T Value { get; set; }

            public override string ToString()
            {
                return $"Value={Value}";
            }
        }

        private Element First { get; set; }

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
            First = new Element()
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
                Element current = First;
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
                Element current = First;
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

        private Element GetByIndex(int index)
        {
            int i = 0;
            foreach (Element item in this.GetElements())
            {
                if (i == index)
                    return item;
                i++;
            }
            return null;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                return false;

            Element deletedElement = GetByIndex(index);
            Element next = deletedElement.Next;
            Element previous = deletedElement.Previous;

            if (previous is null)
            {
                First = next;
            }
            else
            {
                previous.Next = next;
            }

            if (next is not null)
            {
                next.Previous = previous;
            }
            Count--;
            return true;
        }

        private IEnumerable<Element> GetElements()
        {
            Element current = First;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            //Element current = First;
            //while (current != null)
            //{
            //    yield return current.Value;
            //    current = current.Next;
            //}
            return new StackEnumerator(First);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", this)}]";
        }

        public static Stack<T> operator+(Stack<T> stack1, Stack<T> stack2)
        {
            var result = new Stack<T>();
            foreach (var item in stack1)
            {
                result.Add(item);
            }
            foreach (var item in stack2)
            {
                result.Add(item);
            }
            return result;
        }

        public static explicit operator Stack<T>(T[] items)
        {
            return new Stack<T>(items);
        }

        public delegate int Compare(T item1, T item2);

        public void Sort(Compare comparer)
        {
            Element maximum, current = null;
            for (int i = 0; i < Count; i++)
            {
                maximum = GetByIndex(i);
                for (int j = i + 1; j < Count; j++)
                {
                    current = GetByIndex(j);
                    if (comparer(current.Value, maximum.Value) > 0)
                    {
                        maximum = current;
                    }
                }
                _MoveToFirst(maximum);
                current = null;
            }
        }

        private void _MoveToFirst(Element maximum)
        {
            if (maximum == First)
                return;

            var index = IndexOf(maximum);
            if(RemoveAt(index))
            {
                Add(maximum.Value);
            }
        }

        private int IndexOf(Element element)
        {
            int i = 0;
            foreach (var item in GetElements())
            {
                if (item == element)
                    return i;
                i++;
            }
            return -1;
        }

        private class StackEnumerator : IEnumerator<T>
        {
            public Element First { get; }

            public Element CurrentElement { get; private set; }

            public StackEnumerator(Element first)
            {
                First = first;
            }

            public T Current { get { return CurrentElement.Value; }  }

            object IEnumerator.Current { get { return Current; } }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (CurrentElement is null)
                {
                    CurrentElement = First;
                    return true;
                }
                if (CurrentElement.Next is null)
                    return false;
                CurrentElement = CurrentElement.Next; // ??
                return true;
            }

            public void Reset()
            {
                CurrentElement = null;
            }
        }
    }


}
