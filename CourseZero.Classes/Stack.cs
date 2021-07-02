using CourseZero.Classes.SomeClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes
{
    public partial class Stack<T> : IEnumerable<T>
    {
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
                Element element = GetByIndex(index);
                if (element is not null)
                    return element.Value;
                return default(T);
            }
            set
            {
                Element element = GetByIndex(index);
                if (element is not null)
                    element.Value = value;
            }
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
            Element current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
            //return new StackEnumerator(First);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", this)}]";
        }

        public delegate int Compare(T item1, T item2);

        public void Sort(Compare comparer)
        {
            Element maximum, current = null;
            for (int k = 0; k < Count; k++)
            {
                maximum = GetByIndex(k);
                for (int i = k + 1; i < Count; i++)
                {
                    current = GetByIndex(i);
                    if (comparer(current.Value, maximum.Value) > 0)
                        maximum = current;
                }
                _MoveToFirst(maximum);
                current = null;
            }
        }

        private void _MoveToFirst(Element maximum)
        {
            if (maximum == First)
                return;

            int index = IndexOf(maximum);
            if (RemoveAt(index))
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

        public static Stack<T> operator +(Stack<T> stack1, Stack<T> stack2)
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

    }


}
