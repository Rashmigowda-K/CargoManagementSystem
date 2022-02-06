using System;
using System.Collections.Generic;
using System.Text;
using CargoManagementSystem.Entity.Models;

namespace CargoManagementSystem.DAL.Repository
{
    public interface IRegisterRepo
    {
        void Register(CargoRegister cargoRegister);
        CargoRegister Login(CargoRegister cargologin);
        
    }
}
