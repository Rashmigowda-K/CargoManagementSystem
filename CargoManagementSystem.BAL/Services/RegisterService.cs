using System;
using System.Collections.Generic;
using System.Text;
using CargoManagementSystem.DAL.Repository;
using CargoManagementSystem.Entity.Models;

namespace CargoManagementSystem.BAL.Services
{
    public class RegisterService
    {
        private IRegisterRepo _registerRepo;
        public RegisterService(IRegisterRepo registerRepo)
        {
            _registerRepo = registerRepo;
        }
        public void Register(CargoRegister cargoRegister)
        {
            _registerRepo.Register(cargoRegister);
        }
        public CargoRegister Login(CargoRegister cargologin)
        {
            return _registerRepo.Login(cargologin);
        }
    }
}
