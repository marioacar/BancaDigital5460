using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BancaDigital5460.Model5460
{
    public class RegisterModel5460
    {

        public string id { get; set; }
        public string Name { get; set; }
        public string FLastName { get; set; }
        public string MLastName { get; set; }
        public ObservableCollection<RegisterPhone> RegisterPhoneNumber { get; set; }
    }

    public class RegisterPhone
    {
        public string id { get; set; }
        public string Number { get; set; }
    }
}
