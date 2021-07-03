using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes.Events
{
    public class EventSubscriber
    {
        public int Value { get; set; }

        public EventSource Source { get; private set; }

        public event EventHandler PropertyChanged;

        public EventSubscriber(int value)
        {
            Value = value;
        }

        public void Subscribe(EventSource source)
        {
            Source = source;
            Source.PropertyChanged += Source_PropertyChanged;
        }

        private void Source_PropertyChanged(object sender, ValueEventArgs e)
        {
            var source = (EventSource)sender;
            Value = source.Value;
            OnPropertyChanged();
        }

        private void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, EventArgs.Empty);
        }

        public void UnSubscribe()
        {
            Source.PropertyChanged -= Source_PropertyChanged;
            Source = null;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
