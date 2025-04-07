using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task AddAsync(User user);
}