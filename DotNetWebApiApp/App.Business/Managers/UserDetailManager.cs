using App.DomainModels;
using App.Business.Interfaces;
using App.DataAccess;
using System;
using System.Collections.Generic;

namespace App.Business.Managers
{
    public class UserDetailManager : IUserDetailManager
    {
        public List<UserDetailItem> GetAllAvailableUsers()
        {
            throw new NotImplementedException();
        }
    }
}
