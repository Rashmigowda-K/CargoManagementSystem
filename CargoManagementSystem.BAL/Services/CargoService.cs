using System;
using System.Collections.Generic;
using System.Text;
using CargoManagementSystem.DAL.Repository;
using CargoManagementSystem.Entity.Models;

namespace CargoManagementSystem.BAL.Services
{
    public class CargoService
    {
        ICustRepo _custrepo;
        public CargoService(ICustRepo custrepo)
        {
            _custrepo = custrepo;
        }

        public void Addcustdetails(CustomerDetails custdetails)
        {
            _custrepo.AddCustomerDetails(custdetails);

        }
        public void Updatecustdetails(CustomerDetails custdetails)
        {
            _custrepo.UpdateCustomerDetails(custdetails);
        }
        public void Deletecustdetails(int custId)
        {
            _custrepo.DeleteCustomerDetails(custId);
        }
        public void Getcustdetailsbyid(int custId)
        {
            _custrepo.GetCustomerDetailsbyid(custId);
        }
        public IEnumerable<CustomerDetails> GetCustomerDetails()
        {
            return _custrepo.GetCustomerDetails();
        }
    }
}
