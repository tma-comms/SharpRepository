﻿using SharpRepository.Benchmarks.Configuration.Models;
using SharpRepository.InMemoryRepository;
using SharpRepository.Repository;

namespace SharpRepository.Benchmarks.Configuration.Repositories
{
    public interface IUserRepository : IRepository<User, int>
    {
        User GetAdminUser();
    }

    public class UserFromConfigRepository : ConfigurationBasedRepository<User, int>, IUserRepository
    {
        public User GetAdminUser()
        {
            return Find(x => x.Email == "admin@admin.com");
        }
    }

    public class UserRepository : InMemoryRepository<User, int>, IUserRepository
    {
        public User GetAdminUser()
        {
            return Find(x => x.Email == "admin@admin.com");
        }
    }
}
