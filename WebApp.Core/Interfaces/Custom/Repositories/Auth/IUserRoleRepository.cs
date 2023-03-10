using WebApp.DataTransferObjects.Filters.Auth;
using WebApp.Core.Entities.Auth;

namespace WebApp.Core.Interfaces.Custom.Repositories.Auth
{
    public interface IUserRoleRepository : IGenericRepository<UserRole>
    {
        IQueryable<UserRole> BuildUserRoleQuery(UserRoleFilter userRoleFilter);
    }
}
