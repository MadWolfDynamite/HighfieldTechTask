using Highfield.Domain.Entities;

namespace Highfield.Domain.DTOs
{
    public class ResponseDTO
    {
        public ICollection<UserEntity> Users { get; set; }

        public ICollection<AgePlusTwentyDTO> Ages { get; set; }

        public ICollection<TopColoursDTO> TopColours { get; set; }

        public ResponseDTO() 
        { 
            Users = new List<UserEntity>();
            Ages = new List<AgePlusTwentyDTO>();
            TopColours = new List<TopColoursDTO>();
        }
    }
}
