using Microsoft.AspNetCore.Identity;

namespace BlogApp.Models
{
    public class AppUser: IdentityUser{
        
        public string FirstName{
            get; set;
        }
        public string LastName{
            get; set;
        }
        public string Email{
            get;set;
        }
       
    
}
}
