using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorgovoPosredFirma.Model.Classes;

namespace TorgovoPosredFirma.View.Interfaces
{
    public interface IAuth
    {
        event EventHandler LoginAttempt;
        List<string> GetLoginPassword();
        void Message(string message);
        bool YesNoForm(string message);
        void Registration();
        void Authorize(User user);
    }
}
