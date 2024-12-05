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
    public partial class RegistrationForm : Form, IRegister
    {
        private readonly RegistrationPresenter _presenter;
        public RegistrationForm()
        {
            InitializeComponent();
            _presenter = new RegistrationPresenter(this);

            this.KeyPreview = true;

            CapsLabel.Text = "Клавиша CapsLock: " + (Console.CapsLock ? "Включена" : "Выключена");

            int x1 = RegisterBottomPanel.Width - CapsLabel.Width - 5;
            int y1 = RegisterBottomPanel.Height - CapsLabel.Height - 10;

            CapsLabel.Location = new System.Drawing.Point(x1, y1);

            var currentInputLanguage = InputLanguage.CurrentInputLanguage.Culture.NativeName;

            LanguageLabel.Text = "Язык ввода: " + currentInputLanguage;

            InputLanguageChanged += AuthForm_InputLanguageChanged;
        }

        public event EventHandler RegistrationAttempt;

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
            RegistrationAttempt?.Invoke(this, EventArgs.Empty);
        }
        public List<string> GetLoginPassword()
        {
            List<string> result = new List<string>
            {
                LoginTextBox.Text,
                PasswordTextBox.Text,
                CheckPasswordTextBox.Text
            };
            return result;
        }
        public void Message(string message)
        {
            MessageForm messageForm = new MessageForm(message);
            messageForm.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CloseForm()
        {
            this.FormClosing -= RegistrationForm_FormClosing;
            this.Dispose();
        }
        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            YesNoForm yesNoForm = new YesNoForm("Вы уверены, что хотите прервать регистрацию?");
            if (yesNoForm.ShowDialog() == DialogResult.OK)
            {
                e.Cancel = false;
                Message("Регистрация прекращена пользователем");
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
