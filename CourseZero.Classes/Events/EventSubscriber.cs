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

        public EventSubscriber(int value)
        {
            Value = value;
        }
    }
}
