using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BabyPainter
{
    public partial class LineButton : UserControl
    {
        private float m_lineWidth = 1;
        private Color m_lineColor = Color.Blue;

        private bool m_selected = false;

        [Browsable(true)]
        public bool Selected
        {
            get { return m_selected; }
            set { m_selected = value; }
        }

        [Browsable(true)]
        public Color LineColor
        {
            get { return m_lineColor; }
            set
            {
                m_lineColor = value;
            }
        }

        [Browsable(true)]
        public float LineWidth
        {
            get { return m_lineWidth; }
            set { m_lineWidth = value; }
        }

        public LineButton()
        {
            InitializeComponent();
        }

        private void LineWidthControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Pen p = new Pen(m_lineColor, m_lineWidth))
            {
                int penWidth = 6;
                using (Pen penBorder = new Pen(Color.Black, penWidth))
                {
                    g.DrawLine(p, 0, this.Height / 2, this.Width, this.Height / 2);
                    if (m_selected == true)
                    {
                        Rectangle rect = new Rectangle(
                            ClientRectangle.X + penWidth / 2, ClientRectangle.Y + penWidth / 2,
                            ClientRectangle.Width - penWidth, ClientRectangle.Height - penWidth);
                        g.DrawRectangle(penBorder, rect);
                    }
                }
            }

        }

        private void LineButton_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
