using FluentValidation;
using gym_assignment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_assignment.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string type { get; set; }

        public User(string name, string password, string type) {
            this.name = name; this.password = password; this.type = type;
            this.Id = Guid.NewGuid();
        }

        public void resetUserForm ()
        {
            this.name = "";
            this.password = "";
            this.type = "";
        }
    }

    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator() { 
            RuleFor(x => x).Must(x => !string.IsNullOrWhiteSpace(x.name) && !string.IsNullOrWhiteSpace(x.password))
        .WithName(".") 
        .WithMessage("Please enter username and password");
        }
    }
}
