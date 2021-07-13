using System.ComponentModel;

namespace CourseZero.Reflection
{
    public class CustomClass : BaseClass
    {
        private int _index;

        public int Index 
        { 
            get => _index;
            set 
            {
                if (Index == value)
                    return;
                _index = value;
                OnPropertyChanged(nameof(Index));
            }
        }

        public string Text { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CustomClass() : this(1, "")
        {

        }

        public CustomClass(int index, string text)
        {
            Index = index;
            Text = text;
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DoTheThing()
        {
            Index++;
        }

        public void Do()
        {
            Index++;
        }

        public void Deconstruct(out string text, out int index)
        {
            text = this.Text;
            index = this.Index;
        }

        public static CustomClass Build()
        {
            return new CustomClass();
        }

        public static int GlobalIndex { get; set; }
    }
}
