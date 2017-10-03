using System;
using System.Collections.Generic;
using System.Text;


namespace SoundV.Models
{
    class Call
    {
        string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetProperty(ref phoneNumber, value); }
        }
    }
}
