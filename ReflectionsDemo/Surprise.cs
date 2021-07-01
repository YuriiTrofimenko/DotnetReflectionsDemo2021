using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionsDemo
{
    class Surprise
    {
        private static readonly int MIN_RANDOM_BOUND = 1;
        private static readonly int MAX_RANDOM_BOUND = 4;
        public static dynamic GetResult() {
            Random random = new Random();
            int optionNumber = MIN_RANDOM_BOUND + random.Next(MAX_RANDOM_BOUND);
            dynamic result;
            switch (optionNumber) {
                case 1:
                    result = new User() { Id = optionNumber, Name = $"John{optionNumber}", Password = "123456", RoleId = optionNumber * optionNumber };
                    break;
                case 2:
                    var users = new List<User>();
                    users.Add(new User() { Id = optionNumber, Name = $"John{optionNumber}", Password = "123456", RoleId = optionNumber * optionNumber });
                    result = new { RoleName = "Admin",  Users = users };
                    break;
                case 3:
                    result = $"Hello Reflections! #{optionNumber}";
                    break;
                case 4:
                    result = optionNumber;
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }
    }
}
