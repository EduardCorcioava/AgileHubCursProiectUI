using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.Dto
{
    class UserDto
    {
        public string emailAddress { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }
        public string mobilePhone { get; set; }
        public string alias { get; set; }
        public string newPassword { get; set; }
        


        public UserDto GetValidUser()
        {
            UserDto validUserDto = new UserDto();
            if (this.emailAddress != null)
            {
                validUserDto.emailAddress = emailAddress;
            }
            else
            {
                validUserDto.emailAddress = string.Empty;

            }
            if (this.firstName != null)
            {
                validUserDto.firstName = firstName;
            }
            else
            {
                validUserDto.firstName = string.Empty;

            }

            if (this.lastName != null)
            {
                validUserDto.lastName = lastName;
            }
            else
            {
                validUserDto.lastName = string.Empty;

            }

            if (this.password != null)
            {
                validUserDto.password = password;
            }
            else
            {
                validUserDto.password = string.Empty;

            }

            if (this.address != null)
            {
                validUserDto.address = address;
            }
            else
            {
                validUserDto.address = string.Empty;

            }

            if (this.city != null)
            {
                validUserDto.city = city;
            }
            else
            {
                validUserDto.city = string.Empty;

            }

            if (this.postcode != null)
            {
                validUserDto.postcode = postcode;
            }
            else
            {
                validUserDto.postcode = string.Empty;

            }

            if (this.mobilePhone != null)
            {
                validUserDto.mobilePhone = mobilePhone;
            }
            else
            {
                validUserDto.mobilePhone = string.Empty;

            }

            if (this.alias != null)
            {
                validUserDto.alias = alias;
            }
            else
            {
                validUserDto.alias = string.Empty;

            }

            if (this.newPassword != null)
            {
                validUserDto.newPassword = newPassword;
            }
            else
            {
                validUserDto.newPassword = string.Empty;

            }
            return validUserDto;
        }
    }
}
