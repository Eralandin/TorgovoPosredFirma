using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorgovoPosredFirma.View.Interfaces
{
    public interface IRegister
    {
        event EventHandler RegistrationAttempt;
        List<string> GetLoginPassword();
        void Message(string message);
        void CloseForm();
    }
}
