using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BabyPainter
{
    public class ColorChangedEventArgs : EventArgs
    {
        private Color m_color;

        public Color Color
        {
            get { return m_color; }
            set { m_color = value; }
        }

        public ColorChangedEventArgs(Color color)
        {
            m_color = color;
        }
    }

    public delegate void ColorChangedEventHandler(object sender, ColorChangedEventArgs e);

}
