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
                _value = value; 
            }
        }

    }
}
