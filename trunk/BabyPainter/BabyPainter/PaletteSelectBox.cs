using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BabyPainter
{
    public partial class PaletteSelectBox : UserControl
    {
        private PaletteButton m_prevSelected = null;
        private Color m_selectedColor;

        [Browsable(true)]
        public Color SelectedColor
        {
            get { return m_selectedColor; }
            set { m_selectedColor = value; }
        }

        public event ColorChangedEventHandler ColorChanged;

        public PaletteSelectBox()
        {
            InitializeComponent();
        }

        private void OnPaletteButtonClick(object sender, EventArgs e)
        {
        }

        private void OnPaletteButtonMouseEnter(object sender, EventArgs e)
        {
            if (sender is PaletteButton)
            {
                PaletteButton palette = sender as PaletteButton;
                m_selectedColor = palette.Color;
                palette.Selected = true;
                palette.Invalidate();

                if (m_prevSelected != null)
                {
                    m_prevSelected.Selected = false;
                    m_prevSelected.Invalidate();
                }

                m_prevSelected = palette;

                if (ColorChanged != null)
                {
                    ColorChanged(this, new ColorChangedEventArgs(m_selectedColor));
                }
            }
        }
    }
}
