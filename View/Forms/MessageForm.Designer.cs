namespace TorgovoPosredFirma.View.Forms
{
    partial class MessageForm
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
            CancelBtn = new Button();
            MainRTB = new RichTextBox();
            TopPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
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
            TopPanel.TabIndex = 0;
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
            BottomPanel.Controls.Add(CancelBtn);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 256);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(454, 55);
            BottomPanel.TabIndex = 1;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = Color.ForestGreen;
            CancelBtn.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ControlLightLight;
            CancelBtn.Location = new Point(321, 7);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(125, 40);
            CancelBtn.TabIndex = 6;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // MainRTB
            // 
            MainRTB.Dock = DockStyle.Fill;
            MainRTB.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainRTB.Location = new Point(0, 50);
            MainRTB.Name = "MainRTB";
            MainRTB.Size = new Size(454, 206);
            MainRTB.TabIndex = 2;
            MainRTB.Text = "";
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 311);
            Controls.Add(MainRTB);
            Controls.Add(BottomPanel);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сообщение";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label MainLabel;
        private Panel BottomPanel;
        private Button CancelBtn;
        private RichTextBox MainRTB;
    }
}