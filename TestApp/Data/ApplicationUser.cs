using AspNetCore.Identity.Mongo.Model;
using Microsoft.AspNetCore.Identity;

namespace TestApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : MongoUser
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
    }

}
