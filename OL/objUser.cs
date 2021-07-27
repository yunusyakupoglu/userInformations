using System;
using System.Collections.Generic;

namespace OL
{
    public class objUser
    {
        public int userID { get; set; }
        public string name { get; set; }
        public string Surname { get; set; }
        public int gender { get; set; }
        public List<objMail> mails { get; set; }
        public List<objPhone> phones { get; set; }
    }
}
