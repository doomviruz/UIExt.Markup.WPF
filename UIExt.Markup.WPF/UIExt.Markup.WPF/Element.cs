using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIExt.Markup.WPF
{
    public abstract class Element
    {
        public Element(Type t)
        {
            Factory = new FrameworkElementFactory(t);
        }

        public FrameworkElementFactory Factory { get; }
    }

    public class Element<T> : Element where T : UIElement
    {
        public Element() : base(typeof(T))
        {
        }

        public Element<T> AppendChild(Element element)
        {
            Factory.AppendChild(element.Factory);
            return this;
        }
    }
}
