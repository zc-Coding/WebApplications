using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewletterApp.ViewModels
{
    public class SignupVm
    {
        public int ID { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string EmailAddress { get; internal set; }
    }
}