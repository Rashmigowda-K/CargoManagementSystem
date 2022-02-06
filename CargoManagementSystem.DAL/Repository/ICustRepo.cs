using System;
using System.Collections.Generic;
using System.Text;
using CargoManagementSystem.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace CargoManagementSystem.DAL.Repository
{
    public interface ICustRepo
    {
        void AddCustomerDetails(CustomerDetails customer);
        void UpdateCustomerDetails(CustomerDetails customer);
        void DeleteCustomerDetails(int CustId);
        CustomerDetails GetCustomerDetailsbyid(int CustId);
        IEnumerable<CustomerDetails> GetCustomerDetails();
    }
}
