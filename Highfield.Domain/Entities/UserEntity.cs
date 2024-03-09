﻿namespace Highfield.Domain.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime Dob { get; set; }

        public string FavouriteColour { get; set; }
    }
}
