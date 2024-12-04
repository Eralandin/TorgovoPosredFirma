namespace TorgovoPosredFirma.View.Forms
{
    partial class YesNoForm
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
            TopPanel = new Panel();
            MainLabel = new Label();
            BottomPanel = new Panel();
            OkBtn = new Button();
            CancelBtn = new Button();
            MainPanel = new Panel();
            MainRTB = new RichTextBox();
            TopPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.ForestGreen;
            TopPanel.Controls.Add(MainLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(454, 50);
            TopPanel.TabIndex = 1;
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainLabel.ForeColor = SystemColors.ControlLightLight;
            MainLabel.Location = new Point(12, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(158, 33);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "Сообщение";
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(OkBtn);
            BottomPanel.Controls.Add(CancelBtn);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 256);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(454, 55);
            BottomPanel.TabIndex = 2;
            // 
            // OkBtn
            // 
            OkBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkBtn.BackColor = Color.ForestGreen;
            OkBtn.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OkBtn.ForeColor = SystemColors.ControlLightLight;
            OkBtn.Location = new Point(12, 7);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(125, 40);
            OkBtn.TabIndex = 8;
            OkBtn.Text = "ОК";
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = Color.ForestGreen;
            CancelBtn.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ControlLightLight;
            CancelBtn.Location = new Point(317, 7);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(125, 40);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(MainRTB);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 50);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(454, 206);
            MainPanel.TabIndex = 3;
            // 
            // MainRTB
            // 
            MainRTB.Dock = DockStyle.Fill;
            MainRTB.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainRTB.Location = new Point(0, 0);
            MainRTB.Name = "MainRTB";
            MainRTB.ReadOnly = true;
            MainRTB.Size = new Size(454, 206);
            MainRTB.TabIndex = 3;
            MainRTB.Text = "";
            // 
            // YesNoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 311);
            Controls.Add(MainPanel);
            Controls.Add(BottomPanel);
            Controls.Add(TopPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "YesNoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Подтверждение";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label MainLabel;
        private Panel BottomPanel;
        private Button OkBtn;
        private Button CancelBtn;
        private Panel MainPanel;
        private RichTextBox MainRTB;
    }
}