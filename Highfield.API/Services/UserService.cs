using Highfield.Domain.Contracts;
using Highfield.Domain.DTOs;
using Highfield.Domain.Entities;

namespace Highfield.API.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpClientFactory _HttpClientFactory;

        public UserService(IHttpClientFactory httpClientFactory)
        {
            _HttpClientFactory = httpClientFactory;
        }

        public async Task<ResponseDTO> GetUserDataAsync()
        {
            var result = new ResponseDTO();

            using var client = _HttpClientFactory.CreateClient("Highfield_External");

            var response = await client.GetAsync("test");

            if (!response.IsSuccessStatusCode)
                throw new InvalidOperationException(response.ReasonPhrase);

            var users = await response.Content.ReadFromJsonAsync<IEnumerable<UserEntity>>();

            if (users == null)
                return result;

            foreach (var user in users) 
            {
                result.Users.Add(user);

                var userAge = DateTime.Now.Year - user.Dob.Year;

                result.Ages.Add(new AgePlusTwentyDTO(user.Id, userAge));

                if (!result.TopColours.Any(c => c.Colour.Equals(user.FavouriteColour)))
                {
                    result.TopColours.Add(new TopColoursDTO
                    {
                        Colour = user.FavouriteColour,
                        Count = 0
                    });
                }

                var colour = result.TopColours.First(c => c.Colour.Equals(user.FavouriteColour));
                colour.Count++;
            }

            return result;
        }
    }
}
