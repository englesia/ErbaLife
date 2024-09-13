using ErbaLife__Online_Fitness_Koçluğu_Platformu.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

public class ApplicationUserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<ApplicationUserRepository> _logger;

    public ApplicationUserRepository(ApplicationDbContext context, ILogger<ApplicationUserRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<ApplicationUser> GetUserByIdAsync(string userId)
    {
        try
        {
            return await _context.AspNetUsers.FindAsync(userId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcı ID ile alınırken bir hata oluştu.");
            throw;
        }
    }

    public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
    {
        try
        {
            return await _context.AspNetUsers.ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Tüm kullanıcılar alınırken bir hata oluştu.");
            throw;
        }
    }

    public async Task AddUserAsync(ApplicationUser user)
    {
        try
        {
            _context.AspNetUsers.Add(user);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcı eklenirken bir hata oluştu.");
            throw;
        }
    }

    public async Task UpdateUserAsync(ApplicationUser user)
    {
        try
        {
            _context.AspNetUsers.Update(user);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcı güncellenirken bir hata oluştu.");
            throw;
        }
    }

    public async Task DeleteUserAsync(string userId)
    {
        try
        {
            var user = await _context.AspNetUsers.FindAsync(userId);
            if (user != null)
            {
                _context.AspNetUsers.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcı silinirken bir hata oluştu.");
            throw;
        }
    }
}
