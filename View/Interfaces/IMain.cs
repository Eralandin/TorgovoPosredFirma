﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorgovoPosredFirma.Model.Classes;

namespace TorgovoPosredFirma.View.Interfaces
{
    public interface IMain
    {
        event EventHandler fullGrant;
        event EventHandler userAccessGrant;
        event EventHandler GetConnectionString;
        void Message(string message);
        bool YesNoForm(string message);
        void BuildMenu(List<Module> modules);
        void BuildMenu(List<Module> modules, User user);
        void SendConnectionString(string connectionString);
    }
}
