using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploro_App
{
    public class Constructor
    {
        private string VarEmail;

        public void emailInVar(string email)
        {
            VarEmail = email;
        }

        public string emailDoorgeven()
        {
            return VarEmail;
        }
    }

}

