using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BabyPainter
{
    public class DrawingObject
    {
        private Pen mPen;
        private GraphicsPath mGp;


        public Pen Pen
        {
            get { return mPen; }
            set { mPen = value; }
        }

        public GraphicsPath GraphicsPath
        {
            get { return mGp; }
            set { mGp = value; }
        }

        public DrawingObject(Pen pen, GraphicsPath gp)
        {
            mPen = pen;
            mGp = gp;
        }
    }
}
