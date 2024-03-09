namespace Highfield.Domain.DTOs
{
    public class AgePlusTwentyDTO
    {
        private int _age;

        public Guid UserId { get; set; }

        public int OriginalAge 
        {
            get => _age;
            set => _age = value; 
        }

        public int AgePlusTwenty { get => _age + 20; }

        public AgePlusTwentyDTO(Guid userId, int age)
        {
            UserId = userId;
            OriginalAge = age;
        }
    }
}
