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

        public void Subscribe(EventSource source)
        {
            Source = source;
            source.PropertyChanged += SourceValuePropertyChanged;
        }

        private void SourceValuePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Value = ((EventSource)sender).Value;
        }

        public void Unsubscribe()
        {
            if (Source is not null)
            {
                Source.PropertyChanged -= SourceValuePropertyChanged;
                Source = null;
            }
        }
    }
}
