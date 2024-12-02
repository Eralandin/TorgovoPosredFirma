using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorgovoPosredFirma.View.Interfaces
{
    public interface IAuth
    {
        event EventHandler LoginAttempt;
        List<string> GetLoginPassword();
        void Message(string message);
    }
}
