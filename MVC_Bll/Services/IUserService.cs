using MVC_Bll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Bll.Services
{
    public interface IUserService
    {
        Task<UserModel> GetUserAsync(int id);
    }
}
