namespace CourseZero.Classes
{
    public partial class Stack<T>
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
    }


}
