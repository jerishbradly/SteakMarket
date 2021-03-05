using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SteakMarket.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }

        public string FullName { get; set; }

        public string SIN { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string MailingAddress { get; set; }

        public int StatusId { get; set; }

        public Status Status { get; set; }

        public DateTime BirthDate { get; set; }

        public int PersonalAccountId { get; set; }
    }
}
