﻿using Hi.Domain.Entities;
using Hi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public User FindByLoginName(string loginName)
        {
            return _repository.FindByClause(x => x.LoginName == loginName);
        }

        public IEnumerable<User> FindList(string loginName)
        {
            return _repository.FindListByClause(x => x.LoginName.Contains(loginName), "");
        }
    }
}
