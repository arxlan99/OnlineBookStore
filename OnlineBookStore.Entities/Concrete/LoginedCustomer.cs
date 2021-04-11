using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Entities.Concrete
{
    public class LoginedCustomer : Customer
    {
        private static LoginedCustomer _loginedCustomer;

        private LoginedCustomer()
        {

        }

        public static LoginedCustomer GetLoginedCustomer
        {
            get
            {
                if (_loginedCustomer == null)
                    _loginedCustomer = new LoginedCustomer();
                return _loginedCustomer;
            }
        }
    }
}
