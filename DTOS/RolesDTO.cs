using System;
namespace myInstagramClass.DTOS
{
    public class RolesDTO
    {
        public string role1 { get; set; }

        public RolesDTO(string newRole)
        {
            this.role1 = newRole;
        }
    }
}
