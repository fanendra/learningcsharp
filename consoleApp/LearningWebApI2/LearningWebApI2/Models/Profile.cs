using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningWebApI2.Models
{
    public enum Sex
    {
        Male=0,
        Female =1
    }

    public class Profile
    {
        public int ProfileID { get; set; }

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public Sex  Gender { get; set; }

        public string EmailId { get; set; }

        public string PhoneNumber { get; set; }

        public Profile()
        {
            ProfileID = -1 ;
            FirstName = string.Empty;
            LastName = string.Empty;
            EmailId = string.Empty;
            PhoneNumber = string.Empty;
        }

    }
}