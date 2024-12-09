namespace TorgovoPosredFirma.View.Forms
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainMenu = new MenuStrip();
            MainPanel = new Panel();
            MainDGV = new DataGridView();
            BottomPanel = new Panel();
            SearchBtn = new Button();
            SearchTextBox = new TextBox();
            NSTULogo = new PictureBox();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDGV).BeginInit();
            BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NSTULogo).BeginInit();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.BackColor = Color.ForestGreen;
            MainMenu.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(1099, 24);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "Главное Меню";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(MainDGV);
            MainPanel.Controls.Add(BottomPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 24);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1099, 492);
            MainPanel.TabIndex = 1;
            // 
            // MainDGV
            // 
            MainDGV.AllowUserToAddRows = false;
            MainDGV.AllowUserToDeleteRows = false;
            MainDGV.AllowUserToResizeColumns = false;
            MainDGV.AllowUserToResizeRows = false;
            MainDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MainDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MainDGV.BackgroundColor = SystemColors.GradientInactiveCaption;
            MainDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            MainDGV.DefaultCellStyle = dataGridViewCellStyle1;
            MainDGV.Dock = DockStyle.Fill;
            MainDGV.GridColor = Color.Firebrick;
            MainDGV.Location = new Point(0, 0);
            MainDGV.MultiSelect = false;
            MainDGV.Name = "MainDGV";
            MainDGV.ReadOnly = true;
            MainDGV.Size = new Size(1099, 422);
            MainDGV.TabIndex = 0;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.ForestGreen;
            BottomPanel.Controls.Add(SearchBtn);
            BottomPanel.Controls.Add(SearchTextBox);
            BottomPanel.Controls.Add(NSTULogo);
            BottomPanel.Controls.Add(AddBtn);
            BottomPanel.Controls.Add(UpdateBtn);
            BottomPanel.Controls.Add(DeleteBtn);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 422);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(1099, 70);
            BottomPanel.TabIndex = 1;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchBtn.BackColor = SystemColors.ControlLightLight;
            SearchBtn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBtn.ForeColor = SystemColors.ActiveCaptionText;
            SearchBtn.Location = new Point(118, 3);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(159, 60);
            SearchBtn.TabIndex = 5;
            SearchBtn.Text = "Поиск";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchTextBox.Location = new Point(283, 15);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(315, 40);
            SearchTextBox.TabIndex = 4;
            // 
            // NSTULogo
            // 
            NSTULogo.Image = Resource.Логотип_НГТУ_НЭТИ;
            NSTULogo.Location = new Point(12, 8);
            NSTULogo.Name = "NSTULogo";
            NSTULogo.Size = new Size(100, 50);
            NSTULogo.SizeMode = PictureBoxSizeMode.Zoom;
            NSTULogo.TabIndex = 3;
            NSTULogo.TabStop = false;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.BackColor = SystemColors.ControlLightLight;
            AddBtn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(604, 3);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(159, 60);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateBtn.BackColor = SystemColors.ControlLightLight;
            UpdateBtn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpdateBtn.ForeColor = SystemColors.ActiveCaptionText;
            UpdateBtn.Location = new Point(769, 3);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(159, 60);
            UpdateBtn.TabIndex = 1;
            UpdateBtn.Text = "Изменить";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteBtn.BackColor = SystemColors.ControlLightLight;
            DeleteBtn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(934, 3);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(159, 60);
            DeleteBtn.TabIndex = 0;
            DeleteBtn.Text = "Удалить";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1099, 516);
            Controls.Add(MainPanel);
            Controls.Add(MainMenu);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MainMenu;
            MinimumSize = new Size(1115, 555);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Торгово-Посредническая фирма";
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainDGV).EndInit();
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NSTULogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu;
        private Panel MainPanel;
        private DataGridView MainDGV;
        private Panel BottomPanel;
        private Button DeleteBtn;
        private Button AddBtn;
        private Button UpdateBtn;
        private PictureBox NSTULogo;
        private Button SearchBtn;
        private TextBox SearchTextBox;
    }
}