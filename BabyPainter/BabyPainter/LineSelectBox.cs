using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BabyPainter
{
    public partial class LineSelectBox : UserControl
    {
        private LineButton m_prevSelected = null;
        private float m_selectedLineWidth;

        [Browsable(true)]
        public float SelectedLineWidth
        {
            get { return m_selectedLineWidth; }
            set { m_selectedLineWidth = value; }
        }
        private Color m_lineColor;

        [Browsable(true)]
        public Color LineColor
        {
            get { return m_lineColor; }
            set { m_lineColor = value; }
        }

        public event LineWidthChangedEventHandler LineWidthChanged;

        public LineSelectBox()
        {
            InitializeComponent();
        }

        private void OnLineButtonClick(object sender, EventArgs e)
        {
            //if (sender is LineButton)
            //{
            //    LineButton lb = sender as LineButton;

            //    m_lineColor = lb.LineColor;
            //    m_selectedLineWidth = lb.LineWidth;

            //    lb.Selected = true;
            //    lb.Invalidate();

            //    if (m_prevSelected != null)
            //    {
            //        m_prevSelected.Selected = false;
            //        m_prevSelected.Invalidate();
            //    }

            //    m_prevSelected = lb;

            //    if (LineWidthChanged != null)
            //    {
            //        LineWidthChanged(this, new LineWidthChangedEventArgs(m_selectedLineWidth));
            //    }
            //}
        }

        private void OnLineButtonMouseEnter(object sender, EventArgs e)
        {
            if (sender is LineButton)
            {
                LineButton lb = sender as LineButton;

                m_lineColor = lb.LineColor;
                m_selectedLineWidth = lb.LineWidth;

                lb.Selected = true;
                lb.Invalidate();

                if (m_prevSelected != null)
                {
                    m_prevSelected.Selected = false;
                    m_prevSelected.Invalidate();
                }

                m_prevSelected = lb;

                if (LineWidthChanged != null)
                {
                    LineWidthChanged(this, new LineWidthChangedEventArgs(m_selectedLineWidth));
                }
            }
        }

    }
}
