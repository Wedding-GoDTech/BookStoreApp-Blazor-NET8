using System.ComponentModel.DataAnnotations;

namespace BookStoreAppAPI.Models.Author
{
    public class AuthorGetDto:BaseDto
    {

        public string FirstName { get; set; }


        public string LastName { get; set; }

 
        public string Bio { get; set; }

    }
}
