using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ClientInfo
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }

        // parameterless constructor sets members to default values
        public ClientInfo() : this(string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,0M) { }

        // overloaded constructor sets members to parameter values
        public ClientInfo(string name,string gender,string age,string phonenumber,
            string account,string password,decimal balance)
        {
            Name = name;
            Gender = gender;
            Age = age;
            PhoneNumber = phonenumber;
            Account = account;
            Password = password;
            Balance = balance;
        }
    }
}