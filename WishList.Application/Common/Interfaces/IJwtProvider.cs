using WishList.Domain.Entities;

namespace WishList.Application.Common.Interfaces
{
    public interface IJwtProvider
    {
        string Generate(User user);
    }
}
