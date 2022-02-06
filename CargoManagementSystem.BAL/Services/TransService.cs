using CargoManagementSystem.DAL.Repository;
using CargoManagementSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoManagementSystem.BAL.Services
{
    public class TransService
    {
        ITransRepo _transRepo;

        public TransService(ITransRepo transRepo)
        {
            _transRepo = transRepo;
        }
        public void AddTransactionDetails(Transaction transaction)
        {
            _transRepo.AddTransactionDetails(transaction);
        }
        public void UpdateTransationDetails(Transaction transaction)
        {
            _transRepo.UpdateTransationDetails(transaction);
        }
        public void DeleteTransactionDetails(int BillNo)
        {
            _transRepo.DeleteTransactionDetails(BillNo);
        }
        public void GetTransactionDetailsbyid(int BillNo)
        {
            _transRepo.GetTransactionDetailsbyid(BillNo);
        }
        public IEnumerable<Transaction> GetTransactionDetails()
        {
            return _transRepo.GetTransactionDetails();
        }
    }
}
