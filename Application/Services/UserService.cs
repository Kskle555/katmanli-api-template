using Domain.DTOs;
using Domain.Entities;
using Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class UserService
{
    private readonly IUserRepository _repo;

    public UserService(IUserRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<UserDto>> GetAllUsersAsync()
    {
        var users = await _repo.GetAllAsync();
        return users.Select(u => new UserDto { Name = u.Name }).ToList();
    }

    public async Task AddUserAsync(UserDto dto)
    {
        var user = new User { Name = dto.Name };
        await _repo.AddAsync(user);
    }
}