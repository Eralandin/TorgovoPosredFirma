namespace TorgovoPosredFirma.View.Forms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            AuthTopPanel = new Panel();
            VersionLabel = new Label();
            FormNameLabel = new Label();
            AuthMainLabel = new Label();
            NSTULogo = new PictureBox();
            AuthBottomPanel = new Panel();
            CapsLabel = new Label();
            LanguageLabel = new Label();
            AuthMainPanel = new Panel();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            CancelBtn = new Button();
            TopLabel = new Label();
            LoginLabel = new Label();
            LoginTextBox = new TextBox();
            LoginBtn = new Button();
            AuthTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NSTULogo).BeginInit();
            AuthBottomPanel.SuspendLayout();
            AuthMainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AuthTopPanel
            // 
            AuthTopPanel.BackColor = Color.ForestGreen;
            AuthTopPanel.Controls.Add(VersionLabel);
            AuthTopPanel.Controls.Add(FormNameLabel);
            AuthTopPanel.Controls.Add(AuthMainLabel);
            AuthTopPanel.Controls.Add(NSTULogo);
            AuthTopPanel.Dock = DockStyle.Top;
            AuthTopPanel.Location = new Point(0, 0);
            AuthTopPanel.Name = "AuthTopPanel";
            AuthTopPanel.Size = new Size(784, 80);
            AuthTopPanel.TabIndex = 0;
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            VersionLabel.ForeColor = SystemColors.ControlLightLight;
            VersionLabel.Location = new Point(686, 40);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(86, 25);
            VersionLabel.TabIndex = 3;
            VersionLabel.Text = "Версия:";
            // 
            // FormNameLabel
            // 
            FormNameLabel.AutoSize = true;
            FormNameLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormNameLabel.ForeColor = SystemColors.ControlLightLight;
            FormNameLabel.Location = new Point(120, 40);
            FormNameLabel.Name = "FormNameLabel";
            FormNameLabel.Size = new Size(137, 25);
            FormNameLabel.TabIndex = 2;
            FormNameLabel.Text = "Авторизация";
            // 
            // AuthMainLabel
            // 
            AuthMainLabel.AutoSize = true;
            AuthMainLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AuthMainLabel.ForeColor = SystemColors.ControlLightLight;
            AuthMainLabel.Location = new Point(119, 7);
            AuthMainLabel.Name = "AuthMainLabel";
            AuthMainLabel.Size = new Size(418, 33);
            AuthMainLabel.TabIndex = 1;
            AuthMainLabel.Text = "Торгово-посредническая фирма";
            // 
            // NSTULogo
            // 
            NSTULogo.Image = Resource.Логотип_НГТУ_НЭТИ;
            NSTULogo.Location = new Point(12, 15);
            NSTULogo.Name = "NSTULogo";
            NSTULogo.Size = new Size(100, 50);
            NSTULogo.SizeMode = PictureBoxSizeMode.Zoom;
            NSTULogo.TabIndex = 0;
            NSTULogo.TabStop = false;
            // 
            // AuthBottomPanel
            // 
            AuthBottomPanel.BackColor = Color.ForestGreen;
            AuthBottomPanel.Controls.Add(CapsLabel);
            AuthBottomPanel.Controls.Add(LanguageLabel);
            AuthBottomPanel.Dock = DockStyle.Bottom;
            AuthBottomPanel.Location = new Point(0, 404);
            AuthBottomPanel.Name = "AuthBottomPanel";
            AuthBottomPanel.Size = new Size(784, 46);
            AuthBottomPanel.TabIndex = 1;
            // 
            // CapsLabel
            // 
            CapsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CapsLabel.AutoSize = true;
            CapsLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CapsLabel.ForeColor = SystemColors.ControlLightLight;
            CapsLabel.Location = new Point(573, 12);
            CapsLabel.Name = "CapsLabel";
            CapsLabel.Size = new Size(199, 25);
            CapsLabel.TabIndex = 5;
            CapsLabel.Text = "Клавиша CapsLock:";
            // 
            // LanguageLabel
            // 
            LanguageLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LanguageLabel.AutoSize = true;
            LanguageLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LanguageLabel.ForeColor = SystemColors.ControlLightLight;
            LanguageLabel.Location = new Point(12, 12);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(128, 25);
            LanguageLabel.TabIndex = 4;
            LanguageLabel.Text = "Язык ввода:";
            // 
            // AuthMainPanel
            // 
            AuthMainPanel.Controls.Add(PasswordLabel);
            AuthMainPanel.Controls.Add(PasswordTextBox);
            AuthMainPanel.Controls.Add(CancelBtn);
            AuthMainPanel.Controls.Add(TopLabel);
            AuthMainPanel.Controls.Add(LoginLabel);
            AuthMainPanel.Controls.Add(LoginTextBox);
            AuthMainPanel.Controls.Add(LoginBtn);
            AuthMainPanel.Dock = DockStyle.Fill;
            AuthMainPanel.Location = new Point(0, 80);
            AuthMainPanel.Name = "AuthMainPanel";
            AuthMainPanel.Size = new Size(784, 324);
            AuthMainPanel.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Top;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordLabel.ForeColor = SystemColors.ControlText;
            PasswordLabel.Location = new Point(205, 146);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(110, 33);
            PasswordLabel.TabIndex = 7;
            PasswordLabel.Text = "Пароль:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top;
            PasswordTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(321, 143);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(379, 40);
            PasswordTextBox.TabIndex = 6;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Top;
            CancelBtn.BackColor = Color.ForestGreen;
            CancelBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ControlLightLight;
            CancelBtn.Location = new Point(536, 200);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(125, 50);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // TopLabel
            // 
            TopLabel.Anchor = AnchorStyles.Top;
            TopLabel.AutoSize = true;
            TopLabel.BackColor = Color.ForestGreen;
            TopLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TopLabel.ForeColor = SystemColors.ControlLightLight;
            TopLabel.Location = new Point(158, 17);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(467, 33);
            TopLabel.TabIndex = 4;
            TopLabel.Text = "Введите имя пользователя и пароль";
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.Top;
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginLabel.ForeColor = SystemColors.ControlText;
            LoginLabel.Location = new Point(65, 84);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(250, 33);
            LoginLabel.TabIndex = 4;
            LoginLabel.Text = "Имя пользователя:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top;
            LoginTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTextBox.Location = new Point(321, 81);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(379, 40);
            LoginTextBox.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top;
            LoginBtn.BackColor = Color.ForestGreen;
            LoginBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginBtn.ForeColor = SystemColors.ControlLightLight;
            LoginBtn.Location = new Point(125, 200);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(125, 50);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Вход";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(AuthMainPanel);
            Controls.Add(AuthBottomPanel);
            Controls.Add(AuthTopPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 489);
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            KeyDown += AuthorizationForm_KeyDown;
            AuthTopPanel.ResumeLayout(false);
            AuthTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NSTULogo).EndInit();
            AuthBottomPanel.ResumeLayout(false);
            AuthBottomPanel.PerformLayout();
            AuthMainPanel.ResumeLayout(false);
            AuthMainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AuthTopPanel;
        private Label FormNameLabel;
        private Label AuthMainLabel;
        private PictureBox NSTULogo;
        private Label VersionLabel;
        private Panel AuthBottomPanel;
        private Label CapsLabel;
        private Label LanguageLabel;
        private Panel AuthMainPanel;
        private Label LoginLabel;
        private TextBox LoginTextBox;
        private Button LoginBtn;
        private Label TopLabel;
        private Button CancelBtn;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
    }
}