using Highfield.Domain.DTOs;

namespace Highfield.Domain.Contracts
{
    public interface IUserService
    {
        Task<ResponseDTO> GetUserDataAsync();
    }
}
