namespace ContactWebEFCore5.Data
{
    public interface IUserRolesService
    {
        Task EnsureAdminUserRole();
    }
}