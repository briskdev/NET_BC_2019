using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3_ERRHNDL
{
    class UserProfile
    {
        public enum Genders
        {
            Male,
            Female
        }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public Genders Gender { get; set; }

        public UserProfile(string fullName, DateTime birthDate, Genders gender)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public int Age()
        {
            // calculate age using BirthDate
            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - BirthDate.Year;
            // Go back to the year the person was born in case of a leap year
            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
