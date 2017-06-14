using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DomainModels;

namespace App.Business.Interfaces
{
    public interface IUserDetailManager
    {
        List<UserDetailItem> GetAllAvailableUsers(); 
    }
}
