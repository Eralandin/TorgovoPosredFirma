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
            MainPanel.SuspendLayout();
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
            MainPanel.Controls.Add(MainDGV);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 24);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 426);
            MainPanel.TabIndex = 1;
            // 
            // MainDGV
            // 
            MainDGV.AllowUserToAddRows = false;
            MainDGV.AllowUserToDeleteRows = false;
            MainDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            ((System.ComponentModel.ISupportInitialize)MainDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu;
        private Panel MainPanel;
        private DataGridView MainDGV;
    }
}