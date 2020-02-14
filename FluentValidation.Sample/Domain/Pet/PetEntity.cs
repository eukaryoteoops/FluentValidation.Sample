using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.Sample.Domain.Pet
{
    public class PetEntity
    {
        public string NickName { get; set; }
        public byte Type { get; set; }
    }
}
