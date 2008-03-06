using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BabyPainter
{
    public partial class PaletteButton : UserControl
    {
        private Color m_color = Color.Blue;
        private bool m_selected = false;

        [Browsable(true)]
        public bool Selected
        {
            get { return m_selected; }
            set { m_selected = value; }
        }

        [Browsable(true)]
        public Color Color
        {
            get { return m_color; }
            set { m_color = value; }
        }

        public PaletteButton()
        {
            InitializeComponent();
        }

        private void PaletteButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Brush b = new SolidBrush(m_color))
            {
                int penWidth = 6;
                using (Pen penBorder = new Pen(Color.Black, penWidth))
                {
                    g.FillRectangle(b, ClientRectangle);
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
    }
}
