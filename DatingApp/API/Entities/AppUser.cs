using System;
using System.Collections.Generic;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        /* 
            - To create a property, use 'prop' 
        */

        // Create ID property
        public int Id { get; set; }

        // Create User Name property
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }  

        public byte[] PasswordSalt { get; set; }    

        public DateTime DateOfBirth { get; set; } 

        public string KnownAS { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastActive { get; set; } = DateTime.Now;

        public string Gender { get; set; }

        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public ICollection<UserLike> LikedByUser { get; set; }

        public ICollection<UserLike> LikedUsers { get; set; }
    }
}