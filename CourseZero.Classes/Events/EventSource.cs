using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes.Events
{
    public class EventSource 
    {
        private int _value;

        public int Value 
        { 
            get { return _value; }
            set 
            {
                var odlValue = _value;
                _value = value;
                OnPropertyChanged(odlValue);
            }
        }

        public event EventHandler<ValueEventArgs> PropertyChanged;

        protected void OnPropertyChanged(int oldValue)
        {
            PropertyChanged?.Invoke(this, new ValueEventArgs(oldValue));
        }
    }

    public class ValueEventArgs : EventArgs
    {
        public int OldValue { get; private set; }

        public ValueEventArgs(int oldValue)
        {
            OldValue = oldValue;
        }
    }
}
