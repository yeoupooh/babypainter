using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BabyPainter
{
    public partial class FormMain : Form
    {
        private float m_lineWidth = 5;
        private Color m_lineColor = Color.Blue;

        private Point m_prevLoc;

        private GraphicsPath m_gp;

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
                m_prevLoc = e.Location;
                m_gp = new GraphicsPath();
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                using (Pen p = new Pen(m_lineColor, m_lineWidth))
                {
                    m_gp.AddLine(m_prevLoc, e.Location);
                    //g.DrawLine(p, m_prevLoc, e.Location);
                    g.DrawPath(p, m_gp);
                }
                m_prevLoc = e.Location;
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                using (Pen p = new Pen(m_lineColor, m_lineWidth))
                {
                    g.DrawLine(p, m_prevLoc, e.Location);
                }
                m_prevLoc = e.Location;
            }

            if (m_gp != null)
            {
                m_gp = null;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void lineSelectBox1_LineWidthChanged(object sender, LineWidthChangedEventArgs e)
        {
            m_lineWidth = e.LineWidth;
        }

        private void paletteSelectBox1_ColorChanged(object sender, ColorChangedEventArgs e)
        {
            m_lineColor = e.Color;
        }
    }
}