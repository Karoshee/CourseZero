using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Reflection
{
    public abstract class BaseClass
    {
        [Description("Введите внутренний текст:")]
        [Index(5)]
        public virtual string InnerText { get; set; }

        protected abstract void OnPropertyChanged(string propertyName);
    }
}
