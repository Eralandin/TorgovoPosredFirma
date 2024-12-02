using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorgovoPosredFirma.View.Forms
{
    public partial class MessageForm : Form
    {
        public MessageForm(string message)
        {
            InitializeComponent();
            MainRTB.Text = message;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
