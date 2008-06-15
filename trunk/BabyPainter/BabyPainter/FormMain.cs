using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace BabyPainter
{
    public partial class FormMain : Form
    {
        private float mLineWidth = 5;
        private Color mLineColor = Color.Blue;

        private Point mPrevLoc;

        private List<DrawingObject> mDrawingObjects = new List<DrawingObject>();
        private GraphicsPath mGp;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mPrevLoc = e.Location;
                mGp = new GraphicsPath();
                mDrawingObjects.Add(new DrawingObject(new Pen(mLineColor, mLineWidth), mGp));
                Invalidate();
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Graphics g = this.CreateGraphics();
                mGp.AddLine(mPrevLoc, e.Location);
                //using (Pen p = new Pen(mLineColor, mLineWidth))
                {
                    //g.DrawLine(p, m_prevLoc, e.Location);
                    //g.DrawPath(p, mGp);
                }
                mPrevLoc = e.Location;
                this.Invalidate();
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mGp.AddLine(mPrevLoc, e.Location);
                //Graphics g = this.CreateGraphics();
                //using (Pen p = new Pen(mLineColor, mLineWidth))
                //{
                //    g.DrawLine(p, mPrevLoc, e.Location);
                //}
                //mPrevLoc = e.Location;
                this.Invalidate();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            mDrawingObjects.Clear();
            this.Invalidate();
        }

        private void lineSelectBox1_LineWidthChanged(object sender, LineWidthChangedEventArgs e)
        {
            mLineWidth = e.LineWidth;
        }

        private void paletteSelectBox1_ColorChanged(object sender, ColorChangedEventArgs e)
        {
            mLineColor = e.Color;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(this.Width, this.Height);
                    this.DrawToBitmap(bmp, this.Bounds);
                    bmp.Save(dlg.FileName, ImageFormat.Png);
                }
            }
        }

        private void buttonNew_Paint(object sender, PaintEventArgs e)
        {
            foreach (DrawingObject drawingObject in mDrawingObjects)
            {
                e.Graphics.DrawPath(drawingObject.Pen, drawingObject.GraphicsPath);
            }
        }
    }
}