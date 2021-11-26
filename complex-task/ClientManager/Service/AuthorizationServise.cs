using ClientManager.MVVM.Models;
using System.Threading.Tasks;

namespace ClientManager.Service
{
    internal class AuthorizationServise
        : IAuthorizationServise
    {
        public EmployeeModel Authorization(AuthorizationModel user)
        {
            return new EmployeeModel()
            {
                
            };
        }
    }
}
