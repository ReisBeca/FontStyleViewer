using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FontStyleViewer
{
    public partial class frmAddFont : Form
    {
        #region VARIABLES

        bool v_font_name_existance;

        #endregion

        public frmAddFont()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(c_Appearance.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        #region METHODS

        private void m_InsertData()
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO tb_font_style (font_name) VALUES ('" + txtFontName.Text + "')", cn);

                cmd.ExecuteNonQuery();

                //SUCCESS MESSAGE
                MessageBox.Show(" Data inserted successful! ", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex) { MessageBox.Show(" An error ocurred while inserting the data! " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cn.Close(); }
        }

        private void m_verifyDataExistanceFontName()
        {
            //BASIC STRUTURE ACCES DATABASE CONNECT
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand(" SELECT font_name FROM tb_font_style WHERE font_name = '" + txtFontName.Text + "' ", cn);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    v_font_name_existance = true;
                }
                else
                {
                    v_font_name_existance = false;
                }
            }

            catch (Exception ex) { MessageBox.Show(" An error occurred while verifying font name existance data! " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cn.Close(); }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFontName.Text != "")
            {
                m_verifyDataExistanceFontName();
                if(v_font_name_existance == true) { MessageBox.Show(" This font name already exist! Type another font!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    m_InsertData();
                    c_Global.action = true;
                    //Optional - 01
                    //Close();

                    //Optional - 02
                    txtFontName.Text = "";
                }
            }
            else { MessageBox.Show(" The text area is empty! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //c_Performance.ReleaseCapture();
            //c_Performance.SendMessage(Handle, 0x112, 0xf12, 0);
        }

        private void frmAddFont_Load(object sender, EventArgs e)
        {
            if(c_Global.theme_value == 1)
            {
                BackColor = Color.White;
                txtFontName.BackColor = Color.White;
                label1.ForeColor = Color.Gray;
                panel1.BackColor = Color.FromArgb(240, 240, 240);
                c_Performance.AnimateWindow(Handle, 200, c_Performance.BLEND);
            }
            else if (c_Global.theme_value == 2)
            {
                BackColor = Color.FromArgb(41, 45, 62);
                label1.ForeColor = Color.AliceBlue;
                panel1.BackColor = Color.FromArgb(55, 60, 83);
                txtFontName.BackColor = Color.FromArgb(55, 60, 83);
            }
        }
    }
}
