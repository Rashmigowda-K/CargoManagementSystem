using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CargoManagementSystem.DAL.Data;
using CargoManagementSystem.Entity.Models;

namespace CargoManagementSystem.DAL.Repository
{
    public class RegisterRepo:IRegisterRepo
    {
        private CargoDbContext _cargoDbContext;
        public RegisterRepo(CargoDbContext cargoDbContext)
        {
            _cargoDbContext = cargoDbContext;
        }
        public CargoRegister login(CargoRegister cargologin)
        {
            CargoRegister cargoRegister = null;
            var result = _cargoDbContext.Register.Where(obj => obj.CustMailId == cargologin.CustMailId && obj.Password == cargologin.Password).ToList();
            if(result.Count>0)
            {
                cargoRegister = result[0];
            }
            return cargoRegister;
        }

        public CargoRegister Login(CargoRegister cargologin)
        {
            throw new NotImplementedException();
        }

        public void Register(CargoRegister cargoRegister)
        {
            _cargoDbContext.Register.Add(cargoRegister);
            _cargoDbContext.SaveChanges();
        }
    }
}
