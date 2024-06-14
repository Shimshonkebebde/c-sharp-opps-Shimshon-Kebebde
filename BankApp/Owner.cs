using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c_sharp_opps_Shimshon_Kebebde.BankApp
{
    public class Owner
    {
        string firstName;
        string lastName;

        public Owner(string fn, string ln)
        {
            this.firstName = fn;
            this.lastName = ln;
        }

        public string GetFn()
        {
            return firstName;
        }

        public void Setfn(string firstName)
        {
           this.firstName = firstName;
        }

        public string GetLn()
        {
            return lastName;
        }

        public void SetLn(string lastName)
        {
            this.lastName = lastName;
        }
       
    }
}
