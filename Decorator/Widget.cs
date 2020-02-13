using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    interface Widget
    {
        public void draw();
    }
    class TextField : Widget
    {
        private int width;
        private int height;
        public TextField(int w, int h)
        {
            Console.WriteLine("I am a new text Field with the dimensions " + w + " by " + h);
        }
        void Widget.draw()
        {
            Console.WriteLine("I am a text Field with the dimensions " + w + " by " + h);
        }
    }
    public abstract class Decorator : Widget
    {
        private Widget wid;
        protected Decorator(Widget w)
        {
            wid = w;
        }
        public abstract void draw();
    }
    class BorderDecorator : Decorator
    {
        
        
        public BorderDecorator(Widget w)
        {
            
        }
        public override void draw()
        {
            Widget w = new TextField(5,5);
            Decorator x = new BorderDecorator(w);
            w.draw();
            x.draw();

        }
    }

    internal class ScrollDecorator : Decorator
    {
        public override void draw()
        {
            Console.WriteLine("I am a scroll bar")
        }
    }

}
