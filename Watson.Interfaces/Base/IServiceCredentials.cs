using System;
using System.Collections.Generic;
using System.Text;

namespace Watson.Interfaces
{
    public interface IServiceCredentials
    {
        string username { get; set; }
        string password { get; set; }
        string version { get; set; }

    }
}
