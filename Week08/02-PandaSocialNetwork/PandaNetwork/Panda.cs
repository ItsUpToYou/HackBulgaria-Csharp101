using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaNetwork
{
    public enum GenderType
    {
        Male, Female
    }

    public class Panda
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public GenderType Gender { get; set; }
        public bool IsMale(Panda panda)
        {
            if (panda.Gender.Equals("Male"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFemale(Panda panda)
        {
            if (panda.IsMale(panda))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Panda()
        {

        }

        public Panda(string name, string email, GenderType gender)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        }

        public bool ValidateEmail()
        {
            if ((Email.Contains("@")) && (Email.Contains(".com")))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Please enter a valid email address.");
            }
        }


        public override string ToString()
        {
            return string.Format("Name: {0}  Email: {1} Gender: {2}", Name, Email, Gender);
        }
    }
}
