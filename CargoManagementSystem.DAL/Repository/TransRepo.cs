using CargoManagementSystem.DAL.Data;
using CargoManagementSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CargoManagementSystem.DAL.Repository
{
    public class TransRepo:ITransRepo
    {
        CargoDbContext _cargoDbcontext;
        public TransRepo(CargoDbContext cargoDbcontext)
        {
            _cargoDbcontext = cargoDbcontext;
        }
        public void AddTransactionDetails(Transaction transaction)
        {
            _cargoDbcontext.transactions.Add(transaction);
            _cargoDbcontext.SaveChanges();
        }
        
        public void DeleteTransactionDetails(int Bill_no)
        {
            var transaction = _cargoDbcontext.transactions.Find(Bill_no);
            _cargoDbcontext.transactions.Remove(transaction);
            _cargoDbcontext.SaveChanges();
        }
        public Transaction GetTransactionDetailsbyid(int Bill_no)
        {
            return _cargoDbcontext.transactions.Find(Bill_no);
        }
        public IEnumerable<Transaction> GetTransactionDetails()
        {
            return _cargoDbcontext.transactions.ToList();
        }


        public void UpdateTransationDetails(Transaction transaction)
        {
            _cargoDbcontext.Entry(transaction).State = EntityState.Modified;
            _cargoDbcontext.SaveChanges();
        }
    }
}
