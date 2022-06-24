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
using WinFormAnimation;

namespace FontStyleViewer
{
    public partial class Form1 : Form
    {
        int v_font_size = 12;
        string v_font_name;
        string mode;
        int font_id;
        bool v_bold;
        bool v_font_name_existance;

        bool v_theme;
        int v_theme_value;

        bool data_existance;

        int v_side01;
        int v_side02;
        int v_side03;

        int v_side04;
        int v_side05;
        int v_side06;

        Point alignment_location = new Point();
        Point case_style_location = new Point();

        Panel p01 = new Panel();
        Panel p02 = new Panel();

        public Form1()
        {
            InitializeComponent();

            //Rounded borders
            Region = System.Drawing.Region.FromHrgn(c_Appearance.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        #region METHODS
        
        //Verifying
        private void m_verifyingThemeValue()
        {
            //BASIC STRUTURE ACCES DATABASE CONNECT
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand(" SELECT theme_value FROM tb_theme WHERE id = 1 ", cn);

                v_theme_value = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch (Exception ex) { MessageBox.Show("  " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cn.Close(); }
        }

        private void m_verifyDataExistanceFonts()
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand(" SELECT * FROM tb_font_Style", cn);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    data_existance = true;
                }

                else
                {
                    data_existance = false;
                }
            }

            catch(Exception ex) { MessageBox.Show(" An error occurred while verifying if data exists! " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cn.Close(); }
        }

        //Load

        private void m_loadSearchData()
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT font_name FROM tb_font_style WHERE font_name LIKE '%" + txtSearch.Text + "%' ORDER BY font_name", cn);

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                dgvFontStyles.DataSource = dt;
            }

            catch(Exception ex) { MessageBox.Show("An error occurred while search the data on database!" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);}

            finally { cn.Close(); }
        }

        private void m_loadData()
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();

