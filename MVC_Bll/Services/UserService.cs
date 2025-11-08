using MVC_Bll.Models;
using MVC_Dll;
using MVC_Dll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Bll.Services
{
    public class UserService : IUserService
    {
        public MVCDbContext DbContext { get; }

        public UserService(MVCDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private static readonly Func<UserEntity, UserModel> UserSelector = u => new UserModel
        {
            Id = u.Id,
            Name = u.Name,
            Email = u.Email,
        };

        public async Task<UserModel> GetUserAsync(int id)
        {
            return DbContext.Users.Where(usr => usr.Id == id).Select(UserSelector).Single();
        }
    }
}
