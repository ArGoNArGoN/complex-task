using ClientManager.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Service
{
    interface IAuthorizationServise
    {
        EmployeeModel Authorization(AuthorizationModel user);
    }
}