                OleDbCommand cmd = new OleDbCommand(" SELECT font_name FROM tb_font_style ORDER BY font_name", cn);

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                dgvFontStyles.DataSource = dt;
            }

            catch(Exception ex) { MessageBox.Show(" Ocorreu um erroa o carregar os dados! " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cn.Close(); }
        }

        private void m_loadDataText(TextBox txtFontName)
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();

                OleDbCommand cmd = new OleDbCommand(" SELECT font_name FROM tb_font_style WHERE font_name = '" + v_font_name + "' ", cn);

                OleDbDataReader reader = cmd.ExecuteReader();

                reader.Read();

                txtFontName.Text = reader.GetString(0);
            }

            catch (Exception ex) { MessageBox.Show(" An error ocurred while loading the data on text area! " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cn.Close(); }
        }

        //Insert

        private void m_InsertData(TextBox txtFontName)
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

        //Update
        private void m_changeThemeValue()
        {
            //BASIC STRUTURE ACCES DATABASE CONNECT
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand(" UPDATE tb_theme SET theme_value = @theme_value WHERE id = 1", cn);

                cmd.Parameters.Add("@theme_value", OleDbType.Integer).Value = v_theme_value;

                cmd.ExecuteNonQuery();

                //MessageBox.Show(" Theme changed successful! ");
            }

            catch(Exception ex) { MessageBox.Show(" An error occurred while changing theme value! " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cn.Close(); }
        }

        //Delete
        private void m_deleteData()
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Font Style Viewer\FontStyleViewer.accdb");

            try
            {
                cn.Open();

                OleDbCommand cmd = new OleDbCommand(" DELETE FROM tb_font_style WHERE font_name = '" + v_font_name + "' ", cn);

                cmd.ExecuteNonQuery();

                MessageBox.Show(" Data deleted successfull!", "Success messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch(Exception ex) { MessageBox.Show(" An error occurred while deleting the data!" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cn.Close(); }
        }

        private void m_lightTheme()
        {
            BackColor = Color.White;

            //DataGridView colors customization
            dgvFontStyles.BackgroundColor = Color.White;
            dgvFontStyles.DefaultCellStyle.BackColor = Color.White;
            //dgvFontStyles.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvFontStyles.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvFontStyles.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dgvFontStyles.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 120, 215);

            //Font name title
            txtFontNameTitle.BackColor = Color.White;
            txtFontNameTitle.ForeColor = Color.Black;

            //Display font style
            txtDisplayFontStyle.BackColor = Color.White;
            txtDisplayFontStyle.ForeColor = Color.Black;
            ForeColor = Color.Black;

            //Panels
            Color panels_light_theme = Color.FromArgb(240, 240, 240);

            panel4.GradientBottomColor = panels_light_theme;
            panel4.GradientTopColor = panels_light_theme;

            panel5.GradientBottomColor = panels_light_theme;
            panel5.GradientTopColor = panels_light_theme;

            rbPanel1.GradientBottomColor = panels_light_theme;
            rbPanel1.GradientTopColor = panels_light_theme;

            panel1.BackColor = Color.FromArgb(246, 245, 245);

            panel7.BackColor = Color.AliceBlue;

            //TextBox
            txtSearch.BackColor = Color.FromArgb(240, 240, 240);
            rbPanel1.GradientBottomColor = Color.FromArgb(240, 240, 240);
            rbPanel1.GradientTopColor = Color.FromArgb(240, 240, 240);
        }

        private void m_darkTheme()
        {
            //First bakcground color 49, 18, 77
            //Second background color 41, 45, 62

            BackColor = Color.FromArgb(41, 45, 62);

            //DataGridView colors customization
            dgvFontStyles.BackgroundColor = Color.FromArgb(41, 45, 62);
            dgvFontStyles.DefaultCellStyle.BackColor = Color.FromArgb(41, 45, 62);
            //dgvFontStyles.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvFontStyles.DefaultCellStyle.ForeColor = Color.FromArgb(130, 146, 166);
            dgvFontStyles.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 54, 74);
            dgvFontStyles.DefaultCellStyle.SelectionForeColor = Color.White;

            Color panels_dark_theme = Color.FromArgb(51, 56, 78);
            //Panels
            panel4.GradientBottomColor = panels_dark_theme;
            panel4.GradientTopColor = panels_dark_theme;

            panel5.GradientBottomColor = panels_dark_theme;
            panel5.GradientTopColor = panels_dark_theme;

            panel1.BackColor = Color.FromArgb(55, 60, 83);

            //Font name title
            txtFontNameTitle.BackColor = Color.FromArgb(41, 45, 62);
            txtFontNameTitle.ForeColor = Color.White;

            //Display font style
            txtDisplayFontStyle.BackColor = Color.FromArgb(41, 45, 62);
            txtDisplayFontStyle.ForeColor = Color.White;
            ForeColor = Color.White;

            //Panels
            panel5.BackColor = Color.FromArgb(41, 45, 62);
            panel4.BackColor = Color.FromArgb(41, 45, 62);
            panel7.BackColor = Color.FromArgb(55, 60, 83);

            //TextBox
            txtSearch.BackColor = Color.FromArgb(51, 56, 78);
            rbPanel1.GradientBottomColor = Color.FromArgb(51, 56, 78);
            rbPanel1.GradientTopColor = Color.FromArgb(51, 56, 78);
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //c_Performance.AnimateWindow(Handle, 200, c_Performance.BLEND);

            p01.Visible = false;
            p02.Visible = false;

            v_bold = true;
            v_theme = true;
            //if (v_theme_value == 1)
            //{
            //    v_theme = false;
            //}
            //else if(v_theme_value == 2)
            //{
            //    v_theme = true;
            //}

            //Verifying methods
            
            m_verifyDataExistanceFonts();
            if(data_existance == true)
            {
                m_loadData();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnCopyFontStyle.Enabled = true;

                //Getting id value
                //font_id = Convert.ToInt32(dgvFontStyles.Rows[0].Cells[0].Value);

                v_font_name = Convert.ToString(dgvFontStyles.Rows[0].Cells[0].Value);
                c_Global.font_name = v_font_name;
                txtFontNameTitle.Text = v_font_name;
                txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size);
            }
            else
            {
                dgvFontStyles.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnCopyFontStyle.Enabled = false;
            }
            m_verifyingThemeValue();
            if (v_theme_value == 1)
            {
                m_lightTheme();
                c_Global.theme_value = 1;
            }
            else if(v_theme_value == 2)
            {
                m_darkTheme();
                c_Global.theme_value = 2;
            }

            v_side02 = 1;
            v_side03 = 1;

            v_side04 = 3;
            v_side05 = 3;

            txtDisplayFontStyle.Focus();
            txtDisplayFontStyle.BorderStyle = BorderStyle.None;
            txtDisplayFontStyle.CharacterCasing = CharacterCasing.Normal;

            Point location = new Point(378, 38);
            pCharacterCasing.Location = location;

            Point location2 = new Point(12, 38);
            pFocus.Location = location2;
        }

        private void lblAddNewFontStyle_Click(object sender, EventArgs e)
        {
            //m_InsertData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dgvFontStyles.Enabled = true;
            txtDisplayFontStyle.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNewFontStyle.Enabled = true;

        }

        private void dgvFontStyles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Getting the font name from dataGradView
            v_font_name = Convert.ToString(dgvFontStyles.Rows[e.RowIndex].Cells[0].Value);
            txtFontNameTitle.Text = v_font_name;
            c_Global.font_name = v_font_name;

            //Gettting/Setting the size and the font style
            txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size);

            //Getting id value from dataGridView
            //font_id = Convert.ToInt32(dgvFontStyles.Rows[e.RowIndex].Cells[0].Value);

            //Getting the size value from cbSize tool
            if (cbSize.Text != "")
            {
                v_font_size = int.Parse(cbSize.Text);
                if (v_font_size < 12 || v_font_size > 100)
                {
                    MessageBox.Show(" Invalid font size value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size);
                }
            }
            else
            {
                //Nothing to do
            }

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            //Bold
            if (v_bold == false)
            {
                txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size, System.Drawing.FontStyle.Bold);
                btnBold.BackColor = Color.FromArgb(225, 225, 225);
            }
            else
            {
                txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size, System.Drawing.FontStyle.Regular);
                btnBold.BackColor = Color.Transparent;
            }
        }

        private void btnAlignCenter_Click(object sender, EventArgs e)
        {
            v_side01 = 2;
            v_side03 = 2;

            alignment_location.X = 86;
            alignment_location.Y = 36;

            p01.Location = alignment_location;

            Controls.Add(p01);

            if (pFocus.Location == p01.Location)
            {
                //Nothing to do!
            }

            else
            {
                if(v_side02 == 1)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(12, 36, 36, 36, 1)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }

                else if(v_side02 == 3)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(159, 86, 36, 36, 150)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }
            }

            txtDisplayFontStyle.TextAlign = HorizontalAlignment.Center;
        }

        // This was the first (now it's invalid)
        private void btnAlignLeft_Click(object sender, EventArgs e)
        {
            v_side02 = 1;
            v_side03 = 1;

            alignment_location.X = 12;
            alignment_location.Y = 36;

            case_style_location.X = 86;
            case_style_location.Y = 36;

            p01.Location = alignment_location;

            Controls.Add(p01);

            if (pFocus.Location == p01.Location)
            {
                //Nothing to do!
            }

            else
            {
                if(v_side01 == 2)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(36, 12, 36, 36, 50)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }

                else if(v_side01 == 3)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(159, 12, 36, 36, 100)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }
            }

            txtDisplayFontStyle.TextAlign = HorizontalAlignment.Left;
        }

        // This was the first (now it's invalid)
        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            v_side01 = 3;
            v_side02 = 3;

            alignment_location.X = 159;
            alignment_location.Y = 38;

            p01.Location = alignment_location;

            Controls.Add(p01);

            txtDisplayFontStyle.TextAlign = HorizontalAlignment.Right;

            if (pFocus.Location == p01.Location)
            {
                //Nothing to do!
            }

            else
            {
                if(v_side03 == 1)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(12, 159, 38, 38, 50)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }

                else if(v_side03 == 2)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(86, 159, 36, 36, 100)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }
            }
        }

        private void btnUppercaseAllText_Click(object sender, EventArgs e)
        {
            v_side05 = 1;
            v_side06 = 1;

            case_style_location.X = 232;
            case_style_location.Y = 38;

            p02.Location = case_style_location;

            txtDisplayFontStyle.CharacterCasing = CharacterCasing.Upper;

            if(pCharacterCasing.Location == p02.Location)
            {
                //Nothing to do
            }
            else
            {
                if(v_side04 == 2)
                {
                    new Animator2D
                    (
                        new Path2D(232, 308, 38, 38, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }

                else if (v_side04 == 3)
                {
                    new Animator2D
                    (
                        new Path2D(379, 234, 38, 38, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }
            }
        }

        private void btnLowerCaseAllText_Click(object sender, EventArgs e)
        {
            v_side04 = 2;
            v_side06 = 2;

            case_style_location.X = 308;
            case_style_location.Y = 36;

            p02.Location = case_style_location;

            txtDisplayFontStyle.CharacterCasing = CharacterCasing.Lower;

            if (pCharacterCasing.Location == p02.Location)
            {
                //Nothing to do
            }
            else
            {
                if (v_side05 == 1)
                {
                    new Animator2D
                    (
                        new Path2D(234, 308, 36, 36, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }

                else if (v_side05 == 3)
                {
                    new Animator2D
                    (
                        new Path2D(379, 308, 36, 36, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }
            }
        }

        
        private void txtDisplayFontStyle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplayFontStyle_Leave(object sender, EventArgs e)
        {
            //txtDisplayFontStyle.BorderStyle = BorderStyle.None;
        }

        private void txtDisplayFontStyle_Enter(object sender, EventArgs e)
        {
            //txtDisplayFontStyle.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            c_Performance.ReleaseCapture();
            c_Performance.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void lblCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            c_Performance.ReleaseCapture();
            c_Performance.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            c_Performance.ReleaseCapture();
            c_Performance.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by font name" || txtSearch.Text == "")
                return;

            else
            {
                m_loadSearchData();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search by font name")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search by font name";
                m_loadData();
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void btnTheme_Click_1(object sender, EventArgs e)
        {
            if (v_theme_value == 2)
            {
                v_theme_value = 1;
                c_Global.theme_value = 1;
                m_changeThemeValue();
                m_lightTheme();
                v_theme = false;
            }
            else if (v_theme_value == 1)
            {
                v_theme_value = 2;
                c_Global.theme_value = 2;
                m_changeThemeValue();
                m_darkTheme();
                v_theme = true;
            }
        }

        private void cbSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            v_font_size = int.Parse(cbSize.Text);
            txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size);
            //if (cbSize.Text != "")
            //{
            //    if (Convert.ToInt32(cbSize.Text) < 12 || Convert.ToInt32(cbSize.Text) > 100)
            //    {
            //        MessageBox.Show(" Invalid font size value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, int.Parse(cbSize.Text));
            //    }
            //}
            //else
            //{
            //    //Nothing to do
            //}
        }

        private void cbSize_Leave_1(object sender, EventArgs e)
        {
            if (cbSize.Text != "")
            {
                if (Convert.ToInt32(cbSize.Text) < 12 || Convert.ToInt32(cbSize.Text) > 100)
                {
                    MessageBox.Show(" Invalid font size value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, int.Parse(cbSize.Text));
                }
            }
            else
            {
                //Nothing to do
            }
        }

        private void btnBold_Click_1(object sender, EventArgs e)
        {
            //, System.Drawing.GraphicsUnit.Point, ((byte)(0))
            if (v_bold == true)
            {
                this.txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size, System.Drawing.FontStyle.Bold);
                btnBold.BackColor = Color.FromArgb(225, 225, 225);
                v_bold = false;
            }

            else
            {
                txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size, System.Drawing.FontStyle.Regular);
                btnBold.BackColor = Color.Transparent;
                v_bold = true;
            }
        }

        private void btnCopyFontStyle_Click_1(object sender, EventArgs e)
        {
            //Copying the text to ClipBoard
            Clipboard.SetText(v_font_name);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Form frmBg = new Form();

            using (frmUpdateFont frmAF = new frmUpdateFont())
            {
                frmBg.WindowState = FormWindowState.Maximized;
                frmBg.FormBorderStyle = FormBorderStyle.None;
                frmBg.Opacity = .50d;
                frmBg.BackColor = Color.Black;
                frmBg.StartPosition = FormStartPosition.Manual;
                frmBg.TopMost = true;
                frmBg.Location = Location;
                frmBg.ShowInTaskbar = false;
                frmBg.Show();

                frmAF.Owner = frmBg;
                frmAF.ShowDialog();

                frmBg.Dispose();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do you want to delete this font style?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_deleteData();
                m_verifyDataExistanceFonts();
                if (data_existance == true)
                {
                    m_loadData();
                    v_font_name = Convert.ToString(dgvFontStyles.Rows[0].Cells[0].Value);
                }
                else
                {
                    dgvFontStyles.Enabled = false;
                }
            }
        }

        private void btnAddNewFontStyle_Click_1(object sender, EventArgs e)
        {
            Form frmBg = new Form();

            using (frmAddFont frmAF = new frmAddFont())
            {
                frmBg.WindowState = FormWindowState.Maximized;
                frmBg.FormBorderStyle = FormBorderStyle.None;
                frmBg.Opacity = .50d;
                frmBg.BackColor = Color.Black;
                frmBg.StartPosition = FormStartPosition.Manual;
                frmBg.TopMost = true;
                frmBg.Location = Location;
                frmBg.ShowInTaskbar = false;
                frmBg.Show();

                frmAF.Owner = frmBg;
                frmAF.ShowDialog();

                frmBg.Dispose();
            }
        }

        private void btnAlignLeft_Click_1(object sender, EventArgs e)
        {
            v_side02 = 1;
            v_side03 = 1;

            alignment_location.X = 12;
            alignment_location.Y = 38;

            //case_style_location.X = 86;
            //case_style_location.Y = 36;

            p01.Location = alignment_location;

            Controls.Add(p01);

            if (pFocus.Location == p01.Location)
            {
                //Nothing to do!
            }

            else
            {
                if (v_side01 == 2)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(86, 12, 38, 38, 50)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }

                else if (v_side01 == 3)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(159, 12, 38, 38, 100)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }
            }

            txtDisplayFontStyle.TextAlign = HorizontalAlignment.Left;
        }

        private void btnAlignCenter_Click_1(object sender, EventArgs e)
        {
            v_side01 = 2;
            v_side03 = 2;

            alignment_location.X = 86;
            alignment_location.Y = 38;

            p01.Location = alignment_location;

            Controls.Add(p01);

            if (pFocus.Location == p01.Location)
            {
                //Nothing to do!
            }

            else
            {
                if (v_side02 == 1)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(12, 38, 38, 38, 1)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }

                else if (v_side02 == 3)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(159, 86, 38, 38, 150)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }
            }

            txtDisplayFontStyle.TextAlign = HorizontalAlignment.Center;
        }

        private void btnAlignRight_Click_1(object sender, EventArgs e)
        {
            v_side01 = 3;
            v_side02 = 3;

            alignment_location.X = 159;
            alignment_location.Y = 38;

            p01.Location = alignment_location;

            Controls.Add(p01);

            txtDisplayFontStyle.TextAlign = HorizontalAlignment.Right;

            if (pFocus.Location == p01.Location)
            {
                //Nothing to do!
            }

            else
            {
                if (v_side03 == 1)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(12, 159, 38, 38, 50)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }

                else if (v_side03 == 2)
                {
                    new Animator2D
                    (
                        //start X, end X, start Y, end Y, duration time

                        //pAddNewFontStyle.Location.ToFloat2D(), 250, 100)
                        new Path2D(86, 159, 38, 38, 100)
                        .ContinueTo(p01.Location.ToFloat2D(), 50, 0))
                        .Play(pFocus, Animator2D.KnownProperties.Location
                    );
                }
            }
        }

        private void btnUppercaseAllText_Click_1(object sender, EventArgs e)
        {
            v_side05 = 1;
            v_side06 = 1;

            case_style_location.X = 232;
            case_style_location.Y = 38;

            p02.Location = case_style_location;

            txtDisplayFontStyle.CharacterCasing = CharacterCasing.Upper;

            if (pCharacterCasing.Location == p02.Location)
            {
                //Nothing to do
            }
            else
            {
                if (v_side04 == 2)
                {
                    new Animator2D
                    (
                        new Path2D(308, 232, 38, 38, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }

                else if (v_side04 == 3)
                {
                    new Animator2D
                    (
                        new Path2D(379, 232, 38, 38, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }
            }
        }

        private void btnLowerCaseAllText_Click_1(object sender, EventArgs e)
        {
            v_side04 = 2;
            v_side06 = 2;

            case_style_location.X = 308;
            case_style_location.Y = 38;

            p02.Location = case_style_location;

            txtDisplayFontStyle.CharacterCasing = CharacterCasing.Lower;

            if (pCharacterCasing.Location == p02.Location)
            {
                //Nothing to do
            }
            else
            {
                if (v_side05 == 1)
                {
                    new Animator2D
                    (
                        new Path2D(232, 308, 38, 38, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }

                else if (v_side05 == 3)
                {
                    new Animator2D
                    (
                        new Path2D(379, 308, 38, 38, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }
            }
        }

        private void btnNormalFont_Click_1(object sender, EventArgs e)
        {
            v_side04 = 3;
            v_side05 = 3;

            case_style_location.X = 379;
            case_style_location.Y = 38;

            p02.Location = case_style_location;

            txtDisplayFontStyle.CharacterCasing = CharacterCasing.Normal;

            if (pCharacterCasing.Location == p02.Location)
            {
                //Nothing to do
            }
            else
            {
                if (v_side06 == 1)
                {
                    new Animator2D
                    (
                        new Path2D(232, 379, 38, 38, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }

                else if (v_side06 == 2)
                {
                    new Animator2D
                    (
                        new Path2D(308, 379, 38, 38, 100)
                        .ContinueTo(p02.Location.ToFloat2D(), 50, 0))
                        .Play(pCharacterCasing, Animator2D.KnownProperties.Location
                    );
                }
            }
        }

        private void btnIncreaseFont_Click_1(object sender, EventArgs e)
        {
            if (v_font_size < 100)
            {
                v_font_size += 4;
                txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size);
            }
        }

        private void btnDecreaseFont_Click_1(object sender, EventArgs e)
        {
            if (v_font_size > 12)
            {
                v_font_size -= 4;
                txtDisplayFontStyle.Font = new System.Drawing.Font(v_font_name, v_font_size);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(c_Global.action == true)
            {
                m_loadData();
                c_Global.action = false;
            }
        }
    }
}
 