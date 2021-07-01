using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionsDemo
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public void SetId(int id) {
            if (id > 0)
            {
                Id = id;
            }
            else {
                throw new Exception("Id should be greather than 0!");
            }
        }

        public void SetIds(int[] ids)
        {
            Id = ids[0];
            RoleId = ids[1];
        }

        public override string ToString()
        {
            return $"User {{Id = {Id}, Name = {Name}, Password = {Password}, RoleId = {RoleId}}}";
        }
    }
}
