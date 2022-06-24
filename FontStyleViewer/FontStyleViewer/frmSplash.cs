using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAnimation;

namespace FontStyleViewer
{
    public partial class frmSplash : Form
    {
        Label lbltitle = new Label();
        Point p_title_location = new Point();

        public frmSplash()
        {
            InitializeComponent();

            //Rounded borders
            Region = System.Drawing.Region.FromHrgn(c_Appearance.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //c_Performance.AnimateWindow(Handle, 100, c_Performance.BLEND);
        }

        private void c_Gradient_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            c_Performance.ReleaseCapture();
            c_Performance.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value  < 100)
            {
                progressBar1.Value += 4;
            }

            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                Hide();
                new Form1().Show();
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            c_Performance.ReleaseCapture();
            c_Performance.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            c_Performance.ReleaseCapture();
            c_Performance.SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
