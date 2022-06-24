using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace FontStyleViewer
{
    internal class c_Gradient_Panel : Panel
    {
        public Color m_TopColor
        {
            get;
            set;
        }

        public Color m_BottomColor
        {
            get;
            set;
        }

        public float m_Angle
        {
            get;
            set;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, m_TopColor, m_BottomColor, m_Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, ClientRectangle);
            base.OnPaint(e);
        }
    }
}
