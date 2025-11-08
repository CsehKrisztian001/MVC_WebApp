using MVC_Dll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Dll
{
    public class MVCDbContext
    {
        private List<UserEntity> _users = new List<UserEntity>() 
        { new UserEntity() { Id = 1, Name = "Krisztián", Email = "haha1@mail.com" }, 
          new UserEntity() { Id = 2, Name = "Péter", Email = "haha2@mail.com" } };

        public List<UserEntity> Users { get { return _users; } }
    }
}
