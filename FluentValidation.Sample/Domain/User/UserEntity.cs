using System.Collections.Generic;
using FluentValidation.Sample.Domain.Pet;

namespace FluentValidation.Sample.Domain.User
{
    public class UserEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //複雜型別
        public PetEntity Pet { get; set; }
        //集合型別
        public List<string> Phone { get; set; }
    }
}
