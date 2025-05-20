using Loosly_Domain;

namespace LooselyCoupledCode.Adapters;

public class AspNetUserContextAdapter : IUserContext
{
    private static HttpContextAccessor _accessor = new HttpContextAccessor();
    public bool IsInRole(Role role)
    {
        return _accessor.HttpContext.User.IsInRole(role.ToString());
    }
}
