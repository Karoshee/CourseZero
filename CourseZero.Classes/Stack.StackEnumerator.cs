using System.Collections;
using System.Collections.Generic;

namespace CourseZero.Classes
{
    public partial class Stack<T>
    {
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

                CurrentElement = CurrentElement?.Next ?? First;

                return true;
            }

            public void Reset()
            {
                CurrentElement = null;
            }
        }
    }


}
