namespace TorgovoPosredFirma.View.Forms
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            RegisterTopPanel = new Panel();
            FormNameLabel = new Label();
            RegisterMainLabel = new Label();
            NSTULogo = new PictureBox();
            RegisterBottomPanel = new Panel();
            CapsLabel = new Label();
            LanguageLabel = new Label();
            AuthMainPanel = new Panel();
            CheckPassLabel = new Label();
            CheckPasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            CancelBtn = new Button();
            TopLabel = new Label();
            LoginLabel = new Label();
            LoginTextBox = new TextBox();
            LoginBtn = new Button();
            RegisterTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NSTULogo).BeginInit();
            RegisterBottomPanel.SuspendLayout();
            AuthMainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterTopPanel
            // 
            RegisterTopPanel.BackColor = Color.ForestGreen;
            RegisterTopPanel.Controls.Add(FormNameLabel);
            RegisterTopPanel.Controls.Add(RegisterMainLabel);
            RegisterTopPanel.Controls.Add(NSTULogo);
            RegisterTopPanel.Dock = DockStyle.Top;
            RegisterTopPanel.Location = new Point(0, 0);
            RegisterTopPanel.Name = "RegisterTopPanel";
            RegisterTopPanel.Size = new Size(784, 80);
            RegisterTopPanel.TabIndex = 0;
            // 
            // FormNameLabel
            // 
            FormNameLabel.AutoSize = true;
            FormNameLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormNameLabel.ForeColor = SystemColors.ControlLightLight;
            FormNameLabel.Location = new Point(120, 40);
            FormNameLabel.Name = "FormNameLabel";
            FormNameLabel.Size = new Size(134, 25);
            FormNameLabel.TabIndex = 2;
            FormNameLabel.Text = "Регистрация";
            // 
            // RegisterMainLabel
            // 
            RegisterMainLabel.AutoSize = true;
            RegisterMainLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegisterMainLabel.ForeColor = SystemColors.ControlLightLight;
            RegisterMainLabel.Location = new Point(119, 7);
            RegisterMainLabel.Name = "RegisterMainLabel";
            RegisterMainLabel.Size = new Size(418, 33);
            RegisterMainLabel.TabIndex = 1;
            RegisterMainLabel.Text = "Торгово-посредническая фирма";
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
            // RegisterBottomPanel
            // 
            RegisterBottomPanel.BackColor = Color.ForestGreen;
            RegisterBottomPanel.Controls.Add(CapsLabel);
            RegisterBottomPanel.Controls.Add(LanguageLabel);
            RegisterBottomPanel.Dock = DockStyle.Bottom;
            RegisterBottomPanel.Location = new Point(0, 457);
            RegisterBottomPanel.Name = "RegisterBottomPanel";
            RegisterBottomPanel.Size = new Size(784, 46);
            RegisterBottomPanel.TabIndex = 1;
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
            AuthMainPanel.Controls.Add(CheckPassLabel);
            AuthMainPanel.Controls.Add(CheckPasswordTextBox);
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
            AuthMainPanel.Size = new Size(784, 377);
            AuthMainPanel.TabIndex = 2;
            // 
            // CheckPassLabel
            // 
            CheckPassLabel.Anchor = AnchorStyles.Top;
            CheckPassLabel.AutoSize = true;
            CheckPassLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CheckPassLabel.ForeColor = SystemColors.ControlText;
            CheckPassLabel.Location = new Point(37, 208);
            CheckPassLabel.Name = "CheckPassLabel";
            CheckPassLabel.Size = new Size(278, 33);
            CheckPassLabel.TabIndex = 9;
            CheckPassLabel.Text = "Подтвердите пароль:";
            // 
            // CheckPasswordTextBox
            // 
            CheckPasswordTextBox.Anchor = AnchorStyles.Top;
            CheckPasswordTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CheckPasswordTextBox.Location = new Point(321, 205);
            CheckPasswordTextBox.Name = "CheckPasswordTextBox";
            CheckPasswordTextBox.Size = new Size(379, 40);
            CheckPasswordTextBox.TabIndex = 8;
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
            CancelBtn.Location = new Point(536, 300);
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
            LoginBtn.Location = new Point(125, 300);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(125, 50);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Вход";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 503);
            Controls.Add(AuthMainPanel);
            Controls.Add(RegisterBottomPanel);
            Controls.Add(RegisterTopPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 542);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            FormClosing += RegistrationForm_FormClosing;
            KeyDown += AuthorizationForm_KeyDown;
            RegisterTopPanel.ResumeLayout(false);
            RegisterTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NSTULogo).EndInit();
            RegisterBottomPanel.ResumeLayout(false);
            RegisterBottomPanel.PerformLayout();
            AuthMainPanel.ResumeLayout(false);
            AuthMainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RegisterTopPanel;
        private Label FormNameLabel;
        private Label RegisterMainLabel;
        private PictureBox NSTULogo;
        private Panel RegisterBottomPanel;
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
        private Label CheckPassLabel;
        private TextBox CheckPasswordTextBox;
    }
}