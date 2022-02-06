using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CargoManagementSystem.DAL.Data;
using CargoManagementSystem.Entity.Models;
using System.Linq;

namespace CargoManagementSystem.DAL.Repository
{
    public class CustRepo:ICustRepo
    {
        CargoDbContext _cargoManagementDbContext;
      
        public CustRepo(CargoDbContext cargoManagementDbContext)
        {
            _cargoManagementDbContext = cargoManagementDbContext;
            
        }
        public void AddCustomerDetails(CustomerDetails customer)
        {
            _cargoManagementDbContext.customerDetails.Add(customer);
            _cargoManagementDbContext.SaveChanges();
        }

        public void UpdateCustomerDetails(CustomerDetails customer)
        {
            _cargoManagementDbContext.Entry(customer).State = EntityState.Modified;
            _cargoManagementDbContext.SaveChanges();
        }

        public void DeleteCustomerDetails(int CustId)
        {
            var customer = _cargoManagementDbContext.customerDetails.Find(CustId);
            _cargoManagementDbContext.customerDetails.Remove(customer);
            _cargoManagementDbContext.SaveChanges();
        }

        public CustomerDetails GetCustomerDetailsbyid(int CustId)
        {
            return _cargoManagementDbContext.customerDetails.Find(CustId);
        }

        public IEnumerable<CustomerDetails> GetCustomerDetails()
        {
            return _cargoManagementDbContext.customerDetails.ToList();
        }

    }
}
