namespace FontStyleViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvFontStyles = new System.Windows.Forms.DataGridView();
            this.txtDisplayFontStyle = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblCloseForm = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnNormalFont = new System.Windows.Forms.Button();
            this.btnDecreaseFont = new System.Windows.Forms.Button();
            this.btnIncreaseFont = new System.Windows.Forms.Button();
            this.btnLowerCaseAllText = new System.Windows.Forms.Button();
            this.btnUppercaseAllText = new System.Windows.Forms.Button();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.btnAlignLeft = new System.Windows.Forms.Button();
            this.btnAlignCenter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNewFontStyle = new System.Windows.Forms.Button();
            this.btnCopyFontStyle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtFontNameTitle = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.RB.Tools.RBPanel();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.RB.Tools.RBPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPanel1 = new System.RB.Tools.RBPanel();
            this.pFocus = new System.Windows.Forms.Panel();
            this.pCharacterCasing = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFontStyles)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rbPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvFontStyles
            // 
            this.dgvFontStyles.AllowUserToAddRows = false;
            this.dgvFontStyles.AllowUserToDeleteRows = false;
            this.dgvFontStyles.AllowUserToResizeColumns = false;
            this.dgvFontStyles.AllowUserToResizeRows = false;
            this.dgvFontStyles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFontStyles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFontStyles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFontStyles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFontStyles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvFontStyles.ColumnHeadersHeight = 50;
            this.dgvFontStyles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFontStyles.ColumnHeadersVisible = false;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFontStyles.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvFontStyles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFontStyles.EnableHeadersVisualStyles = false;
            this.dgvFontStyles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFontStyles.Location = new System.Drawing.Point(10, 122);
            this.dgvFontStyles.MultiSelect = false;
            this.dgvFontStyles.Name = "dgvFontStyles";
            this.dgvFontStyles.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFontStyles.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvFontStyles.RowHeadersVisible = false;
            this.dgvFontStyles.RowHeadersWidth = 50;
            this.dgvFontStyles.RowTemplate.Height = 50;
            this.dgvFontStyles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFontStyles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFontStyles.Size = new System.Drawing.Size(209, 521);
            this.dgvFontStyles.TabIndex = 0;
            this.dgvFontStyles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFontStyles_CellClick);
            // 
            // txtDisplayFontStyle
            // 
            this.txtDisplayFontStyle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayFontStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayFontStyle.Location = new System.Drawing.Point(257, 165);
            this.txtDisplayFontStyle.Multiline = true;
            this.txtDisplayFontStyle.Name = "txtDisplayFontStyle";
            this.txtDisplayFontStyle.Size = new System.Drawing.Size(1054, 478);
            this.txtDisplayFontStyle.TabIndex = 2;
            this.txtDisplayFontStyle.TextChanged += new System.EventHandler(this.txtDisplayFontStyle_TextChanged);
            this.txtDisplayFontStyle.Enter += new System.EventHandler(this.txtDisplayFontStyle_Enter);
            this.txtDisplayFontStyle.Leave += new System.EventHandler(this.txtDisplayFontStyle_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.Location = new System.Drawing.Point(-33, 106);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1380, 2);
            this.panel7.TabIndex = 7;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Silver;
            this.lblMinimize.Location = new System.Drawing.Point(1273, -3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(28, 25);
            this.lblMinimize.TabIndex = 16;
            this.lblMinimize.Text = "__";
            this.toolTip1.SetToolTip(this.lblMinimize, "Minimize");
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblCloseForm
            // 
            this.lblCloseForm.AutoSize = true;
            this.lblCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseForm.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseForm.ForeColor = System.Drawing.Color.Silver;
            this.lblCloseForm.Location = new System.Drawing.Point(1303, 5);
            this.lblCloseForm.Name = "lblCloseForm";
            this.lblCloseForm.Size = new System.Drawing.Size(24, 25);
            this.lblCloseForm.TabIndex = 15;
            this.lblCloseForm.Text = "X";
            this.toolTip1.SetToolTip(this.lblCloseForm, "Close");
            this.lblCloseForm.Click += new System.EventHandler(this.lblCloseForm_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.AutoSize = true;
            this.btnTheme.BackColor = System.Drawing.Color.Transparent;
            this.btnTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTheme.BackgroundImage")));
            this.btnTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Location = new System.Drawing.Point(1297, 52);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(34, 32);
            this.btnTheme.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnTheme, "Theme");
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1238, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnSearch, "Search font style");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            // 
            // btnBold
            // 
            this.btnBold.AutoSize = true;
            this.btnBold.BackColor = System.Drawing.Color.Transparent;
            this.btnBold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBold.BackgroundImage")));
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBold.FlatAppearance.BorderSize = 0;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Location = new System.Drawing.Point(635, 8);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(30, 30);
            this.btnBold.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnBold, "Bold font style");
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click_1);
            // 
            // btnNormalFont
            // 
            this.btnNormalFont.BackColor = System.Drawing.Color.Transparent;
            this.btnNormalFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNormalFont.BackgroundImage")));
            this.btnNormalFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormalFont.FlatAppearance.BorderSize = 0;
            this.btnNormalFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormalFont.Location = new System.Drawing.Point(382, 5);
            this.btnNormalFont.Name = "btnNormalFont";
            this.btnNormalFont.Size = new System.Drawing.Size(30, 30);
            this.btnNormalFont.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnNormalFont, "Normal text");
            this.btnNormalFont.UseVisualStyleBackColor = false;
            this.btnNormalFont.Click += new System.EventHandler(this.btnNormalFont_Click_1);
            // 
            // btnDecreaseFont
            // 
            this.btnDecreaseFont.BackColor = System.Drawing.Color.Transparent;
            this.btnDecreaseFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseFont.BackgroundImage")));
            this.btnDecreaseFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecreaseFont.FlatAppearance.BorderSize = 0;
            this.btnDecreaseFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseFont.Location = new System.Drawing.Point(520, 7);
            this.btnDecreaseFont.Name = "btnDecreaseFont";
            this.btnDecreaseFont.Size = new System.Drawing.Size(30, 30);
            this.btnDecreaseFont.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnDecreaseFont, "Decrease font style");
            this.btnDecreaseFont.UseVisualStyleBackColor = false;
            this.btnDecreaseFont.Click += new System.EventHandler(this.btnDecreaseFont_Click_1);
            // 
            // btnIncreaseFont
            // 
            this.btnIncreaseFont.BackColor = System.Drawing.Color.Transparent;
            this.btnIncreaseFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncreaseFont.BackgroundImage")));
            this.btnIncreaseFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncreaseFont.FlatAppearance.BorderSize = 0;
            this.btnIncreaseFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseFont.Location = new System.Drawing.Point(455, 7);
            this.btnIncreaseFont.Name = "btnIncreaseFont";
            this.btnIncreaseFont.Size = new System.Drawing.Size(30, 30);
            this.btnIncreaseFont.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnIncreaseFont, "Increase font style");
            this.btnIncreaseFont.UseVisualStyleBackColor = false;
            this.btnIncreaseFont.Click += new System.EventHandler(this.btnIncreaseFont_Click_1);
            // 
            // btnLowerCaseAllText
            // 
            this.btnLowerCaseAllText.BackColor = System.Drawing.Color.Transparent;
            this.btnLowerCaseAllText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLowerCaseAllText.BackgroundImage")));
            this.btnLowerCaseAllText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLowerCaseAllText.FlatAppearance.BorderSize = 0;
            this.btnLowerCaseAllText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowerCaseAllText.Location = new System.Drawing.Point(311, 6);
            this.btnLowerCaseAllText.Name = "btnLowerCaseAllText";
            this.btnLowerCaseAllText.Size = new System.Drawing.Size(30, 30);
            this.btnLowerCaseAllText.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnLowerCaseAllText, "Lower case all text");
            this.btnLowerCaseAllText.UseVisualStyleBackColor = false;
            this.btnLowerCaseAllText.Click += new System.EventHandler(this.btnLowerCaseAllText_Click_1);
            // 
            // btnUppercaseAllText
            // 
            this.btnUppercaseAllText.BackColor = System.Drawing.Color.Transparent;
            this.btnUppercaseAllText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUppercaseAllText.BackgroundImage")));
            this.btnUppercaseAllText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUppercaseAllText.FlatAppearance.BorderSize = 0;
            this.btnUppercaseAllText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUppercaseAllText.Location = new System.Drawing.Point(235, 6);
            this.btnUppercaseAllText.Name = "btnUppercaseAllText";
            this.btnUppercaseAllText.Size = new System.Drawing.Size(30, 30);
            this.btnUppercaseAllText.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnUppercaseAllText, "Uppercase all text");
            this.btnUppercaseAllText.UseVisualStyleBackColor = false;
            this.btnUppercaseAllText.Click += new System.EventHandler(this.btnUppercaseAllText_Click_1);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.BackColor = System.Drawing.Color.Transparent;
            this.btnAlignRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlignRight.BackgroundImage")));
            this.btnAlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlignRight.FlatAppearance.BorderSize = 0;
            this.btnAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignRight.Location = new System.Drawing.Point(163, 6);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(30, 30);
            this.btnAlignRight.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnAlignRight, "Align right");
            this.btnAlignRight.UseVisualStyleBackColor = false;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click_1);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnAlignLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlignLeft.BackgroundImage")));
            this.btnAlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlignLeft.FlatAppearance.BorderSize = 0;
            this.btnAlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignLeft.Location = new System.Drawing.Point(15, 6);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(30, 30);
            this.btnAlignLeft.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnAlignLeft, "Align left");
            this.btnAlignLeft.UseVisualStyleBackColor = false;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click_1);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.BackColor = System.Drawing.Color.Transparent;
            this.btnAlignCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlignCenter.BackgroundImage")));
            this.btnAlignCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlignCenter.FlatAppearance.BorderSize = 0;
            this.btnAlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignCenter.Location = new System.Drawing.Point(89, 6);
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(30, 30);
            this.btnAlignCenter.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnAlignCenter, "Align center");
            this.btnAlignCenter.UseVisualStyleBackColor = false;
            this.btnAlignCenter.Click += new System.EventHandler(this.btnAlignCenter_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(117, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete font style");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAddNewFontStyle
            // 
            this.btnAddNewFontStyle.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewFontStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewFontStyle.BackgroundImage")));
            this.btnAddNewFontStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewFontStyle.FlatAppearance.BorderSize = 0;
            this.btnAddNewFontStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewFontStyle.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewFontStyle.Location = new System.Drawing.Point(13, 7);
            this.btnAddNewFontStyle.Name = "btnAddNewFontStyle";
            this.btnAddNewFontStyle.Size = new System.Drawing.Size(30, 30);
            this.btnAddNewFontStyle.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnAddNewFontStyle, "Add new font style");
            this.btnAddNewFontStyle.UseVisualStyleBackColor = false;
            this.btnAddNewFontStyle.Click += new System.EventHandler(this.btnAddNewFontStyle_Click_1);
            // 
            // btnCopyFontStyle
            // 
            this.btnCopyFontStyle.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyFontStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyFontStyle.BackgroundImage")));
            this.btnCopyFontStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyFontStyle.Enabled = false;
            this.btnCopyFontStyle.FlatAppearance.BorderSize = 0;
            this.btnCopyFontStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyFontStyle.ForeColor = System.Drawing.Color.Black;
            this.btnCopyFontStyle.Location = new System.Drawing.Point(169, 7);
            this.btnCopyFontStyle.Name = "btnCopyFontStyle";
            this.btnCopyFontStyle.Size = new System.Drawing.Size(30, 30);
            this.btnCopyFontStyle.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnCopyFontStyle, "Copy font style name");
            this.btnCopyFontStyle.UseVisualStyleBackColor = false;
            this.btnCopyFontStyle.Click += new System.EventHandler(this.btnCopyFontStyle_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(65, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(30, 30);
            this.btnUpdate.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnUpdate, "Update font style");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtFontNameTitle
            // 
            this.txtFontNameTitle.BackColor = System.Drawing.Color.White;
            this.txtFontNameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFontNameTitle.Enabled = false;
            this.txtFontNameTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontNameTitle.Location = new System.Drawing.Point(257, 122);
            this.txtFontNameTitle.Name = "txtFontNameTitle";
            this.txtFontNameTitle.ReadOnly = true;
            this.txtFontNameTitle.Size = new System.Drawing.Size(321, 15);
            this.txtFontNameTitle.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(15, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 20);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.Text = "Search by font name";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderRadius = 20;
            this.panel4.Controls.Add(this.pCharacterCasing);
            this.panel4.Controls.Add(this.pFocus);
            this.panel4.Controls.Add(this.cbSize);
            this.panel4.Controls.Add(this.btnBold);
            this.panel4.Controls.Add(this.btnNormalFont);
            this.panel4.Controls.Add(this.btnDecreaseFont);
            this.panel4.Controls.Add(this.btnIncreaseFont);
            this.panel4.Controls.Add(this.btnLowerCaseAllText);
            this.panel4.Controls.Add(this.btnUppercaseAllText);
            this.panel4.Controls.Add(this.btnAlignRight);
            this.panel4.Controls.Add(this.btnAlignLeft);
            this.panel4.Controls.Add(this.btnAlignCenter);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.GradientAngle = 30F;
            this.panel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.Location = new System.Drawing.Point(257, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 55);
            this.panel4.TabIndex = 26;
            // 
            // cbSize
            // 
            this.cbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "12",
            "16",
            "20",
            "24",
            "28",
            "30",
            "32",
            "34",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbSize.Location = new System.Drawing.Point(562, 9);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(63, 29);
            this.cbSize.TabIndex = 20;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged_1);
            this.cbSize.Leave += new System.EventHandler(this.cbSize_Leave_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderRadius = 20;
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnAddNewFontStyle);
            this.panel5.Controls.Add(this.btnCopyFontStyle);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.GradientAngle = 30F;
            this.panel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel5.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel5.Location = new System.Drawing.Point(9, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 55);
            this.panel5.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.lblCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 39);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // rbPanel1
            // 
            this.rbPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbPanel1.BorderRadius = 20;
            this.rbPanel1.Controls.Add(this.txtSearch);
            this.rbPanel1.ForeColor = System.Drawing.Color.Black;
            this.rbPanel1.GradientAngle = 90F;
            this.rbPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbPanel1.Location = new System.Drawing.Point(979, 53);
            this.rbPanel1.Name = "rbPanel1";
            this.rbPanel1.Size = new System.Drawing.Size(253, 33);
            this.rbPanel1.TabIndex = 32;
            // 
            // pFocus
            // 
            this.pFocus.BackColor = System.Drawing.Color.SkyBlue;
            this.pFocus.Location = new System.Drawing.Point(12, 38);
            this.pFocus.Name = "pFocus";
            this.pFocus.Size = new System.Drawing.Size(37, 5);
            this.pFocus.TabIndex = 36;
            // 
            // pCharacterCasing
            // 
            this.pCharacterCasing.BackColor = System.Drawing.Color.SkyBlue;
            this.pCharacterCasing.Location = new System.Drawing.Point(375, 38);
            this.pCharacterCasing.Name = "pCharacterCasing";
            this.pCharacterCasing.Size = new System.Drawing.Size(37, 5);
            this.pCharacterCasing.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Font Style Viewer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 655);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtFontNameTitle);
            this.Controls.Add(this.txtDisplayFontStyle);
            this.Controls.Add(this.dgvFontStyles);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Style Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFontStyles)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rbPanel1.ResumeLayout(false);
            this.rbPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvFontStyles;
        private System.Windows.Forms.TextBox txtDisplayFontStyle;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtFontNameTitle;
        private System.Windows.Forms.Label lblCloseForm;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnSearch;
        private System.RB.Tools.RBPanel panel4;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnNormalFont;
        private System.Windows.Forms.Button btnDecreaseFont;
        private System.Windows.Forms.Button btnIncreaseFont;
        private System.Windows.Forms.Button btnLowerCaseAllText;
        private System.Windows.Forms.Button btnUppercaseAllText;
        private System.Windows.Forms.Button btnAlignRight;
        private System.Windows.Forms.Button btnAlignLeft;
        private System.Windows.Forms.Button btnAlignCenter;
        private System.RB.Tools.RBPanel panel5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNewFontStyle;
        private System.Windows.Forms.Button btnCopyFontStyle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.RB.Tools.RBPanel rbPanel1;
        private System.Windows.Forms.Panel pCharacterCasing;
        private System.Windows.Forms.Panel pFocus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

