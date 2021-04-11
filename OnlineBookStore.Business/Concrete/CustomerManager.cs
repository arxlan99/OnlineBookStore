using OnlineBookStore.Business.Abstract;
using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            try
            {
                if (ControlExistCustomer(customer))
                    throw new System.Exception("Bu email zaten kayıtlı");

                _customerDal.Add(customer);
            }
            catch (System.Exception)
            { }
        }

        public void ChangePassword(Customer customer, string newPassword)
        {
            var _customer = Get(customer.Email, customer.Password);

            if (_customer == null)
                throw new System.Exception("Eski şifreniz doğru değil");

            customer.Password = newPassword;
            Update(customer);
        }

        public Customer Get(string email, string password)
        {
            return _customerDal.Get(p => p.Email == email && p.Password == password);
        }

        public Customer GetById(int customerId)
        {
            return _customerDal.Get(p => p.Id == customerId);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }

        private bool ControlExistCustomer(Customer customer)
        {
            if (_customerDal.Get(x => x.Email == customer.Email) == null) return false;
            else return true;
        }
    }
}
