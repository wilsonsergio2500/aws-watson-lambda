using System;
using System.Collections.Generic;
using System.Text;
using Watson.Interfaces;

namespace Watson.Models
{
    public abstract class ServiceCredentials : IServiceCredentials
    {
        public string username { get; set; }
        public string password { get; set; }
        public string version { get; set; }
    }
}
