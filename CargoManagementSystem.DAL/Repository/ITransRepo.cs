using CargoManagementSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoManagementSystem.DAL.Repository
{
    public interface ITransRepo
    {
        void AddTransactionDetails(Transaction transaction);
        void UpdateTransationDetails(Transaction transaction);
        void DeleteTransactionDetails(int BillNo);
        Transaction GetTransactionDetailsbyid(int BillNo);
        IEnumerable<Transaction> GetTransactionDetails();

    }
}
