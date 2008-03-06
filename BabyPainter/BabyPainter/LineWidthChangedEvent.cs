using System;
using System.Collections.Generic;
using System.Text;

namespace BabyPainter
{
    public class LineWidthChangedEventArgs : EventArgs
    {
        private float m_lineWidth;

        public float LineWidth
        {
            get { return m_lineWidth; }
            set { m_lineWidth = value; }
        }

        public LineWidthChangedEventArgs(float lineWidth)
        {
            m_lineWidth = lineWidth;
        }

    }

    public delegate void LineWidthChangedEventHandler(object sender, LineWidthChangedEventArgs e);
}
