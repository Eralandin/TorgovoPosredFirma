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
            BottomPanel = new Panel();
            NSTULogo = new PictureBox();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            MainDGV = new DataGridView();
            MainPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NSTULogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainDGV).BeginInit();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.BackColor = Color.ForestGreen;
            MainMenu.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(800, 24);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "Главное Меню";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(BottomPanel);
            MainPanel.Controls.Add(MainDGV);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 24);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 426);
            MainPanel.TabIndex = 1;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.ForestGreen;
            BottomPanel.Controls.Add(NSTULogo);
            BottomPanel.Controls.Add(AddBtn);
            BottomPanel.Controls.Add(UpdateBtn);
            BottomPanel.Controls.Add(DeleteBtn);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 371);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(800, 55);
            BottomPanel.TabIndex = 1;
            // 
            // NSTULogo
            // 
            NSTULogo.Image = Resource.Логотип_НГТУ_НЭТИ;
            NSTULogo.Location = new Point(5, 3);
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
            AddBtn.Location = new Point(437, 8);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(115, 40);
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
            UpdateBtn.Location = new Point(558, 8);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 40);
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
            DeleteBtn.Location = new Point(679, 8);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(115, 40);
            DeleteBtn.TabIndex = 0;
            DeleteBtn.Text = "Удалить";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
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
            MainDGV.Size = new Size(800, 426);
            MainDGV.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            Controls.Add(MainMenu);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MainMenu;
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Торгово-Посредническая фирма";
            FormClosing += MainForm_FormClosing;
            MainPanel.ResumeLayout(false);
            BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NSTULogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainDGV).EndInit();
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
    }
}