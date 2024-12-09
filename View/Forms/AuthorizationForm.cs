using SharedModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorgovoPosredFirma.Logic.Presenters;
using TorgovoPosredFirma.View.Interfaces;

namespace TorgovoPosredFirma.View.Forms
{
    public partial class AuthorizationForm : Form, IAuth
    {
        private readonly AuthorizationPresenter _presenter;
        public AuthorizationForm()
        {
            InitializeComponent();
            _presenter = new AuthorizationPresenter(this);

            this.KeyPreview = true;
            VersionLabel.AutoSize = true;
            VersionLabel.Text = "Версия: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            int x = AuthTopPanel.Width - VersionLabel.Width - 3;
            int y = AuthTopPanel.Height - VersionLabel.Height - 10;

            VersionLabel.Location = new System.Drawing.Point(x, y);

            CapsLabel.Text = "Клавиша CapsLock: " + (Console.CapsLock ? "Включена" : "Выключена");

            int x1 = AuthBottomPanel.Width - CapsLabel.Width - 5;
            int y1 = AuthBottomPanel.Height - CapsLabel.Height - 10;

            CapsLabel.Location = new System.Drawing.Point(x1, y1);

            var currentInputLanguage = InputLanguage.CurrentInputLanguage.Culture.NativeName;

            LanguageLabel.Text = "Язык ввода: " + currentInputLanguage;

            InputLanguageChanged += AuthForm_InputLanguageChanged;
        }
        
        public event EventHandler LoginAttempt;

        private void AuthForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            var currentInputLanguage = InputLanguage.CurrentInputLanguage.Culture.NativeName;
            LanguageLabel.Text = "Язык ввода: " + currentInputLanguage;
        }

        private void AuthorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                CapsLabel.Text = "Клавиша CapsLock: " + (Console.CapsLock ? "Включена" : "Выключена");
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginAttempt?.Invoke(this, EventArgs.Empty);
        }
        public List<string> GetLoginPassword()
        {
            List<string> result = new List<string>
            {
                LoginTextBox.Text,
                PasswordTextBox.Text
            };
            return result;
        }
        public void Message(string message)
        {
            MessageForm messageForm = new MessageForm(message);
            messageForm.ShowDialog();
        }
        public bool YesNoForm(string message)
        {
            YesNoForm yesNoForm = new YesNoForm(message);
            if (yesNoForm.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Authorize(User user)
        {
            MainForm mainForm = new MainForm(user);
            this.Visible = false;
            mainForm.ShowDialog();
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
            this.Visible = true;
        }
        public void Registration()
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            YesNoForm yesNoForm = new YesNoForm("Вы уверены, что хотите закрыть программу?");
            if (yesNoForm.ShowDialog() == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
